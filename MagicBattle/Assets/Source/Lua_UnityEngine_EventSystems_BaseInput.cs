using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Scripting;

// Token: 0x0200169E RID: 5790
[Preserve]
public class Lua_UnityEngine_EventSystems_BaseInput : LuaObject
{
	// Token: 0x06023101 RID: 143617 RVA: 0x00C24F68 File Offset: 0x00C23168
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetMouseButtonDown(IntPtr l)
	{
		int result;
		try
		{
			BaseInput baseInput = (BaseInput)LuaObject.checkSelf(l);
			int button;
			LuaObject.checkType(l, 2, out button);
			bool mouseButtonDown = baseInput.GetMouseButtonDown(button);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mouseButtonDown);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023102 RID: 143618 RVA: 0x00C24FCC File Offset: 0x00C231CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetMouseButtonUp(IntPtr l)
	{
		int result;
		try
		{
			BaseInput baseInput = (BaseInput)LuaObject.checkSelf(l);
			int button;
			LuaObject.checkType(l, 2, out button);
			bool mouseButtonUp = baseInput.GetMouseButtonUp(button);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mouseButtonUp);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023103 RID: 143619 RVA: 0x00C25030 File Offset: 0x00C23230
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetMouseButton(IntPtr l)
	{
		int result;
		try
		{
			BaseInput baseInput = (BaseInput)LuaObject.checkSelf(l);
			int button;
			LuaObject.checkType(l, 2, out button);
			bool mouseButton = baseInput.GetMouseButton(button);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mouseButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023104 RID: 143620 RVA: 0x00C25094 File Offset: 0x00C23294
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetTouch(IntPtr l)
	{
		int result;
		try
		{
			BaseInput baseInput = (BaseInput)LuaObject.checkSelf(l);
			int index;
			LuaObject.checkType(l, 2, out index);
			Touch touch = baseInput.GetTouch(index);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, touch);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023105 RID: 143621 RVA: 0x00C250FC File Offset: 0x00C232FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetAxisRaw(IntPtr l)
	{
		int result;
		try
		{
			BaseInput baseInput = (BaseInput)LuaObject.checkSelf(l);
			string axisName;
			LuaObject.checkType(l, 2, out axisName);
			float axisRaw = baseInput.GetAxisRaw(axisName);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, axisRaw);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023106 RID: 143622 RVA: 0x00C25160 File Offset: 0x00C23360
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetButtonDown(IntPtr l)
	{
		int result;
		try
		{
			BaseInput baseInput = (BaseInput)LuaObject.checkSelf(l);
			string buttonName;
			LuaObject.checkType(l, 2, out buttonName);
			bool buttonDown = baseInput.GetButtonDown(buttonName);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, buttonDown);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023107 RID: 143623 RVA: 0x00C251C4 File Offset: 0x00C233C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_compositionString(IntPtr l)
	{
		int result;
		try
		{
			BaseInput baseInput = (BaseInput)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, baseInput.compositionString);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023108 RID: 143624 RVA: 0x00C25218 File Offset: 0x00C23418
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_imeCompositionMode(IntPtr l)
	{
		int result;
		try
		{
			BaseInput baseInput = (BaseInput)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)baseInput.imeCompositionMode);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023109 RID: 143625 RVA: 0x00C2526C File Offset: 0x00C2346C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_imeCompositionMode(IntPtr l)
	{
		int result;
		try
		{
			BaseInput baseInput = (BaseInput)LuaObject.checkSelf(l);
			IMECompositionMode imeCompositionMode;
			LuaObject.checkEnum<IMECompositionMode>(l, 2, out imeCompositionMode);
			baseInput.imeCompositionMode = imeCompositionMode;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602310A RID: 143626 RVA: 0x00C252C4 File Offset: 0x00C234C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_compositionCursorPos(IntPtr l)
	{
		int result;
		try
		{
			BaseInput baseInput = (BaseInput)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, baseInput.compositionCursorPos);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602310B RID: 143627 RVA: 0x00C25318 File Offset: 0x00C23518
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_compositionCursorPos(IntPtr l)
	{
		int result;
		try
		{
			BaseInput baseInput = (BaseInput)LuaObject.checkSelf(l);
			Vector2 compositionCursorPos;
			LuaObject.checkType(l, 2, out compositionCursorPos);
			baseInput.compositionCursorPos = compositionCursorPos;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602310C RID: 143628 RVA: 0x00C25370 File Offset: 0x00C23570
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_mousePresent(IntPtr l)
	{
		int result;
		try
		{
			BaseInput baseInput = (BaseInput)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, baseInput.mousePresent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602310D RID: 143629 RVA: 0x00C253C4 File Offset: 0x00C235C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_mousePosition(IntPtr l)
	{
		int result;
		try
		{
			BaseInput baseInput = (BaseInput)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, baseInput.mousePosition);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602310E RID: 143630 RVA: 0x00C25418 File Offset: 0x00C23618
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_mouseScrollDelta(IntPtr l)
	{
		int result;
		try
		{
			BaseInput baseInput = (BaseInput)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, baseInput.mouseScrollDelta);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602310F RID: 143631 RVA: 0x00C2546C File Offset: 0x00C2366C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_touchSupported(IntPtr l)
	{
		int result;
		try
		{
			BaseInput baseInput = (BaseInput)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, baseInput.touchSupported);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023110 RID: 143632 RVA: 0x00C254C0 File Offset: 0x00C236C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_touchCount(IntPtr l)
	{
		int result;
		try
		{
			BaseInput baseInput = (BaseInput)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, baseInput.touchCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023111 RID: 143633 RVA: 0x00C25514 File Offset: 0x00C23714
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.EventSystems.BaseInput");
		if (Lua_UnityEngine_EventSystems_BaseInput.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_EventSystems_BaseInput.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_EventSystems_BaseInput.GetMouseButtonDown);
		}
		LuaObject.addMember(l, Lua_UnityEngine_EventSystems_BaseInput.<>f__mg$cache0);
		if (Lua_UnityEngine_EventSystems_BaseInput.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_EventSystems_BaseInput.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_EventSystems_BaseInput.GetMouseButtonUp);
		}
		LuaObject.addMember(l, Lua_UnityEngine_EventSystems_BaseInput.<>f__mg$cache1);
		if (Lua_UnityEngine_EventSystems_BaseInput.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_EventSystems_BaseInput.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_EventSystems_BaseInput.GetMouseButton);
		}
		LuaObject.addMember(l, Lua_UnityEngine_EventSystems_BaseInput.<>f__mg$cache2);
		if (Lua_UnityEngine_EventSystems_BaseInput.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_EventSystems_BaseInput.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_EventSystems_BaseInput.GetTouch);
		}
		LuaObject.addMember(l, Lua_UnityEngine_EventSystems_BaseInput.<>f__mg$cache3);
		if (Lua_UnityEngine_EventSystems_BaseInput.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_EventSystems_BaseInput.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_EventSystems_BaseInput.GetAxisRaw);
		}
		LuaObject.addMember(l, Lua_UnityEngine_EventSystems_BaseInput.<>f__mg$cache4);
		if (Lua_UnityEngine_EventSystems_BaseInput.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_EventSystems_BaseInput.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_EventSystems_BaseInput.GetButtonDown);
		}
		LuaObject.addMember(l, Lua_UnityEngine_EventSystems_BaseInput.<>f__mg$cache5);
		string name = "compositionString";
		if (Lua_UnityEngine_EventSystems_BaseInput.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_EventSystems_BaseInput.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_EventSystems_BaseInput.get_compositionString);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_EventSystems_BaseInput.<>f__mg$cache6, null, true);
		string name2 = "imeCompositionMode";
		if (Lua_UnityEngine_EventSystems_BaseInput.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_EventSystems_BaseInput.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_EventSystems_BaseInput.get_imeCompositionMode);
		}
		LuaCSFunction get = Lua_UnityEngine_EventSystems_BaseInput.<>f__mg$cache7;
		if (Lua_UnityEngine_EventSystems_BaseInput.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_EventSystems_BaseInput.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_EventSystems_BaseInput.set_imeCompositionMode);
		}
		LuaObject.addMember(l, name2, get, Lua_UnityEngine_EventSystems_BaseInput.<>f__mg$cache8, true);
		string name3 = "compositionCursorPos";
		if (Lua_UnityEngine_EventSystems_BaseInput.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_EventSystems_BaseInput.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_EventSystems_BaseInput.get_compositionCursorPos);
		}
		LuaCSFunction get2 = Lua_UnityEngine_EventSystems_BaseInput.<>f__mg$cache9;
		if (Lua_UnityEngine_EventSystems_BaseInput.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_EventSystems_BaseInput.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_EventSystems_BaseInput.set_compositionCursorPos);
		}
		LuaObject.addMember(l, name3, get2, Lua_UnityEngine_EventSystems_BaseInput.<>f__mg$cacheA, true);
		string name4 = "mousePresent";
		if (Lua_UnityEngine_EventSystems_BaseInput.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_EventSystems_BaseInput.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_EventSystems_BaseInput.get_mousePresent);
		}
		LuaObject.addMember(l, name4, Lua_UnityEngine_EventSystems_BaseInput.<>f__mg$cacheB, null, true);
		string name5 = "mousePosition";
		if (Lua_UnityEngine_EventSystems_BaseInput.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_EventSystems_BaseInput.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_EventSystems_BaseInput.get_mousePosition);
		}
		LuaObject.addMember(l, name5, Lua_UnityEngine_EventSystems_BaseInput.<>f__mg$cacheC, null, true);
		string name6 = "mouseScrollDelta";
		if (Lua_UnityEngine_EventSystems_BaseInput.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_EventSystems_BaseInput.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_EventSystems_BaseInput.get_mouseScrollDelta);
		}
		LuaObject.addMember(l, name6, Lua_UnityEngine_EventSystems_BaseInput.<>f__mg$cacheD, null, true);
		string name7 = "touchSupported";
		if (Lua_UnityEngine_EventSystems_BaseInput.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_EventSystems_BaseInput.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_EventSystems_BaseInput.get_touchSupported);
		}
		LuaObject.addMember(l, name7, Lua_UnityEngine_EventSystems_BaseInput.<>f__mg$cacheE, null, true);
		string name8 = "touchCount";
		if (Lua_UnityEngine_EventSystems_BaseInput.<>f__mg$cacheF == null)
		{
			Lua_UnityEngine_EventSystems_BaseInput.<>f__mg$cacheF = new LuaCSFunction(Lua_UnityEngine_EventSystems_BaseInput.get_touchCount);
		}
		LuaObject.addMember(l, name8, Lua_UnityEngine_EventSystems_BaseInput.<>f__mg$cacheF, null, true);
		LuaObject.createTypeMetatable(l, null, typeof(BaseInput), typeof(UIBehaviour));
	}

	// Token: 0x04019023 RID: 102435
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019024 RID: 102436
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019025 RID: 102437
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019026 RID: 102438
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019027 RID: 102439
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04019028 RID: 102440
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04019029 RID: 102441
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0401902A RID: 102442
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0401902B RID: 102443
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0401902C RID: 102444
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0401902D RID: 102445
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0401902E RID: 102446
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0401902F RID: 102447
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04019030 RID: 102448
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04019031 RID: 102449
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04019032 RID: 102450
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;
}
