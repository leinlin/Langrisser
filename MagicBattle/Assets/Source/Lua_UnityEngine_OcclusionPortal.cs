using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001735 RID: 5941
[Preserve]
public class Lua_UnityEngine_OcclusionPortal : LuaObject
{
	// Token: 0x060236CC RID: 145100 RVA: 0x00C54CC0 File Offset: 0x00C52EC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_open(IntPtr l)
	{
		int result;
		try
		{
			OcclusionPortal occlusionPortal = (OcclusionPortal)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, occlusionPortal.open);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060236CD RID: 145101 RVA: 0x00C54D14 File Offset: 0x00C52F14
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_open(IntPtr l)
	{
		int result;
		try
		{
			OcclusionPortal occlusionPortal = (OcclusionPortal)LuaObject.checkSelf(l);
			bool open;
			LuaObject.checkType(l, 2, out open);
			occlusionPortal.open = open;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060236CE RID: 145102 RVA: 0x00C54D6C File Offset: 0x00C52F6C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.OcclusionPortal");
		string name = "open";
		if (Lua_UnityEngine_OcclusionPortal.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_OcclusionPortal.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_OcclusionPortal.get_open);
		}
		LuaCSFunction get = Lua_UnityEngine_OcclusionPortal.<>f__mg$cache0;
		if (Lua_UnityEngine_OcclusionPortal.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_OcclusionPortal.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_OcclusionPortal.set_open);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_OcclusionPortal.<>f__mg$cache1, true);
		LuaObject.createTypeMetatable(l, null, typeof(OcclusionPortal), typeof(Component));
	}

	// Token: 0x040194C0 RID: 103616
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040194C1 RID: 103617
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;
}
