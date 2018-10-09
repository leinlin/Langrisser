using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x0200187B RID: 6267
[Preserve]
public class Lua_UnityEngine_WaitForFixedUpdate : LuaObject
{
	// Token: 0x06024436 RID: 148534 RVA: 0x00CBF80C File Offset: 0x00CBDA0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			WaitForFixedUpdate o = new WaitForFixedUpdate();
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

	// Token: 0x06024437 RID: 148535 RVA: 0x00CBF854 File Offset: 0x00CBDA54
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.WaitForFixedUpdate");
		if (Lua_UnityEngine_WaitForFixedUpdate.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_WaitForFixedUpdate.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_WaitForFixedUpdate.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_WaitForFixedUpdate.<>f__mg$cache0, typeof(WaitForFixedUpdate), typeof(YieldInstruction));
	}

	// Token: 0x04019F9E RID: 106398
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
