using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001870 RID: 6256
[Preserve]
public class Lua_UnityEngine_UnityEventQueueSystem : LuaObject
{
	// Token: 0x0602434D RID: 148301 RVA: 0x00CB8510 File Offset: 0x00CB6710
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			UnityEventQueueSystem o = new UnityEventQueueSystem();
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

	// Token: 0x0602434E RID: 148302 RVA: 0x00CB8558 File Offset: 0x00CB6758
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GenerateEventIdForPayload_s(IntPtr l)
	{
		int result;
		try
		{
			string eventPayloadName;
			LuaObject.checkType(l, 1, out eventPayloadName);
			string s = UnityEventQueueSystem.GenerateEventIdForPayload(eventPayloadName);
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

	// Token: 0x0602434F RID: 148303 RVA: 0x00CB85AC File Offset: 0x00CB67AC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetGlobalEventQueue_s(IntPtr l)
	{
		int result;
		try
		{
			IntPtr globalEventQueue = UnityEventQueueSystem.GetGlobalEventQueue();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, globalEventQueue);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024350 RID: 148304 RVA: 0x00CB85F8 File Offset: 0x00CB67F8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.UnityEventQueueSystem");
		if (Lua_UnityEngine_UnityEventQueueSystem.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_UnityEventQueueSystem.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_UnityEventQueueSystem.GenerateEventIdForPayload_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UnityEventQueueSystem.<>f__mg$cache0);
		if (Lua_UnityEngine_UnityEventQueueSystem.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_UnityEventQueueSystem.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_UnityEventQueueSystem.GetGlobalEventQueue_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UnityEventQueueSystem.<>f__mg$cache1);
		if (Lua_UnityEngine_UnityEventQueueSystem.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_UnityEventQueueSystem.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_UnityEventQueueSystem.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_UnityEventQueueSystem.<>f__mg$cache2, typeof(UnityEventQueueSystem));
	}

	// Token: 0x04019ECB RID: 106187
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019ECC RID: 106188
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019ECD RID: 106189
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;
}
