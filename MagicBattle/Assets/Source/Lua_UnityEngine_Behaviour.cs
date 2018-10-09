using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x0200163E RID: 5694
[Preserve]
public class Lua_UnityEngine_Behaviour : LuaObject
{
	// Token: 0x06022C3B RID: 142395 RVA: 0x00C00A08 File Offset: 0x00BFEC08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_enabled(IntPtr l)
	{
		int result;
		try
		{
			Behaviour behaviour = (Behaviour)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, behaviour.enabled);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022C3C RID: 142396 RVA: 0x00C00A5C File Offset: 0x00BFEC5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_enabled(IntPtr l)
	{
		int result;
		try
		{
			Behaviour behaviour = (Behaviour)LuaObject.checkSelf(l);
			bool enabled;
			LuaObject.checkType(l, 2, out enabled);
			behaviour.enabled = enabled;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022C3D RID: 142397 RVA: 0x00C00AB4 File Offset: 0x00BFECB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_isActiveAndEnabled(IntPtr l)
	{
		int result;
		try
		{
			Behaviour behaviour = (Behaviour)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, behaviour.isActiveAndEnabled);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022C3E RID: 142398 RVA: 0x00C00B08 File Offset: 0x00BFED08
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Behaviour");
		string name = "enabled";
		if (Lua_UnityEngine_Behaviour.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_Behaviour.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_Behaviour.get_enabled);
		}
		LuaCSFunction get = Lua_UnityEngine_Behaviour.<>f__mg$cache0;
		if (Lua_UnityEngine_Behaviour.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_Behaviour.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_Behaviour.set_enabled);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_Behaviour.<>f__mg$cache1, true);
		string name2 = "isActiveAndEnabled";
		if (Lua_UnityEngine_Behaviour.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_Behaviour.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_Behaviour.get_isActiveAndEnabled);
		}
		LuaObject.addMember(l, name2, Lua_UnityEngine_Behaviour.<>f__mg$cache2, null, true);
		LuaObject.createTypeMetatable(l, null, typeof(Behaviour), typeof(Component));
	}

	// Token: 0x04018C1D RID: 101405
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04018C1E RID: 101406
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04018C1F RID: 101407
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;
}
