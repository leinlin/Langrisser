using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001687 RID: 5767
[Preserve]
public class Lua_UnityEngine_DefaultExecutionOrder : LuaObject
{
	// Token: 0x0602305F RID: 143455 RVA: 0x00C210A4 File Offset: 0x00C1F2A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int order;
			LuaObject.checkType(l, 2, out order);
			DefaultExecutionOrder o = new DefaultExecutionOrder(order);
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

	// Token: 0x06023060 RID: 143456 RVA: 0x00C210F8 File Offset: 0x00C1F2F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_order(IntPtr l)
	{
		int result;
		try
		{
			DefaultExecutionOrder defaultExecutionOrder = (DefaultExecutionOrder)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, defaultExecutionOrder.order);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023061 RID: 143457 RVA: 0x00C2114C File Offset: 0x00C1F34C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.DefaultExecutionOrder");
		string name = "order";
		if (Lua_UnityEngine_DefaultExecutionOrder.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_DefaultExecutionOrder.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_DefaultExecutionOrder.get_order);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_DefaultExecutionOrder.<>f__mg$cache0, null, true);
		if (Lua_UnityEngine_DefaultExecutionOrder.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_DefaultExecutionOrder.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_DefaultExecutionOrder.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_DefaultExecutionOrder.<>f__mg$cache1, typeof(DefaultExecutionOrder), typeof(Attribute));
	}

	// Token: 0x04018FAF RID: 102319
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04018FB0 RID: 102320
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;
}
