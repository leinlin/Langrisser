using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x0200186C RID: 6252
[Preserve]
public class Lua_UnityEngine_UISystemProfilerApi : LuaObject
{
	// Token: 0x0602432D RID: 148269 RVA: 0x00CB784C File Offset: 0x00CB5A4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			UISystemProfilerApi o = new UISystemProfilerApi();
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

	// Token: 0x0602432E RID: 148270 RVA: 0x00CB7894 File Offset: 0x00CB5A94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BeginSample_s(IntPtr l)
	{
		int result;
		try
		{
			UISystemProfilerApi.SampleType type;
			LuaObject.checkEnum<UISystemProfilerApi.SampleType>(l, 1, out type);
			UISystemProfilerApi.BeginSample(type);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602432F RID: 148271 RVA: 0x00CB78E0 File Offset: 0x00CB5AE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int EndSample_s(IntPtr l)
	{
		int result;
		try
		{
			UISystemProfilerApi.SampleType type;
			LuaObject.checkEnum<UISystemProfilerApi.SampleType>(l, 1, out type);
			UISystemProfilerApi.EndSample(type);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024330 RID: 148272 RVA: 0x00CB792C File Offset: 0x00CB5B2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddMarker_s(IntPtr l)
	{
		int result;
		try
		{
			string name;
			LuaObject.checkType(l, 1, out name);
			UnityEngine.Object obj;
			LuaObject.checkType<UnityEngine.Object>(l, 2, out obj);
			UISystemProfilerApi.AddMarker(name, obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024331 RID: 148273 RVA: 0x00CB7984 File Offset: 0x00CB5B84
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.UISystemProfilerApi");
		if (Lua_UnityEngine_UISystemProfilerApi.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_UISystemProfilerApi.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_UISystemProfilerApi.BeginSample_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UISystemProfilerApi.<>f__mg$cache0);
		if (Lua_UnityEngine_UISystemProfilerApi.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_UISystemProfilerApi.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_UISystemProfilerApi.EndSample_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UISystemProfilerApi.<>f__mg$cache1);
		if (Lua_UnityEngine_UISystemProfilerApi.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_UISystemProfilerApi.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_UISystemProfilerApi.AddMarker_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UISystemProfilerApi.<>f__mg$cache2);
		if (Lua_UnityEngine_UISystemProfilerApi.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_UISystemProfilerApi.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_UISystemProfilerApi.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_UISystemProfilerApi.<>f__mg$cache3, typeof(UISystemProfilerApi));
	}

	// Token: 0x04019EB3 RID: 106163
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019EB4 RID: 106164
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019EB5 RID: 106165
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019EB6 RID: 106166
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;
}
