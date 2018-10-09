using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x0200183E RID: 6206
[Preserve]
public class Lua_UnityEngine_UI_IMeshModifier : LuaObject
{
	// Token: 0x06024112 RID: 147730 RVA: 0x00CA960C File Offset: 0x00CA780C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ModifyMesh(IntPtr l)
	{
		int result;
		try
		{
			IMeshModifier meshModifier = (IMeshModifier)LuaObject.checkSelf(l);
			VertexHelper verts;
			LuaObject.checkType<VertexHelper>(l, 2, out verts);
			meshModifier.ModifyMesh(verts);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024113 RID: 147731 RVA: 0x00CA9664 File Offset: 0x00CA7864
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.UI.IMeshModifier");
		if (Lua_UnityEngine_UI_IMeshModifier.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_UI_IMeshModifier.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_UI_IMeshModifier.ModifyMesh);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_IMeshModifier.<>f__mg$cache0);
		LuaObject.createTypeMetatable(l, null, typeof(IMeshModifier));
	}

	// Token: 0x04019CF4 RID: 105716
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
