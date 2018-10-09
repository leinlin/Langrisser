using System;
using System.Collections;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x0200152D RID: 5421
[Preserve]
public class Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController : LuaObject
{
	// Token: 0x060203C6 RID: 132038 RVA: 0x00AB4BA0 File Offset: 0x00AB2DA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowPlayerLevelUp(IntPtr l)
	{
		int result;
		try
		{
			PlayerLevelUpUIController playerLevelUpUIController = (PlayerLevelUpUIController)LuaObject.checkSelf(l);
			int oldLevel;
			LuaObject.checkType(l, 2, out oldLevel);
			int newLevel;
			LuaObject.checkType(l, 3, out newLevel);
			playerLevelUpUIController.ShowPlayerLevelUp(oldLevel, newLevel);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060203C7 RID: 132039 RVA: 0x00AB4C04 File Offset: 0x00AB2E04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			PlayerLevelUpUIController playerLevelUpUIController = (PlayerLevelUpUIController)LuaObject.checkSelf(l);
			playerLevelUpUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060203C8 RID: 132040 RVA: 0x00AB4C58 File Offset: 0x00AB2E58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Co_Open(IntPtr l)
	{
		int result;
		try
		{
			PlayerLevelUpUIController playerLevelUpUIController = (PlayerLevelUpUIController)LuaObject.checkSelf(l);
			int oldLevel;
			LuaObject.checkType(l, 2, out oldLevel);
			int newLevel;
			LuaObject.checkType(l, 3, out newLevel);
			IEnumerator o = playerLevelUpUIController.m_luaExportHelper.Co_Open(oldLevel, newLevel);
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

	// Token: 0x060203C9 RID: 132041 RVA: 0x00AB4CCC File Offset: 0x00AB2ECC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Co_SetAndWaitUIState(IntPtr l)
	{
		int result;
		try
		{
			PlayerLevelUpUIController playerLevelUpUIController = (PlayerLevelUpUIController)LuaObject.checkSelf(l);
			CommonUIStateController ctrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out ctrl);
			string state;
			LuaObject.checkType(l, 3, out state);
			IEnumerator o = playerLevelUpUIController.m_luaExportHelper.Co_SetAndWaitUIState(ctrl, state);
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

	// Token: 0x060203CA RID: 132042 RVA: 0x00AB4D40 File Offset: 0x00AB2F40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Co_WaitClick(IntPtr l)
	{
		int result;
		try
		{
			PlayerLevelUpUIController playerLevelUpUIController = (PlayerLevelUpUIController)LuaObject.checkSelf(l);
			IEnumerator o = playerLevelUpUIController.m_luaExportHelper.Co_WaitClick();
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

	// Token: 0x060203CB RID: 132043 RVA: 0x00AB4D9C File Offset: 0x00AB2F9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBackgroundButtonClick(IntPtr l)
	{
		int result;
		try
		{
			PlayerLevelUpUIController playerLevelUpUIController = (PlayerLevelUpUIController)LuaObject.checkSelf(l);
			playerLevelUpUIController.m_luaExportHelper.OnBackgroundButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060203CC RID: 132044 RVA: 0x00AB4DF0 File Offset: 0x00AB2FF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			PlayerLevelUpUIController playerLevelUpUIController = (PlayerLevelUpUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			playerLevelUpUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060203CD RID: 132045 RVA: 0x00AB4E5C File Offset: 0x00AB305C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			PlayerLevelUpUIController playerLevelUpUIController = (PlayerLevelUpUIController)LuaObject.checkSelf(l);
			playerLevelUpUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060203CE RID: 132046 RVA: 0x00AB4EB0 File Offset: 0x00AB30B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			PlayerLevelUpUIController playerLevelUpUIController = (PlayerLevelUpUIController)LuaObject.checkSelf(l);
			playerLevelUpUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060203CF RID: 132047 RVA: 0x00AB4F04 File Offset: 0x00AB3104
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			PlayerLevelUpUIController playerLevelUpUIController = (PlayerLevelUpUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = playerLevelUpUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x060203D0 RID: 132048 RVA: 0x00AB4FAC File Offset: 0x00AB31AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			PlayerLevelUpUIController playerLevelUpUIController = (PlayerLevelUpUIController)LuaObject.checkSelf(l);
			playerLevelUpUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060203D1 RID: 132049 RVA: 0x00AB5000 File Offset: 0x00AB3200
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			PlayerLevelUpUIController playerLevelUpUIController = (PlayerLevelUpUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			playerLevelUpUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060203D2 RID: 132050 RVA: 0x00AB506C File Offset: 0x00AB326C
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
				PlayerLevelUpUIController playerLevelUpUIController = (PlayerLevelUpUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				playerLevelUpUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				PlayerLevelUpUIController playerLevelUpUIController2 = (PlayerLevelUpUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				playerLevelUpUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x060203D3 RID: 132051 RVA: 0x00AB517C File Offset: 0x00AB337C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			PlayerLevelUpUIController playerLevelUpUIController = (PlayerLevelUpUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			playerLevelUpUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060203D4 RID: 132052 RVA: 0x00AB51E8 File Offset: 0x00AB33E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			PlayerLevelUpUIController playerLevelUpUIController = (PlayerLevelUpUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			playerLevelUpUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060203D5 RID: 132053 RVA: 0x00AB5254 File Offset: 0x00AB3454
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			PlayerLevelUpUIController playerLevelUpUIController = (PlayerLevelUpUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			playerLevelUpUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060203D6 RID: 132054 RVA: 0x00AB52C0 File Offset: 0x00AB34C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			PlayerLevelUpUIController playerLevelUpUIController = (PlayerLevelUpUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			playerLevelUpUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060203D7 RID: 132055 RVA: 0x00AB532C File Offset: 0x00AB352C
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
				PlayerLevelUpUIController playerLevelUpUIController = (PlayerLevelUpUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				playerLevelUpUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				PlayerLevelUpUIController playerLevelUpUIController2 = (PlayerLevelUpUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				playerLevelUpUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x060203D8 RID: 132056 RVA: 0x00AB543C File Offset: 0x00AB363C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			PlayerLevelUpUIController playerLevelUpUIController = (PlayerLevelUpUIController)LuaObject.checkSelf(l);
			string s = playerLevelUpUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x060203D9 RID: 132057 RVA: 0x00AB5498 File Offset: 0x00AB3698
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			PlayerLevelUpUIController playerLevelUpUIController = (PlayerLevelUpUIController)LuaObject.checkSelf(l);
			playerLevelUpUIController.m_luaExportHelper.__callDele_EventOnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060203DA RID: 132058 RVA: 0x00AB54EC File Offset: 0x00AB36EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			PlayerLevelUpUIController playerLevelUpUIController = (PlayerLevelUpUIController)LuaObject.checkSelf(l);
			playerLevelUpUIController.m_luaExportHelper.__clearDele_EventOnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060203DB RID: 132059 RVA: 0x00AB5540 File Offset: 0x00AB3740
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			PlayerLevelUpUIController playerLevelUpUIController = (PlayerLevelUpUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					playerLevelUpUIController.EventOnClose += value;
				}
				else if (num == 2)
				{
					playerLevelUpUIController.EventOnClose -= value;
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

	// Token: 0x060203DC RID: 132060 RVA: 0x00AB55C0 File Offset: 0x00AB37C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			PlayerLevelUpUIController playerLevelUpUIController = (PlayerLevelUpUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerLevelUpUIController.m_luaExportHelper.m_uiStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060203DD RID: 132061 RVA: 0x00AB5618 File Offset: 0x00AB3818
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			PlayerLevelUpUIController playerLevelUpUIController = (PlayerLevelUpUIController)LuaObject.checkSelf(l);
			CommonUIStateController uiStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out uiStateController);
			playerLevelUpUIController.m_luaExportHelper.m_uiStateController = uiStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060203DE RID: 132062 RVA: 0x00AB5674 File Offset: 0x00AB3874
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_backgroundButton(IntPtr l)
	{
		int result;
		try
		{
			PlayerLevelUpUIController playerLevelUpUIController = (PlayerLevelUpUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerLevelUpUIController.m_luaExportHelper.m_backgroundButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060203DF RID: 132063 RVA: 0x00AB56CC File Offset: 0x00AB38CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_backgroundButton(IntPtr l)
	{
		int result;
		try
		{
			PlayerLevelUpUIController playerLevelUpUIController = (PlayerLevelUpUIController)LuaObject.checkSelf(l);
			Button backgroundButton;
			LuaObject.checkType<Button>(l, 2, out backgroundButton);
			playerLevelUpUIController.m_luaExportHelper.m_backgroundButton = backgroundButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060203E0 RID: 132064 RVA: 0x00AB5728 File Offset: 0x00AB3928
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_oldLevelText(IntPtr l)
	{
		int result;
		try
		{
			PlayerLevelUpUIController playerLevelUpUIController = (PlayerLevelUpUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerLevelUpUIController.m_luaExportHelper.m_oldLevelText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060203E1 RID: 132065 RVA: 0x00AB5780 File Offset: 0x00AB3980
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_oldLevelText(IntPtr l)
	{
		int result;
		try
		{
			PlayerLevelUpUIController playerLevelUpUIController = (PlayerLevelUpUIController)LuaObject.checkSelf(l);
			Text oldLevelText;
			LuaObject.checkType<Text>(l, 2, out oldLevelText);
			playerLevelUpUIController.m_luaExportHelper.m_oldLevelText = oldLevelText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060203E2 RID: 132066 RVA: 0x00AB57DC File Offset: 0x00AB39DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_newLevelText(IntPtr l)
	{
		int result;
		try
		{
			PlayerLevelUpUIController playerLevelUpUIController = (PlayerLevelUpUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerLevelUpUIController.m_luaExportHelper.m_newLevelText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060203E3 RID: 132067 RVA: 0x00AB5834 File Offset: 0x00AB3A34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_newLevelText(IntPtr l)
	{
		int result;
		try
		{
			PlayerLevelUpUIController playerLevelUpUIController = (PlayerLevelUpUIController)LuaObject.checkSelf(l);
			Text newLevelText;
			LuaObject.checkType<Text>(l, 2, out newLevelText);
			playerLevelUpUIController.m_luaExportHelper.m_newLevelText = newLevelText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060203E4 RID: 132068 RVA: 0x00AB5890 File Offset: 0x00AB3A90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_addHeroLevelText(IntPtr l)
	{
		int result;
		try
		{
			PlayerLevelUpUIController playerLevelUpUIController = (PlayerLevelUpUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerLevelUpUIController.m_luaExportHelper.m_addHeroLevelText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060203E5 RID: 132069 RVA: 0x00AB58E8 File Offset: 0x00AB3AE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_addHeroLevelText(IntPtr l)
	{
		int result;
		try
		{
			PlayerLevelUpUIController playerLevelUpUIController = (PlayerLevelUpUIController)LuaObject.checkSelf(l);
			Text addHeroLevelText;
			LuaObject.checkType<Text>(l, 2, out addHeroLevelText);
			playerLevelUpUIController.m_luaExportHelper.m_addHeroLevelText = addHeroLevelText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060203E6 RID: 132070 RVA: 0x00AB5944 File Offset: 0x00AB3B44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_addEnergyText(IntPtr l)
	{
		int result;
		try
		{
			PlayerLevelUpUIController playerLevelUpUIController = (PlayerLevelUpUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerLevelUpUIController.m_luaExportHelper.m_addEnergyText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060203E7 RID: 132071 RVA: 0x00AB599C File Offset: 0x00AB3B9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_addEnergyText(IntPtr l)
	{
		int result;
		try
		{
			PlayerLevelUpUIController playerLevelUpUIController = (PlayerLevelUpUIController)LuaObject.checkSelf(l);
			Text addEnergyText;
			LuaObject.checkType<Text>(l, 2, out addEnergyText);
			playerLevelUpUIController.m_luaExportHelper.m_addEnergyText = addEnergyText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060203E8 RID: 132072 RVA: 0x00AB59F8 File Offset: 0x00AB3BF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isClick(IntPtr l)
	{
		int result;
		try
		{
			PlayerLevelUpUIController playerLevelUpUIController = (PlayerLevelUpUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerLevelUpUIController.m_luaExportHelper.m_isClick);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060203E9 RID: 132073 RVA: 0x00AB5A50 File Offset: 0x00AB3C50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isClick(IntPtr l)
	{
		int result;
		try
		{
			PlayerLevelUpUIController playerLevelUpUIController = (PlayerLevelUpUIController)LuaObject.checkSelf(l);
			bool isClick;
			LuaObject.checkType(l, 2, out isClick);
			playerLevelUpUIController.m_luaExportHelper.m_isClick = isClick;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060203EA RID: 132074 RVA: 0x00AB5AAC File Offset: 0x00AB3CAC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.PlayerLevelUpUIController");
		if (Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.ShowPlayerLevelUp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.Co_Open);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.Co_SetAndWaitUIState);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.Co_WaitClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.OnBackgroundButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.__callDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.__clearDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.<>f__mg$cache14);
		string name = "EventOnClose";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.set_EventOnClose);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.<>f__mg$cache15, true);
		string name2 = "m_uiStateController";
		if (Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.get_m_uiStateController);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.<>f__mg$cache16;
		if (Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.set_m_uiStateController);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.<>f__mg$cache17, true);
		string name3 = "m_backgroundButton";
		if (Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.get_m_backgroundButton);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.<>f__mg$cache18;
		if (Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.set_m_backgroundButton);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.<>f__mg$cache19, true);
		string name4 = "m_oldLevelText";
		if (Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.get_m_oldLevelText);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.<>f__mg$cache1A;
		if (Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.set_m_oldLevelText);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.<>f__mg$cache1B, true);
		string name5 = "m_newLevelText";
		if (Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.get_m_newLevelText);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.<>f__mg$cache1C;
		if (Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.set_m_newLevelText);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.<>f__mg$cache1D, true);
		string name6 = "m_addHeroLevelText";
		if (Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.get_m_addHeroLevelText);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.<>f__mg$cache1E;
		if (Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.set_m_addHeroLevelText);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.<>f__mg$cache1F, true);
		string name7 = "m_addEnergyText";
		if (Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.get_m_addEnergyText);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.<>f__mg$cache20;
		if (Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.set_m_addEnergyText);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.<>f__mg$cache21, true);
		string name8 = "m_isClick";
		if (Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.get_m_isClick);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.set_m_isClick);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_PlayerLevelUpUIController.<>f__mg$cache23, true);
		LuaObject.createTypeMetatable(l, null, typeof(PlayerLevelUpUIController), typeof(UIControllerBase));
	}

	// Token: 0x0401634E RID: 90958
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401634F RID: 90959
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04016350 RID: 90960
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04016351 RID: 90961
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04016352 RID: 90962
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04016353 RID: 90963
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04016354 RID: 90964
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04016355 RID: 90965
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04016356 RID: 90966
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04016357 RID: 90967
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04016358 RID: 90968
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04016359 RID: 90969
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0401635A RID: 90970
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0401635B RID: 90971
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0401635C RID: 90972
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0401635D RID: 90973
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0401635E RID: 90974
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0401635F RID: 90975
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04016360 RID: 90976
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04016361 RID: 90977
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04016362 RID: 90978
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04016363 RID: 90979
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04016364 RID: 90980
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04016365 RID: 90981
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04016366 RID: 90982
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04016367 RID: 90983
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04016368 RID: 90984
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04016369 RID: 90985
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0401636A RID: 90986
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0401636B RID: 90987
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0401636C RID: 90988
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0401636D RID: 90989
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0401636E RID: 90990
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0401636F RID: 90991
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04016370 RID: 90992
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04016371 RID: 90993
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;
}
