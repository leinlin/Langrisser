using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001767 RID: 5991
[Preserve]
public class Lua_UnityEngine_Random_State : LuaObject
{
	// Token: 0x06023938 RID: 145720 RVA: 0x00C6D734 File Offset: 0x00C6B934
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			UnityEngine.Random.State state = default(UnityEngine.Random.State);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, state);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023939 RID: 145721 RVA: 0x00C6D784 File Offset: 0x00C6B984
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Random.State");
		if (Lua_UnityEngine_Random_State.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_Random_State.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_Random_State.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_Random_State.<>f__mg$cache0, typeof(UnityEngine.Random.State), typeof(ValueType));
	}

	// Token: 0x040196C8 RID: 104136
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
