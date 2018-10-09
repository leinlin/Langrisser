using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x020017C2 RID: 6082
[Preserve]
public class Lua_UnityEngine_ScalableBufferManager : LuaObject
{
	// Token: 0x06023C95 RID: 146581 RVA: 0x00C89444 File Offset: 0x00C87644
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ResizeBuffers_s(IntPtr l)
	{
		int result;
		try
		{
			float widthScale;
			LuaObject.checkType(l, 1, out widthScale);
			float heightScale;
			LuaObject.checkType(l, 2, out heightScale);
			ScalableBufferManager.ResizeBuffers(widthScale, heightScale);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C96 RID: 146582 RVA: 0x00C8949C File Offset: 0x00C8769C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_widthScaleFactor(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, ScalableBufferManager.widthScaleFactor);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C97 RID: 146583 RVA: 0x00C894E4 File Offset: 0x00C876E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_heightScaleFactor(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, ScalableBufferManager.heightScaleFactor);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023C98 RID: 146584 RVA: 0x00C8952C File Offset: 0x00C8772C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.ScalableBufferManager");
		if (Lua_UnityEngine_ScalableBufferManager.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_ScalableBufferManager.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_ScalableBufferManager.ResizeBuffers_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_ScalableBufferManager.<>f__mg$cache0);
		string name = "widthScaleFactor";
		if (Lua_UnityEngine_ScalableBufferManager.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_ScalableBufferManager.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_ScalableBufferManager.get_widthScaleFactor);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_ScalableBufferManager.<>f__mg$cache1, null, false);
		string name2 = "heightScaleFactor";
		if (Lua_UnityEngine_ScalableBufferManager.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_ScalableBufferManager.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_ScalableBufferManager.get_heightScaleFactor);
		}
		LuaObject.addMember(l, name2, Lua_UnityEngine_ScalableBufferManager.<>f__mg$cache2, null, false);
		LuaObject.createTypeMetatable(l, null, typeof(ScalableBufferManager));
	}

	// Token: 0x0401996F RID: 104815
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019970 RID: 104816
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019971 RID: 104817
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;
}
