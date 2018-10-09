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

// Token: 0x020015E5 RID: 5605
[Preserve]
public class Lua_BlackJack_ProjectL_UI_WorldMapUIController : LuaObject
{
	// Token: 0x06022441 RID: 140353 RVA: 0x00BB722C File Offset: 0x00BB542C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnPointerDown(IntPtr l)
	{
		int result;
		try
		{
			WorldMapUIController worldMapUIController = (WorldMapUIController)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			worldMapUIController.OnPointerDown(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022442 RID: 140354 RVA: 0x00BB7284 File Offset: 0x00BB5484
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPointerUp(IntPtr l)
	{
		int result;
		try
		{
			WorldMapUIController worldMapUIController = (WorldMapUIController)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			worldMapUIController.OnPointerUp(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022443 RID: 140355 RVA: 0x00BB72DC File Offset: 0x00BB54DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPointerClick(IntPtr l)
	{
		int result;
		try
		{
			WorldMapUIController worldMapUIController = (WorldMapUIController)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			worldMapUIController.OnPointerClick(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022444 RID: 140356 RVA: 0x00BB7334 File Offset: 0x00BB5534
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			WorldMapUIController worldMapUIController = (WorldMapUIController)LuaObject.checkSelf(l);
			worldMapUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022445 RID: 140357 RVA: 0x00BB7388 File Offset: 0x00BB5588
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			WorldMapUIController worldMapUIController = (WorldMapUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			worldMapUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022446 RID: 140358 RVA: 0x00BB73F4 File Offset: 0x00BB55F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			WorldMapUIController worldMapUIController = (WorldMapUIController)LuaObject.checkSelf(l);
			worldMapUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022447 RID: 140359 RVA: 0x00BB7448 File Offset: 0x00BB5648
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			WorldMapUIController worldMapUIController = (WorldMapUIController)LuaObject.checkSelf(l);
			worldMapUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022448 RID: 140360 RVA: 0x00BB749C File Offset: 0x00BB569C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			WorldMapUIController worldMapUIController = (WorldMapUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = worldMapUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x06022449 RID: 140361 RVA: 0x00BB7544 File Offset: 0x00BB5744
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			WorldMapUIController worldMapUIController = (WorldMapUIController)LuaObject.checkSelf(l);
			worldMapUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602244A RID: 140362 RVA: 0x00BB7598 File Offset: 0x00BB5798
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			WorldMapUIController worldMapUIController = (WorldMapUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			worldMapUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602244B RID: 140363 RVA: 0x00BB7604 File Offset: 0x00BB5804
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
				WorldMapUIController worldMapUIController = (WorldMapUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				worldMapUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				WorldMapUIController worldMapUIController2 = (WorldMapUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				worldMapUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0602244C RID: 140364 RVA: 0x00BB7714 File Offset: 0x00BB5914
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			WorldMapUIController worldMapUIController = (WorldMapUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			worldMapUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602244D RID: 140365 RVA: 0x00BB7780 File Offset: 0x00BB5980
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			WorldMapUIController worldMapUIController = (WorldMapUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			worldMapUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602244E RID: 140366 RVA: 0x00BB77EC File Offset: 0x00BB59EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			WorldMapUIController worldMapUIController = (WorldMapUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			worldMapUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602244F RID: 140367 RVA: 0x00BB7858 File Offset: 0x00BB5A58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			WorldMapUIController worldMapUIController = (WorldMapUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			worldMapUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022450 RID: 140368 RVA: 0x00BB78C4 File Offset: 0x00BB5AC4
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
				WorldMapUIController worldMapUIController = (WorldMapUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				worldMapUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				WorldMapUIController worldMapUIController2 = (WorldMapUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				worldMapUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x06022451 RID: 140369 RVA: 0x00BB79D4 File Offset: 0x00BB5BD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			WorldMapUIController worldMapUIController = (WorldMapUIController)LuaObject.checkSelf(l);
			string s = worldMapUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x06022452 RID: 140370 RVA: 0x00BB7A30 File Offset: 0x00BB5C30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnPointerDown(IntPtr l)
	{
		int result;
		try
		{
			WorldMapUIController worldMapUIController = (WorldMapUIController)LuaObject.checkSelf(l);
			worldMapUIController.m_luaExportHelper.__callDele_EventOnPointerDown();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022453 RID: 140371 RVA: 0x00BB7A84 File Offset: 0x00BB5C84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnPointerDown(IntPtr l)
	{
		int result;
		try
		{
			WorldMapUIController worldMapUIController = (WorldMapUIController)LuaObject.checkSelf(l);
			worldMapUIController.m_luaExportHelper.__clearDele_EventOnPointerDown();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022454 RID: 140372 RVA: 0x00BB7AD8 File Offset: 0x00BB5CD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnPointerUp(IntPtr l)
	{
		int result;
		try
		{
			WorldMapUIController worldMapUIController = (WorldMapUIController)LuaObject.checkSelf(l);
			worldMapUIController.m_luaExportHelper.__callDele_EventOnPointerUp();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022455 RID: 140373 RVA: 0x00BB7B2C File Offset: 0x00BB5D2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnPointerUp(IntPtr l)
	{
		int result;
		try
		{
			WorldMapUIController worldMapUIController = (WorldMapUIController)LuaObject.checkSelf(l);
			worldMapUIController.m_luaExportHelper.__clearDele_EventOnPointerUp();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022456 RID: 140374 RVA: 0x00BB7B80 File Offset: 0x00BB5D80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnClick(IntPtr l)
	{
		int result;
		try
		{
			WorldMapUIController worldMapUIController = (WorldMapUIController)LuaObject.checkSelf(l);
			worldMapUIController.m_luaExportHelper.__callDele_EventOnClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022457 RID: 140375 RVA: 0x00BB7BD4 File Offset: 0x00BB5DD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnClick(IntPtr l)
	{
		int result;
		try
		{
			WorldMapUIController worldMapUIController = (WorldMapUIController)LuaObject.checkSelf(l);
			worldMapUIController.m_luaExportHelper.__clearDele_EventOnClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022458 RID: 140376 RVA: 0x00BB7C28 File Offset: 0x00BB5E28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnPointerDown(IntPtr l)
	{
		int result;
		try
		{
			WorldMapUIController worldMapUIController = (WorldMapUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					worldMapUIController.EventOnPointerDown += value;
				}
				else if (num == 2)
				{
					worldMapUIController.EventOnPointerDown -= value;
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

	// Token: 0x06022459 RID: 140377 RVA: 0x00BB7CA8 File Offset: 0x00BB5EA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnPointerUp(IntPtr l)
	{
		int result;
		try
		{
			WorldMapUIController worldMapUIController = (WorldMapUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					worldMapUIController.EventOnPointerUp += value;
				}
				else if (num == 2)
				{
					worldMapUIController.EventOnPointerUp -= value;
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

	// Token: 0x0602245A RID: 140378 RVA: 0x00BB7D28 File Offset: 0x00BB5F28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnClick(IntPtr l)
	{
		int result;
		try
		{
			WorldMapUIController worldMapUIController = (WorldMapUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					worldMapUIController.EventOnClick += value;
				}
				else if (num == 2)
				{
					worldMapUIController.EventOnClick -= value;
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

	// Token: 0x0602245B RID: 140379 RVA: 0x00BB7DA8 File Offset: 0x00BB5FA8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.WorldMapUIController");
		if (Lua_BlackJack_ProjectL_UI_WorldMapUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldMapUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldMapUIController.OnPointerDown);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldMapUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_WorldMapUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldMapUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldMapUIController.OnPointerUp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldMapUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_WorldMapUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldMapUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldMapUIController.OnPointerClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldMapUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_WorldMapUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldMapUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldMapUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldMapUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_WorldMapUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldMapUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldMapUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldMapUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_WorldMapUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldMapUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldMapUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldMapUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_WorldMapUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldMapUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldMapUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldMapUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_WorldMapUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldMapUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldMapUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldMapUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_WorldMapUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldMapUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldMapUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldMapUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_WorldMapUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldMapUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldMapUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldMapUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_WorldMapUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldMapUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldMapUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldMapUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_WorldMapUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldMapUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldMapUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldMapUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_WorldMapUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldMapUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldMapUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldMapUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_WorldMapUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldMapUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldMapUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldMapUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_WorldMapUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldMapUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldMapUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldMapUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_WorldMapUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldMapUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldMapUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldMapUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_WorldMapUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldMapUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldMapUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldMapUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_WorldMapUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldMapUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldMapUIController.__callDele_EventOnPointerDown);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldMapUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_WorldMapUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldMapUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldMapUIController.__clearDele_EventOnPointerDown);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldMapUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_WorldMapUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldMapUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldMapUIController.__callDele_EventOnPointerUp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldMapUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_WorldMapUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldMapUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldMapUIController.__clearDele_EventOnPointerUp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldMapUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_WorldMapUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldMapUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldMapUIController.__callDele_EventOnClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldMapUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_WorldMapUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldMapUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldMapUIController.__clearDele_EventOnClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_WorldMapUIController.<>f__mg$cache16);
		string name = "EventOnPointerDown";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_WorldMapUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldMapUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldMapUIController.set_EventOnPointerDown);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_WorldMapUIController.<>f__mg$cache17, true);
		string name2 = "EventOnPointerUp";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_WorldMapUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldMapUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldMapUIController.set_EventOnPointerUp);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_WorldMapUIController.<>f__mg$cache18, true);
		string name3 = "EventOnClick";
		LuaCSFunction get3 = null;
		if (Lua_BlackJack_ProjectL_UI_WorldMapUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_WorldMapUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_WorldMapUIController.set_EventOnClick);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_WorldMapUIController.<>f__mg$cache19, true);
		LuaObject.createTypeMetatable(l, null, typeof(WorldMapUIController), typeof(UIControllerBase));
	}

	// Token: 0x04018259 RID: 98905
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401825A RID: 98906
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401825B RID: 98907
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0401825C RID: 98908
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0401825D RID: 98909
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0401825E RID: 98910
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0401825F RID: 98911
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04018260 RID: 98912
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04018261 RID: 98913
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04018262 RID: 98914
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04018263 RID: 98915
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04018264 RID: 98916
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04018265 RID: 98917
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04018266 RID: 98918
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04018267 RID: 98919
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04018268 RID: 98920
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04018269 RID: 98921
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0401826A RID: 98922
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0401826B RID: 98923
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0401826C RID: 98924
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0401826D RID: 98925
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0401826E RID: 98926
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0401826F RID: 98927
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04018270 RID: 98928
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04018271 RID: 98929
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04018272 RID: 98930
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;
}
