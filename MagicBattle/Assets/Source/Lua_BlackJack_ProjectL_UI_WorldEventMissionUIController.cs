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

// Token: 0x020015E3 RID: 5603
[Preserve]
public class Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController : LuaObject
{
	// Token: 0x060223D2 RID: 140242 RVA: 0x00BB3AF8 File Offset: 0x00BB1CF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Open(IntPtr l)
	{
		int result;
		try
		{
			WorldEventMissionUIController worldEventMissionUIController = (WorldEventMissionUIController)LuaObject.checkSelf(l);
			worldEventMissionUIController.Open();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060223D3 RID: 140243 RVA: 0x00BB3B44 File Offset: 0x00BB1D44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetEvent(IntPtr l)
	{
		int result;
		try
		{
			WorldEventMissionUIController worldEventMissionUIController = (WorldEventMissionUIController)LuaObject.checkSelf(l);
			ConfigDataEventInfo @event;
			LuaObject.checkType<ConfigDataEventInfo>(l, 2, out @event);
			worldEventMissionUIController.SetEvent(@event);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060223D4 RID: 140244 RVA: 0x00BB3B9C File Offset: 0x00BB1D9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetRewards(IntPtr l)
	{
		int result;
		try
		{
			WorldEventMissionUIController worldEventMissionUIController = (WorldEventMissionUIController)LuaObject.checkSelf(l);
			List<Goods> rewards;
			LuaObject.checkType<List<Goods>>(l, 2, out rewards);
			worldEventMissionUIController.SetRewards(rewards);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060223D5 RID: 140245 RVA: 0x00BB3BF4 File Offset: 0x00BB1DF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			WorldEventMissionUIController worldEventMissionUIController = (WorldEventMissionUIController)LuaObject.checkSelf(l);
			worldEventMissionUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060223D6 RID: 140246 RVA: 0x00BB3C48 File Offset: 0x00BB1E48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateCharImage(IntPtr l)
	{
		int result;
		try
		{
			WorldEventMissionUIController worldEventMissionUIController = (WorldEventMissionUIController)LuaObject.checkSelf(l);
			ConfigDataCharImageInfo charImageInfo;
			LuaObject.checkType<ConfigDataCharImageInfo>(l, 2, out charImageInfo);
			worldEventMissionUIController.m_luaExportHelper.CreateCharImage(charImageInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060223D7 RID: 140247 RVA: 0x00BB3CA4 File Offset: 0x00BB1EA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DestroyCharImage(IntPtr l)
	{
		int result;
		try
		{
			WorldEventMissionUIController worldEventMissionUIController = (WorldEventMissionUIController)LuaObject.checkSelf(l);
			worldEventMissionUIController.m_luaExportHelper.DestroyCharImage();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060223D8 RID: 140248 RVA: 0x00BB3CF8 File Offset: 0x00BB1EF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBackgroundButtonClick(IntPtr l)
	{
		int result;
		try
		{
			WorldEventMissionUIController worldEventMissionUIController = (WorldEventMissionUIController)LuaObject.checkSelf(l);
			worldEventMissionUIController.m_luaExportHelper.OnBackgroundButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060223D9 RID: 140249 RVA: 0x00BB3D4C File Offset: 0x00BB1F4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnEnterButtonClick(IntPtr l)
	{
		int result;
		try
		{
			WorldEventMissionUIController worldEventMissionUIController = (WorldEventMissionUIController)LuaObject.checkSelf(l);
			worldEventMissionUIController.m_luaExportHelper.OnEnterButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060223DA RID: 140250 RVA: 0x00BB3DA0 File Offset: 0x00BB1FA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnCancelButtonClick(IntPtr l)
	{
		int result;
		try
		{
			WorldEventMissionUIController worldEventMissionUIController = (WorldEventMissionUIController)LuaObject.checkSelf(l);
			worldEventMissionUIController.m_luaExportHelper.OnCancelButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060223DB RID: 140251 RVA: 0x00BB3DF4 File Offset: 0x00BB1FF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			WorldEventMissionUIController worldEventMissionUIController = (WorldEventMissionUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			worldEventMissionUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060223DC RID: 140252 RVA: 0x00BB3E60 File Offset: 0x00BB2060
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			WorldEventMissionUIController worldEventMissionUIController = (WorldEventMissionUIController)LuaObject.checkSelf(l);
			worldEventMissionUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060223DD RID: 140253 RVA: 0x00BB3EB4 File Offset: 0x00BB20B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			WorldEventMissionUIController worldEventMissionUIController = (WorldEventMissionUIController)LuaObject.checkSelf(l);
			worldEventMissionUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060223DE RID: 140254 RVA: 0x00BB3F08 File Offset: 0x00BB2108
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			WorldEventMissionUIController worldEventMissionUIController = (WorldEventMissionUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = worldEventMissionUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x060223DF RID: 140255 RVA: 0x00BB3FB0 File Offset: 0x00BB21B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			WorldEventMissionUIController worldEventMissionUIController = (WorldEventMissionUIController)LuaObject.checkSelf(l);
			worldEventMissionUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060223E0 RID: 140256 RVA: 0x00BB4004 File Offset: 0x00BB2204
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			WorldEventMissionUIController worldEventMissionUIController = (WorldEventMissionUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			worldEventMissionUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060223E1 RID: 140257 RVA: 0x00BB4070 File Offset: 0x00BB2270
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
				WorldEventMissionUIController worldEventMissionUIController = (WorldEventMissionUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				worldEventMissionUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				WorldEventMissionUIController worldEventMissionUIController2 = (WorldEventMissionUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				worldEventMissionUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x060223E2 RID: 140258 RVA: 0x00BB4180 File Offset: 0x00BB2380
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			WorldEventMissionUIController worldEventMissionUIController = (WorldEventMissionUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			worldEventMissionUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060223E3 RID: 140259 RVA: 0x00BB41EC File Offset: 0x00BB23EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			WorldEventMissionUIController worldEventMissionUIController = (WorldEventMissionUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			worldEventMissionUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060223E4 RID: 140260 RVA: 0x00BB4258 File Offset: 0x00BB2458
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			WorldEventMissionUIController worldEventMissionUIController = (WorldEventMissionUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			worldEventMissionUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060223E5 RID: 140261 RVA: 0x00BB42C4 File Offset: 0x00BB24C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			WorldEventMissionUIController worldEventMissionUIController = (WorldEventMissionUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			worldEventMissionUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060223E6 RID: 140262 RVA: 0x00BB4330 File Offset: 0x00BB2530
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetToggleValueChangedListener(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(string[]), typeof(Action<UIControllerBase, bool>)))
			{
				WorldEventMissionUIController worldEventMissionUIController = (WorldEventMissionUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				worldEventMissionUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				WorldEventMissionUIController worldEventMissionUIController2 = (WorldEventMissionUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				worldEventMissionUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x060223E7 RID: 140263 RVA: 0x00BB4440 File Offset: 0x00BB2640
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			WorldEventMissionUIController worldEventMissionUIController = (WorldEventMissionUIController)LuaObject.checkSelf(l);
			string s = worldEventMissionUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x060223E8 RID: 140264 RVA: 0x00BB449C File Offset: 0x00BB269C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnEnterMission(IntPtr l)
	{
		int result;
		try
		{
			WorldEventMissionUIController worldEventMissionUIController = (WorldEventMissionUIController)LuaObject.checkSelf(l);
			worldEventMissionUIController.m_luaExportHelper.__callDele_EventOnEnterMission();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060223E9 RID: 140265 RVA: 0x00BB44F0 File Offset: 0x00BB26F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnEnterMission(IntPtr l)
	{
		int result;
		try
		{
			WorldEventMissionUIController worldEventMissionUIController = (WorldEventMissionUIController)LuaObject.checkSelf(l);
			worldEventMissionUIController.m_luaExportHelper.__clearDele_EventOnEnterMission();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060223EA RID: 140266 RVA: 0x00BB4544 File Offset: 0x00BB2744
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			WorldEventMissionUIController worldEventMissionUIController = (WorldEventMissionUIController)LuaObject.checkSelf(l);
			worldEventMissionUIController.m_luaExportHelper.__callDele_EventOnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060223EB RID: 140267 RVA: 0x00BB4598 File Offset: 0x00BB2798
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			WorldEventMissionUIController worldEventMissionUIController = (WorldEventMissionUIController)LuaObject.checkSelf(l);
			worldEventMissionUIController.m_luaExportHelper.__clearDele_EventOnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060223EC RID: 140268 RVA: 0x00BB45EC File Offset: 0x00BB27EC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_EventOnEnterMission(IntPtr l)
	{
		int result;
		try
		{
			WorldEventMissionUIController worldEventMissionUIController = (WorldEventMissionUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					worldEventMissionUIController.EventOnEnterMission += value;
				}
				else if (num == 2)
				{
					worldEventMissionUIController.EventOnEnterMission -= value;
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

	// Token: 0x060223ED RID: 140269 RVA: 0x00BB466C File Offset: 0x00BB286C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			WorldEventMissionUIController worldEventMissionUIController = (WorldEventMissionUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					worldEventMissionUIController.EventOnClose += value;
				}
				else if (num == 2)
				{
					worldEventMissionUIController.EventOnClose -= value;
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

	// Token: 0x060223EE RID: 140270 RVA: 0x00BB46EC File Offset: 0x00BB28EC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			WorldEventMissionUIController worldEventMissionUIController = (WorldEventMissionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldEventMissionUIController.m_luaExportHelper.m_uiStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060223EF RID: 140271 RVA: 0x00BB4744 File Offset: 0x00BB2944
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			WorldEventMissionUIController worldEventMissionUIController = (WorldEventMissionUIController)LuaObject.checkSelf(l);
			CommonUIStateController uiStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out uiStateController);
			worldEventMissionUIController.m_luaExportHelper.m_uiStateController = uiStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060223F0 RID: 140272 RVA: 0x00BB47A0 File Offset: 0x00BB29A0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_dangerUIStateController(IntPtr l)
	{
		int result;
		try
		{
			WorldEventMissionUIController worldEventMissionUIController = (WorldEventMissionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldEventMissionUIController.m_luaExportHelper.m_dangerUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060223F1 RID: 140273 RVA: 0x00BB47F8 File Offset: 0x00BB29F8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_dangerUIStateController(IntPtr l)
	{
		int result;
		try
		{
			WorldEventMissionUIController worldEventMissionUIController = (WorldEventMissionUIController)LuaObject.checkSelf(l);
			CommonUIStateController dangerUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out dangerUIStateController);
			worldEventMissionUIController.m_luaExportHelper.m_dangerUIStateController = dangerUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060223F2 RID: 140274 RVA: 0x00BB4854 File Offset: 0x00BB2A54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_nameText(IntPtr l)
	{
		int result;
		try
		{
			WorldEventMissionUIController worldEventMissionUIController = (WorldEventMissionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldEventMissionUIController.m_luaExportHelper.m_nameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060223F3 RID: 140275 RVA: 0x00BB48AC File Offset: 0x00BB2AAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_nameText(IntPtr l)
	{
		int result;
		try
		{
			WorldEventMissionUIController worldEventMissionUIController = (WorldEventMissionUIController)LuaObject.checkSelf(l);
			Text nameText;
			LuaObject.checkType<Text>(l, 2, out nameText);
			worldEventMissionUIController.m_luaExportHelper.m_nameText = nameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060223F4 RID: 140276 RVA: 0x00BB4908 File Offset: 0x00BB2B08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_descText(IntPtr l)
	{
		int result;
		try
		{
			WorldEventMissionUIController worldEventMissionUIController = (WorldEventMissionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldEventMissionUIController.m_luaExportHelper.m_descText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060223F5 RID: 140277 RVA: 0x00BB4960 File Offset: 0x00BB2B60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_descText(IntPtr l)
	{
		int result;
		try
		{
			WorldEventMissionUIController worldEventMissionUIController = (WorldEventMissionUIController)LuaObject.checkSelf(l);
			Text descText;
			LuaObject.checkType<Text>(l, 2, out descText);
			worldEventMissionUIController.m_luaExportHelper.m_descText = descText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060223F6 RID: 140278 RVA: 0x00BB49BC File Offset: 0x00BB2BBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_monsterLevelText(IntPtr l)
	{
		int result;
		try
		{
			WorldEventMissionUIController worldEventMissionUIController = (WorldEventMissionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldEventMissionUIController.m_luaExportHelper.m_monsterLevelText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060223F7 RID: 140279 RVA: 0x00BB4A14 File Offset: 0x00BB2C14
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_monsterLevelText(IntPtr l)
	{
		int result;
		try
		{
			WorldEventMissionUIController worldEventMissionUIController = (WorldEventMissionUIController)LuaObject.checkSelf(l);
			Text monsterLevelText;
			LuaObject.checkType<Text>(l, 2, out monsterLevelText);
			worldEventMissionUIController.m_luaExportHelper.m_monsterLevelText = monsterLevelText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060223F8 RID: 140280 RVA: 0x00BB4A70 File Offset: 0x00BB2C70
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_energyText(IntPtr l)
	{
		int result;
		try
		{
			WorldEventMissionUIController worldEventMissionUIController = (WorldEventMissionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldEventMissionUIController.m_luaExportHelper.m_energyText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060223F9 RID: 140281 RVA: 0x00BB4AC8 File Offset: 0x00BB2CC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_energyText(IntPtr l)
	{
		int result;
		try
		{
			WorldEventMissionUIController worldEventMissionUIController = (WorldEventMissionUIController)LuaObject.checkSelf(l);
			Text energyText;
			LuaObject.checkType<Text>(l, 2, out energyText);
			worldEventMissionUIController.m_luaExportHelper.m_energyText = energyText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060223FA RID: 140282 RVA: 0x00BB4B24 File Offset: 0x00BB2D24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_rewardGoodsGameObject(IntPtr l)
	{
		int result;
		try
		{
			WorldEventMissionUIController worldEventMissionUIController = (WorldEventMissionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldEventMissionUIController.m_luaExportHelper.m_rewardGoodsGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060223FB RID: 140283 RVA: 0x00BB4B7C File Offset: 0x00BB2D7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_rewardGoodsGameObject(IntPtr l)
	{
		int result;
		try
		{
			WorldEventMissionUIController worldEventMissionUIController = (WorldEventMissionUIController)LuaObject.checkSelf(l);
			GameObject rewardGoodsGameObject;
			LuaObject.checkType<GameObject>(l, 2, out rewardGoodsGameObject);
			worldEventMissionUIController.m_luaExportHelper.m_rewardGoodsGameObject = rewardGoodsGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060223FC RID: 140284 RVA: 0x00BB4BD8 File Offset: 0x00BB2DD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_backgroundButton(IntPtr l)
	{
		int result;
		try
		{
			WorldEventMissionUIController worldEventMissionUIController = (WorldEventMissionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldEventMissionUIController.m_luaExportHelper.m_backgroundButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060223FD RID: 140285 RVA: 0x00BB4C30 File Offset: 0x00BB2E30
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_backgroundButton(IntPtr l)
	{
		int result;
		try
		{
			WorldEventMissionUIController worldEventMissionUIController = (WorldEventMissionUIController)LuaObject.checkSelf(l);
			Button backgroundButton;
			LuaObject.checkType<Button>(l, 2, out backgroundButton);
			worldEventMissionUIController.m_luaExportHelper.m_backgroundButton = backgroundButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060223FE RID: 140286 RVA: 0x00BB4C8C File Offset: 0x00BB2E8C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_enterButton(IntPtr l)
	{
		int result;
		try
		{
			WorldEventMissionUIController worldEventMissionUIController = (WorldEventMissionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldEventMissionUIController.m_luaExportHelper.m_enterButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060223FF RID: 140287 RVA: 0x00BB4CE4 File Offset: 0x00BB2EE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_enterButton(IntPtr l)
	{
		int result;
		try
		{
			WorldEventMissionUIController worldEventMissionUIController = (WorldEventMissionUIController)LuaObject.checkSelf(l);
			Button enterButton;
			LuaObject.checkType<Button>(l, 2, out enterButton);
			worldEventMissionUIController.m_luaExportHelper.m_enterButton = enterButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022400 RID: 140288 RVA: 0x00BB4D40 File Offset: 0x00BB2F40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_cancelButton(IntPtr l)
	{
		int result;
		try
		{
			WorldEventMissionUIController worldEventMissionUIController = (WorldEventMissionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldEventMissionUIController.m_luaExportHelper.m_cancelButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022401 RID: 140289 RVA: 0x00BB4D98 File Offset: 0x00BB2F98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_cancelButton(IntPtr l)
	{
		int result;
		try
		{
			WorldEventMissionUIController worldEventMissionUIController = (WorldEventMissionUIController)LuaObject.checkSelf(l);
			Button cancelButton;
			LuaObject.checkType<Button>(l, 2, out cancelButton);
			worldEventMissionUIController.m_luaExportHelper.m_cancelButton = cancelButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022402 RID: 140290 RVA: 0x00BB4DF4 File Offset: 0x00BB2FF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_missionUIStateController(IntPtr l)
	{
		int result;
		try
		{
			WorldEventMissionUIController worldEventMissionUIController = (WorldEventMissionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldEventMissionUIController.m_luaExportHelper.m_missionUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022403 RID: 140291 RVA: 0x00BB4E4C File Offset: 0x00BB304C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_missionUIStateController(IntPtr l)
	{
		int result;
		try
		{
			WorldEventMissionUIController worldEventMissionUIController = (WorldEventMissionUIController)LuaObject.checkSelf(l);
			CommonUIStateController missionUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out missionUIStateController);
			worldEventMissionUIController.m_luaExportHelper.m_missionUIStateController = missionUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022404 RID: 140292 RVA: 0x00BB4EA8 File Offset: 0x00BB30A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_charGameObject(IntPtr l)
	{
		int result;
		try
		{
			WorldEventMissionUIController worldEventMissionUIController = (WorldEventMissionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldEventMissionUIController.m_luaExportHelper.m_charGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022405 RID: 140293 RVA: 0x00BB4F00 File Offset: 0x00BB3100
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_charGameObject(IntPtr l)
	{
		int result;
		try
		{
			WorldEventMissionUIController worldEventMissionUIController = (WorldEventMissionUIController)LuaObject.checkSelf(l);
			GameObject charGameObject;
			LuaObject.checkType<GameObject>(l, 2, out charGameObject);
			worldEventMissionUIController.m_luaExportHelper.m_charGameObject = charGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022406 RID: 140294 RVA: 0x00BB4F5C File Offset: 0x00BB315C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_charImage(IntPtr l)
	{
		int result;
		try
		{
			WorldEventMissionUIController worldEventMissionUIController = (WorldEventMissionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldEventMissionUIController.m_luaExportHelper.m_charImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022407 RID: 140295 RVA: 0x00BB4FB4 File Offset: 0x00BB31B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_charImage(IntPtr l)
	{
		int result;
		try
		{
			WorldEventMissionUIController worldEventMissionUIController = (WorldEventMissionUIController)LuaObject.checkSelf(l);
			Image charImage;
			LuaObject.checkType<Image>(l, 2, out charImage);
			worldEventMissionUIController.m_luaExportHelper.m_charImage = charImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022408 RID: 140296 RVA: 0x00BB5010 File Offset: 0x00BB3210
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_spineGraphic(IntPtr l)
	{
		int result;
		try
		{
			WorldEventMissionUIController worldEventMissionUIController = (WorldEventMissionUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, worldEventMissionUIController.m_luaExportHelper.m_spineGraphic);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022409 RID: 140297 RVA: 0x00BB5068 File Offset: 0x00BB3268
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_spineGraphic(IntPtr l)
	{
		int result;
		try
		{
			WorldEventMissionUIController worldEventMissionUIController = (WorldEventMissionUIController)LuaObject.checkSelf(l);
			UISpineGraphic spineGraphic;
			LuaObject.checkType<UISpineGraphic>(l, 2, out spineGraphic);
			worldEventMissionUIController.m_luaExportHelper.m_spineGraphic = spineGraphic;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602240A RID: 140298 RVA: 0x00BB50C4 File Offset: 0x00BB32C4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.WorldEventMissionUIController");
		if (Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.Open);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.SetEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.SetRewards);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.CreateCharImage);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.DestroyCharImage);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.OnBackgroundButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.OnEnterButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.OnCancelButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.__callDele_EventOnEnterMission);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.__clearDele_EventOnEnterMission);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.__callDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.__clearDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache19);
		string name = "EventOnEnterMission";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.set_EventOnEnterMission);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache1A, true);
		string name2 = "EventOnClose";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.set_EventOnClose);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache1B, true);
		string name3 = "m_uiStateController";
		if (Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.get_m_uiStateController);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache1C;
		if (Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.set_m_uiStateController);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache1D, true);
		string name4 = "m_dangerUIStateController";
		if (Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.get_m_dangerUIStateController);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache1E;
		if (Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.set_m_dangerUIStateController);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache1F, true);
		string name5 = "m_nameText";
		if (Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.get_m_nameText);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache20;
		if (Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.set_m_nameText);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache21, true);
		string name6 = "m_descText";
		if (Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.get_m_descText);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.set_m_descText);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache23, true);
		string name7 = "m_monsterLevelText";
		if (Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.get_m_monsterLevelText);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache24;
		if (Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.set_m_monsterLevelText);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache25, true);
		string name8 = "m_energyText";
		if (Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.get_m_energyText);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache26;
		if (Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.set_m_energyText);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache27, true);
		string name9 = "m_rewardGoodsGameObject";
		if (Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.get_m_rewardGoodsGameObject);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache28;
		if (Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.set_m_rewardGoodsGameObject);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache29, true);
		string name10 = "m_backgroundButton";
		if (Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.get_m_backgroundButton);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache2A;
		if (Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.set_m_backgroundButton);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache2B, true);
		string name11 = "m_enterButton";
		if (Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.get_m_enterButton);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache2C;
		if (Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.set_m_enterButton);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache2D, true);
		string name12 = "m_cancelButton";
		if (Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.get_m_cancelButton);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache2E;
		if (Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.set_m_cancelButton);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache2F, true);
		string name13 = "m_missionUIStateController";
		if (Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.get_m_missionUIStateController);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache30;
		if (Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.set_m_missionUIStateController);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache31, true);
		string name14 = "m_charGameObject";
		if (Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.get_m_charGameObject);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache32;
		if (Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.set_m_charGameObject);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache33, true);
		string name15 = "m_charImage";
		if (Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.get_m_charImage);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache34;
		if (Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.set_m_charImage);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache35, true);
		string name16 = "m_spineGraphic";
		if (Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.get_m_spineGraphic);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache36;
		if (Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.set_m_spineGraphic);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_WorldEventMissionUIController.<>f__mg$cache37, true);
		LuaObject.createTypeMetatable(l, null, typeof(WorldEventMissionUIController), typeof(UIControllerBase));
	}

	// Token: 0x040181EE RID: 98798
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040181EF RID: 98799
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040181F0 RID: 98800
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040181F1 RID: 98801
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040181F2 RID: 98802
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040181F3 RID: 98803
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040181F4 RID: 98804
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040181F5 RID: 98805
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040181F6 RID: 98806
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040181F7 RID: 98807
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040181F8 RID: 98808
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040181F9 RID: 98809
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040181FA RID: 98810
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040181FB RID: 98811
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040181FC RID: 98812
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040181FD RID: 98813
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040181FE RID: 98814
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040181FF RID: 98815
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04018200 RID: 98816
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04018201 RID: 98817
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04018202 RID: 98818
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04018203 RID: 98819
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04018204 RID: 98820
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04018205 RID: 98821
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04018206 RID: 98822
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04018207 RID: 98823
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04018208 RID: 98824
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04018209 RID: 98825
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0401820A RID: 98826
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0401820B RID: 98827
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0401820C RID: 98828
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0401820D RID: 98829
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0401820E RID: 98830
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0401820F RID: 98831
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04018210 RID: 98832
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04018211 RID: 98833
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04018212 RID: 98834
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04018213 RID: 98835
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04018214 RID: 98836
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04018215 RID: 98837
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04018216 RID: 98838
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04018217 RID: 98839
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04018218 RID: 98840
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04018219 RID: 98841
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0401821A RID: 98842
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0401821B RID: 98843
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0401821C RID: 98844
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x0401821D RID: 98845
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x0401821E RID: 98846
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x0401821F RID: 98847
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04018220 RID: 98848
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04018221 RID: 98849
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04018222 RID: 98850
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04018223 RID: 98851
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04018224 RID: 98852
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04018225 RID: 98853
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;
}
