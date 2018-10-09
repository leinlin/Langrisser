using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001815 RID: 6165
[Preserve]
public class Lua_UnityEngine_UI_ClipperRegistry : LuaObject
{
	// Token: 0x06023FC2 RID: 147394 RVA: 0x00CA1238 File Offset: 0x00C9F438
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Cull(IntPtr l)
	{
		int result;
		try
		{
			ClipperRegistry clipperRegistry = (ClipperRegistry)LuaObject.checkSelf(l);
			clipperRegistry.Cull();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023FC3 RID: 147395 RVA: 0x00CA1284 File Offset: 0x00C9F484
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Register_s(IntPtr l)
	{
		int result;
		try
		{
			IClipper c;
			LuaObject.checkType<IClipper>(l, 1, out c);
			ClipperRegistry.Register(c);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023FC4 RID: 147396 RVA: 0x00CA12D0 File Offset: 0x00C9F4D0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Unregister_s(IntPtr l)
	{
		int result;
		try
		{
			IClipper c;
			LuaObject.checkType<IClipper>(l, 1, out c);
			ClipperRegistry.Unregister(c);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023FC5 RID: 147397 RVA: 0x00CA131C File Offset: 0x00C9F51C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_instance(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, ClipperRegistry.instance);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023FC6 RID: 147398 RVA: 0x00CA1364 File Offset: 0x00C9F564
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.UI.ClipperRegistry");
		if (Lua_UnityEngine_UI_ClipperRegistry.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_UI_ClipperRegistry.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_UI_ClipperRegistry.Cull);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_ClipperRegistry.<>f__mg$cache0);
		if (Lua_UnityEngine_UI_ClipperRegistry.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_UI_ClipperRegistry.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_UI_ClipperRegistry.Register_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_ClipperRegistry.<>f__mg$cache1);
		if (Lua_UnityEngine_UI_ClipperRegistry.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_UI_ClipperRegistry.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_UI_ClipperRegistry.Unregister_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_ClipperRegistry.<>f__mg$cache2);
		string name = "instance";
		if (Lua_UnityEngine_UI_ClipperRegistry.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_UI_ClipperRegistry.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_UI_ClipperRegistry.get_instance);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_UI_ClipperRegistry.<>f__mg$cache3, null, false);
		LuaObject.createTypeMetatable(l, null, typeof(ClipperRegistry));
	}

	// Token: 0x04019BF6 RID: 105462
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019BF7 RID: 105463
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019BF8 RID: 105464
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019BF9 RID: 105465
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;
}
