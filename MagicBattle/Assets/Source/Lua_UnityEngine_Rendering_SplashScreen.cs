using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

// Token: 0x020017A5 RID: 6053
[Preserve]
public class Lua_UnityEngine_Rendering_SplashScreen : LuaObject
{
	// Token: 0x06023B2A RID: 146218 RVA: 0x00C7DE4C File Offset: 0x00C7C04C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			SplashScreen o = new SplashScreen();
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

	// Token: 0x06023B2B RID: 146219 RVA: 0x00C7DE94 File Offset: 0x00C7C094
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Begin_s(IntPtr l)
	{
		int result;
		try
		{
			SplashScreen.Begin();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023B2C RID: 146220 RVA: 0x00C7DED4 File Offset: 0x00C7C0D4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Draw_s(IntPtr l)
	{
		int result;
		try
		{
			SplashScreen.Draw();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023B2D RID: 146221 RVA: 0x00C7DF14 File Offset: 0x00C7C114
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_isFinished(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, SplashScreen.isFinished);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023B2E RID: 146222 RVA: 0x00C7DF5C File Offset: 0x00C7C15C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Rendering.SplashScreen");
		if (Lua_UnityEngine_Rendering_SplashScreen.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_Rendering_SplashScreen.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_Rendering_SplashScreen.Begin_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rendering_SplashScreen.<>f__mg$cache0);
		if (Lua_UnityEngine_Rendering_SplashScreen.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_Rendering_SplashScreen.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_Rendering_SplashScreen.Draw_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rendering_SplashScreen.<>f__mg$cache1);
		string name = "isFinished";
		if (Lua_UnityEngine_Rendering_SplashScreen.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_Rendering_SplashScreen.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_Rendering_SplashScreen.get_isFinished);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_Rendering_SplashScreen.<>f__mg$cache2, null, false);
		if (Lua_UnityEngine_Rendering_SplashScreen.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_Rendering_SplashScreen.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_Rendering_SplashScreen.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_Rendering_SplashScreen.<>f__mg$cache3, typeof(SplashScreen));
	}

	// Token: 0x0401983E RID: 104510
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401983F RID: 104511
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019840 RID: 104512
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019841 RID: 104513
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;
}
