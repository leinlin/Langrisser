using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x020017ED RID: 6125
[Preserve]
public class Lua_UnityEngine_StaticBatchingUtility : LuaObject
{
	// Token: 0x06023DDE RID: 146910 RVA: 0x00C92A84 File Offset: 0x00C90C84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			StaticBatchingUtility o = new StaticBatchingUtility();
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

	// Token: 0x06023DDF RID: 146911 RVA: 0x00C92ACC File Offset: 0x00C90CCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Combine_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 1)
			{
				GameObject staticBatchRoot;
				LuaObject.checkType<GameObject>(l, 1, out staticBatchRoot);
				StaticBatchingUtility.Combine(staticBatchRoot);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 2)
			{
				GameObject[] gos;
				LuaObject.checkArray<GameObject>(l, 1, out gos);
				GameObject staticBatchRoot2;
				LuaObject.checkType<GameObject>(l, 2, out staticBatchRoot2);
				StaticBatchingUtility.Combine(gos, staticBatchRoot2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function Combine to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023DE0 RID: 146912 RVA: 0x00C92B70 File Offset: 0x00C90D70
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.StaticBatchingUtility");
		if (Lua_UnityEngine_StaticBatchingUtility.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_StaticBatchingUtility.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_StaticBatchingUtility.Combine_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_StaticBatchingUtility.<>f__mg$cache0);
		if (Lua_UnityEngine_StaticBatchingUtility.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_StaticBatchingUtility.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_StaticBatchingUtility.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_StaticBatchingUtility.<>f__mg$cache1, typeof(StaticBatchingUtility));
	}

	// Token: 0x04019A62 RID: 105058
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019A63 RID: 105059
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;
}
