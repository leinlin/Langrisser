using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine.EventSystems;
using UnityEngine.Scripting;

// Token: 0x020016C1 RID: 5825
[Preserve]
public class Lua_UnityEngine_EventSystems_PointerInputModule_MouseButtonEventData : LuaObject
{
	// Token: 0x060231D9 RID: 143833 RVA: 0x00C29E7C File Offset: 0x00C2807C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			PointerInputModule.MouseButtonEventData o = new PointerInputModule.MouseButtonEventData();
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

	// Token: 0x060231DA RID: 143834 RVA: 0x00C29EC4 File Offset: 0x00C280C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PressedThisFrame(IntPtr l)
	{
		int result;
		try
		{
			PointerInputModule.MouseButtonEventData mouseButtonEventData = (PointerInputModule.MouseButtonEventData)LuaObject.checkSelf(l);
			bool b = mouseButtonEventData.PressedThisFrame();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060231DB RID: 143835 RVA: 0x00C29F18 File Offset: 0x00C28118
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ReleasedThisFrame(IntPtr l)
	{
		int result;
		try
		{
			PointerInputModule.MouseButtonEventData mouseButtonEventData = (PointerInputModule.MouseButtonEventData)LuaObject.checkSelf(l);
			bool b = mouseButtonEventData.ReleasedThisFrame();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060231DC RID: 143836 RVA: 0x00C29F6C File Offset: 0x00C2816C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_buttonState(IntPtr l)
	{
		int result;
		try
		{
			PointerInputModule.MouseButtonEventData mouseButtonEventData = (PointerInputModule.MouseButtonEventData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)mouseButtonEventData.buttonState);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060231DD RID: 143837 RVA: 0x00C29FC0 File Offset: 0x00C281C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_buttonState(IntPtr l)
	{
		int result;
		try
		{
			PointerInputModule.MouseButtonEventData mouseButtonEventData = (PointerInputModule.MouseButtonEventData)LuaObject.checkSelf(l);
			PointerEventData.FramePressState buttonState;
			LuaObject.checkEnum<PointerEventData.FramePressState>(l, 2, out buttonState);
			mouseButtonEventData.buttonState = buttonState;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060231DE RID: 143838 RVA: 0x00C2A018 File Offset: 0x00C28218
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_buttonData(IntPtr l)
	{
		int result;
		try
		{
			PointerInputModule.MouseButtonEventData mouseButtonEventData = (PointerInputModule.MouseButtonEventData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mouseButtonEventData.buttonData);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060231DF RID: 143839 RVA: 0x00C2A06C File Offset: 0x00C2826C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_buttonData(IntPtr l)
	{
		int result;
		try
		{
			PointerInputModule.MouseButtonEventData mouseButtonEventData = (PointerInputModule.MouseButtonEventData)LuaObject.checkSelf(l);
			PointerEventData buttonData;
			LuaObject.checkType<PointerEventData>(l, 2, out buttonData);
			mouseButtonEventData.buttonData = buttonData;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060231E0 RID: 143840 RVA: 0x00C2A0C4 File Offset: 0x00C282C4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData");
		if (Lua_UnityEngine_EventSystems_PointerInputModule_MouseButtonEventData.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_EventSystems_PointerInputModule_MouseButtonEventData.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_EventSystems_PointerInputModule_MouseButtonEventData.PressedThisFrame);
		}
		LuaObject.addMember(l, Lua_UnityEngine_EventSystems_PointerInputModule_MouseButtonEventData.<>f__mg$cache0);
		if (Lua_UnityEngine_EventSystems_PointerInputModule_MouseButtonEventData.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_EventSystems_PointerInputModule_MouseButtonEventData.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_EventSystems_PointerInputModule_MouseButtonEventData.ReleasedThisFrame);
		}
		LuaObject.addMember(l, Lua_UnityEngine_EventSystems_PointerInputModule_MouseButtonEventData.<>f__mg$cache1);
		string name = "buttonState";
		if (Lua_UnityEngine_EventSystems_PointerInputModule_MouseButtonEventData.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_EventSystems_PointerInputModule_MouseButtonEventData.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_EventSystems_PointerInputModule_MouseButtonEventData.get_buttonState);
		}
		LuaCSFunction get = Lua_UnityEngine_EventSystems_PointerInputModule_MouseButtonEventData.<>f__mg$cache2;
		if (Lua_UnityEngine_EventSystems_PointerInputModule_MouseButtonEventData.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_EventSystems_PointerInputModule_MouseButtonEventData.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_EventSystems_PointerInputModule_MouseButtonEventData.set_buttonState);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_EventSystems_PointerInputModule_MouseButtonEventData.<>f__mg$cache3, true);
		string name2 = "buttonData";
		if (Lua_UnityEngine_EventSystems_PointerInputModule_MouseButtonEventData.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_EventSystems_PointerInputModule_MouseButtonEventData.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_EventSystems_PointerInputModule_MouseButtonEventData.get_buttonData);
		}
		LuaCSFunction get2 = Lua_UnityEngine_EventSystems_PointerInputModule_MouseButtonEventData.<>f__mg$cache4;
		if (Lua_UnityEngine_EventSystems_PointerInputModule_MouseButtonEventData.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_EventSystems_PointerInputModule_MouseButtonEventData.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_EventSystems_PointerInputModule_MouseButtonEventData.set_buttonData);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_EventSystems_PointerInputModule_MouseButtonEventData.<>f__mg$cache5, true);
		if (Lua_UnityEngine_EventSystems_PointerInputModule_MouseButtonEventData.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_EventSystems_PointerInputModule_MouseButtonEventData.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_EventSystems_PointerInputModule_MouseButtonEventData.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_EventSystems_PointerInputModule_MouseButtonEventData.<>f__mg$cache6, typeof(PointerInputModule.MouseButtonEventData));
	}

	// Token: 0x040190B5 RID: 102581
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040190B6 RID: 102582
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040190B7 RID: 102583
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040190B8 RID: 102584
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040190B9 RID: 102585
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040190BA RID: 102586
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040190BB RID: 102587
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;
}
