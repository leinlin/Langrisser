using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001640 RID: 5696
[Preserve]
public class Lua_UnityEngine_BillboardRenderer : LuaObject
{
	// Token: 0x06022C54 RID: 142420 RVA: 0x00C0170C File Offset: 0x00BFF90C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_billboard(IntPtr l)
	{
		int result;
		try
		{
			BillboardRenderer billboardRenderer = (BillboardRenderer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, billboardRenderer.billboard);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022C55 RID: 142421 RVA: 0x00C01760 File Offset: 0x00BFF960
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_billboard(IntPtr l)
	{
		int result;
		try
		{
			BillboardRenderer billboardRenderer = (BillboardRenderer)LuaObject.checkSelf(l);
			BillboardAsset billboard;
			LuaObject.checkType<BillboardAsset>(l, 2, out billboard);
			billboardRenderer.billboard = billboard;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022C56 RID: 142422 RVA: 0x00C017B8 File Offset: 0x00BFF9B8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.BillboardRenderer");
		string name = "billboard";
		if (Lua_UnityEngine_BillboardRenderer.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_BillboardRenderer.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_BillboardRenderer.get_billboard);
		}
		LuaCSFunction get = Lua_UnityEngine_BillboardRenderer.<>f__mg$cache0;
		if (Lua_UnityEngine_BillboardRenderer.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_BillboardRenderer.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_BillboardRenderer.set_billboard);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_BillboardRenderer.<>f__mg$cache1, true);
		LuaObject.createTypeMetatable(l, null, typeof(BillboardRenderer), typeof(Renderer));
	}

	// Token: 0x04018C32 RID: 101426
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04018C33 RID: 101427
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;
}
