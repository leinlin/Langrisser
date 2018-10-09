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

// Token: 0x0200150B RID: 5387
[Preserve]
public class Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController : LuaObject
{
	// Token: 0x0601FE52 RID: 130642 RVA: 0x00A891E4 File Offset: 0x00A873E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetMemoryCorridorLevelInfo(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorLevelListItemUIController memoryCorridorLevelListItemUIController = (MemoryCorridorLevelListItemUIController)LuaObject.checkSelf(l);
			ConfigDataMemoryCorridorLevelInfo memoryCorridorLevelInfo;
			LuaObject.checkType<ConfigDataMemoryCorridorLevelInfo>(l, 2, out memoryCorridorLevelInfo);
			memoryCorridorLevelListItemUIController.SetMemoryCorridorLevelInfo(memoryCorridorLevelInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE53 RID: 130643 RVA: 0x00A8923C File Offset: 0x00A8743C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetMemoryCorridorLevelInfo(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorLevelListItemUIController memoryCorridorLevelListItemUIController = (MemoryCorridorLevelListItemUIController)LuaObject.checkSelf(l);
			ConfigDataMemoryCorridorLevelInfo memoryCorridorLevelInfo = memoryCorridorLevelListItemUIController.GetMemoryCorridorLevelInfo();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, memoryCorridorLevelInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE54 RID: 130644 RVA: 0x00A89290 File Offset: 0x00A87490
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetLocked(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorLevelListItemUIController memoryCorridorLevelListItemUIController = (MemoryCorridorLevelListItemUIController)LuaObject.checkSelf(l);
			bool locked;
			LuaObject.checkType(l, 2, out locked);
			memoryCorridorLevelListItemUIController.SetLocked(locked);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE55 RID: 130645 RVA: 0x00A892E8 File Offset: 0x00A874E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorLevelListItemUIController memoryCorridorLevelListItemUIController = (MemoryCorridorLevelListItemUIController)LuaObject.checkSelf(l);
			memoryCorridorLevelListItemUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE56 RID: 130646 RVA: 0x00A8933C File Offset: 0x00A8753C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStartButtonClick(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorLevelListItemUIController memoryCorridorLevelListItemUIController = (MemoryCorridorLevelListItemUIController)LuaObject.checkSelf(l);
			memoryCorridorLevelListItemUIController.m_luaExportHelper.OnStartButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE57 RID: 130647 RVA: 0x00A89390 File Offset: 0x00A87590
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnLockedButtonClick(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorLevelListItemUIController memoryCorridorLevelListItemUIController = (MemoryCorridorLevelListItemUIController)LuaObject.checkSelf(l);
			memoryCorridorLevelListItemUIController.m_luaExportHelper.OnLockedButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE58 RID: 130648 RVA: 0x00A893E4 File Offset: 0x00A875E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorLevelListItemUIController memoryCorridorLevelListItemUIController = (MemoryCorridorLevelListItemUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			memoryCorridorLevelListItemUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE59 RID: 130649 RVA: 0x00A89450 File Offset: 0x00A87650
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorLevelListItemUIController memoryCorridorLevelListItemUIController = (MemoryCorridorLevelListItemUIController)LuaObject.checkSelf(l);
			memoryCorridorLevelListItemUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE5A RID: 130650 RVA: 0x00A894A4 File Offset: 0x00A876A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorLevelListItemUIController memoryCorridorLevelListItemUIController = (MemoryCorridorLevelListItemUIController)LuaObject.checkSelf(l);
			memoryCorridorLevelListItemUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE5B RID: 130651 RVA: 0x00A894F8 File Offset: 0x00A876F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorLevelListItemUIController memoryCorridorLevelListItemUIController = (MemoryCorridorLevelListItemUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = memoryCorridorLevelListItemUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601FE5C RID: 130652 RVA: 0x00A895A0 File Offset: 0x00A877A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorLevelListItemUIController memoryCorridorLevelListItemUIController = (MemoryCorridorLevelListItemUIController)LuaObject.checkSelf(l);
			memoryCorridorLevelListItemUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE5D RID: 130653 RVA: 0x00A895F4 File Offset: 0x00A877F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorLevelListItemUIController memoryCorridorLevelListItemUIController = (MemoryCorridorLevelListItemUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			memoryCorridorLevelListItemUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE5E RID: 130654 RVA: 0x00A89660 File Offset: 0x00A87860
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
				MemoryCorridorLevelListItemUIController memoryCorridorLevelListItemUIController = (MemoryCorridorLevelListItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				memoryCorridorLevelListItemUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				MemoryCorridorLevelListItemUIController memoryCorridorLevelListItemUIController2 = (MemoryCorridorLevelListItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				memoryCorridorLevelListItemUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601FE5F RID: 130655 RVA: 0x00A89770 File Offset: 0x00A87970
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorLevelListItemUIController memoryCorridorLevelListItemUIController = (MemoryCorridorLevelListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			memoryCorridorLevelListItemUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE60 RID: 130656 RVA: 0x00A897DC File Offset: 0x00A879DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorLevelListItemUIController memoryCorridorLevelListItemUIController = (MemoryCorridorLevelListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			memoryCorridorLevelListItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE61 RID: 130657 RVA: 0x00A89848 File Offset: 0x00A87A48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorLevelListItemUIController memoryCorridorLevelListItemUIController = (MemoryCorridorLevelListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			memoryCorridorLevelListItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE62 RID: 130658 RVA: 0x00A898B4 File Offset: 0x00A87AB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorLevelListItemUIController memoryCorridorLevelListItemUIController = (MemoryCorridorLevelListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			memoryCorridorLevelListItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE63 RID: 130659 RVA: 0x00A89920 File Offset: 0x00A87B20
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
				MemoryCorridorLevelListItemUIController memoryCorridorLevelListItemUIController = (MemoryCorridorLevelListItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				memoryCorridorLevelListItemUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				MemoryCorridorLevelListItemUIController memoryCorridorLevelListItemUIController2 = (MemoryCorridorLevelListItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				memoryCorridorLevelListItemUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601FE64 RID: 130660 RVA: 0x00A89A30 File Offset: 0x00A87C30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorLevelListItemUIController memoryCorridorLevelListItemUIController = (MemoryCorridorLevelListItemUIController)LuaObject.checkSelf(l);
			string s = memoryCorridorLevelListItemUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601FE65 RID: 130661 RVA: 0x00A89A8C File Offset: 0x00A87C8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnStartButtonClick(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorLevelListItemUIController memoryCorridorLevelListItemUIController = (MemoryCorridorLevelListItemUIController)LuaObject.checkSelf(l);
			MemoryCorridorLevelListItemUIController obj;
			LuaObject.checkType<MemoryCorridorLevelListItemUIController>(l, 2, out obj);
			memoryCorridorLevelListItemUIController.m_luaExportHelper.__callDele_EventOnStartButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE66 RID: 130662 RVA: 0x00A89AE8 File Offset: 0x00A87CE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnStartButtonClick(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorLevelListItemUIController memoryCorridorLevelListItemUIController = (MemoryCorridorLevelListItemUIController)LuaObject.checkSelf(l);
			MemoryCorridorLevelListItemUIController obj;
			LuaObject.checkType<MemoryCorridorLevelListItemUIController>(l, 2, out obj);
			memoryCorridorLevelListItemUIController.m_luaExportHelper.__clearDele_EventOnStartButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE67 RID: 130663 RVA: 0x00A89B44 File Offset: 0x00A87D44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnStartButtonClick(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorLevelListItemUIController memoryCorridorLevelListItemUIController = (MemoryCorridorLevelListItemUIController)LuaObject.checkSelf(l);
			Action<MemoryCorridorLevelListItemUIController> value;
			int num = LuaObject.checkDelegate<Action<MemoryCorridorLevelListItemUIController>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					memoryCorridorLevelListItemUIController.EventOnStartButtonClick += value;
				}
				else if (num == 2)
				{
					memoryCorridorLevelListItemUIController.EventOnStartButtonClick -= value;
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

	// Token: 0x0601FE68 RID: 130664 RVA: 0x00A89BC4 File Offset: 0x00A87DC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_levelText(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorLevelListItemUIController memoryCorridorLevelListItemUIController = (MemoryCorridorLevelListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, memoryCorridorLevelListItemUIController.m_luaExportHelper.m_levelText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE69 RID: 130665 RVA: 0x00A89C1C File Offset: 0x00A87E1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_levelText(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorLevelListItemUIController memoryCorridorLevelListItemUIController = (MemoryCorridorLevelListItemUIController)LuaObject.checkSelf(l);
			Text levelText;
			LuaObject.checkType<Text>(l, 2, out levelText);
			memoryCorridorLevelListItemUIController.m_luaExportHelper.m_levelText = levelText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE6A RID: 130666 RVA: 0x00A89C78 File Offset: 0x00A87E78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_energyText(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorLevelListItemUIController memoryCorridorLevelListItemUIController = (MemoryCorridorLevelListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, memoryCorridorLevelListItemUIController.m_luaExportHelper.m_energyText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE6B RID: 130667 RVA: 0x00A89CD0 File Offset: 0x00A87ED0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_energyText(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorLevelListItemUIController memoryCorridorLevelListItemUIController = (MemoryCorridorLevelListItemUIController)LuaObject.checkSelf(l);
			Text energyText;
			LuaObject.checkType<Text>(l, 2, out energyText);
			memoryCorridorLevelListItemUIController.m_luaExportHelper.m_energyText = energyText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE6C RID: 130668 RVA: 0x00A89D2C File Offset: 0x00A87F2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_lockedButton(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorLevelListItemUIController memoryCorridorLevelListItemUIController = (MemoryCorridorLevelListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, memoryCorridorLevelListItemUIController.m_luaExportHelper.m_lockedButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE6D RID: 130669 RVA: 0x00A89D84 File Offset: 0x00A87F84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_lockedButton(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorLevelListItemUIController memoryCorridorLevelListItemUIController = (MemoryCorridorLevelListItemUIController)LuaObject.checkSelf(l);
			Button lockedButton;
			LuaObject.checkType<Button>(l, 2, out lockedButton);
			memoryCorridorLevelListItemUIController.m_luaExportHelper.m_lockedButton = lockedButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE6E RID: 130670 RVA: 0x00A89DE0 File Offset: 0x00A87FE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_startButton(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorLevelListItemUIController memoryCorridorLevelListItemUIController = (MemoryCorridorLevelListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, memoryCorridorLevelListItemUIController.m_luaExportHelper.m_startButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE6F RID: 130671 RVA: 0x00A89E38 File Offset: 0x00A88038
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_startButton(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorLevelListItemUIController memoryCorridorLevelListItemUIController = (MemoryCorridorLevelListItemUIController)LuaObject.checkSelf(l);
			Button startButton;
			LuaObject.checkType<Button>(l, 2, out startButton);
			memoryCorridorLevelListItemUIController.m_luaExportHelper.m_startButton = startButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE70 RID: 130672 RVA: 0x00A89E94 File Offset: 0x00A88094
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_rewardGroupGameObject(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorLevelListItemUIController memoryCorridorLevelListItemUIController = (MemoryCorridorLevelListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, memoryCorridorLevelListItemUIController.m_luaExportHelper.m_rewardGroupGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE71 RID: 130673 RVA: 0x00A89EEC File Offset: 0x00A880EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_rewardGroupGameObject(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorLevelListItemUIController memoryCorridorLevelListItemUIController = (MemoryCorridorLevelListItemUIController)LuaObject.checkSelf(l);
			GameObject rewardGroupGameObject;
			LuaObject.checkType<GameObject>(l, 2, out rewardGroupGameObject);
			memoryCorridorLevelListItemUIController.m_luaExportHelper.m_rewardGroupGameObject = rewardGroupGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE72 RID: 130674 RVA: 0x00A89F48 File Offset: 0x00A88148
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_lockedText(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorLevelListItemUIController memoryCorridorLevelListItemUIController = (MemoryCorridorLevelListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, memoryCorridorLevelListItemUIController.m_luaExportHelper.m_lockedText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE73 RID: 130675 RVA: 0x00A89FA0 File Offset: 0x00A881A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_lockedText(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorLevelListItemUIController memoryCorridorLevelListItemUIController = (MemoryCorridorLevelListItemUIController)LuaObject.checkSelf(l);
			Text lockedText;
			LuaObject.checkType<Text>(l, 2, out lockedText);
			memoryCorridorLevelListItemUIController.m_luaExportHelper.m_lockedText = lockedText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE74 RID: 130676 RVA: 0x00A89FFC File Offset: 0x00A881FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_memoryCorridorLevelInfo(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorLevelListItemUIController memoryCorridorLevelListItemUIController = (MemoryCorridorLevelListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, memoryCorridorLevelListItemUIController.m_luaExportHelper.m_memoryCorridorLevelInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE75 RID: 130677 RVA: 0x00A8A054 File Offset: 0x00A88254
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_memoryCorridorLevelInfo(IntPtr l)
	{
		int result;
		try
		{
			MemoryCorridorLevelListItemUIController memoryCorridorLevelListItemUIController = (MemoryCorridorLevelListItemUIController)LuaObject.checkSelf(l);
			ConfigDataMemoryCorridorLevelInfo memoryCorridorLevelInfo;
			LuaObject.checkType<ConfigDataMemoryCorridorLevelInfo>(l, 2, out memoryCorridorLevelInfo);
			memoryCorridorLevelListItemUIController.m_luaExportHelper.m_memoryCorridorLevelInfo = memoryCorridorLevelInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FE76 RID: 130678 RVA: 0x00A8A0B0 File Offset: 0x00A882B0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.MemoryCorridorLevelListItemUIController");
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.SetMemoryCorridorLevelInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.GetMemoryCorridorLevelInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.SetLocked);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.OnStartButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.OnLockedButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.__callDele_EventOnStartButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.__clearDele_EventOnStartButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.<>f__mg$cache14);
		string name = "EventOnStartButtonClick";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.set_EventOnStartButtonClick);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.<>f__mg$cache15, true);
		string name2 = "m_levelText";
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.get_m_levelText);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.<>f__mg$cache16;
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.set_m_levelText);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.<>f__mg$cache17, true);
		string name3 = "m_energyText";
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.get_m_energyText);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.<>f__mg$cache18;
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.set_m_energyText);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.<>f__mg$cache19, true);
		string name4 = "m_lockedButton";
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.get_m_lockedButton);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.<>f__mg$cache1A;
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.set_m_lockedButton);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.<>f__mg$cache1B, true);
		string name5 = "m_startButton";
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.get_m_startButton);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.<>f__mg$cache1C;
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.set_m_startButton);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.<>f__mg$cache1D, true);
		string name6 = "m_rewardGroupGameObject";
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.get_m_rewardGroupGameObject);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.<>f__mg$cache1E;
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.set_m_rewardGroupGameObject);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.<>f__mg$cache1F, true);
		string name7 = "m_lockedText";
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.get_m_lockedText);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.<>f__mg$cache20;
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.set_m_lockedText);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.<>f__mg$cache21, true);
		string name8 = "m_memoryCorridorLevelInfo";
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.get_m_memoryCorridorLevelInfo);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.set_m_memoryCorridorLevelInfo);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_MemoryCorridorLevelListItemUIController.<>f__mg$cache23, true);
		LuaObject.createTypeMetatable(l, null, typeof(MemoryCorridorLevelListItemUIController), typeof(UIControllerBase));
	}

	// Token: 0x04015E1E RID: 89630
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04015E1F RID: 89631
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04015E20 RID: 89632
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04015E21 RID: 89633
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04015E22 RID: 89634
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04015E23 RID: 89635
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04015E24 RID: 89636
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04015E25 RID: 89637
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04015E26 RID: 89638
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04015E27 RID: 89639
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04015E28 RID: 89640
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04015E29 RID: 89641
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04015E2A RID: 89642
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04015E2B RID: 89643
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04015E2C RID: 89644
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04015E2D RID: 89645
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04015E2E RID: 89646
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04015E2F RID: 89647
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04015E30 RID: 89648
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04015E31 RID: 89649
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04015E32 RID: 89650
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04015E33 RID: 89651
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04015E34 RID: 89652
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04015E35 RID: 89653
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04015E36 RID: 89654
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04015E37 RID: 89655
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04015E38 RID: 89656
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04015E39 RID: 89657
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04015E3A RID: 89658
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04015E3B RID: 89659
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04015E3C RID: 89660
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04015E3D RID: 89661
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04015E3E RID: 89662
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04015E3F RID: 89663
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04015E40 RID: 89664
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04015E41 RID: 89665
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;
}
