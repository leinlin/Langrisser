using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001372 RID: 4978
[Preserve]
public class Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController : LuaObject
{
	// Token: 0x0601ADEC RID: 110060 RVA: 0x00809D70 File Offset: 0x00807F70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPointerDown(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendSceneUIController arenaDefendSceneUIController = (ArenaDefendSceneUIController)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			arenaDefendSceneUIController.OnPointerDown(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ADED RID: 110061 RVA: 0x00809DC8 File Offset: 0x00807FC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPointerUp(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendSceneUIController arenaDefendSceneUIController = (ArenaDefendSceneUIController)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			arenaDefendSceneUIController.OnPointerUp(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ADEE RID: 110062 RVA: 0x00809E20 File Offset: 0x00808020
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPointerClick(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendSceneUIController arenaDefendSceneUIController = (ArenaDefendSceneUIController)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			arenaDefendSceneUIController.OnPointerClick(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ADEF RID: 110063 RVA: 0x00809E78 File Offset: 0x00808078
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBeginDrag(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendSceneUIController arenaDefendSceneUIController = (ArenaDefendSceneUIController)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			arenaDefendSceneUIController.OnBeginDrag(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ADF0 RID: 110064 RVA: 0x00809ED0 File Offset: 0x008080D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnEndDrag(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendSceneUIController arenaDefendSceneUIController = (ArenaDefendSceneUIController)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			arenaDefendSceneUIController.OnEndDrag(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ADF1 RID: 110065 RVA: 0x00809F28 File Offset: 0x00808128
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnDrag(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendSceneUIController arenaDefendSceneUIController = (ArenaDefendSceneUIController)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			arenaDefendSceneUIController.OnDrag(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ADF2 RID: 110066 RVA: 0x00809F80 File Offset: 0x00808180
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendSceneUIController arenaDefendSceneUIController = (ArenaDefendSceneUIController)LuaObject.checkSelf(l);
			arenaDefendSceneUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ADF3 RID: 110067 RVA: 0x00809FD4 File Offset: 0x008081D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendSceneUIController arenaDefendSceneUIController = (ArenaDefendSceneUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			arenaDefendSceneUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ADF4 RID: 110068 RVA: 0x0080A040 File Offset: 0x00808240
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendSceneUIController arenaDefendSceneUIController = (ArenaDefendSceneUIController)LuaObject.checkSelf(l);
			arenaDefendSceneUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ADF5 RID: 110069 RVA: 0x0080A094 File Offset: 0x00808294
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendSceneUIController arenaDefendSceneUIController = (ArenaDefendSceneUIController)LuaObject.checkSelf(l);
			arenaDefendSceneUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ADF6 RID: 110070 RVA: 0x0080A0E8 File Offset: 0x008082E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendSceneUIController arenaDefendSceneUIController = (ArenaDefendSceneUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = arenaDefendSceneUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601ADF7 RID: 110071 RVA: 0x0080A190 File Offset: 0x00808390
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendSceneUIController arenaDefendSceneUIController = (ArenaDefendSceneUIController)LuaObject.checkSelf(l);
			arenaDefendSceneUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ADF8 RID: 110072 RVA: 0x0080A1E4 File Offset: 0x008083E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendSceneUIController arenaDefendSceneUIController = (ArenaDefendSceneUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			arenaDefendSceneUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ADF9 RID: 110073 RVA: 0x0080A250 File Offset: 0x00808450
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
				ArenaDefendSceneUIController arenaDefendSceneUIController = (ArenaDefendSceneUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				arenaDefendSceneUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				ArenaDefendSceneUIController arenaDefendSceneUIController2 = (ArenaDefendSceneUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				arenaDefendSceneUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601ADFA RID: 110074 RVA: 0x0080A360 File Offset: 0x00808560
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendSceneUIController arenaDefendSceneUIController = (ArenaDefendSceneUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			arenaDefendSceneUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ADFB RID: 110075 RVA: 0x0080A3CC File Offset: 0x008085CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendSceneUIController arenaDefendSceneUIController = (ArenaDefendSceneUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			arenaDefendSceneUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ADFC RID: 110076 RVA: 0x0080A438 File Offset: 0x00808638
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendSceneUIController arenaDefendSceneUIController = (ArenaDefendSceneUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			arenaDefendSceneUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ADFD RID: 110077 RVA: 0x0080A4A4 File Offset: 0x008086A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendSceneUIController arenaDefendSceneUIController = (ArenaDefendSceneUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			arenaDefendSceneUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ADFE RID: 110078 RVA: 0x0080A510 File Offset: 0x00808710
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
				ArenaDefendSceneUIController arenaDefendSceneUIController = (ArenaDefendSceneUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				arenaDefendSceneUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				ArenaDefendSceneUIController arenaDefendSceneUIController2 = (ArenaDefendSceneUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				arenaDefendSceneUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601ADFF RID: 110079 RVA: 0x0080A620 File Offset: 0x00808820
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendSceneUIController arenaDefendSceneUIController = (ArenaDefendSceneUIController)LuaObject.checkSelf(l);
			string s = arenaDefendSceneUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601AE00 RID: 110080 RVA: 0x0080A67C File Offset: 0x0080887C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnPointerDown(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendSceneUIController arenaDefendSceneUIController = (ArenaDefendSceneUIController)LuaObject.checkSelf(l);
			PointerEventData obj;
			LuaObject.checkType<PointerEventData>(l, 2, out obj);
			arenaDefendSceneUIController.m_luaExportHelper.__callDele_EventOnPointerDown(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE01 RID: 110081 RVA: 0x0080A6D8 File Offset: 0x008088D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnPointerDown(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendSceneUIController arenaDefendSceneUIController = (ArenaDefendSceneUIController)LuaObject.checkSelf(l);
			PointerEventData obj;
			LuaObject.checkType<PointerEventData>(l, 2, out obj);
			arenaDefendSceneUIController.m_luaExportHelper.__clearDele_EventOnPointerDown(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE02 RID: 110082 RVA: 0x0080A734 File Offset: 0x00808934
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnPointerUp(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendSceneUIController arenaDefendSceneUIController = (ArenaDefendSceneUIController)LuaObject.checkSelf(l);
			PointerEventData obj;
			LuaObject.checkType<PointerEventData>(l, 2, out obj);
			arenaDefendSceneUIController.m_luaExportHelper.__callDele_EventOnPointerUp(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE03 RID: 110083 RVA: 0x0080A790 File Offset: 0x00808990
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnPointerUp(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendSceneUIController arenaDefendSceneUIController = (ArenaDefendSceneUIController)LuaObject.checkSelf(l);
			PointerEventData obj;
			LuaObject.checkType<PointerEventData>(l, 2, out obj);
			arenaDefendSceneUIController.m_luaExportHelper.__clearDele_EventOnPointerUp(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE04 RID: 110084 RVA: 0x0080A7EC File Offset: 0x008089EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnPointerClick(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendSceneUIController arenaDefendSceneUIController = (ArenaDefendSceneUIController)LuaObject.checkSelf(l);
			PointerEventData obj;
			LuaObject.checkType<PointerEventData>(l, 2, out obj);
			arenaDefendSceneUIController.m_luaExportHelper.__callDele_EventOnPointerClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE05 RID: 110085 RVA: 0x0080A848 File Offset: 0x00808A48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnPointerClick(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendSceneUIController arenaDefendSceneUIController = (ArenaDefendSceneUIController)LuaObject.checkSelf(l);
			PointerEventData obj;
			LuaObject.checkType<PointerEventData>(l, 2, out obj);
			arenaDefendSceneUIController.m_luaExportHelper.__clearDele_EventOnPointerClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE06 RID: 110086 RVA: 0x0080A8A4 File Offset: 0x00808AA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnBeginDrag(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendSceneUIController arenaDefendSceneUIController = (ArenaDefendSceneUIController)LuaObject.checkSelf(l);
			PointerEventData obj;
			LuaObject.checkType<PointerEventData>(l, 2, out obj);
			arenaDefendSceneUIController.m_luaExportHelper.__callDele_EventOnBeginDrag(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE07 RID: 110087 RVA: 0x0080A900 File Offset: 0x00808B00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnBeginDrag(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendSceneUIController arenaDefendSceneUIController = (ArenaDefendSceneUIController)LuaObject.checkSelf(l);
			PointerEventData obj;
			LuaObject.checkType<PointerEventData>(l, 2, out obj);
			arenaDefendSceneUIController.m_luaExportHelper.__clearDele_EventOnBeginDrag(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE08 RID: 110088 RVA: 0x0080A95C File Offset: 0x00808B5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnEndDrag(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendSceneUIController arenaDefendSceneUIController = (ArenaDefendSceneUIController)LuaObject.checkSelf(l);
			PointerEventData obj;
			LuaObject.checkType<PointerEventData>(l, 2, out obj);
			arenaDefendSceneUIController.m_luaExportHelper.__callDele_EventOnEndDrag(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE09 RID: 110089 RVA: 0x0080A9B8 File Offset: 0x00808BB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnEndDrag(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendSceneUIController arenaDefendSceneUIController = (ArenaDefendSceneUIController)LuaObject.checkSelf(l);
			PointerEventData obj;
			LuaObject.checkType<PointerEventData>(l, 2, out obj);
			arenaDefendSceneUIController.m_luaExportHelper.__clearDele_EventOnEndDrag(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE0A RID: 110090 RVA: 0x0080AA14 File Offset: 0x00808C14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnDrag(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendSceneUIController arenaDefendSceneUIController = (ArenaDefendSceneUIController)LuaObject.checkSelf(l);
			PointerEventData obj;
			LuaObject.checkType<PointerEventData>(l, 2, out obj);
			arenaDefendSceneUIController.m_luaExportHelper.__callDele_EventOnDrag(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE0B RID: 110091 RVA: 0x0080AA70 File Offset: 0x00808C70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnDrag(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendSceneUIController arenaDefendSceneUIController = (ArenaDefendSceneUIController)LuaObject.checkSelf(l);
			PointerEventData obj;
			LuaObject.checkType<PointerEventData>(l, 2, out obj);
			arenaDefendSceneUIController.m_luaExportHelper.__clearDele_EventOnDrag(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE0C RID: 110092 RVA: 0x0080AACC File Offset: 0x00808CCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnPointerDown(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendSceneUIController arenaDefendSceneUIController = (ArenaDefendSceneUIController)LuaObject.checkSelf(l);
			Action<PointerEventData> value;
			int num = LuaObject.checkDelegate<Action<PointerEventData>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					arenaDefendSceneUIController.EventOnPointerDown += value;
				}
				else if (num == 2)
				{
					arenaDefendSceneUIController.EventOnPointerDown -= value;
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

	// Token: 0x0601AE0D RID: 110093 RVA: 0x0080AB4C File Offset: 0x00808D4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnPointerUp(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendSceneUIController arenaDefendSceneUIController = (ArenaDefendSceneUIController)LuaObject.checkSelf(l);
			Action<PointerEventData> value;
			int num = LuaObject.checkDelegate<Action<PointerEventData>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					arenaDefendSceneUIController.EventOnPointerUp += value;
				}
				else if (num == 2)
				{
					arenaDefendSceneUIController.EventOnPointerUp -= value;
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

	// Token: 0x0601AE0E RID: 110094 RVA: 0x0080ABCC File Offset: 0x00808DCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnPointerClick(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendSceneUIController arenaDefendSceneUIController = (ArenaDefendSceneUIController)LuaObject.checkSelf(l);
			Action<PointerEventData> value;
			int num = LuaObject.checkDelegate<Action<PointerEventData>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					arenaDefendSceneUIController.EventOnPointerClick += value;
				}
				else if (num == 2)
				{
					arenaDefendSceneUIController.EventOnPointerClick -= value;
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

	// Token: 0x0601AE0F RID: 110095 RVA: 0x0080AC4C File Offset: 0x00808E4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnBeginDrag(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendSceneUIController arenaDefendSceneUIController = (ArenaDefendSceneUIController)LuaObject.checkSelf(l);
			Action<PointerEventData> value;
			int num = LuaObject.checkDelegate<Action<PointerEventData>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					arenaDefendSceneUIController.EventOnBeginDrag += value;
				}
				else if (num == 2)
				{
					arenaDefendSceneUIController.EventOnBeginDrag -= value;
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

	// Token: 0x0601AE10 RID: 110096 RVA: 0x0080ACCC File Offset: 0x00808ECC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnEndDrag(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendSceneUIController arenaDefendSceneUIController = (ArenaDefendSceneUIController)LuaObject.checkSelf(l);
			Action<PointerEventData> value;
			int num = LuaObject.checkDelegate<Action<PointerEventData>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					arenaDefendSceneUIController.EventOnEndDrag += value;
				}
				else if (num == 2)
				{
					arenaDefendSceneUIController.EventOnEndDrag -= value;
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

	// Token: 0x0601AE11 RID: 110097 RVA: 0x0080AD4C File Offset: 0x00808F4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnDrag(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendSceneUIController arenaDefendSceneUIController = (ArenaDefendSceneUIController)LuaObject.checkSelf(l);
			Action<PointerEventData> value;
			int num = LuaObject.checkDelegate<Action<PointerEventData>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					arenaDefendSceneUIController.EventOnDrag += value;
				}
				else if (num == 2)
				{
					arenaDefendSceneUIController.EventOnDrag -= value;
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

	// Token: 0x0601AE12 RID: 110098 RVA: 0x0080ADCC File Offset: 0x00808FCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_InvalidPointerID(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, ArenaDefendSceneUIController.LuaExportHelper.InvalidPointerID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE13 RID: 110099 RVA: 0x0080AE14 File Offset: 0x00809014
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_downPointerId(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendSceneUIController arenaDefendSceneUIController = (ArenaDefendSceneUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaDefendSceneUIController.m_luaExportHelper.m_downPointerId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE14 RID: 110100 RVA: 0x0080AE6C File Offset: 0x0080906C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_downPointerId(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendSceneUIController arenaDefendSceneUIController = (ArenaDefendSceneUIController)LuaObject.checkSelf(l);
			int downPointerId;
			LuaObject.checkType(l, 2, out downPointerId);
			arenaDefendSceneUIController.m_luaExportHelper.m_downPointerId = downPointerId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE15 RID: 110101 RVA: 0x0080AEC8 File Offset: 0x008090C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_clickPointerId(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendSceneUIController arenaDefendSceneUIController = (ArenaDefendSceneUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaDefendSceneUIController.m_luaExportHelper.m_clickPointerId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE16 RID: 110102 RVA: 0x0080AF20 File Offset: 0x00809120
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_clickPointerId(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendSceneUIController arenaDefendSceneUIController = (ArenaDefendSceneUIController)LuaObject.checkSelf(l);
			int clickPointerId;
			LuaObject.checkType(l, 2, out clickPointerId);
			arenaDefendSceneUIController.m_luaExportHelper.m_clickPointerId = clickPointerId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE17 RID: 110103 RVA: 0x0080AF7C File Offset: 0x0080917C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_dragPointerId(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendSceneUIController arenaDefendSceneUIController = (ArenaDefendSceneUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaDefendSceneUIController.m_luaExportHelper.m_dragPointerId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE18 RID: 110104 RVA: 0x0080AFD4 File Offset: 0x008091D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_dragPointerId(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefendSceneUIController arenaDefendSceneUIController = (ArenaDefendSceneUIController)LuaObject.checkSelf(l);
			int dragPointerId;
			LuaObject.checkType(l, 2, out dragPointerId);
			arenaDefendSceneUIController.m_luaExportHelper.m_dragPointerId = dragPointerId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601AE19 RID: 110105 RVA: 0x0080B030 File Offset: 0x00809230
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.ArenaDefendSceneUIController");
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.OnPointerDown);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.OnPointerUp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.OnPointerClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.OnBeginDrag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.OnEndDrag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.OnDrag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.__callDele_EventOnPointerDown);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.__clearDele_EventOnPointerDown);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.__callDele_EventOnPointerUp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.__clearDele_EventOnPointerUp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.__callDele_EventOnPointerClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.__clearDele_EventOnPointerClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.__callDele_EventOnBeginDrag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.__clearDele_EventOnBeginDrag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.__callDele_EventOnEndDrag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.__clearDele_EventOnEndDrag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.__callDele_EventOnDrag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.__clearDele_EventOnDrag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache1F);
		string name = "EventOnPointerDown";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.set_EventOnPointerDown);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache20, true);
		string name2 = "EventOnPointerUp";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.set_EventOnPointerUp);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache21, true);
		string name3 = "EventOnPointerClick";
		LuaCSFunction get3 = null;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.set_EventOnPointerClick);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache22, true);
		string name4 = "EventOnBeginDrag";
		LuaCSFunction get4 = null;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.set_EventOnBeginDrag);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache23, true);
		string name5 = "EventOnEndDrag";
		LuaCSFunction get5 = null;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.set_EventOnEndDrag);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache24, true);
		string name6 = "EventOnDrag";
		LuaCSFunction get6 = null;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.set_EventOnDrag);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache25, true);
		string name7 = "InvalidPointerID";
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.get_InvalidPointerID);
		}
		LuaObject.addMember(l, name7, Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache26, null, false);
		string name8 = "m_downPointerId";
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.get_m_downPointerId);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache27;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.set_m_downPointerId);
		}
		LuaObject.addMember(l, name8, get7, Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache28, true);
		string name9 = "m_clickPointerId";
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.get_m_clickPointerId);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache29;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.set_m_clickPointerId);
		}
		LuaObject.addMember(l, name9, get8, Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache2A, true);
		string name10 = "m_dragPointerId";
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.get_m_dragPointerId);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache2B;
		if (Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.set_m_dragPointerId);
		}
		LuaObject.addMember(l, name10, get9, Lua_BlackJack_ProjectL_UI_ArenaDefendSceneUIController.<>f__mg$cache2C, true);
		LuaObject.createTypeMetatable(l, null, typeof(ArenaDefendSceneUIController), typeof(UIControllerBase));
	}

	// Token: 0x040110EA RID: 69866
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040110EB RID: 69867
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040110EC RID: 69868
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040110ED RID: 69869
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040110EE RID: 69870
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040110EF RID: 69871
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040110F0 RID: 69872
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040110F1 RID: 69873
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040110F2 RID: 69874
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040110F3 RID: 69875
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040110F4 RID: 69876
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040110F5 RID: 69877
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040110F6 RID: 69878
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040110F7 RID: 69879
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040110F8 RID: 69880
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040110F9 RID: 69881
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040110FA RID: 69882
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040110FB RID: 69883
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040110FC RID: 69884
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x040110FD RID: 69885
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x040110FE RID: 69886
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x040110FF RID: 69887
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04011100 RID: 69888
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04011101 RID: 69889
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04011102 RID: 69890
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04011103 RID: 69891
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04011104 RID: 69892
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04011105 RID: 69893
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04011106 RID: 69894
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04011107 RID: 69895
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04011108 RID: 69896
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04011109 RID: 69897
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0401110A RID: 69898
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0401110B RID: 69899
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0401110C RID: 69900
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0401110D RID: 69901
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0401110E RID: 69902
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0401110F RID: 69903
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04011110 RID: 69904
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04011111 RID: 69905
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04011112 RID: 69906
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04011113 RID: 69907
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04011114 RID: 69908
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04011115 RID: 69909
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04011116 RID: 69910
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;
}
