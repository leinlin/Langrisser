using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Scripting;

// Token: 0x020016A2 RID: 5794
[Preserve]
public class Lua_UnityEngine_EventSystems_EventSystem : LuaObject
{
	// Token: 0x06023125 RID: 143653 RVA: 0x00C25E08 File Offset: 0x00C24008
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateModules(IntPtr l)
	{
		int result;
		try
		{
			EventSystem eventSystem = (EventSystem)LuaObject.checkSelf(l);
			eventSystem.UpdateModules();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023126 RID: 143654 RVA: 0x00C25E54 File Offset: 0x00C24054
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetSelectedGameObject(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				EventSystem eventSystem = (EventSystem)LuaObject.checkSelf(l);
				GameObject selectedGameObject;
				LuaObject.checkType<GameObject>(l, 2, out selectedGameObject);
				eventSystem.SetSelectedGameObject(selectedGameObject);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 3)
			{
				EventSystem eventSystem2 = (EventSystem)LuaObject.checkSelf(l);
				GameObject selected;
				LuaObject.checkType<GameObject>(l, 2, out selected);
				BaseEventData pointer;
				LuaObject.checkType<BaseEventData>(l, 3, out pointer);
				eventSystem2.SetSelectedGameObject(selected, pointer);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function SetSelectedGameObject to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023127 RID: 143655 RVA: 0x00C25F18 File Offset: 0x00C24118
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RaycastAll(IntPtr l)
	{
		int result;
		try
		{
			EventSystem eventSystem = (EventSystem)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			List<RaycastResult> raycastResults;
			LuaObject.checkType<List<RaycastResult>>(l, 3, out raycastResults);
			eventSystem.RaycastAll(eventData, raycastResults);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023128 RID: 143656 RVA: 0x00C25F7C File Offset: 0x00C2417C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsPointerOverGameObject(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 1)
			{
				EventSystem eventSystem = (EventSystem)LuaObject.checkSelf(l);
				bool b = eventSystem.IsPointerOverGameObject();
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b);
				result = 2;
			}
			else if (num == 2)
			{
				EventSystem eventSystem2 = (EventSystem)LuaObject.checkSelf(l);
				int pointerId;
				LuaObject.checkType(l, 2, out pointerId);
				bool b2 = eventSystem2.IsPointerOverGameObject(pointerId);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function IsPointerOverGameObject to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023129 RID: 143657 RVA: 0x00C26038 File Offset: 0x00C24238
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_current(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, EventSystem.current);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602312A RID: 143658 RVA: 0x00C26080 File Offset: 0x00C24280
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_current(IntPtr l)
	{
		int result;
		try
		{
			EventSystem current;
			LuaObject.checkType<EventSystem>(l, 2, out current);
			EventSystem.current = current;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602312B RID: 143659 RVA: 0x00C260CC File Offset: 0x00C242CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_sendNavigationEvents(IntPtr l)
	{
		int result;
		try
		{
			EventSystem eventSystem = (EventSystem)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, eventSystem.sendNavigationEvents);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602312C RID: 143660 RVA: 0x00C26120 File Offset: 0x00C24320
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_sendNavigationEvents(IntPtr l)
	{
		int result;
		try
		{
			EventSystem eventSystem = (EventSystem)LuaObject.checkSelf(l);
			bool sendNavigationEvents;
			LuaObject.checkType(l, 2, out sendNavigationEvents);
			eventSystem.sendNavigationEvents = sendNavigationEvents;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602312D RID: 143661 RVA: 0x00C26178 File Offset: 0x00C24378
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_pixelDragThreshold(IntPtr l)
	{
		int result;
		try
		{
			EventSystem eventSystem = (EventSystem)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, eventSystem.pixelDragThreshold);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602312E RID: 143662 RVA: 0x00C261CC File Offset: 0x00C243CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_pixelDragThreshold(IntPtr l)
	{
		int result;
		try
		{
			EventSystem eventSystem = (EventSystem)LuaObject.checkSelf(l);
			int pixelDragThreshold;
			LuaObject.checkType(l, 2, out pixelDragThreshold);
			eventSystem.pixelDragThreshold = pixelDragThreshold;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602312F RID: 143663 RVA: 0x00C26224 File Offset: 0x00C24424
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_currentInputModule(IntPtr l)
	{
		int result;
		try
		{
			EventSystem eventSystem = (EventSystem)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, eventSystem.currentInputModule);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023130 RID: 143664 RVA: 0x00C26278 File Offset: 0x00C24478
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_firstSelectedGameObject(IntPtr l)
	{
		int result;
		try
		{
			EventSystem eventSystem = (EventSystem)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, eventSystem.firstSelectedGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023131 RID: 143665 RVA: 0x00C262CC File Offset: 0x00C244CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_firstSelectedGameObject(IntPtr l)
	{
		int result;
		try
		{
			EventSystem eventSystem = (EventSystem)LuaObject.checkSelf(l);
			GameObject firstSelectedGameObject;
			LuaObject.checkType<GameObject>(l, 2, out firstSelectedGameObject);
			eventSystem.firstSelectedGameObject = firstSelectedGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023132 RID: 143666 RVA: 0x00C26324 File Offset: 0x00C24524
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_currentSelectedGameObject(IntPtr l)
	{
		int result;
		try
		{
			EventSystem eventSystem = (EventSystem)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, eventSystem.currentSelectedGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023133 RID: 143667 RVA: 0x00C26378 File Offset: 0x00C24578
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_isFocused(IntPtr l)
	{
		int result;
		try
		{
			EventSystem eventSystem = (EventSystem)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, eventSystem.isFocused);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023134 RID: 143668 RVA: 0x00C263CC File Offset: 0x00C245CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_alreadySelecting(IntPtr l)
	{
		int result;
		try
		{
			EventSystem eventSystem = (EventSystem)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, eventSystem.alreadySelecting);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023135 RID: 143669 RVA: 0x00C26420 File Offset: 0x00C24620
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.EventSystems.EventSystem");
		if (Lua_UnityEngine_EventSystems_EventSystem.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_EventSystems_EventSystem.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_EventSystems_EventSystem.UpdateModules);
		}
		LuaObject.addMember(l, Lua_UnityEngine_EventSystems_EventSystem.<>f__mg$cache0);
		if (Lua_UnityEngine_EventSystems_EventSystem.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_EventSystems_EventSystem.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_EventSystems_EventSystem.SetSelectedGameObject);
		}
		LuaObject.addMember(l, Lua_UnityEngine_EventSystems_EventSystem.<>f__mg$cache1);
		if (Lua_UnityEngine_EventSystems_EventSystem.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_EventSystems_EventSystem.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_EventSystems_EventSystem.RaycastAll);
		}
		LuaObject.addMember(l, Lua_UnityEngine_EventSystems_EventSystem.<>f__mg$cache2);
		if (Lua_UnityEngine_EventSystems_EventSystem.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_EventSystems_EventSystem.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_EventSystems_EventSystem.IsPointerOverGameObject);
		}
		LuaObject.addMember(l, Lua_UnityEngine_EventSystems_EventSystem.<>f__mg$cache3);
		string name = "current";
		if (Lua_UnityEngine_EventSystems_EventSystem.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_EventSystems_EventSystem.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_EventSystems_EventSystem.get_current);
		}
		LuaCSFunction get = Lua_UnityEngine_EventSystems_EventSystem.<>f__mg$cache4;
		if (Lua_UnityEngine_EventSystems_EventSystem.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_EventSystems_EventSystem.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_EventSystems_EventSystem.set_current);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_EventSystems_EventSystem.<>f__mg$cache5, false);
		string name2 = "sendNavigationEvents";
		if (Lua_UnityEngine_EventSystems_EventSystem.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_EventSystems_EventSystem.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_EventSystems_EventSystem.get_sendNavigationEvents);
		}
		LuaCSFunction get2 = Lua_UnityEngine_EventSystems_EventSystem.<>f__mg$cache6;
		if (Lua_UnityEngine_EventSystems_EventSystem.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_EventSystems_EventSystem.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_EventSystems_EventSystem.set_sendNavigationEvents);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_EventSystems_EventSystem.<>f__mg$cache7, true);
		string name3 = "pixelDragThreshold";
		if (Lua_UnityEngine_EventSystems_EventSystem.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_EventSystems_EventSystem.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_EventSystems_EventSystem.get_pixelDragThreshold);
		}
		LuaCSFunction get3 = Lua_UnityEngine_EventSystems_EventSystem.<>f__mg$cache8;
		if (Lua_UnityEngine_EventSystems_EventSystem.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_EventSystems_EventSystem.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_EventSystems_EventSystem.set_pixelDragThreshold);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_EventSystems_EventSystem.<>f__mg$cache9, true);
		string name4 = "currentInputModule";
		if (Lua_UnityEngine_EventSystems_EventSystem.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_EventSystems_EventSystem.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_EventSystems_EventSystem.get_currentInputModule);
		}
		LuaObject.addMember(l, name4, Lua_UnityEngine_EventSystems_EventSystem.<>f__mg$cacheA, null, true);
		string name5 = "firstSelectedGameObject";
		if (Lua_UnityEngine_EventSystems_EventSystem.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_EventSystems_EventSystem.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_EventSystems_EventSystem.get_firstSelectedGameObject);
		}
		LuaCSFunction get4 = Lua_UnityEngine_EventSystems_EventSystem.<>f__mg$cacheB;
		if (Lua_UnityEngine_EventSystems_EventSystem.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_EventSystems_EventSystem.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_EventSystems_EventSystem.set_firstSelectedGameObject);
		}
		LuaObject.addMember(l, name5, get4, Lua_UnityEngine_EventSystems_EventSystem.<>f__mg$cacheC, true);
		string name6 = "currentSelectedGameObject";
		if (Lua_UnityEngine_EventSystems_EventSystem.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_EventSystems_EventSystem.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_EventSystems_EventSystem.get_currentSelectedGameObject);
		}
		LuaObject.addMember(l, name6, Lua_UnityEngine_EventSystems_EventSystem.<>f__mg$cacheD, null, true);
		string name7 = "isFocused";
		if (Lua_UnityEngine_EventSystems_EventSystem.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_EventSystems_EventSystem.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_EventSystems_EventSystem.get_isFocused);
		}
		LuaObject.addMember(l, name7, Lua_UnityEngine_EventSystems_EventSystem.<>f__mg$cacheE, null, true);
		string name8 = "alreadySelecting";
		if (Lua_UnityEngine_EventSystems_EventSystem.<>f__mg$cacheF == null)
		{
			Lua_UnityEngine_EventSystems_EventSystem.<>f__mg$cacheF = new LuaCSFunction(Lua_UnityEngine_EventSystems_EventSystem.get_alreadySelecting);
		}
		LuaObject.addMember(l, name8, Lua_UnityEngine_EventSystems_EventSystem.<>f__mg$cacheF, null, true);
		LuaObject.createTypeMetatable(l, null, typeof(EventSystem), typeof(UIBehaviour));
	}

	// Token: 0x0401903F RID: 102463
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019040 RID: 102464
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019041 RID: 102465
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019042 RID: 102466
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019043 RID: 102467
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04019044 RID: 102468
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04019045 RID: 102469
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04019046 RID: 102470
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04019047 RID: 102471
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04019048 RID: 102472
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04019049 RID: 102473
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0401904A RID: 102474
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0401904B RID: 102475
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0401904C RID: 102476
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0401904D RID: 102477
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0401904E RID: 102478
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;
}
