using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001431 RID: 5169
[Preserve]
public class Lua_BlackJack_ProjectL_UI_EventRiftLevelButton : LuaObject
{
	// Token: 0x0601DA5B RID: 121435 RVA: 0x0096B9A8 File Offset: 0x00969BA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetRiftLevelInfo(IntPtr l)
	{
		int result;
		try
		{
			EventRiftLevelButton eventRiftLevelButton = (EventRiftLevelButton)LuaObject.checkSelf(l);
			ConfigDataRiftLevelInfo riftLevelInfo;
			LuaObject.checkType<ConfigDataRiftLevelInfo>(l, 2, out riftLevelInfo);
			eventRiftLevelButton.SetRiftLevelInfo(riftLevelInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DA5C RID: 121436 RVA: 0x0096BA00 File Offset: 0x00969C00
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetRiftLevelInfo(IntPtr l)
	{
		int result;
		try
		{
			EventRiftLevelButton eventRiftLevelButton = (EventRiftLevelButton)LuaObject.checkSelf(l);
			ConfigDataRiftLevelInfo riftLevelInfo = eventRiftLevelButton.GetRiftLevelInfo();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftLevelInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DA5D RID: 121437 RVA: 0x0096BA54 File Offset: 0x00969C54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetStatus(IntPtr l)
	{
		int result;
		try
		{
			EventRiftLevelButton eventRiftLevelButton = (EventRiftLevelButton)LuaObject.checkSelf(l);
			RiftLevelStatus status;
			LuaObject.checkEnum<RiftLevelStatus>(l, 2, out status);
			eventRiftLevelButton.SetStatus(status);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DA5E RID: 121438 RVA: 0x0096BAAC File Offset: 0x00969CAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetStatus(IntPtr l)
	{
		int result;
		try
		{
			EventRiftLevelButton eventRiftLevelButton = (EventRiftLevelButton)LuaObject.checkSelf(l);
			RiftLevelStatus status = eventRiftLevelButton.GetStatus();
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)status);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DA5F RID: 121439 RVA: 0x0096BB00 File Offset: 0x00969D00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			EventRiftLevelButton eventRiftLevelButton = (EventRiftLevelButton)LuaObject.checkSelf(l);
			eventRiftLevelButton.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DA60 RID: 121440 RVA: 0x0096BB54 File Offset: 0x00969D54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnClick(IntPtr l)
	{
		int result;
		try
		{
			EventRiftLevelButton eventRiftLevelButton = (EventRiftLevelButton)LuaObject.checkSelf(l);
			eventRiftLevelButton.m_luaExportHelper.OnClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DA61 RID: 121441 RVA: 0x0096BBA8 File Offset: 0x00969DA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			EventRiftLevelButton eventRiftLevelButton = (EventRiftLevelButton)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			eventRiftLevelButton.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DA62 RID: 121442 RVA: 0x0096BC14 File Offset: 0x00969E14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			EventRiftLevelButton eventRiftLevelButton = (EventRiftLevelButton)LuaObject.checkSelf(l);
			eventRiftLevelButton.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DA63 RID: 121443 RVA: 0x0096BC68 File Offset: 0x00969E68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			EventRiftLevelButton eventRiftLevelButton = (EventRiftLevelButton)LuaObject.checkSelf(l);
			eventRiftLevelButton.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DA64 RID: 121444 RVA: 0x0096BCBC File Offset: 0x00969EBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			EventRiftLevelButton eventRiftLevelButton = (EventRiftLevelButton)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = eventRiftLevelButton.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601DA65 RID: 121445 RVA: 0x0096BD64 File Offset: 0x00969F64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			EventRiftLevelButton eventRiftLevelButton = (EventRiftLevelButton)LuaObject.checkSelf(l);
			eventRiftLevelButton.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DA66 RID: 121446 RVA: 0x0096BDB8 File Offset: 0x00969FB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			EventRiftLevelButton eventRiftLevelButton = (EventRiftLevelButton)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			eventRiftLevelButton.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DA67 RID: 121447 RVA: 0x0096BE24 File Offset: 0x0096A024
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
				EventRiftLevelButton eventRiftLevelButton = (EventRiftLevelButton)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				eventRiftLevelButton.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				EventRiftLevelButton eventRiftLevelButton2 = (EventRiftLevelButton)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				eventRiftLevelButton2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601DA68 RID: 121448 RVA: 0x0096BF34 File Offset: 0x0096A134
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			EventRiftLevelButton eventRiftLevelButton = (EventRiftLevelButton)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			eventRiftLevelButton.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DA69 RID: 121449 RVA: 0x0096BFA0 File Offset: 0x0096A1A0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			EventRiftLevelButton eventRiftLevelButton = (EventRiftLevelButton)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			eventRiftLevelButton.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DA6A RID: 121450 RVA: 0x0096C00C File Offset: 0x0096A20C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			EventRiftLevelButton eventRiftLevelButton = (EventRiftLevelButton)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			eventRiftLevelButton.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DA6B RID: 121451 RVA: 0x0096C078 File Offset: 0x0096A278
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			EventRiftLevelButton eventRiftLevelButton = (EventRiftLevelButton)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			eventRiftLevelButton.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DA6C RID: 121452 RVA: 0x0096C0E4 File Offset: 0x0096A2E4
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
				EventRiftLevelButton eventRiftLevelButton = (EventRiftLevelButton)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				eventRiftLevelButton.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				EventRiftLevelButton eventRiftLevelButton2 = (EventRiftLevelButton)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				eventRiftLevelButton2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601DA6D RID: 121453 RVA: 0x0096C1F4 File Offset: 0x0096A3F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			EventRiftLevelButton eventRiftLevelButton = (EventRiftLevelButton)LuaObject.checkSelf(l);
			string s = eventRiftLevelButton.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601DA6E RID: 121454 RVA: 0x0096C250 File Offset: 0x0096A450
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnClick(IntPtr l)
	{
		int result;
		try
		{
			EventRiftLevelButton eventRiftLevelButton = (EventRiftLevelButton)LuaObject.checkSelf(l);
			EventRiftLevelButton obj;
			LuaObject.checkType<EventRiftLevelButton>(l, 2, out obj);
			eventRiftLevelButton.m_luaExportHelper.__callDele_EventOnClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DA6F RID: 121455 RVA: 0x0096C2AC File Offset: 0x0096A4AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnClick(IntPtr l)
	{
		int result;
		try
		{
			EventRiftLevelButton eventRiftLevelButton = (EventRiftLevelButton)LuaObject.checkSelf(l);
			EventRiftLevelButton obj;
			LuaObject.checkType<EventRiftLevelButton>(l, 2, out obj);
			eventRiftLevelButton.m_luaExportHelper.__clearDele_EventOnClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DA70 RID: 121456 RVA: 0x0096C308 File Offset: 0x0096A508
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnClick(IntPtr l)
	{
		int result;
		try
		{
			EventRiftLevelButton eventRiftLevelButton = (EventRiftLevelButton)LuaObject.checkSelf(l);
			Action<EventRiftLevelButton> value;
			int num = LuaObject.checkDelegate<Action<EventRiftLevelButton>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					eventRiftLevelButton.EventOnClick += value;
				}
				else if (num == 2)
				{
					eventRiftLevelButton.EventOnClick -= value;
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

	// Token: 0x0601DA71 RID: 121457 RVA: 0x0096C388 File Offset: 0x0096A588
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_button(IntPtr l)
	{
		int result;
		try
		{
			EventRiftLevelButton eventRiftLevelButton = (EventRiftLevelButton)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, eventRiftLevelButton.m_luaExportHelper.m_button);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DA72 RID: 121458 RVA: 0x0096C3E0 File Offset: 0x0096A5E0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_button(IntPtr l)
	{
		int result;
		try
		{
			EventRiftLevelButton eventRiftLevelButton = (EventRiftLevelButton)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			eventRiftLevelButton.m_luaExportHelper.m_button = button;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DA73 RID: 121459 RVA: 0x0096C43C File Offset: 0x0096A63C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			EventRiftLevelButton eventRiftLevelButton = (EventRiftLevelButton)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, eventRiftLevelButton.m_luaExportHelper.m_uiStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DA74 RID: 121460 RVA: 0x0096C494 File Offset: 0x0096A694
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			EventRiftLevelButton eventRiftLevelButton = (EventRiftLevelButton)LuaObject.checkSelf(l);
			CommonUIStateController uiStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out uiStateController);
			eventRiftLevelButton.m_luaExportHelper.m_uiStateController = uiStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DA75 RID: 121461 RVA: 0x0096C4F0 File Offset: 0x0096A6F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_status(IntPtr l)
	{
		int result;
		try
		{
			EventRiftLevelButton eventRiftLevelButton = (EventRiftLevelButton)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)eventRiftLevelButton.m_luaExportHelper.m_status);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DA76 RID: 121462 RVA: 0x0096C548 File Offset: 0x0096A748
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_status(IntPtr l)
	{
		int result;
		try
		{
			EventRiftLevelButton eventRiftLevelButton = (EventRiftLevelButton)LuaObject.checkSelf(l);
			RiftLevelStatus status;
			LuaObject.checkEnum<RiftLevelStatus>(l, 2, out status);
			eventRiftLevelButton.m_luaExportHelper.m_status = status;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DA77 RID: 121463 RVA: 0x0096C5A4 File Offset: 0x0096A7A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_riftLevelInfo(IntPtr l)
	{
		int result;
		try
		{
			EventRiftLevelButton eventRiftLevelButton = (EventRiftLevelButton)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, eventRiftLevelButton.m_luaExportHelper.m_riftLevelInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DA78 RID: 121464 RVA: 0x0096C5FC File Offset: 0x0096A7FC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_riftLevelInfo(IntPtr l)
	{
		int result;
		try
		{
			EventRiftLevelButton eventRiftLevelButton = (EventRiftLevelButton)LuaObject.checkSelf(l);
			ConfigDataRiftLevelInfo riftLevelInfo;
			LuaObject.checkType<ConfigDataRiftLevelInfo>(l, 2, out riftLevelInfo);
			eventRiftLevelButton.m_luaExportHelper.m_riftLevelInfo = riftLevelInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DA79 RID: 121465 RVA: 0x0096C658 File Offset: 0x0096A858
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.EventRiftLevelButton");
		if (Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.SetRiftLevelInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.GetRiftLevelInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.SetStatus);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.GetStatus);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.OnClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.__callDele_EventOnClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.__clearDele_EventOnClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.<>f__mg$cache14);
		string name = "EventOnClick";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.set_EventOnClick);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.<>f__mg$cache15, true);
		string name2 = "m_button";
		if (Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.get_m_button);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.<>f__mg$cache16;
		if (Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.set_m_button);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.<>f__mg$cache17, true);
		string name3 = "m_uiStateController";
		if (Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.get_m_uiStateController);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.<>f__mg$cache18;
		if (Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.set_m_uiStateController);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.<>f__mg$cache19, true);
		string name4 = "m_status";
		if (Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.get_m_status);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.<>f__mg$cache1A;
		if (Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.set_m_status);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.<>f__mg$cache1B, true);
		string name5 = "m_riftLevelInfo";
		if (Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.get_m_riftLevelInfo);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.<>f__mg$cache1C;
		if (Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.set_m_riftLevelInfo);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_EventRiftLevelButton.<>f__mg$cache1D, true);
		LuaObject.createTypeMetatable(l, null, typeof(EventRiftLevelButton), typeof(UIControllerBase));
	}

	// Token: 0x04013BDB RID: 80859
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04013BDC RID: 80860
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04013BDD RID: 80861
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04013BDE RID: 80862
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04013BDF RID: 80863
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04013BE0 RID: 80864
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04013BE1 RID: 80865
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04013BE2 RID: 80866
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04013BE3 RID: 80867
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04013BE4 RID: 80868
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04013BE5 RID: 80869
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04013BE6 RID: 80870
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04013BE7 RID: 80871
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04013BE8 RID: 80872
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04013BE9 RID: 80873
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04013BEA RID: 80874
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04013BEB RID: 80875
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04013BEC RID: 80876
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04013BED RID: 80877
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04013BEE RID: 80878
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04013BEF RID: 80879
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04013BF0 RID: 80880
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04013BF1 RID: 80881
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04013BF2 RID: 80882
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04013BF3 RID: 80883
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04013BF4 RID: 80884
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04013BF5 RID: 80885
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04013BF6 RID: 80886
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04013BF7 RID: 80887
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04013BF8 RID: 80888
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;
}
