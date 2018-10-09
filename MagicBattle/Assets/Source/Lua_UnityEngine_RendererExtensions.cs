using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001778 RID: 6008
[Preserve]
public class Lua_UnityEngine_RendererExtensions : LuaObject
{
	// Token: 0x06023A6A RID: 146026 RVA: 0x00C764D8 File Offset: 0x00C746D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateGIMaterials_s(IntPtr l)
	{
		int result;
		try
		{
			Renderer renderer;
			LuaObject.checkType<Renderer>(l, 1, out renderer);
			renderer.UpdateGIMaterials();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A6B RID: 146027 RVA: 0x00C76524 File Offset: 0x00C74724
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.RendererExtensions");
		if (Lua_UnityEngine_RendererExtensions.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_RendererExtensions.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_RendererExtensions.UpdateGIMaterials_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_RendererExtensions.<>f__mg$cache0);
		LuaObject.createTypeMetatable(l, null, typeof(RendererExtensions));
	}

	// Token: 0x040197D8 RID: 104408
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
