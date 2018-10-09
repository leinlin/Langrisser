using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x020016E9 RID: 5865
[Preserve]
public class Lua_UnityEngine_ICanvasRaycastFilter : LuaObject
{
	// Token: 0x06023376 RID: 144246 RVA: 0x00C3862C File Offset: 0x00C3682C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsRaycastLocationValid(IntPtr l)
	{
		int result;
		try
		{
			ICanvasRaycastFilter canvasRaycastFilter = (ICanvasRaycastFilter)LuaObject.checkSelf(l);
			Vector2 sp;
			LuaObject.checkType(l, 2, out sp);
			Camera eventCamera;
			LuaObject.checkType<Camera>(l, 3, out eventCamera);
			bool b = canvasRaycastFilter.IsRaycastLocationValid(sp, eventCamera);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023377 RID: 144247 RVA: 0x00C3869C File Offset: 0x00C3689C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.ICanvasRaycastFilter");
		if (Lua_UnityEngine_ICanvasRaycastFilter.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_ICanvasRaycastFilter.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_ICanvasRaycastFilter.IsRaycastLocationValid);
		}
		LuaObject.addMember(l, Lua_UnityEngine_ICanvasRaycastFilter.<>f__mg$cache0);
		LuaObject.createTypeMetatable(l, null, typeof(ICanvasRaycastFilter));
	}

	// Token: 0x04019202 RID: 102914
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
