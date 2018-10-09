using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001381 RID: 4993
[Preserve]
public class Lua_BlackJack_ProjectL_UI_ArenaSelectUIController : LuaObject
{
	// Token: 0x0601B04B RID: 110667 RVA: 0x0081CEFC File Offset: 0x0081B0FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Open(IntPtr l)
	{
		int result;
		try
		{
			ArenaSelectUIController arenaSelectUIController = (ArenaSelectUIController)LuaObject.checkSelf(l);
			arenaSelectUIController.Open();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B04C RID: 110668 RVA: 0x0081CF48 File Offset: 0x0081B148
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Close(IntPtr l)
	{
		int result;
		try
		{
			ArenaSelectUIController arenaSelectUIController = (ArenaSelectUIController)LuaObject.checkSelf(l);
			Action onEnd;
			LuaObject.checkDelegate<Action>(l, 2, out onEnd);
			arenaSelectUIController.Close(onEnd);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B04D RID: 110669 RVA: 0x0081CFA0 File Offset: 0x0081B1A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			ArenaSelectUIController arenaSelectUIController = (ArenaSelectUIController)LuaObject.checkSelf(l);
			arenaSelectUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B04E RID: 110670 RVA: 0x0081CFF4 File Offset: 0x0081B1F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBackgroundButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ArenaSelectUIController arenaSelectUIController = (ArenaSelectUIController)LuaObject.checkSelf(l);
			arenaSelectUIController.m_luaExportHelper.OnBackgroundButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B04F RID: 110671 RVA: 0x0081D048 File Offset: 0x0081B248
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnOnlineButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ArenaSelectUIController arenaSelectUIController = (ArenaSelectUIController)LuaObject.checkSelf(l);
			arenaSelectUIController.m_luaExportHelper.OnOnlineButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B050 RID: 110672 RVA: 0x0081D09C File Offset: 0x0081B29C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnOffineButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ArenaSelectUIController arenaSelectUIController = (ArenaSelectUIController)LuaObject.checkSelf(l);
			arenaSelectUIController.m_luaExportHelper.OnOffineButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B051 RID: 110673 RVA: 0x0081D0F0 File Offset: 0x0081B2F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			ArenaSelectUIController arenaSelectUIController = (ArenaSelectUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			arenaSelectUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B052 RID: 110674 RVA: 0x0081D15C File Offset: 0x0081B35C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			ArenaSelectUIController arenaSelectUIController = (ArenaSelectUIController)LuaObject.checkSelf(l);
			arenaSelectUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B053 RID: 110675 RVA: 0x0081D1B0 File Offset: 0x0081B3B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			ArenaSelectUIController arenaSelectUIController = (ArenaSelectUIController)LuaObject.checkSelf(l);
			arenaSelectUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B054 RID: 110676 RVA: 0x0081D204 File Offset: 0x0081B404
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			ArenaSelectUIController arenaSelectUIController = (ArenaSelectUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = arenaSelectUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601B055 RID: 110677 RVA: 0x0081D2AC File Offset: 0x0081B4AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			ArenaSelectUIController arenaSelectUIController = (ArenaSelectUIController)LuaObject.checkSelf(l);
			arenaSelectUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B056 RID: 110678 RVA: 0x0081D300 File Offset: 0x0081B500
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ArenaSelectUIController arenaSelectUIController = (ArenaSelectUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			arenaSelectUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B057 RID: 110679 RVA: 0x0081D36C File Offset: 0x0081B56C
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
				ArenaSelectUIController arenaSelectUIController = (ArenaSelectUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				arenaSelectUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				ArenaSelectUIController arenaSelectUIController2 = (ArenaSelectUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				arenaSelectUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601B058 RID: 110680 RVA: 0x0081D47C File Offset: 0x0081B67C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			ArenaSelectUIController arenaSelectUIController = (ArenaSelectUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			arenaSelectUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B059 RID: 110681 RVA: 0x0081D4E8 File Offset: 0x0081B6E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			ArenaSelectUIController arenaSelectUIController = (ArenaSelectUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			arenaSelectUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B05A RID: 110682 RVA: 0x0081D554 File Offset: 0x0081B754
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			ArenaSelectUIController arenaSelectUIController = (ArenaSelectUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			arenaSelectUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B05B RID: 110683 RVA: 0x0081D5C0 File Offset: 0x0081B7C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			ArenaSelectUIController arenaSelectUIController = (ArenaSelectUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			arenaSelectUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B05C RID: 110684 RVA: 0x0081D62C File Offset: 0x0081B82C
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
				ArenaSelectUIController arenaSelectUIController = (ArenaSelectUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				arenaSelectUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				ArenaSelectUIController arenaSelectUIController2 = (ArenaSelectUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				arenaSelectUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601B05D RID: 110685 RVA: 0x0081D73C File Offset: 0x0081B93C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			ArenaSelectUIController arenaSelectUIController = (ArenaSelectUIController)LuaObject.checkSelf(l);
			string s = arenaSelectUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601B05E RID: 110686 RVA: 0x0081D798 File Offset: 0x0081B998
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			ArenaSelectUIController arenaSelectUIController = (ArenaSelectUIController)LuaObject.checkSelf(l);
			arenaSelectUIController.m_luaExportHelper.__callDele_EventOnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B05F RID: 110687 RVA: 0x0081D7EC File Offset: 0x0081B9EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			ArenaSelectUIController arenaSelectUIController = (ArenaSelectUIController)LuaObject.checkSelf(l);
			arenaSelectUIController.m_luaExportHelper.__clearDele_EventOnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B060 RID: 110688 RVA: 0x0081D840 File Offset: 0x0081BA40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnShowOnlineArena(IntPtr l)
	{
		int result;
		try
		{
			ArenaSelectUIController arenaSelectUIController = (ArenaSelectUIController)LuaObject.checkSelf(l);
			arenaSelectUIController.m_luaExportHelper.__callDele_EventOnShowOnlineArena();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B061 RID: 110689 RVA: 0x0081D894 File Offset: 0x0081BA94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnShowOnlineArena(IntPtr l)
	{
		int result;
		try
		{
			ArenaSelectUIController arenaSelectUIController = (ArenaSelectUIController)LuaObject.checkSelf(l);
			arenaSelectUIController.m_luaExportHelper.__clearDele_EventOnShowOnlineArena();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B062 RID: 110690 RVA: 0x0081D8E8 File Offset: 0x0081BAE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnShowOfflineArena(IntPtr l)
	{
		int result;
		try
		{
			ArenaSelectUIController arenaSelectUIController = (ArenaSelectUIController)LuaObject.checkSelf(l);
			arenaSelectUIController.m_luaExportHelper.__callDele_EventOnShowOfflineArena();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B063 RID: 110691 RVA: 0x0081D93C File Offset: 0x0081BB3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnShowOfflineArena(IntPtr l)
	{
		int result;
		try
		{
			ArenaSelectUIController arenaSelectUIController = (ArenaSelectUIController)LuaObject.checkSelf(l);
			arenaSelectUIController.m_luaExportHelper.__clearDele_EventOnShowOfflineArena();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B064 RID: 110692 RVA: 0x0081D990 File Offset: 0x0081BB90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			ArenaSelectUIController arenaSelectUIController = (ArenaSelectUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					arenaSelectUIController.EventOnClose += value;
				}
				else if (num == 2)
				{
					arenaSelectUIController.EventOnClose -= value;
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

	// Token: 0x0601B065 RID: 110693 RVA: 0x0081DA10 File Offset: 0x0081BC10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnShowOnlineArena(IntPtr l)
	{
		int result;
		try
		{
			ArenaSelectUIController arenaSelectUIController = (ArenaSelectUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					arenaSelectUIController.EventOnShowOnlineArena += value;
				}
				else if (num == 2)
				{
					arenaSelectUIController.EventOnShowOnlineArena -= value;
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

	// Token: 0x0601B066 RID: 110694 RVA: 0x0081DA90 File Offset: 0x0081BC90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnShowOfflineArena(IntPtr l)
	{
		int result;
		try
		{
			ArenaSelectUIController arenaSelectUIController = (ArenaSelectUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					arenaSelectUIController.EventOnShowOfflineArena += value;
				}
				else if (num == 2)
				{
					arenaSelectUIController.EventOnShowOfflineArena -= value;
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

	// Token: 0x0601B067 RID: 110695 RVA: 0x0081DB10 File Offset: 0x0081BD10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			ArenaSelectUIController arenaSelectUIController = (ArenaSelectUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaSelectUIController.m_luaExportHelper.m_uiStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B068 RID: 110696 RVA: 0x0081DB68 File Offset: 0x0081BD68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			ArenaSelectUIController arenaSelectUIController = (ArenaSelectUIController)LuaObject.checkSelf(l);
			CommonUIStateController uiStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out uiStateController);
			arenaSelectUIController.m_luaExportHelper.m_uiStateController = uiStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B069 RID: 110697 RVA: 0x0081DBC4 File Offset: 0x0081BDC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_backgroundButton(IntPtr l)
	{
		int result;
		try
		{
			ArenaSelectUIController arenaSelectUIController = (ArenaSelectUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaSelectUIController.m_luaExportHelper.m_backgroundButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B06A RID: 110698 RVA: 0x0081DC1C File Offset: 0x0081BE1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_backgroundButton(IntPtr l)
	{
		int result;
		try
		{
			ArenaSelectUIController arenaSelectUIController = (ArenaSelectUIController)LuaObject.checkSelf(l);
			Button backgroundButton;
			LuaObject.checkType<Button>(l, 2, out backgroundButton);
			arenaSelectUIController.m_luaExportHelper.m_backgroundButton = backgroundButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B06B RID: 110699 RVA: 0x0081DC78 File Offset: 0x0081BE78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_onlineButton(IntPtr l)
	{
		int result;
		try
		{
			ArenaSelectUIController arenaSelectUIController = (ArenaSelectUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaSelectUIController.m_luaExportHelper.m_onlineButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B06C RID: 110700 RVA: 0x0081DCD0 File Offset: 0x0081BED0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_onlineButton(IntPtr l)
	{
		int result;
		try
		{
			ArenaSelectUIController arenaSelectUIController = (ArenaSelectUIController)LuaObject.checkSelf(l);
			Button onlineButton;
			LuaObject.checkType<Button>(l, 2, out onlineButton);
			arenaSelectUIController.m_luaExportHelper.m_onlineButton = onlineButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B06D RID: 110701 RVA: 0x0081DD2C File Offset: 0x0081BF2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_offlineButton(IntPtr l)
	{
		int result;
		try
		{
			ArenaSelectUIController arenaSelectUIController = (ArenaSelectUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaSelectUIController.m_luaExportHelper.m_offlineButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B06E RID: 110702 RVA: 0x0081DD84 File Offset: 0x0081BF84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_offlineButton(IntPtr l)
	{
		int result;
		try
		{
			ArenaSelectUIController arenaSelectUIController = (ArenaSelectUIController)LuaObject.checkSelf(l);
			Button offlineButton;
			LuaObject.checkType<Button>(l, 2, out offlineButton);
			arenaSelectUIController.m_luaExportHelper.m_offlineButton = offlineButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B06F RID: 110703 RVA: 0x0081DDE0 File Offset: 0x0081BFE0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.ArenaSelectUIController");
		if (Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.Open);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.Close);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.OnBackgroundButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.OnOnlineButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.OnOffineButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.__callDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.__clearDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.__callDele_EventOnShowOnlineArena);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.__clearDele_EventOnShowOnlineArena);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.__callDele_EventOnShowOfflineArena);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.__clearDele_EventOnShowOfflineArena);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.<>f__mg$cache18);
		string name = "EventOnClose";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.set_EventOnClose);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.<>f__mg$cache19, true);
		string name2 = "EventOnShowOnlineArena";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.set_EventOnShowOnlineArena);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.<>f__mg$cache1A, true);
		string name3 = "EventOnShowOfflineArena";
		LuaCSFunction get3 = null;
		if (Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.set_EventOnShowOfflineArena);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.<>f__mg$cache1B, true);
		string name4 = "m_uiStateController";
		if (Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.get_m_uiStateController);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.<>f__mg$cache1C;
		if (Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.set_m_uiStateController);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.<>f__mg$cache1D, true);
		string name5 = "m_backgroundButton";
		if (Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.get_m_backgroundButton);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.<>f__mg$cache1E;
		if (Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.set_m_backgroundButton);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.<>f__mg$cache1F, true);
		string name6 = "m_onlineButton";
		if (Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.get_m_onlineButton);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.<>f__mg$cache20;
		if (Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.set_m_onlineButton);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.<>f__mg$cache21, true);
		string name7 = "m_offlineButton";
		if (Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.get_m_offlineButton);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.set_m_offlineButton);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_ArenaSelectUIController.<>f__mg$cache23, true);
		LuaObject.createTypeMetatable(l, null, typeof(ArenaSelectUIController), typeof(UIControllerBase));
	}

	// Token: 0x0401132B RID: 70443
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401132C RID: 70444
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401132D RID: 70445
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0401132E RID: 70446
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0401132F RID: 70447
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04011330 RID: 70448
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04011331 RID: 70449
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04011332 RID: 70450
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04011333 RID: 70451
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04011334 RID: 70452
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04011335 RID: 70453
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04011336 RID: 70454
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04011337 RID: 70455
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04011338 RID: 70456
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04011339 RID: 70457
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0401133A RID: 70458
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0401133B RID: 70459
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0401133C RID: 70460
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0401133D RID: 70461
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0401133E RID: 70462
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0401133F RID: 70463
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04011340 RID: 70464
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04011341 RID: 70465
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04011342 RID: 70466
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04011343 RID: 70467
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04011344 RID: 70468
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04011345 RID: 70469
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04011346 RID: 70470
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04011347 RID: 70471
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04011348 RID: 70472
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04011349 RID: 70473
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0401134A RID: 70474
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0401134B RID: 70475
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0401134C RID: 70476
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0401134D RID: 70477
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0401134E RID: 70478
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;
}
