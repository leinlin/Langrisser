using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x0200172C RID: 5932
[Preserve]
public class Lua_UnityEngine_MeshRenderer : LuaObject
{
	// Token: 0x0602369B RID: 145051 RVA: 0x00C532C4 File Offset: 0x00C514C4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_additionalVertexStreams(IntPtr l)
	{
		int result;
		try
		{
			MeshRenderer meshRenderer = (MeshRenderer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, meshRenderer.additionalVertexStreams);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602369C RID: 145052 RVA: 0x00C53318 File Offset: 0x00C51518
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_additionalVertexStreams(IntPtr l)
	{
		int result;
		try
		{
			MeshRenderer meshRenderer = (MeshRenderer)LuaObject.checkSelf(l);
			Mesh additionalVertexStreams;
			LuaObject.checkType<Mesh>(l, 2, out additionalVertexStreams);
			meshRenderer.additionalVertexStreams = additionalVertexStreams;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602369D RID: 145053 RVA: 0x00C53370 File Offset: 0x00C51570
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.MeshRenderer");
		string name = "additionalVertexStreams";
		if (Lua_UnityEngine_MeshRenderer.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_MeshRenderer.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_MeshRenderer.get_additionalVertexStreams);
		}
		LuaCSFunction get = Lua_UnityEngine_MeshRenderer.<>f__mg$cache0;
		if (Lua_UnityEngine_MeshRenderer.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_MeshRenderer.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_MeshRenderer.set_additionalVertexStreams);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_MeshRenderer.<>f__mg$cache1, true);
		LuaObject.createTypeMetatable(l, null, typeof(MeshRenderer), typeof(Renderer));
	}

	// Token: 0x040194A1 RID: 103585
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040194A2 RID: 103586
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;
}
