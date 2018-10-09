using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001868 RID: 6248
[Preserve]
public class Lua_UnityEngine_UI_VertexHelper : LuaObject
{
	// Token: 0x06024305 RID: 148229 RVA: 0x00CB66B8 File Offset: 0x00CB48B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 1)
			{
				VertexHelper o = new VertexHelper();
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (num == 2)
			{
				Mesh m;
				LuaObject.checkType<Mesh>(l, 2, out m);
				VertexHelper o = new VertexHelper(m);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else
			{
				result = LuaObject.error(l, "New object failed.");
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024306 RID: 148230 RVA: 0x00CB6750 File Offset: 0x00CB4950
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Clear(IntPtr l)
	{
		int result;
		try
		{
			VertexHelper vertexHelper = (VertexHelper)LuaObject.checkSelf(l);
			vertexHelper.Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024307 RID: 148231 RVA: 0x00CB679C File Offset: 0x00CB499C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PopulateUIVertex(IntPtr l)
	{
		int result;
		try
		{
			VertexHelper vertexHelper = (VertexHelper)LuaObject.checkSelf(l);
			UIVertex uivertex;
			LuaObject.checkValueType<UIVertex>(l, 2, out uivertex);
			int i;
			LuaObject.checkType(l, 3, out i);
			vertexHelper.PopulateUIVertex(ref uivertex, i);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, uivertex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024308 RID: 148232 RVA: 0x00CB6810 File Offset: 0x00CB4A10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetUIVertex(IntPtr l)
	{
		int result;
		try
		{
			VertexHelper vertexHelper = (VertexHelper)LuaObject.checkSelf(l);
			UIVertex vertex;
			LuaObject.checkValueType<UIVertex>(l, 2, out vertex);
			int i;
			LuaObject.checkType(l, 3, out i);
			vertexHelper.SetUIVertex(vertex, i);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024309 RID: 148233 RVA: 0x00CB6874 File Offset: 0x00CB4A74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FillMesh(IntPtr l)
	{
		int result;
		try
		{
			VertexHelper vertexHelper = (VertexHelper)LuaObject.checkSelf(l);
			Mesh mesh;
			LuaObject.checkType<Mesh>(l, 2, out mesh);
			vertexHelper.FillMesh(mesh);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602430A RID: 148234 RVA: 0x00CB68CC File Offset: 0x00CB4ACC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Dispose(IntPtr l)
	{
		int result;
		try
		{
			VertexHelper vertexHelper = (VertexHelper)LuaObject.checkSelf(l);
			vertexHelper.Dispose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602430B RID: 148235 RVA: 0x00CB6918 File Offset: 0x00CB4B18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddVert(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				VertexHelper vertexHelper = (VertexHelper)LuaObject.checkSelf(l);
				UIVertex v;
				LuaObject.checkValueType<UIVertex>(l, 2, out v);
				vertexHelper.AddVert(v);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 4)
			{
				VertexHelper vertexHelper2 = (VertexHelper)LuaObject.checkSelf(l);
				Vector3 position;
				LuaObject.checkType(l, 2, out position);
				Color32 color;
				LuaObject.checkValueType<Color32>(l, 3, out color);
				Vector2 uv;
				LuaObject.checkType(l, 4, out uv);
				vertexHelper2.AddVert(position, color, uv);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 7)
			{
				VertexHelper vertexHelper3 = (VertexHelper)LuaObject.checkSelf(l);
				Vector3 position2;
				LuaObject.checkType(l, 2, out position2);
				Color32 color2;
				LuaObject.checkValueType<Color32>(l, 3, out color2);
				Vector2 uv2;
				LuaObject.checkType(l, 4, out uv2);
				Vector2 uv3;
				LuaObject.checkType(l, 5, out uv3);
				Vector3 normal;
				LuaObject.checkType(l, 6, out normal);
				Vector4 tangent;
				LuaObject.checkType(l, 7, out tangent);
				vertexHelper3.AddVert(position2, color2, uv2, uv3, normal, tangent);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function AddVert to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602430C RID: 148236 RVA: 0x00CB6A64 File Offset: 0x00CB4C64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddTriangle(IntPtr l)
	{
		int result;
		try
		{
			VertexHelper vertexHelper = (VertexHelper)LuaObject.checkSelf(l);
			int idx;
			LuaObject.checkType(l, 2, out idx);
			int idx2;
			LuaObject.checkType(l, 3, out idx2);
			int idx3;
			LuaObject.checkType(l, 4, out idx3);
			vertexHelper.AddTriangle(idx, idx2, idx3);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602430D RID: 148237 RVA: 0x00CB6AD8 File Offset: 0x00CB4CD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddUIVertexQuad(IntPtr l)
	{
		int result;
		try
		{
			VertexHelper vertexHelper = (VertexHelper)LuaObject.checkSelf(l);
			UIVertex[] verts;
			LuaObject.checkArray<UIVertex>(l, 2, out verts);
			vertexHelper.AddUIVertexQuad(verts);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602430E RID: 148238 RVA: 0x00CB6B30 File Offset: 0x00CB4D30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddUIVertexStream(IntPtr l)
	{
		int result;
		try
		{
			VertexHelper vertexHelper = (VertexHelper)LuaObject.checkSelf(l);
			List<UIVertex> verts;
			LuaObject.checkType<List<UIVertex>>(l, 2, out verts);
			List<int> indices;
			LuaObject.checkType<List<int>>(l, 3, out indices);
			vertexHelper.AddUIVertexStream(verts, indices);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602430F RID: 148239 RVA: 0x00CB6B94 File Offset: 0x00CB4D94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddUIVertexTriangleStream(IntPtr l)
	{
		int result;
		try
		{
			VertexHelper vertexHelper = (VertexHelper)LuaObject.checkSelf(l);
			List<UIVertex> verts;
			LuaObject.checkType<List<UIVertex>>(l, 2, out verts);
			vertexHelper.AddUIVertexTriangleStream(verts);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024310 RID: 148240 RVA: 0x00CB6BEC File Offset: 0x00CB4DEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetUIVertexStream(IntPtr l)
	{
		int result;
		try
		{
			VertexHelper vertexHelper = (VertexHelper)LuaObject.checkSelf(l);
			List<UIVertex> stream;
			LuaObject.checkType<List<UIVertex>>(l, 2, out stream);
			vertexHelper.GetUIVertexStream(stream);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024311 RID: 148241 RVA: 0x00CB6C44 File Offset: 0x00CB4E44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_currentVertCount(IntPtr l)
	{
		int result;
		try
		{
			VertexHelper vertexHelper = (VertexHelper)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, vertexHelper.currentVertCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024312 RID: 148242 RVA: 0x00CB6C98 File Offset: 0x00CB4E98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_currentIndexCount(IntPtr l)
	{
		int result;
		try
		{
			VertexHelper vertexHelper = (VertexHelper)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, vertexHelper.currentIndexCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024313 RID: 148243 RVA: 0x00CB6CEC File Offset: 0x00CB4EEC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.UI.VertexHelper");
		if (Lua_UnityEngine_UI_VertexHelper.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_UI_VertexHelper.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_UI_VertexHelper.Clear);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_VertexHelper.<>f__mg$cache0);
		if (Lua_UnityEngine_UI_VertexHelper.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_UI_VertexHelper.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_UI_VertexHelper.PopulateUIVertex);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_VertexHelper.<>f__mg$cache1);
		if (Lua_UnityEngine_UI_VertexHelper.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_UI_VertexHelper.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_UI_VertexHelper.SetUIVertex);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_VertexHelper.<>f__mg$cache2);
		if (Lua_UnityEngine_UI_VertexHelper.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_UI_VertexHelper.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_UI_VertexHelper.FillMesh);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_VertexHelper.<>f__mg$cache3);
		if (Lua_UnityEngine_UI_VertexHelper.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_UI_VertexHelper.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_UI_VertexHelper.Dispose);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_VertexHelper.<>f__mg$cache4);
		if (Lua_UnityEngine_UI_VertexHelper.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_UI_VertexHelper.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_UI_VertexHelper.AddVert);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_VertexHelper.<>f__mg$cache5);
		if (Lua_UnityEngine_UI_VertexHelper.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_UI_VertexHelper.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_UI_VertexHelper.AddTriangle);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_VertexHelper.<>f__mg$cache6);
		if (Lua_UnityEngine_UI_VertexHelper.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_UI_VertexHelper.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_UI_VertexHelper.AddUIVertexQuad);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_VertexHelper.<>f__mg$cache7);
		if (Lua_UnityEngine_UI_VertexHelper.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_UI_VertexHelper.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_UI_VertexHelper.AddUIVertexStream);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_VertexHelper.<>f__mg$cache8);
		if (Lua_UnityEngine_UI_VertexHelper.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_UI_VertexHelper.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_UI_VertexHelper.AddUIVertexTriangleStream);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_VertexHelper.<>f__mg$cache9);
		if (Lua_UnityEngine_UI_VertexHelper.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_UI_VertexHelper.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_UI_VertexHelper.GetUIVertexStream);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_VertexHelper.<>f__mg$cacheA);
		string name = "currentVertCount";
		if (Lua_UnityEngine_UI_VertexHelper.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_UI_VertexHelper.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_UI_VertexHelper.get_currentVertCount);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_UI_VertexHelper.<>f__mg$cacheB, null, true);
		string name2 = "currentIndexCount";
		if (Lua_UnityEngine_UI_VertexHelper.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_UI_VertexHelper.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_UI_VertexHelper.get_currentIndexCount);
		}
		LuaObject.addMember(l, name2, Lua_UnityEngine_UI_VertexHelper.<>f__mg$cacheC, null, true);
		if (Lua_UnityEngine_UI_VertexHelper.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_UI_VertexHelper.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_UI_VertexHelper.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_UI_VertexHelper.<>f__mg$cacheD, typeof(VertexHelper));
	}

	// Token: 0x04019E93 RID: 106131
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019E94 RID: 106132
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019E95 RID: 106133
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019E96 RID: 106134
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019E97 RID: 106135
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04019E98 RID: 106136
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04019E99 RID: 106137
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04019E9A RID: 106138
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04019E9B RID: 106139
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04019E9C RID: 106140
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04019E9D RID: 106141
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04019E9E RID: 106142
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04019E9F RID: 106143
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04019EA0 RID: 106144
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;
}
