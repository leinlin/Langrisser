using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Scripting;

// Token: 0x0200169C RID: 5788
[Preserve]
public class Lua_UnityEngine_EventSystems_AxisEventData : LuaObject
{
	// Token: 0x060230F4 RID: 143604 RVA: 0x00C24ABC File Offset: 0x00C22CBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			EventSystem eventSystem;
			LuaObject.checkType<EventSystem>(l, 2, out eventSystem);
			AxisEventData o = new AxisEventData(eventSystem);
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

	// Token: 0x060230F5 RID: 143605 RVA: 0x00C24B10 File Offset: 0x00C22D10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_moveVector(IntPtr l)
	{
		int result;
		try
		{
			AxisEventData axisEventData = (AxisEventData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, axisEventData.moveVector);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060230F6 RID: 143606 RVA: 0x00C24B64 File Offset: 0x00C22D64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_moveVector(IntPtr l)
	{
		int result;
		try
		{
			AxisEventData axisEventData = (AxisEventData)LuaObject.checkSelf(l);
			Vector2 moveVector;
			LuaObject.checkType(l, 2, out moveVector);
			axisEventData.moveVector = moveVector;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060230F7 RID: 143607 RVA: 0x00C24BBC File Offset: 0x00C22DBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_moveDir(IntPtr l)
	{
		int result;
		try
		{
			AxisEventData axisEventData = (AxisEventData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)axisEventData.moveDir);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060230F8 RID: 143608 RVA: 0x00C24C10 File Offset: 0x00C22E10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_moveDir(IntPtr l)
	{
		int result;
		try
		{
			AxisEventData axisEventData = (AxisEventData)LuaObject.checkSelf(l);
			MoveDirection moveDir;
			LuaObject.checkEnum<MoveDirection>(l, 2, out moveDir);
			axisEventData.moveDir = moveDir;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060230F9 RID: 143609 RVA: 0x00C24C68 File Offset: 0x00C22E68
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.EventSystems.AxisEventData");
		string name = "moveVector";
		if (Lua_UnityEngine_EventSystems_AxisEventData.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_EventSystems_AxisEventData.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_EventSystems_AxisEventData.get_moveVector);
		}
		LuaCSFunction get = Lua_UnityEngine_EventSystems_AxisEventData.<>f__mg$cache0;
		if (Lua_UnityEngine_EventSystems_AxisEventData.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_EventSystems_AxisEventData.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_EventSystems_AxisEventData.set_moveVector);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_EventSystems_AxisEventData.<>f__mg$cache1, true);
		string name2 = "moveDir";
		if (Lua_UnityEngine_EventSystems_AxisEventData.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_EventSystems_AxisEventData.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_EventSystems_AxisEventData.get_moveDir);
		}
		LuaCSFunction get2 = Lua_UnityEngine_EventSystems_AxisEventData.<>f__mg$cache2;
		if (Lua_UnityEngine_EventSystems_AxisEventData.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_EventSystems_AxisEventData.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_EventSystems_AxisEventData.set_moveDir);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_EventSystems_AxisEventData.<>f__mg$cache3, true);
		if (Lua_UnityEngine_EventSystems_AxisEventData.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_EventSystems_AxisEventData.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_EventSystems_AxisEventData.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_EventSystems_AxisEventData.<>f__mg$cache4, typeof(AxisEventData), typeof(BaseEventData));
	}

	// Token: 0x0401901A RID: 102426
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401901B RID: 102427
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401901C RID: 102428
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0401901D RID: 102429
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0401901E RID: 102430
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;
}
