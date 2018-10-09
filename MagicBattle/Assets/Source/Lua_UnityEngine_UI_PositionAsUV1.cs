using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001851 RID: 6225
[Preserve]
public class Lua_UnityEngine_UI_PositionAsUV1 : LuaObject
{
	// Token: 0x060241DF RID: 147935 RVA: 0x00CAEB08 File Offset: 0x00CACD08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ModifyMesh(IntPtr l)
	{
		int result;
		try
		{
			PositionAsUV1 positionAsUV = (PositionAsUV1)LuaObject.checkSelf(l);
			VertexHelper vh;
			LuaObject.checkType<VertexHelper>(l, 2, out vh);
			positionAsUV.ModifyMesh(vh);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060241E0 RID: 147936 RVA: 0x00CAEB60 File Offset: 0x00CACD60
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.UI.PositionAsUV1");
		if (Lua_UnityEngine_UI_PositionAsUV1.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_UI_PositionAsUV1.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_UI_PositionAsUV1.ModifyMesh);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_PositionAsUV1.<>f__mg$cache0);
		LuaObject.createTypeMetatable(l, null, typeof(PositionAsUV1), typeof(BaseMeshEffect));
	}

	// Token: 0x04019D9B RID: 105883
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
