using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001653 RID: 5715
[Preserve]
public class Lua_UnityEngine_CanvasRenderer : LuaObject
{
	// Token: 0x06022DC0 RID: 142784 RVA: 0x00C0C0B0 File Offset: 0x00C0A2B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetColor(IntPtr l)
	{
		int result;
		try
		{
			CanvasRenderer canvasRenderer = (CanvasRenderer)LuaObject.checkSelf(l);
			Color color;
			LuaObject.checkType(l, 2, out color);
			canvasRenderer.SetColor(color);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022DC1 RID: 142785 RVA: 0x00C0C108 File Offset: 0x00C0A308
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetColor(IntPtr l)
	{
		int result;
		try
		{
			CanvasRenderer canvasRenderer = (CanvasRenderer)LuaObject.checkSelf(l);
			Color color = canvasRenderer.GetColor();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, color);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022DC2 RID: 142786 RVA: 0x00C0C15C File Offset: 0x00C0A35C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetAlpha(IntPtr l)
	{
		int result;
		try
		{
			CanvasRenderer canvasRenderer = (CanvasRenderer)LuaObject.checkSelf(l);
			float alpha = canvasRenderer.GetAlpha();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, alpha);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022DC3 RID: 142787 RVA: 0x00C0C1B0 File Offset: 0x00C0A3B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetAlpha(IntPtr l)
	{
		int result;
		try
		{
			CanvasRenderer canvasRenderer = (CanvasRenderer)LuaObject.checkSelf(l);
			float alpha;
			LuaObject.checkType(l, 2, out alpha);
			canvasRenderer.SetAlpha(alpha);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022DC4 RID: 142788 RVA: 0x00C0C208 File Offset: 0x00C0A408
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int EnableRectClipping(IntPtr l)
	{
		int result;
		try
		{
			CanvasRenderer canvasRenderer = (CanvasRenderer)LuaObject.checkSelf(l);
			Rect rect;
			LuaObject.checkValueType<Rect>(l, 2, out rect);
			canvasRenderer.EnableRectClipping(rect);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022DC5 RID: 142789 RVA: 0x00C0C260 File Offset: 0x00C0A460
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DisableRectClipping(IntPtr l)
	{
		int result;
		try
		{
			CanvasRenderer canvasRenderer = (CanvasRenderer)LuaObject.checkSelf(l);
			canvasRenderer.DisableRectClipping();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022DC6 RID: 142790 RVA: 0x00C0C2AC File Offset: 0x00C0A4AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetMaterial(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(Material), typeof(Texture)))
			{
				CanvasRenderer canvasRenderer = (CanvasRenderer)LuaObject.checkSelf(l);
				Material material;
				LuaObject.checkType<Material>(l, 2, out material);
				Texture texture;
				LuaObject.checkType<Texture>(l, 3, out texture);
				canvasRenderer.SetMaterial(material, texture);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(Material), typeof(int)))
			{
				CanvasRenderer canvasRenderer2 = (CanvasRenderer)LuaObject.checkSelf(l);
				Material material2;
				LuaObject.checkType<Material>(l, 2, out material2);
				int index;
				LuaObject.checkType(l, 3, out index);
				canvasRenderer2.SetMaterial(material2, index);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function SetMaterial to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022DC7 RID: 142791 RVA: 0x00C0C3B4 File Offset: 0x00C0A5B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetMaterial(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 1)
			{
				CanvasRenderer canvasRenderer = (CanvasRenderer)LuaObject.checkSelf(l);
				Material material = canvasRenderer.GetMaterial();
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, material);
				result = 2;
			}
			else if (num == 2)
			{
				CanvasRenderer canvasRenderer2 = (CanvasRenderer)LuaObject.checkSelf(l);
				int index;
				LuaObject.checkType(l, 2, out index);
				Material material2 = canvasRenderer2.GetMaterial(index);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, material2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function GetMaterial to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022DC8 RID: 142792 RVA: 0x00C0C470 File Offset: 0x00C0A670
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetPopMaterial(IntPtr l)
	{
		int result;
		try
		{
			CanvasRenderer canvasRenderer = (CanvasRenderer)LuaObject.checkSelf(l);
			Material material;
			LuaObject.checkType<Material>(l, 2, out material);
			int index;
			LuaObject.checkType(l, 3, out index);
			canvasRenderer.SetPopMaterial(material, index);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022DC9 RID: 142793 RVA: 0x00C0C4D4 File Offset: 0x00C0A6D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetPopMaterial(IntPtr l)
	{
		int result;
		try
		{
			CanvasRenderer canvasRenderer = (CanvasRenderer)LuaObject.checkSelf(l);
			int index;
			LuaObject.checkType(l, 2, out index);
			Material popMaterial = canvasRenderer.GetPopMaterial(index);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, popMaterial);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022DCA RID: 142794 RVA: 0x00C0C538 File Offset: 0x00C0A738
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetTexture(IntPtr l)
	{
		int result;
		try
		{
			CanvasRenderer canvasRenderer = (CanvasRenderer)LuaObject.checkSelf(l);
			Texture texture;
			LuaObject.checkType<Texture>(l, 2, out texture);
			canvasRenderer.SetTexture(texture);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022DCB RID: 142795 RVA: 0x00C0C590 File Offset: 0x00C0A790
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetAlphaTexture(IntPtr l)
	{
		int result;
		try
		{
			CanvasRenderer canvasRenderer = (CanvasRenderer)LuaObject.checkSelf(l);
			Texture alphaTexture;
			LuaObject.checkType<Texture>(l, 2, out alphaTexture);
			canvasRenderer.SetAlphaTexture(alphaTexture);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022DCC RID: 142796 RVA: 0x00C0C5E8 File Offset: 0x00C0A7E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetMesh(IntPtr l)
	{
		int result;
		try
		{
			CanvasRenderer canvasRenderer = (CanvasRenderer)LuaObject.checkSelf(l);
			Mesh mesh;
			LuaObject.checkType<Mesh>(l, 2, out mesh);
			canvasRenderer.SetMesh(mesh);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022DCD RID: 142797 RVA: 0x00C0C640 File Offset: 0x00C0A840
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Clear(IntPtr l)
	{
		int result;
		try
		{
			CanvasRenderer canvasRenderer = (CanvasRenderer)LuaObject.checkSelf(l);
			canvasRenderer.Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022DCE RID: 142798 RVA: 0x00C0C68C File Offset: 0x00C0A88C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SplitUIVertexStreams_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 8)
			{
				List<UIVertex> verts;
				LuaObject.checkType<List<UIVertex>>(l, 1, out verts);
				List<Vector3> positions;
				LuaObject.checkType<List<Vector3>>(l, 2, out positions);
				List<Color32> colors;
				LuaObject.checkType<List<Color32>>(l, 3, out colors);
				List<Vector2> uv0S;
				LuaObject.checkType<List<Vector2>>(l, 4, out uv0S);
				List<Vector2> uv1S;
				LuaObject.checkType<List<Vector2>>(l, 5, out uv1S);
				List<Vector3> normals;
				LuaObject.checkType<List<Vector3>>(l, 6, out normals);
				List<Vector4> tangents;
				LuaObject.checkType<List<Vector4>>(l, 7, out tangents);
				List<int> indices;
				LuaObject.checkType<List<int>>(l, 8, out indices);
				CanvasRenderer.SplitUIVertexStreams(verts, positions, colors, uv0S, uv1S, normals, tangents, indices);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 10)
			{
				List<UIVertex> verts2;
				LuaObject.checkType<List<UIVertex>>(l, 1, out verts2);
				List<Vector3> positions2;
				LuaObject.checkType<List<Vector3>>(l, 2, out positions2);
				List<Color32> colors2;
				LuaObject.checkType<List<Color32>>(l, 3, out colors2);
				List<Vector2> uv0S2;
				LuaObject.checkType<List<Vector2>>(l, 4, out uv0S2);
				List<Vector2> uv1S2;
				LuaObject.checkType<List<Vector2>>(l, 5, out uv1S2);
				List<Vector2> uv2S;
				LuaObject.checkType<List<Vector2>>(l, 6, out uv2S);
				List<Vector2> uv3S;
				LuaObject.checkType<List<Vector2>>(l, 7, out uv3S);
				List<Vector3> normals2;
				LuaObject.checkType<List<Vector3>>(l, 8, out normals2);
				List<Vector4> tangents2;
				LuaObject.checkType<List<Vector4>>(l, 9, out tangents2);
				List<int> indices2;
				LuaObject.checkType<List<int>>(l, 10, out indices2);
				CanvasRenderer.SplitUIVertexStreams(verts2, positions2, colors2, uv0S2, uv1S2, uv2S, uv3S, normals2, tangents2, indices2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function SplitUIVertexStreams to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022DCF RID: 142799 RVA: 0x00C0C7F8 File Offset: 0x00C0A9F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateUIVertexStream_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 8)
			{
				List<UIVertex> verts;
				LuaObject.checkType<List<UIVertex>>(l, 1, out verts);
				List<Vector3> positions;
				LuaObject.checkType<List<Vector3>>(l, 2, out positions);
				List<Color32> colors;
				LuaObject.checkType<List<Color32>>(l, 3, out colors);
				List<Vector2> uv0S;
				LuaObject.checkType<List<Vector2>>(l, 4, out uv0S);
				List<Vector2> uv1S;
				LuaObject.checkType<List<Vector2>>(l, 5, out uv1S);
				List<Vector3> normals;
				LuaObject.checkType<List<Vector3>>(l, 6, out normals);
				List<Vector4> tangents;
				LuaObject.checkType<List<Vector4>>(l, 7, out tangents);
				List<int> indices;
				LuaObject.checkType<List<int>>(l, 8, out indices);
				CanvasRenderer.CreateUIVertexStream(verts, positions, colors, uv0S, uv1S, normals, tangents, indices);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 10)
			{
				List<UIVertex> verts2;
				LuaObject.checkType<List<UIVertex>>(l, 1, out verts2);
				List<Vector3> positions2;
				LuaObject.checkType<List<Vector3>>(l, 2, out positions2);
				List<Color32> colors2;
				LuaObject.checkType<List<Color32>>(l, 3, out colors2);
				List<Vector2> uv0S2;
				LuaObject.checkType<List<Vector2>>(l, 4, out uv0S2);
				List<Vector2> uv1S2;
				LuaObject.checkType<List<Vector2>>(l, 5, out uv1S2);
				List<Vector2> uv2S;
				LuaObject.checkType<List<Vector2>>(l, 6, out uv2S);
				List<Vector2> uv3S;
				LuaObject.checkType<List<Vector2>>(l, 7, out uv3S);
				List<Vector3> normals2;
				LuaObject.checkType<List<Vector3>>(l, 8, out normals2);
				List<Vector4> tangents2;
				LuaObject.checkType<List<Vector4>>(l, 9, out tangents2);
				List<int> indices2;
				LuaObject.checkType<List<int>>(l, 10, out indices2);
				CanvasRenderer.CreateUIVertexStream(verts2, positions2, colors2, uv0S2, uv1S2, uv2S, uv3S, normals2, tangents2, indices2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function CreateUIVertexStream to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022DD0 RID: 142800 RVA: 0x00C0C964 File Offset: 0x00C0AB64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddUIVertexStream_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 7)
			{
				List<UIVertex> verts;
				LuaObject.checkType<List<UIVertex>>(l, 1, out verts);
				List<Vector3> positions;
				LuaObject.checkType<List<Vector3>>(l, 2, out positions);
				List<Color32> colors;
				LuaObject.checkType<List<Color32>>(l, 3, out colors);
				List<Vector2> uv0S;
				LuaObject.checkType<List<Vector2>>(l, 4, out uv0S);
				List<Vector2> uv1S;
				LuaObject.checkType<List<Vector2>>(l, 5, out uv1S);
				List<Vector3> normals;
				LuaObject.checkType<List<Vector3>>(l, 6, out normals);
				List<Vector4> tangents;
				LuaObject.checkType<List<Vector4>>(l, 7, out tangents);
				CanvasRenderer.AddUIVertexStream(verts, positions, colors, uv0S, uv1S, normals, tangents);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 9)
			{
				List<UIVertex> verts2;
				LuaObject.checkType<List<UIVertex>>(l, 1, out verts2);
				List<Vector3> positions2;
				LuaObject.checkType<List<Vector3>>(l, 2, out positions2);
				List<Color32> colors2;
				LuaObject.checkType<List<Color32>>(l, 3, out colors2);
				List<Vector2> uv0S2;
				LuaObject.checkType<List<Vector2>>(l, 4, out uv0S2);
				List<Vector2> uv1S2;
				LuaObject.checkType<List<Vector2>>(l, 5, out uv1S2);
				List<Vector2> uv2S;
				LuaObject.checkType<List<Vector2>>(l, 6, out uv2S);
				List<Vector2> uv3S;
				LuaObject.checkType<List<Vector2>>(l, 7, out uv3S);
				List<Vector3> normals2;
				LuaObject.checkType<List<Vector3>>(l, 8, out normals2);
				List<Vector4> tangents2;
				LuaObject.checkType<List<Vector4>>(l, 9, out tangents2);
				CanvasRenderer.AddUIVertexStream(verts2, positions2, colors2, uv0S2, uv1S2, uv2S, uv3S, normals2, tangents2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function AddUIVertexStream to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022DD1 RID: 142801 RVA: 0x00C0CAB8 File Offset: 0x00C0ACB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_hasRectClipping(IntPtr l)
	{
		int result;
		try
		{
			CanvasRenderer canvasRenderer = (CanvasRenderer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, canvasRenderer.hasRectClipping);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022DD2 RID: 142802 RVA: 0x00C0CB0C File Offset: 0x00C0AD0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_hasPopInstruction(IntPtr l)
	{
		int result;
		try
		{
			CanvasRenderer canvasRenderer = (CanvasRenderer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, canvasRenderer.hasPopInstruction);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022DD3 RID: 142803 RVA: 0x00C0CB60 File Offset: 0x00C0AD60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_hasPopInstruction(IntPtr l)
	{
		int result;
		try
		{
			CanvasRenderer canvasRenderer = (CanvasRenderer)LuaObject.checkSelf(l);
			bool hasPopInstruction;
			LuaObject.checkType(l, 2, out hasPopInstruction);
			canvasRenderer.hasPopInstruction = hasPopInstruction;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022DD4 RID: 142804 RVA: 0x00C0CBB8 File Offset: 0x00C0ADB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_materialCount(IntPtr l)
	{
		int result;
		try
		{
			CanvasRenderer canvasRenderer = (CanvasRenderer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, canvasRenderer.materialCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022DD5 RID: 142805 RVA: 0x00C0CC0C File Offset: 0x00C0AE0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_materialCount(IntPtr l)
	{
		int result;
		try
		{
			CanvasRenderer canvasRenderer = (CanvasRenderer)LuaObject.checkSelf(l);
			int materialCount;
			LuaObject.checkType(l, 2, out materialCount);
			canvasRenderer.materialCount = materialCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022DD6 RID: 142806 RVA: 0x00C0CC64 File Offset: 0x00C0AE64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_popMaterialCount(IntPtr l)
	{
		int result;
		try
		{
			CanvasRenderer canvasRenderer = (CanvasRenderer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, canvasRenderer.popMaterialCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022DD7 RID: 142807 RVA: 0x00C0CCB8 File Offset: 0x00C0AEB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_popMaterialCount(IntPtr l)
	{
		int result;
		try
		{
			CanvasRenderer canvasRenderer = (CanvasRenderer)LuaObject.checkSelf(l);
			int popMaterialCount;
			LuaObject.checkType(l, 2, out popMaterialCount);
			canvasRenderer.popMaterialCount = popMaterialCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022DD8 RID: 142808 RVA: 0x00C0CD10 File Offset: 0x00C0AF10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_relativeDepth(IntPtr l)
	{
		int result;
		try
		{
			CanvasRenderer canvasRenderer = (CanvasRenderer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, canvasRenderer.relativeDepth);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022DD9 RID: 142809 RVA: 0x00C0CD64 File Offset: 0x00C0AF64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_cull(IntPtr l)
	{
		int result;
		try
		{
			CanvasRenderer canvasRenderer = (CanvasRenderer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, canvasRenderer.cull);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022DDA RID: 142810 RVA: 0x00C0CDB8 File Offset: 0x00C0AFB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_cull(IntPtr l)
	{
		int result;
		try
		{
			CanvasRenderer canvasRenderer = (CanvasRenderer)LuaObject.checkSelf(l);
			bool cull;
			LuaObject.checkType(l, 2, out cull);
			canvasRenderer.cull = cull;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022DDB RID: 142811 RVA: 0x00C0CE10 File Offset: 0x00C0B010
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_absoluteDepth(IntPtr l)
	{
		int result;
		try
		{
			CanvasRenderer canvasRenderer = (CanvasRenderer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, canvasRenderer.absoluteDepth);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022DDC RID: 142812 RVA: 0x00C0CE64 File Offset: 0x00C0B064
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_hasMoved(IntPtr l)
	{
		int result;
		try
		{
			CanvasRenderer canvasRenderer = (CanvasRenderer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, canvasRenderer.hasMoved);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022DDD RID: 142813 RVA: 0x00C0CEB8 File Offset: 0x00C0B0B8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.CanvasRenderer");
		if (Lua_UnityEngine_CanvasRenderer.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_CanvasRenderer.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_CanvasRenderer.SetColor);
		}
		LuaObject.addMember(l, Lua_UnityEngine_CanvasRenderer.<>f__mg$cache0);
		if (Lua_UnityEngine_CanvasRenderer.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_CanvasRenderer.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_CanvasRenderer.GetColor);
		}
		LuaObject.addMember(l, Lua_UnityEngine_CanvasRenderer.<>f__mg$cache1);
		if (Lua_UnityEngine_CanvasRenderer.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_CanvasRenderer.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_CanvasRenderer.GetAlpha);
		}
		LuaObject.addMember(l, Lua_UnityEngine_CanvasRenderer.<>f__mg$cache2);
		if (Lua_UnityEngine_CanvasRenderer.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_CanvasRenderer.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_CanvasRenderer.SetAlpha);
		}
		LuaObject.addMember(l, Lua_UnityEngine_CanvasRenderer.<>f__mg$cache3);
		if (Lua_UnityEngine_CanvasRenderer.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_CanvasRenderer.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_CanvasRenderer.EnableRectClipping);
		}
		LuaObject.addMember(l, Lua_UnityEngine_CanvasRenderer.<>f__mg$cache4);
		if (Lua_UnityEngine_CanvasRenderer.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_CanvasRenderer.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_CanvasRenderer.DisableRectClipping);
		}
		LuaObject.addMember(l, Lua_UnityEngine_CanvasRenderer.<>f__mg$cache5);
		if (Lua_UnityEngine_CanvasRenderer.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_CanvasRenderer.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_CanvasRenderer.SetMaterial);
		}
		LuaObject.addMember(l, Lua_UnityEngine_CanvasRenderer.<>f__mg$cache6);
		if (Lua_UnityEngine_CanvasRenderer.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_CanvasRenderer.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_CanvasRenderer.GetMaterial);
		}
		LuaObject.addMember(l, Lua_UnityEngine_CanvasRenderer.<>f__mg$cache7);
		if (Lua_UnityEngine_CanvasRenderer.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_CanvasRenderer.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_CanvasRenderer.SetPopMaterial);
		}
		LuaObject.addMember(l, Lua_UnityEngine_CanvasRenderer.<>f__mg$cache8);
		if (Lua_UnityEngine_CanvasRenderer.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_CanvasRenderer.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_CanvasRenderer.GetPopMaterial);
		}
		LuaObject.addMember(l, Lua_UnityEngine_CanvasRenderer.<>f__mg$cache9);
		if (Lua_UnityEngine_CanvasRenderer.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_CanvasRenderer.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_CanvasRenderer.SetTexture);
		}
		LuaObject.addMember(l, Lua_UnityEngine_CanvasRenderer.<>f__mg$cacheA);
		if (Lua_UnityEngine_CanvasRenderer.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_CanvasRenderer.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_CanvasRenderer.SetAlphaTexture);
		}
		LuaObject.addMember(l, Lua_UnityEngine_CanvasRenderer.<>f__mg$cacheB);
		if (Lua_UnityEngine_CanvasRenderer.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_CanvasRenderer.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_CanvasRenderer.SetMesh);
		}
		LuaObject.addMember(l, Lua_UnityEngine_CanvasRenderer.<>f__mg$cacheC);
		if (Lua_UnityEngine_CanvasRenderer.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_CanvasRenderer.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_CanvasRenderer.Clear);
		}
		LuaObject.addMember(l, Lua_UnityEngine_CanvasRenderer.<>f__mg$cacheD);
		if (Lua_UnityEngine_CanvasRenderer.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_CanvasRenderer.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_CanvasRenderer.SplitUIVertexStreams_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_CanvasRenderer.<>f__mg$cacheE);
		if (Lua_UnityEngine_CanvasRenderer.<>f__mg$cacheF == null)
		{
			Lua_UnityEngine_CanvasRenderer.<>f__mg$cacheF = new LuaCSFunction(Lua_UnityEngine_CanvasRenderer.CreateUIVertexStream_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_CanvasRenderer.<>f__mg$cacheF);
		if (Lua_UnityEngine_CanvasRenderer.<>f__mg$cache10 == null)
		{
			Lua_UnityEngine_CanvasRenderer.<>f__mg$cache10 = new LuaCSFunction(Lua_UnityEngine_CanvasRenderer.AddUIVertexStream_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_CanvasRenderer.<>f__mg$cache10);
		string name = "hasRectClipping";
		if (Lua_UnityEngine_CanvasRenderer.<>f__mg$cache11 == null)
		{
			Lua_UnityEngine_CanvasRenderer.<>f__mg$cache11 = new LuaCSFunction(Lua_UnityEngine_CanvasRenderer.get_hasRectClipping);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_CanvasRenderer.<>f__mg$cache11, null, true);
		string name2 = "hasPopInstruction";
		if (Lua_UnityEngine_CanvasRenderer.<>f__mg$cache12 == null)
		{
			Lua_UnityEngine_CanvasRenderer.<>f__mg$cache12 = new LuaCSFunction(Lua_UnityEngine_CanvasRenderer.get_hasPopInstruction);
		}
		LuaCSFunction get = Lua_UnityEngine_CanvasRenderer.<>f__mg$cache12;
		if (Lua_UnityEngine_CanvasRenderer.<>f__mg$cache13 == null)
		{
			Lua_UnityEngine_CanvasRenderer.<>f__mg$cache13 = new LuaCSFunction(Lua_UnityEngine_CanvasRenderer.set_hasPopInstruction);
		}
		LuaObject.addMember(l, name2, get, Lua_UnityEngine_CanvasRenderer.<>f__mg$cache13, true);
		string name3 = "materialCount";
		if (Lua_UnityEngine_CanvasRenderer.<>f__mg$cache14 == null)
		{
			Lua_UnityEngine_CanvasRenderer.<>f__mg$cache14 = new LuaCSFunction(Lua_UnityEngine_CanvasRenderer.get_materialCount);
		}
		LuaCSFunction get2 = Lua_UnityEngine_CanvasRenderer.<>f__mg$cache14;
		if (Lua_UnityEngine_CanvasRenderer.<>f__mg$cache15 == null)
		{
			Lua_UnityEngine_CanvasRenderer.<>f__mg$cache15 = new LuaCSFunction(Lua_UnityEngine_CanvasRenderer.set_materialCount);
		}
		LuaObject.addMember(l, name3, get2, Lua_UnityEngine_CanvasRenderer.<>f__mg$cache15, true);
		string name4 = "popMaterialCount";
		if (Lua_UnityEngine_CanvasRenderer.<>f__mg$cache16 == null)
		{
			Lua_UnityEngine_CanvasRenderer.<>f__mg$cache16 = new LuaCSFunction(Lua_UnityEngine_CanvasRenderer.get_popMaterialCount);
		}
		LuaCSFunction get3 = Lua_UnityEngine_CanvasRenderer.<>f__mg$cache16;
		if (Lua_UnityEngine_CanvasRenderer.<>f__mg$cache17 == null)
		{
			Lua_UnityEngine_CanvasRenderer.<>f__mg$cache17 = new LuaCSFunction(Lua_UnityEngine_CanvasRenderer.set_popMaterialCount);
		}
		LuaObject.addMember(l, name4, get3, Lua_UnityEngine_CanvasRenderer.<>f__mg$cache17, true);
		string name5 = "relativeDepth";
		if (Lua_UnityEngine_CanvasRenderer.<>f__mg$cache18 == null)
		{
			Lua_UnityEngine_CanvasRenderer.<>f__mg$cache18 = new LuaCSFunction(Lua_UnityEngine_CanvasRenderer.get_relativeDepth);
		}
		LuaObject.addMember(l, name5, Lua_UnityEngine_CanvasRenderer.<>f__mg$cache18, null, true);
		string name6 = "cull";
		if (Lua_UnityEngine_CanvasRenderer.<>f__mg$cache19 == null)
		{
			Lua_UnityEngine_CanvasRenderer.<>f__mg$cache19 = new LuaCSFunction(Lua_UnityEngine_CanvasRenderer.get_cull);
		}
		LuaCSFunction get4 = Lua_UnityEngine_CanvasRenderer.<>f__mg$cache19;
		if (Lua_UnityEngine_CanvasRenderer.<>f__mg$cache1A == null)
		{
			Lua_UnityEngine_CanvasRenderer.<>f__mg$cache1A = new LuaCSFunction(Lua_UnityEngine_CanvasRenderer.set_cull);
		}
		LuaObject.addMember(l, name6, get4, Lua_UnityEngine_CanvasRenderer.<>f__mg$cache1A, true);
		string name7 = "absoluteDepth";
		if (Lua_UnityEngine_CanvasRenderer.<>f__mg$cache1B == null)
		{
			Lua_UnityEngine_CanvasRenderer.<>f__mg$cache1B = new LuaCSFunction(Lua_UnityEngine_CanvasRenderer.get_absoluteDepth);
		}
		LuaObject.addMember(l, name7, Lua_UnityEngine_CanvasRenderer.<>f__mg$cache1B, null, true);
		string name8 = "hasMoved";
		if (Lua_UnityEngine_CanvasRenderer.<>f__mg$cache1C == null)
		{
			Lua_UnityEngine_CanvasRenderer.<>f__mg$cache1C = new LuaCSFunction(Lua_UnityEngine_CanvasRenderer.get_hasMoved);
		}
		LuaObject.addMember(l, name8, Lua_UnityEngine_CanvasRenderer.<>f__mg$cache1C, null, true);
		LuaObject.createTypeMetatable(l, null, typeof(CanvasRenderer), typeof(Component));
	}

	// Token: 0x04018D78 RID: 101752
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04018D79 RID: 101753
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04018D7A RID: 101754
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04018D7B RID: 101755
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04018D7C RID: 101756
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04018D7D RID: 101757
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04018D7E RID: 101758
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04018D7F RID: 101759
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04018D80 RID: 101760
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04018D81 RID: 101761
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04018D82 RID: 101762
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04018D83 RID: 101763
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04018D84 RID: 101764
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04018D85 RID: 101765
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04018D86 RID: 101766
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04018D87 RID: 101767
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04018D88 RID: 101768
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04018D89 RID: 101769
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04018D8A RID: 101770
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04018D8B RID: 101771
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04018D8C RID: 101772
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04018D8D RID: 101773
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04018D8E RID: 101774
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04018D8F RID: 101775
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04018D90 RID: 101776
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04018D91 RID: 101777
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04018D92 RID: 101778
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04018D93 RID: 101779
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04018D94 RID: 101780
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;
}
