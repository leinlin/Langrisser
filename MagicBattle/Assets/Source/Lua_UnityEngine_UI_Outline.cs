using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001850 RID: 6224
[Preserve]
public class Lua_UnityEngine_UI_Outline : LuaObject
{
	// Token: 0x060241DC RID: 147932 RVA: 0x00CAEA50 File Offset: 0x00CACC50
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ModifyMesh(IntPtr l)
	{
		int result;
		try
		{
			Outline outline = (Outline)LuaObject.checkSelf(l);
			VertexHelper vh;
			LuaObject.checkType<VertexHelper>(l, 2, out vh);
			outline.ModifyMesh(vh);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060241DD RID: 147933 RVA: 0x00CAEAA8 File Offset: 0x00CACCA8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.UI.Outline");
		if (Lua_UnityEngine_UI_Outline.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_UI_Outline.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_UI_Outline.ModifyMesh);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_Outline.<>f__mg$cache0);
		LuaObject.createTypeMetatable(l, null, typeof(Outline), typeof(Shadow));
	}

	// Token: 0x04019D9A RID: 105882
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
