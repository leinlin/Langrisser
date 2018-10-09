using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x0200180C RID: 6156
[Preserve]
public class Lua_UnityEngine_UI_BaseMeshEffect : LuaObject
{
	// Token: 0x06023F8E RID: 147342 RVA: 0x00C9FF84 File Offset: 0x00C9E184
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ModifyMesh(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(Mesh)))
			{
				BaseMeshEffect baseMeshEffect = (BaseMeshEffect)LuaObject.checkSelf(l);
				Mesh mesh;
				LuaObject.checkType<Mesh>(l, 2, out mesh);
				baseMeshEffect.ModifyMesh(mesh);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(VertexHelper)))
			{
				BaseMeshEffect baseMeshEffect2 = (BaseMeshEffect)LuaObject.checkSelf(l);
				VertexHelper vh;
				LuaObject.checkType<VertexHelper>(l, 2, out vh);
				baseMeshEffect2.ModifyMesh(vh);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function ModifyMesh to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F8F RID: 147343 RVA: 0x00CA005C File Offset: 0x00C9E25C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.UI.BaseMeshEffect");
		if (Lua_UnityEngine_UI_BaseMeshEffect.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_UI_BaseMeshEffect.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_UI_BaseMeshEffect.ModifyMesh);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_BaseMeshEffect.<>f__mg$cache0);
		LuaObject.createTypeMetatable(l, null, typeof(BaseMeshEffect), typeof(UIBehaviour));
	}

	// Token: 0x04019BD4 RID: 105428
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
