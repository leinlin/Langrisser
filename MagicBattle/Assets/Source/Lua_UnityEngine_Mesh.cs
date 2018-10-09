using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

// Token: 0x02001728 RID: 5928
[Preserve]
public class Lua_UnityEngine_Mesh : LuaObject
{
	// Token: 0x0602363E RID: 144958 RVA: 0x00C4FD84 File Offset: 0x00C4DF84
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			Mesh o = new Mesh();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, o);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602363F RID: 144959 RVA: 0x00C4FDCC File Offset: 0x00C4DFCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetNativeVertexBufferPtr(IntPtr l)
	{
		int result;
		try
		{
			Mesh mesh = (Mesh)LuaObject.checkSelf(l);
			int index;
			LuaObject.checkType(l, 2, out index);
			IntPtr nativeVertexBufferPtr = mesh.GetNativeVertexBufferPtr(index);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, nativeVertexBufferPtr);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023640 RID: 144960 RVA: 0x00C4FE34 File Offset: 0x00C4E034
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetNativeIndexBufferPtr(IntPtr l)
	{
		int result;
		try
		{
			Mesh mesh = (Mesh)LuaObject.checkSelf(l);
			IntPtr nativeIndexBufferPtr = mesh.GetNativeIndexBufferPtr();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, nativeIndexBufferPtr);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023641 RID: 144961 RVA: 0x00C4FE90 File Offset: 0x00C4E090
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearBlendShapes(IntPtr l)
	{
		int result;
		try
		{
			Mesh mesh = (Mesh)LuaObject.checkSelf(l);
			mesh.ClearBlendShapes();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023642 RID: 144962 RVA: 0x00C4FEDC File Offset: 0x00C4E0DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetBlendShapeName(IntPtr l)
	{
		int result;
		try
		{
			Mesh mesh = (Mesh)LuaObject.checkSelf(l);
			int shapeIndex;
			LuaObject.checkType(l, 2, out shapeIndex);
			string blendShapeName = mesh.GetBlendShapeName(shapeIndex);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, blendShapeName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023643 RID: 144963 RVA: 0x00C4FF40 File Offset: 0x00C4E140
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetBlendShapeIndex(IntPtr l)
	{
		int result;
		try
		{
			Mesh mesh = (Mesh)LuaObject.checkSelf(l);
			string blendShapeName;
			LuaObject.checkType(l, 2, out blendShapeName);
			int blendShapeIndex = mesh.GetBlendShapeIndex(blendShapeName);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, blendShapeIndex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023644 RID: 144964 RVA: 0x00C4FFA4 File Offset: 0x00C4E1A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetBlendShapeFrameCount(IntPtr l)
	{
		int result;
		try
		{
			Mesh mesh = (Mesh)LuaObject.checkSelf(l);
			int shapeIndex;
			LuaObject.checkType(l, 2, out shapeIndex);
			int blendShapeFrameCount = mesh.GetBlendShapeFrameCount(shapeIndex);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, blendShapeFrameCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023645 RID: 144965 RVA: 0x00C50008 File Offset: 0x00C4E208
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetBlendShapeFrameWeight(IntPtr l)
	{
		int result;
		try
		{
			Mesh mesh = (Mesh)LuaObject.checkSelf(l);
			int shapeIndex;
			LuaObject.checkType(l, 2, out shapeIndex);
			int frameIndex;
			LuaObject.checkType(l, 3, out frameIndex);
			float blendShapeFrameWeight = mesh.GetBlendShapeFrameWeight(shapeIndex, frameIndex);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, blendShapeFrameWeight);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023646 RID: 144966 RVA: 0x00C50078 File Offset: 0x00C4E278
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetBlendShapeFrameVertices(IntPtr l)
	{
		int result;
		try
		{
			Mesh mesh = (Mesh)LuaObject.checkSelf(l);
			int shapeIndex;
			LuaObject.checkType(l, 2, out shapeIndex);
			int frameIndex;
			LuaObject.checkType(l, 3, out frameIndex);
			Vector3[] deltaVertices;
			LuaObject.checkArray<Vector3>(l, 4, out deltaVertices);
			Vector3[] deltaNormals;
			LuaObject.checkArray<Vector3>(l, 5, out deltaNormals);
			Vector3[] deltaTangents;
			LuaObject.checkArray<Vector3>(l, 6, out deltaTangents);
			mesh.GetBlendShapeFrameVertices(shapeIndex, frameIndex, deltaVertices, deltaNormals, deltaTangents);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023647 RID: 144967 RVA: 0x00C50104 File Offset: 0x00C4E304
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddBlendShapeFrame(IntPtr l)
	{
		int result;
		try
		{
			Mesh mesh = (Mesh)LuaObject.checkSelf(l);
			string shapeName;
			LuaObject.checkType(l, 2, out shapeName);
			float frameWeight;
			LuaObject.checkType(l, 3, out frameWeight);
			Vector3[] deltaVertices;
			LuaObject.checkArray<Vector3>(l, 4, out deltaVertices);
			Vector3[] deltaNormals;
			LuaObject.checkArray<Vector3>(l, 5, out deltaNormals);
			Vector3[] deltaTangents;
			LuaObject.checkArray<Vector3>(l, 6, out deltaTangents);
			mesh.AddBlendShapeFrame(shapeName, frameWeight, deltaVertices, deltaNormals, deltaTangents);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023648 RID: 144968 RVA: 0x00C50190 File Offset: 0x00C4E390
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetVertices(IntPtr l)
	{
		int result;
		try
		{
			Mesh mesh = (Mesh)LuaObject.checkSelf(l);
			List<Vector3> vertices;
			LuaObject.checkType<List<Vector3>>(l, 2, out vertices);
			mesh.GetVertices(vertices);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023649 RID: 144969 RVA: 0x00C501E8 File Offset: 0x00C4E3E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetVertices(IntPtr l)
	{
		int result;
		try
		{
			Mesh mesh = (Mesh)LuaObject.checkSelf(l);
			List<Vector3> vertices;
			LuaObject.checkType<List<Vector3>>(l, 2, out vertices);
			mesh.SetVertices(vertices);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602364A RID: 144970 RVA: 0x00C50240 File Offset: 0x00C4E440
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetNormals(IntPtr l)
	{
		int result;
		try
		{
			Mesh mesh = (Mesh)LuaObject.checkSelf(l);
			List<Vector3> normals;
			LuaObject.checkType<List<Vector3>>(l, 2, out normals);
			mesh.GetNormals(normals);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602364B RID: 144971 RVA: 0x00C50298 File Offset: 0x00C4E498
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetNormals(IntPtr l)
	{
		int result;
		try
		{
			Mesh mesh = (Mesh)LuaObject.checkSelf(l);
			List<Vector3> normals;
			LuaObject.checkType<List<Vector3>>(l, 2, out normals);
			mesh.SetNormals(normals);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602364C RID: 144972 RVA: 0x00C502F0 File Offset: 0x00C4E4F0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetTangents(IntPtr l)
	{
		int result;
		try
		{
			Mesh mesh = (Mesh)LuaObject.checkSelf(l);
			List<Vector4> tangents;
			LuaObject.checkType<List<Vector4>>(l, 2, out tangents);
			mesh.GetTangents(tangents);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602364D RID: 144973 RVA: 0x00C50348 File Offset: 0x00C4E548
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetTangents(IntPtr l)
	{
		int result;
		try
		{
			Mesh mesh = (Mesh)LuaObject.checkSelf(l);
			List<Vector4> tangents;
			LuaObject.checkType<List<Vector4>>(l, 2, out tangents);
			mesh.SetTangents(tangents);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602364E RID: 144974 RVA: 0x00C503A0 File Offset: 0x00C4E5A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetColors(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(List<Color>)))
			{
				Mesh mesh = (Mesh)LuaObject.checkSelf(l);
				List<Color> colors;
				LuaObject.checkType<List<Color>>(l, 2, out colors);
				mesh.GetColors(colors);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(List<Color32>)))
			{
				Mesh mesh2 = (Mesh)LuaObject.checkSelf(l);
				List<Color32> colors2;
				LuaObject.checkType<List<Color32>>(l, 2, out colors2);
				mesh2.GetColors(colors2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function GetColors to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602364F RID: 144975 RVA: 0x00C50478 File Offset: 0x00C4E678
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetColors(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(List<Color>)))
			{
				Mesh mesh = (Mesh)LuaObject.checkSelf(l);
				List<Color> colors;
				LuaObject.checkType<List<Color>>(l, 2, out colors);
				mesh.SetColors(colors);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(List<Color32>)))
			{
				Mesh mesh2 = (Mesh)LuaObject.checkSelf(l);
				List<Color32> colors2;
				LuaObject.checkType<List<Color32>>(l, 2, out colors2);
				mesh2.SetColors(colors2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function SetColors to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023650 RID: 144976 RVA: 0x00C50550 File Offset: 0x00C4E750
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetUVs(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(int), typeof(List<Vector4>)))
			{
				Mesh mesh = (Mesh)LuaObject.checkSelf(l);
				int channel;
				LuaObject.checkType(l, 2, out channel);
				List<Vector4> uvs;
				LuaObject.checkType<List<Vector4>>(l, 3, out uvs);
				mesh.SetUVs(channel, uvs);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(int), typeof(List<Vector3>)))
			{
				Mesh mesh2 = (Mesh)LuaObject.checkSelf(l);
				int channel2;
				LuaObject.checkType(l, 2, out channel2);
				List<Vector3> uvs2;
				LuaObject.checkType<List<Vector3>>(l, 3, out uvs2);
				mesh2.SetUVs(channel2, uvs2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(int), typeof(List<Vector2>)))
			{
				Mesh mesh3 = (Mesh)LuaObject.checkSelf(l);
				int channel3;
				LuaObject.checkType(l, 2, out channel3);
				List<Vector2> uvs3;
				LuaObject.checkType<List<Vector2>>(l, 3, out uvs3);
				mesh3.SetUVs(channel3, uvs3);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function SetUVs to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023651 RID: 144977 RVA: 0x00C506C0 File Offset: 0x00C4E8C0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetUVs(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(int), typeof(List<Vector4>)))
			{
				Mesh mesh = (Mesh)LuaObject.checkSelf(l);
				int channel;
				LuaObject.checkType(l, 2, out channel);
				List<Vector4> uvs;
				LuaObject.checkType<List<Vector4>>(l, 3, out uvs);
				mesh.GetUVs(channel, uvs);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(int), typeof(List<Vector3>)))
			{
				Mesh mesh2 = (Mesh)LuaObject.checkSelf(l);
				int channel2;
				LuaObject.checkType(l, 2, out channel2);
				List<Vector3> uvs2;
				LuaObject.checkType<List<Vector3>>(l, 3, out uvs2);
				mesh2.GetUVs(channel2, uvs2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(int), typeof(List<Vector2>)))
			{
				Mesh mesh3 = (Mesh)LuaObject.checkSelf(l);
				int channel3;
				LuaObject.checkType(l, 2, out channel3);
				List<Vector2> uvs3;
				LuaObject.checkType<List<Vector2>>(l, 3, out uvs3);
				mesh3.GetUVs(channel3, uvs3);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function GetUVs to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023652 RID: 144978 RVA: 0x00C50830 File Offset: 0x00C4EA30
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetTriangles(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				Mesh mesh = (Mesh)LuaObject.checkSelf(l);
				int submesh;
				LuaObject.checkType(l, 2, out submesh);
				int[] triangles = mesh.GetTriangles(submesh);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, triangles);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(List<int>), typeof(int)))
			{
				Mesh mesh2 = (Mesh)LuaObject.checkSelf(l);
				List<int> triangles2;
				LuaObject.checkType<List<int>>(l, 2, out triangles2);
				int submesh2;
				LuaObject.checkType(l, 3, out submesh2);
				mesh2.GetTriangles(triangles2, submesh2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(int), typeof(bool)))
			{
				Mesh mesh3 = (Mesh)LuaObject.checkSelf(l);
				int submesh3;
				LuaObject.checkType(l, 2, out submesh3);
				bool applyBaseVertex;
				LuaObject.checkType(l, 3, out applyBaseVertex);
				int[] triangles3 = mesh3.GetTriangles(submesh3, applyBaseVertex);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, triangles3);
				result = 2;
			}
			else if (num == 4)
			{
				Mesh mesh4 = (Mesh)LuaObject.checkSelf(l);
				List<int> triangles4;
				LuaObject.checkType<List<int>>(l, 2, out triangles4);
				int submesh4;
				LuaObject.checkType(l, 3, out submesh4);
				bool applyBaseVertex2;
				LuaObject.checkType(l, 4, out applyBaseVertex2);
				mesh4.GetTriangles(triangles4, submesh4, applyBaseVertex2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function GetTriangles to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023653 RID: 144979 RVA: 0x00C509D8 File Offset: 0x00C4EBD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetIndices(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				Mesh mesh = (Mesh)LuaObject.checkSelf(l);
				int submesh;
				LuaObject.checkType(l, 2, out submesh);
				int[] indices = mesh.GetIndices(submesh);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, indices);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(List<int>), typeof(int)))
			{
				Mesh mesh2 = (Mesh)LuaObject.checkSelf(l);
				List<int> indices2;
				LuaObject.checkType<List<int>>(l, 2, out indices2);
				int submesh2;
				LuaObject.checkType(l, 3, out submesh2);
				mesh2.GetIndices(indices2, submesh2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(int), typeof(bool)))
			{
				Mesh mesh3 = (Mesh)LuaObject.checkSelf(l);
				int submesh3;
				LuaObject.checkType(l, 2, out submesh3);
				bool applyBaseVertex;
				LuaObject.checkType(l, 3, out applyBaseVertex);
				int[] indices3 = mesh3.GetIndices(submesh3, applyBaseVertex);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, indices3);
				result = 2;
			}
			else if (num == 4)
			{
				Mesh mesh4 = (Mesh)LuaObject.checkSelf(l);
				List<int> indices4;
				LuaObject.checkType<List<int>>(l, 2, out indices4);
				int submesh4;
				LuaObject.checkType(l, 3, out submesh4);
				bool applyBaseVertex2;
				LuaObject.checkType(l, 4, out applyBaseVertex2);
				mesh4.GetIndices(indices4, submesh4, applyBaseVertex2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function GetIndices to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023654 RID: 144980 RVA: 0x00C50B80 File Offset: 0x00C4ED80
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetIndexStart(IntPtr l)
	{
		int result;
		try
		{
			Mesh mesh = (Mesh)LuaObject.checkSelf(l);
			int submesh;
			LuaObject.checkType(l, 2, out submesh);
			uint indexStart = mesh.GetIndexStart(submesh);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, indexStart);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023655 RID: 144981 RVA: 0x00C50BE4 File Offset: 0x00C4EDE4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetIndexCount(IntPtr l)
	{
		int result;
		try
		{
			Mesh mesh = (Mesh)LuaObject.checkSelf(l);
			int submesh;
			LuaObject.checkType(l, 2, out submesh);
			uint indexCount = mesh.GetIndexCount(submesh);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, indexCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023656 RID: 144982 RVA: 0x00C50C48 File Offset: 0x00C4EE48
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetBaseVertex(IntPtr l)
	{
		int result;
		try
		{
			Mesh mesh = (Mesh)LuaObject.checkSelf(l);
			int submesh;
			LuaObject.checkType(l, 2, out submesh);
			uint baseVertex = mesh.GetBaseVertex(submesh);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, baseVertex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023657 RID: 144983 RVA: 0x00C50CAC File Offset: 0x00C4EEAC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetTriangles(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(List<int>), typeof(int)))
			{
				Mesh mesh = (Mesh)LuaObject.checkSelf(l);
				List<int> triangles;
				LuaObject.checkType<List<int>>(l, 2, out triangles);
				int submesh;
				LuaObject.checkType(l, 3, out submesh);
				mesh.SetTriangles(triangles, submesh);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(int[]), typeof(int)))
			{
				Mesh mesh2 = (Mesh)LuaObject.checkSelf(l);
				int[] triangles2;
				LuaObject.checkArray<int>(l, 2, out triangles2);
				int submesh2;
				LuaObject.checkType(l, 3, out submesh2);
				mesh2.SetTriangles(triangles2, submesh2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(List<int>), typeof(int), typeof(bool)))
			{
				Mesh mesh3 = (Mesh)LuaObject.checkSelf(l);
				List<int> triangles3;
				LuaObject.checkType<List<int>>(l, 2, out triangles3);
				int submesh3;
				LuaObject.checkType(l, 3, out submesh3);
				bool calculateBounds;
				LuaObject.checkType(l, 4, out calculateBounds);
				mesh3.SetTriangles(triangles3, submesh3, calculateBounds);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(int[]), typeof(int), typeof(bool)))
			{
				Mesh mesh4 = (Mesh)LuaObject.checkSelf(l);
				int[] triangles4;
				LuaObject.checkArray<int>(l, 2, out triangles4);
				int submesh4;
				LuaObject.checkType(l, 3, out submesh4);
				bool calculateBounds2;
				LuaObject.checkType(l, 4, out calculateBounds2);
				mesh4.SetTriangles(triangles4, submesh4, calculateBounds2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(List<int>), typeof(int), typeof(bool), typeof(int)))
			{
				Mesh mesh5 = (Mesh)LuaObject.checkSelf(l);
				List<int> triangles5;
				LuaObject.checkType<List<int>>(l, 2, out triangles5);
				int submesh5;
				LuaObject.checkType(l, 3, out submesh5);
				bool calculateBounds3;
				LuaObject.checkType(l, 4, out calculateBounds3);
				int baseVertex;
				LuaObject.checkType(l, 5, out baseVertex);
				mesh5.SetTriangles(triangles5, submesh5, calculateBounds3, baseVertex);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(int[]), typeof(int), typeof(bool), typeof(int)))
			{
				Mesh mesh6 = (Mesh)LuaObject.checkSelf(l);
				int[] triangles6;
				LuaObject.checkArray<int>(l, 2, out triangles6);
				int submesh6;
				LuaObject.checkType(l, 3, out submesh6);
				bool calculateBounds4;
				LuaObject.checkType(l, 4, out calculateBounds4);
				int baseVertex2;
				LuaObject.checkType(l, 5, out baseVertex2);
				mesh6.SetTriangles(triangles6, submesh6, calculateBounds4, baseVertex2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function SetTriangles to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023658 RID: 144984 RVA: 0x00C50FB4 File Offset: 0x00C4F1B4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetIndices(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 4)
			{
				Mesh mesh = (Mesh)LuaObject.checkSelf(l);
				int[] indices;
				LuaObject.checkArray<int>(l, 2, out indices);
				MeshTopology topology;
				LuaObject.checkEnum<MeshTopology>(l, 3, out topology);
				int submesh;
				LuaObject.checkType(l, 4, out submesh);
				mesh.SetIndices(indices, topology, submesh);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 5)
			{
				Mesh mesh2 = (Mesh)LuaObject.checkSelf(l);
				int[] indices2;
				LuaObject.checkArray<int>(l, 2, out indices2);
				MeshTopology topology2;
				LuaObject.checkEnum<MeshTopology>(l, 3, out topology2);
				int submesh2;
				LuaObject.checkType(l, 4, out submesh2);
				bool calculateBounds;
				LuaObject.checkType(l, 5, out calculateBounds);
				mesh2.SetIndices(indices2, topology2, submesh2, calculateBounds);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 6)
			{
				Mesh mesh3 = (Mesh)LuaObject.checkSelf(l);
				int[] indices3;
				LuaObject.checkArray<int>(l, 2, out indices3);
				MeshTopology topology3;
				LuaObject.checkEnum<MeshTopology>(l, 3, out topology3);
				int submesh3;
				LuaObject.checkType(l, 4, out submesh3);
				bool calculateBounds2;
				LuaObject.checkType(l, 5, out calculateBounds2);
				int baseVertex;
				LuaObject.checkType(l, 6, out baseVertex);
				mesh3.SetIndices(indices3, topology3, submesh3, calculateBounds2, baseVertex);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function SetIndices to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023659 RID: 144985 RVA: 0x00C5111C File Offset: 0x00C4F31C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetBindposes(IntPtr l)
	{
		int result;
		try
		{
			Mesh mesh = (Mesh)LuaObject.checkSelf(l);
			List<Matrix4x4> bindposes;
			LuaObject.checkType<List<Matrix4x4>>(l, 2, out bindposes);
			mesh.GetBindposes(bindposes);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602365A RID: 144986 RVA: 0x00C51174 File Offset: 0x00C4F374
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetBoneWeights(IntPtr l)
	{
		int result;
		try
		{
			Mesh mesh = (Mesh)LuaObject.checkSelf(l);
			List<BoneWeight> boneWeights;
			LuaObject.checkType<List<BoneWeight>>(l, 2, out boneWeights);
			mesh.GetBoneWeights(boneWeights);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602365B RID: 144987 RVA: 0x00C511CC File Offset: 0x00C4F3CC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Clear(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				Mesh mesh = (Mesh)LuaObject.checkSelf(l);
				bool keepVertexLayout;
				LuaObject.checkType(l, 2, out keepVertexLayout);
				mesh.Clear(keepVertexLayout);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 1)
			{
				Mesh mesh2 = (Mesh)LuaObject.checkSelf(l);
				mesh2.Clear();
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function Clear to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602365C RID: 144988 RVA: 0x00C51278 File Offset: 0x00C4F478
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int RecalculateBounds(IntPtr l)
	{
		int result;
		try
		{
			Mesh mesh = (Mesh)LuaObject.checkSelf(l);
			mesh.RecalculateBounds();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602365D RID: 144989 RVA: 0x00C512C4 File Offset: 0x00C4F4C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RecalculateNormals(IntPtr l)
	{
		int result;
		try
		{
			Mesh mesh = (Mesh)LuaObject.checkSelf(l);
			mesh.RecalculateNormals();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602365E RID: 144990 RVA: 0x00C51310 File Offset: 0x00C4F510
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RecalculateTangents(IntPtr l)
	{
		int result;
		try
		{
			Mesh mesh = (Mesh)LuaObject.checkSelf(l);
			mesh.RecalculateTangents();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602365F RID: 144991 RVA: 0x00C5135C File Offset: 0x00C4F55C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int MarkDynamic(IntPtr l)
	{
		int result;
		try
		{
			Mesh mesh = (Mesh)LuaObject.checkSelf(l);
			mesh.MarkDynamic();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023660 RID: 144992 RVA: 0x00C513A8 File Offset: 0x00C4F5A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UploadMeshData(IntPtr l)
	{
		int result;
		try
		{
			Mesh mesh = (Mesh)LuaObject.checkSelf(l);
			bool markNoLogerReadable;
			LuaObject.checkType(l, 2, out markNoLogerReadable);
			mesh.UploadMeshData(markNoLogerReadable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023661 RID: 144993 RVA: 0x00C51400 File Offset: 0x00C4F600
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetTopology(IntPtr l)
	{
		int result;
		try
		{
			Mesh mesh = (Mesh)LuaObject.checkSelf(l);
			int submesh;
			LuaObject.checkType(l, 2, out submesh);
			MeshTopology topology = mesh.GetTopology(submesh);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)topology);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023662 RID: 144994 RVA: 0x00C51464 File Offset: 0x00C4F664
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CombineMeshes(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				Mesh mesh = (Mesh)LuaObject.checkSelf(l);
				CombineInstance[] combine;
				LuaObject.checkArray<CombineInstance>(l, 2, out combine);
				mesh.CombineMeshes(combine);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 3)
			{
				Mesh mesh2 = (Mesh)LuaObject.checkSelf(l);
				CombineInstance[] combine2;
				LuaObject.checkArray<CombineInstance>(l, 2, out combine2);
				bool mergeSubMeshes;
				LuaObject.checkType(l, 3, out mergeSubMeshes);
				mesh2.CombineMeshes(combine2, mergeSubMeshes);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 4)
			{
				Mesh mesh3 = (Mesh)LuaObject.checkSelf(l);
				CombineInstance[] combine3;
				LuaObject.checkArray<CombineInstance>(l, 2, out combine3);
				bool mergeSubMeshes2;
				LuaObject.checkType(l, 3, out mergeSubMeshes2);
				bool useMatrices;
				LuaObject.checkType(l, 4, out useMatrices);
				mesh3.CombineMeshes(combine3, mergeSubMeshes2, useMatrices);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 5)
			{
				Mesh mesh4 = (Mesh)LuaObject.checkSelf(l);
				CombineInstance[] combine4;
				LuaObject.checkArray<CombineInstance>(l, 2, out combine4);
				bool mergeSubMeshes3;
				LuaObject.checkType(l, 3, out mergeSubMeshes3);
				bool useMatrices2;
				LuaObject.checkType(l, 4, out useMatrices2);
				bool hasLightmapData;
				LuaObject.checkType(l, 5, out hasLightmapData);
				mesh4.CombineMeshes(combine4, mergeSubMeshes3, useMatrices2, hasLightmapData);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function CombineMeshes to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023663 RID: 144995 RVA: 0x00C515D8 File Offset: 0x00C4F7D8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_indexFormat(IntPtr l)
	{
		int result;
		try
		{
			Mesh mesh = (Mesh)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)mesh.indexFormat);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023664 RID: 144996 RVA: 0x00C5162C File Offset: 0x00C4F82C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_indexFormat(IntPtr l)
	{
		int result;
		try
		{
			Mesh mesh = (Mesh)LuaObject.checkSelf(l);
			IndexFormat indexFormat;
			LuaObject.checkEnum<IndexFormat>(l, 2, out indexFormat);
			mesh.indexFormat = indexFormat;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023665 RID: 144997 RVA: 0x00C51684 File Offset: 0x00C4F884
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_vertexBufferCount(IntPtr l)
	{
		int result;
		try
		{
			Mesh mesh = (Mesh)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mesh.vertexBufferCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023666 RID: 144998 RVA: 0x00C516D8 File Offset: 0x00C4F8D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_blendShapeCount(IntPtr l)
	{
		int result;
		try
		{
			Mesh mesh = (Mesh)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mesh.blendShapeCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023667 RID: 144999 RVA: 0x00C5172C File Offset: 0x00C4F92C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_boneWeights(IntPtr l)
	{
		int result;
		try
		{
			Mesh mesh = (Mesh)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mesh.boneWeights);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023668 RID: 145000 RVA: 0x00C51780 File Offset: 0x00C4F980
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_boneWeights(IntPtr l)
	{
		int result;
		try
		{
			Mesh mesh = (Mesh)LuaObject.checkSelf(l);
			BoneWeight[] boneWeights;
			LuaObject.checkArray<BoneWeight>(l, 2, out boneWeights);
			mesh.boneWeights = boneWeights;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023669 RID: 145001 RVA: 0x00C517D8 File Offset: 0x00C4F9D8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_bindposes(IntPtr l)
	{
		int result;
		try
		{
			Mesh mesh = (Mesh)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mesh.bindposes);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602366A RID: 145002 RVA: 0x00C5182C File Offset: 0x00C4FA2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_bindposes(IntPtr l)
	{
		int result;
		try
		{
			Mesh mesh = (Mesh)LuaObject.checkSelf(l);
			Matrix4x4[] bindposes;
			LuaObject.checkArray<Matrix4x4>(l, 2, out bindposes);
			mesh.bindposes = bindposes;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602366B RID: 145003 RVA: 0x00C51884 File Offset: 0x00C4FA84
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_isReadable(IntPtr l)
	{
		int result;
		try
		{
			Mesh mesh = (Mesh)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mesh.isReadable);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602366C RID: 145004 RVA: 0x00C518D8 File Offset: 0x00C4FAD8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_vertexCount(IntPtr l)
	{
		int result;
		try
		{
			Mesh mesh = (Mesh)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mesh.vertexCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602366D RID: 145005 RVA: 0x00C5192C File Offset: 0x00C4FB2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_subMeshCount(IntPtr l)
	{
		int result;
		try
		{
			Mesh mesh = (Mesh)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mesh.subMeshCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602366E RID: 145006 RVA: 0x00C51980 File Offset: 0x00C4FB80
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_subMeshCount(IntPtr l)
	{
		int result;
		try
		{
			Mesh mesh = (Mesh)LuaObject.checkSelf(l);
			int subMeshCount;
			LuaObject.checkType(l, 2, out subMeshCount);
			mesh.subMeshCount = subMeshCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602366F RID: 145007 RVA: 0x00C519D8 File Offset: 0x00C4FBD8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_bounds(IntPtr l)
	{
		int result;
		try
		{
			Mesh mesh = (Mesh)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mesh.bounds);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023670 RID: 145008 RVA: 0x00C51A30 File Offset: 0x00C4FC30
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_bounds(IntPtr l)
	{
		int result;
		try
		{
			Mesh mesh = (Mesh)LuaObject.checkSelf(l);
			Bounds bounds;
			LuaObject.checkValueType<Bounds>(l, 2, out bounds);
			mesh.bounds = bounds;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023671 RID: 145009 RVA: 0x00C51A88 File Offset: 0x00C4FC88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_vertices(IntPtr l)
	{
		int result;
		try
		{
			Mesh mesh = (Mesh)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mesh.vertices);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023672 RID: 145010 RVA: 0x00C51ADC File Offset: 0x00C4FCDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_vertices(IntPtr l)
	{
		int result;
		try
		{
			Mesh mesh = (Mesh)LuaObject.checkSelf(l);
			Vector3[] vertices;
			LuaObject.checkArray<Vector3>(l, 2, out vertices);
			mesh.vertices = vertices;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023673 RID: 145011 RVA: 0x00C51B34 File Offset: 0x00C4FD34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_normals(IntPtr l)
	{
		int result;
		try
		{
			Mesh mesh = (Mesh)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mesh.normals);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023674 RID: 145012 RVA: 0x00C51B88 File Offset: 0x00C4FD88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_normals(IntPtr l)
	{
		int result;
		try
		{
			Mesh mesh = (Mesh)LuaObject.checkSelf(l);
			Vector3[] normals;
			LuaObject.checkArray<Vector3>(l, 2, out normals);
			mesh.normals = normals;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023675 RID: 145013 RVA: 0x00C51BE0 File Offset: 0x00C4FDE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_tangents(IntPtr l)
	{
		int result;
		try
		{
			Mesh mesh = (Mesh)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mesh.tangents);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023676 RID: 145014 RVA: 0x00C51C34 File Offset: 0x00C4FE34
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_tangents(IntPtr l)
	{
		int result;
		try
		{
			Mesh mesh = (Mesh)LuaObject.checkSelf(l);
			Vector4[] tangents;
			LuaObject.checkArray<Vector4>(l, 2, out tangents);
			mesh.tangents = tangents;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023677 RID: 145015 RVA: 0x00C51C8C File Offset: 0x00C4FE8C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_uv(IntPtr l)
	{
		int result;
		try
		{
			Mesh mesh = (Mesh)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mesh.uv);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023678 RID: 145016 RVA: 0x00C51CE0 File Offset: 0x00C4FEE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_uv(IntPtr l)
	{
		int result;
		try
		{
			Mesh mesh = (Mesh)LuaObject.checkSelf(l);
			Vector2[] uv;
			LuaObject.checkArray<Vector2>(l, 2, out uv);
			mesh.uv = uv;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023679 RID: 145017 RVA: 0x00C51D38 File Offset: 0x00C4FF38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_uv2(IntPtr l)
	{
		int result;
		try
		{
			Mesh mesh = (Mesh)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mesh.uv2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602367A RID: 145018 RVA: 0x00C51D8C File Offset: 0x00C4FF8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_uv2(IntPtr l)
	{
		int result;
		try
		{
			Mesh mesh = (Mesh)LuaObject.checkSelf(l);
			Vector2[] uv;
			LuaObject.checkArray<Vector2>(l, 2, out uv);
			mesh.uv2 = uv;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602367B RID: 145019 RVA: 0x00C51DE4 File Offset: 0x00C4FFE4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_uv3(IntPtr l)
	{
		int result;
		try
		{
			Mesh mesh = (Mesh)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mesh.uv3);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602367C RID: 145020 RVA: 0x00C51E38 File Offset: 0x00C50038
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_uv3(IntPtr l)
	{
		int result;
		try
		{
			Mesh mesh = (Mesh)LuaObject.checkSelf(l);
			Vector2[] uv;
			LuaObject.checkArray<Vector2>(l, 2, out uv);
			mesh.uv3 = uv;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602367D RID: 145021 RVA: 0x00C51E90 File Offset: 0x00C50090
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_uv4(IntPtr l)
	{
		int result;
		try
		{
			Mesh mesh = (Mesh)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mesh.uv4);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602367E RID: 145022 RVA: 0x00C51EE4 File Offset: 0x00C500E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_uv4(IntPtr l)
	{
		int result;
		try
		{
			Mesh mesh = (Mesh)LuaObject.checkSelf(l);
			Vector2[] uv;
			LuaObject.checkArray<Vector2>(l, 2, out uv);
			mesh.uv4 = uv;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602367F RID: 145023 RVA: 0x00C51F3C File Offset: 0x00C5013C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_colors(IntPtr l)
	{
		int result;
		try
		{
			Mesh mesh = (Mesh)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mesh.colors);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023680 RID: 145024 RVA: 0x00C51F90 File Offset: 0x00C50190
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_colors(IntPtr l)
	{
		int result;
		try
		{
			Mesh mesh = (Mesh)LuaObject.checkSelf(l);
			Color[] colors;
			LuaObject.checkArray<Color>(l, 2, out colors);
			mesh.colors = colors;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023681 RID: 145025 RVA: 0x00C51FE8 File Offset: 0x00C501E8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_colors32(IntPtr l)
	{
		int result;
		try
		{
			Mesh mesh = (Mesh)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mesh.colors32);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023682 RID: 145026 RVA: 0x00C5203C File Offset: 0x00C5023C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_colors32(IntPtr l)
	{
		int result;
		try
		{
			Mesh mesh = (Mesh)LuaObject.checkSelf(l);
			Color32[] colors;
			LuaObject.checkArray<Color32>(l, 2, out colors);
			mesh.colors32 = colors;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023683 RID: 145027 RVA: 0x00C52094 File Offset: 0x00C50294
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_triangles(IntPtr l)
	{
		int result;
		try
		{
			Mesh mesh = (Mesh)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mesh.triangles);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023684 RID: 145028 RVA: 0x00C520E8 File Offset: 0x00C502E8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_triangles(IntPtr l)
	{
		int result;
		try
		{
			Mesh mesh = (Mesh)LuaObject.checkSelf(l);
			int[] triangles;
			LuaObject.checkArray<int>(l, 2, out triangles);
			mesh.triangles = triangles;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023685 RID: 145029 RVA: 0x00C52140 File Offset: 0x00C50340
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Mesh");
		if (Lua_UnityEngine_Mesh.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_Mesh.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_Mesh.GetNativeVertexBufferPtr);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Mesh.<>f__mg$cache0);
		if (Lua_UnityEngine_Mesh.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_Mesh.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_Mesh.GetNativeIndexBufferPtr);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Mesh.<>f__mg$cache1);
		if (Lua_UnityEngine_Mesh.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_Mesh.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_Mesh.ClearBlendShapes);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Mesh.<>f__mg$cache2);
		if (Lua_UnityEngine_Mesh.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_Mesh.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_Mesh.GetBlendShapeName);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Mesh.<>f__mg$cache3);
		if (Lua_UnityEngine_Mesh.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_Mesh.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_Mesh.GetBlendShapeIndex);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Mesh.<>f__mg$cache4);
		if (Lua_UnityEngine_Mesh.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_Mesh.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_Mesh.GetBlendShapeFrameCount);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Mesh.<>f__mg$cache5);
		if (Lua_UnityEngine_Mesh.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_Mesh.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_Mesh.GetBlendShapeFrameWeight);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Mesh.<>f__mg$cache6);
		if (Lua_UnityEngine_Mesh.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_Mesh.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_Mesh.GetBlendShapeFrameVertices);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Mesh.<>f__mg$cache7);
		if (Lua_UnityEngine_Mesh.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_Mesh.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_Mesh.AddBlendShapeFrame);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Mesh.<>f__mg$cache8);
		if (Lua_UnityEngine_Mesh.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_Mesh.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_Mesh.GetVertices);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Mesh.<>f__mg$cache9);
		if (Lua_UnityEngine_Mesh.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_Mesh.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_Mesh.SetVertices);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Mesh.<>f__mg$cacheA);
		if (Lua_UnityEngine_Mesh.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_Mesh.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_Mesh.GetNormals);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Mesh.<>f__mg$cacheB);
		if (Lua_UnityEngine_Mesh.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_Mesh.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_Mesh.SetNormals);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Mesh.<>f__mg$cacheC);
		if (Lua_UnityEngine_Mesh.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_Mesh.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_Mesh.GetTangents);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Mesh.<>f__mg$cacheD);
		if (Lua_UnityEngine_Mesh.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_Mesh.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_Mesh.SetTangents);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Mesh.<>f__mg$cacheE);
		if (Lua_UnityEngine_Mesh.<>f__mg$cacheF == null)
		{
			Lua_UnityEngine_Mesh.<>f__mg$cacheF = new LuaCSFunction(Lua_UnityEngine_Mesh.GetColors);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Mesh.<>f__mg$cacheF);
		if (Lua_UnityEngine_Mesh.<>f__mg$cache10 == null)
		{
			Lua_UnityEngine_Mesh.<>f__mg$cache10 = new LuaCSFunction(Lua_UnityEngine_Mesh.SetColors);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Mesh.<>f__mg$cache10);
		if (Lua_UnityEngine_Mesh.<>f__mg$cache11 == null)
		{
			Lua_UnityEngine_Mesh.<>f__mg$cache11 = new LuaCSFunction(Lua_UnityEngine_Mesh.SetUVs);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Mesh.<>f__mg$cache11);
		if (Lua_UnityEngine_Mesh.<>f__mg$cache12 == null)
		{
			Lua_UnityEngine_Mesh.<>f__mg$cache12 = new LuaCSFunction(Lua_UnityEngine_Mesh.GetUVs);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Mesh.<>f__mg$cache12);
		if (Lua_UnityEngine_Mesh.<>f__mg$cache13 == null)
		{
			Lua_UnityEngine_Mesh.<>f__mg$cache13 = new LuaCSFunction(Lua_UnityEngine_Mesh.GetTriangles);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Mesh.<>f__mg$cache13);
		if (Lua_UnityEngine_Mesh.<>f__mg$cache14 == null)
		{
			Lua_UnityEngine_Mesh.<>f__mg$cache14 = new LuaCSFunction(Lua_UnityEngine_Mesh.GetIndices);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Mesh.<>f__mg$cache14);
		if (Lua_UnityEngine_Mesh.<>f__mg$cache15 == null)
		{
			Lua_UnityEngine_Mesh.<>f__mg$cache15 = new LuaCSFunction(Lua_UnityEngine_Mesh.GetIndexStart);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Mesh.<>f__mg$cache15);
		if (Lua_UnityEngine_Mesh.<>f__mg$cache16 == null)
		{
			Lua_UnityEngine_Mesh.<>f__mg$cache16 = new LuaCSFunction(Lua_UnityEngine_Mesh.GetIndexCount);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Mesh.<>f__mg$cache16);
		if (Lua_UnityEngine_Mesh.<>f__mg$cache17 == null)
		{
			Lua_UnityEngine_Mesh.<>f__mg$cache17 = new LuaCSFunction(Lua_UnityEngine_Mesh.GetBaseVertex);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Mesh.<>f__mg$cache17);
		if (Lua_UnityEngine_Mesh.<>f__mg$cache18 == null)
		{
			Lua_UnityEngine_Mesh.<>f__mg$cache18 = new LuaCSFunction(Lua_UnityEngine_Mesh.SetTriangles);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Mesh.<>f__mg$cache18);
		if (Lua_UnityEngine_Mesh.<>f__mg$cache19 == null)
		{
			Lua_UnityEngine_Mesh.<>f__mg$cache19 = new LuaCSFunction(Lua_UnityEngine_Mesh.SetIndices);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Mesh.<>f__mg$cache19);
		if (Lua_UnityEngine_Mesh.<>f__mg$cache1A == null)
		{
			Lua_UnityEngine_Mesh.<>f__mg$cache1A = new LuaCSFunction(Lua_UnityEngine_Mesh.GetBindposes);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Mesh.<>f__mg$cache1A);
		if (Lua_UnityEngine_Mesh.<>f__mg$cache1B == null)
		{
			Lua_UnityEngine_Mesh.<>f__mg$cache1B = new LuaCSFunction(Lua_UnityEngine_Mesh.GetBoneWeights);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Mesh.<>f__mg$cache1B);
		if (Lua_UnityEngine_Mesh.<>f__mg$cache1C == null)
		{
			Lua_UnityEngine_Mesh.<>f__mg$cache1C = new LuaCSFunction(Lua_UnityEngine_Mesh.Clear);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Mesh.<>f__mg$cache1C);
		if (Lua_UnityEngine_Mesh.<>f__mg$cache1D == null)
		{
			Lua_UnityEngine_Mesh.<>f__mg$cache1D = new LuaCSFunction(Lua_UnityEngine_Mesh.RecalculateBounds);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Mesh.<>f__mg$cache1D);
		if (Lua_UnityEngine_Mesh.<>f__mg$cache1E == null)
		{
			Lua_UnityEngine_Mesh.<>f__mg$cache1E = new LuaCSFunction(Lua_UnityEngine_Mesh.RecalculateNormals);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Mesh.<>f__mg$cache1E);
		if (Lua_UnityEngine_Mesh.<>f__mg$cache1F == null)
		{
			Lua_UnityEngine_Mesh.<>f__mg$cache1F = new LuaCSFunction(Lua_UnityEngine_Mesh.RecalculateTangents);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Mesh.<>f__mg$cache1F);
		if (Lua_UnityEngine_Mesh.<>f__mg$cache20 == null)
		{
			Lua_UnityEngine_Mesh.<>f__mg$cache20 = new LuaCSFunction(Lua_UnityEngine_Mesh.MarkDynamic);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Mesh.<>f__mg$cache20);
		if (Lua_UnityEngine_Mesh.<>f__mg$cache21 == null)
		{
			Lua_UnityEngine_Mesh.<>f__mg$cache21 = new LuaCSFunction(Lua_UnityEngine_Mesh.UploadMeshData);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Mesh.<>f__mg$cache21);
		if (Lua_UnityEngine_Mesh.<>f__mg$cache22 == null)
		{
			Lua_UnityEngine_Mesh.<>f__mg$cache22 = new LuaCSFunction(Lua_UnityEngine_Mesh.GetTopology);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Mesh.<>f__mg$cache22);
		if (Lua_UnityEngine_Mesh.<>f__mg$cache23 == null)
		{
			Lua_UnityEngine_Mesh.<>f__mg$cache23 = new LuaCSFunction(Lua_UnityEngine_Mesh.CombineMeshes);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Mesh.<>f__mg$cache23);
		string name = "indexFormat";
		if (Lua_UnityEngine_Mesh.<>f__mg$cache24 == null)
		{
			Lua_UnityEngine_Mesh.<>f__mg$cache24 = new LuaCSFunction(Lua_UnityEngine_Mesh.get_indexFormat);
		}
		LuaCSFunction get = Lua_UnityEngine_Mesh.<>f__mg$cache24;
		if (Lua_UnityEngine_Mesh.<>f__mg$cache25 == null)
		{
			Lua_UnityEngine_Mesh.<>f__mg$cache25 = new LuaCSFunction(Lua_UnityEngine_Mesh.set_indexFormat);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_Mesh.<>f__mg$cache25, true);
		string name2 = "vertexBufferCount";
		if (Lua_UnityEngine_Mesh.<>f__mg$cache26 == null)
		{
			Lua_UnityEngine_Mesh.<>f__mg$cache26 = new LuaCSFunction(Lua_UnityEngine_Mesh.get_vertexBufferCount);
		}
		LuaObject.addMember(l, name2, Lua_UnityEngine_Mesh.<>f__mg$cache26, null, true);
		string name3 = "blendShapeCount";
		if (Lua_UnityEngine_Mesh.<>f__mg$cache27 == null)
		{
			Lua_UnityEngine_Mesh.<>f__mg$cache27 = new LuaCSFunction(Lua_UnityEngine_Mesh.get_blendShapeCount);
		}
		LuaObject.addMember(l, name3, Lua_UnityEngine_Mesh.<>f__mg$cache27, null, true);
		string name4 = "boneWeights";
		if (Lua_UnityEngine_Mesh.<>f__mg$cache28 == null)
		{
			Lua_UnityEngine_Mesh.<>f__mg$cache28 = new LuaCSFunction(Lua_UnityEngine_Mesh.get_boneWeights);
		}
		LuaCSFunction get2 = Lua_UnityEngine_Mesh.<>f__mg$cache28;
		if (Lua_UnityEngine_Mesh.<>f__mg$cache29 == null)
		{
			Lua_UnityEngine_Mesh.<>f__mg$cache29 = new LuaCSFunction(Lua_UnityEngine_Mesh.set_boneWeights);
		}
		LuaObject.addMember(l, name4, get2, Lua_UnityEngine_Mesh.<>f__mg$cache29, true);
		string name5 = "bindposes";
		if (Lua_UnityEngine_Mesh.<>f__mg$cache2A == null)
		{
			Lua_UnityEngine_Mesh.<>f__mg$cache2A = new LuaCSFunction(Lua_UnityEngine_Mesh.get_bindposes);
		}
		LuaCSFunction get3 = Lua_UnityEngine_Mesh.<>f__mg$cache2A;
		if (Lua_UnityEngine_Mesh.<>f__mg$cache2B == null)
		{
			Lua_UnityEngine_Mesh.<>f__mg$cache2B = new LuaCSFunction(Lua_UnityEngine_Mesh.set_bindposes);
		}
		LuaObject.addMember(l, name5, get3, Lua_UnityEngine_Mesh.<>f__mg$cache2B, true);
		string name6 = "isReadable";
		if (Lua_UnityEngine_Mesh.<>f__mg$cache2C == null)
		{
			Lua_UnityEngine_Mesh.<>f__mg$cache2C = new LuaCSFunction(Lua_UnityEngine_Mesh.get_isReadable);
		}
		LuaObject.addMember(l, name6, Lua_UnityEngine_Mesh.<>f__mg$cache2C, null, true);
		string name7 = "vertexCount";
		if (Lua_UnityEngine_Mesh.<>f__mg$cache2D == null)
		{
			Lua_UnityEngine_Mesh.<>f__mg$cache2D = new LuaCSFunction(Lua_UnityEngine_Mesh.get_vertexCount);
		}
		LuaObject.addMember(l, name7, Lua_UnityEngine_Mesh.<>f__mg$cache2D, null, true);
		string name8 = "subMeshCount";
		if (Lua_UnityEngine_Mesh.<>f__mg$cache2E == null)
		{
			Lua_UnityEngine_Mesh.<>f__mg$cache2E = new LuaCSFunction(Lua_UnityEngine_Mesh.get_subMeshCount);
		}
		LuaCSFunction get4 = Lua_UnityEngine_Mesh.<>f__mg$cache2E;
		if (Lua_UnityEngine_Mesh.<>f__mg$cache2F == null)
		{
			Lua_UnityEngine_Mesh.<>f__mg$cache2F = new LuaCSFunction(Lua_UnityEngine_Mesh.set_subMeshCount);
		}
		LuaObject.addMember(l, name8, get4, Lua_UnityEngine_Mesh.<>f__mg$cache2F, true);
		string name9 = "bounds";
		if (Lua_UnityEngine_Mesh.<>f__mg$cache30 == null)
		{
			Lua_UnityEngine_Mesh.<>f__mg$cache30 = new LuaCSFunction(Lua_UnityEngine_Mesh.get_bounds);
		}
		LuaCSFunction get5 = Lua_UnityEngine_Mesh.<>f__mg$cache30;
		if (Lua_UnityEngine_Mesh.<>f__mg$cache31 == null)
		{
			Lua_UnityEngine_Mesh.<>f__mg$cache31 = new LuaCSFunction(Lua_UnityEngine_Mesh.set_bounds);
		}
		LuaObject.addMember(l, name9, get5, Lua_UnityEngine_Mesh.<>f__mg$cache31, true);
		string name10 = "vertices";
		if (Lua_UnityEngine_Mesh.<>f__mg$cache32 == null)
		{
			Lua_UnityEngine_Mesh.<>f__mg$cache32 = new LuaCSFunction(Lua_UnityEngine_Mesh.get_vertices);
		}
		LuaCSFunction get6 = Lua_UnityEngine_Mesh.<>f__mg$cache32;
		if (Lua_UnityEngine_Mesh.<>f__mg$cache33 == null)
		{
			Lua_UnityEngine_Mesh.<>f__mg$cache33 = new LuaCSFunction(Lua_UnityEngine_Mesh.set_vertices);
		}
		LuaObject.addMember(l, name10, get6, Lua_UnityEngine_Mesh.<>f__mg$cache33, true);
		string name11 = "normals";
		if (Lua_UnityEngine_Mesh.<>f__mg$cache34 == null)
		{
			Lua_UnityEngine_Mesh.<>f__mg$cache34 = new LuaCSFunction(Lua_UnityEngine_Mesh.get_normals);
		}
		LuaCSFunction get7 = Lua_UnityEngine_Mesh.<>f__mg$cache34;
		if (Lua_UnityEngine_Mesh.<>f__mg$cache35 == null)
		{
			Lua_UnityEngine_Mesh.<>f__mg$cache35 = new LuaCSFunction(Lua_UnityEngine_Mesh.set_normals);
		}
		LuaObject.addMember(l, name11, get7, Lua_UnityEngine_Mesh.<>f__mg$cache35, true);
		string name12 = "tangents";
		if (Lua_UnityEngine_Mesh.<>f__mg$cache36 == null)
		{
			Lua_UnityEngine_Mesh.<>f__mg$cache36 = new LuaCSFunction(Lua_UnityEngine_Mesh.get_tangents);
		}
		LuaCSFunction get8 = Lua_UnityEngine_Mesh.<>f__mg$cache36;
		if (Lua_UnityEngine_Mesh.<>f__mg$cache37 == null)
		{
			Lua_UnityEngine_Mesh.<>f__mg$cache37 = new LuaCSFunction(Lua_UnityEngine_Mesh.set_tangents);
		}
		LuaObject.addMember(l, name12, get8, Lua_UnityEngine_Mesh.<>f__mg$cache37, true);
		string name13 = "uv";
		if (Lua_UnityEngine_Mesh.<>f__mg$cache38 == null)
		{
			Lua_UnityEngine_Mesh.<>f__mg$cache38 = new LuaCSFunction(Lua_UnityEngine_Mesh.get_uv);
		}
		LuaCSFunction get9 = Lua_UnityEngine_Mesh.<>f__mg$cache38;
		if (Lua_UnityEngine_Mesh.<>f__mg$cache39 == null)
		{
			Lua_UnityEngine_Mesh.<>f__mg$cache39 = new LuaCSFunction(Lua_UnityEngine_Mesh.set_uv);
		}
		LuaObject.addMember(l, name13, get9, Lua_UnityEngine_Mesh.<>f__mg$cache39, true);
		string name14 = "uv2";
		if (Lua_UnityEngine_Mesh.<>f__mg$cache3A == null)
		{
			Lua_UnityEngine_Mesh.<>f__mg$cache3A = new LuaCSFunction(Lua_UnityEngine_Mesh.get_uv2);
		}
		LuaCSFunction get10 = Lua_UnityEngine_Mesh.<>f__mg$cache3A;
		if (Lua_UnityEngine_Mesh.<>f__mg$cache3B == null)
		{
			Lua_UnityEngine_Mesh.<>f__mg$cache3B = new LuaCSFunction(Lua_UnityEngine_Mesh.set_uv2);
		}
		LuaObject.addMember(l, name14, get10, Lua_UnityEngine_Mesh.<>f__mg$cache3B, true);
		string name15 = "uv3";
		if (Lua_UnityEngine_Mesh.<>f__mg$cache3C == null)
		{
			Lua_UnityEngine_Mesh.<>f__mg$cache3C = new LuaCSFunction(Lua_UnityEngine_Mesh.get_uv3);
		}
		LuaCSFunction get11 = Lua_UnityEngine_Mesh.<>f__mg$cache3C;
		if (Lua_UnityEngine_Mesh.<>f__mg$cache3D == null)
		{
			Lua_UnityEngine_Mesh.<>f__mg$cache3D = new LuaCSFunction(Lua_UnityEngine_Mesh.set_uv3);
		}
		LuaObject.addMember(l, name15, get11, Lua_UnityEngine_Mesh.<>f__mg$cache3D, true);
		string name16 = "uv4";
		if (Lua_UnityEngine_Mesh.<>f__mg$cache3E == null)
		{
			Lua_UnityEngine_Mesh.<>f__mg$cache3E = new LuaCSFunction(Lua_UnityEngine_Mesh.get_uv4);
		}
		LuaCSFunction get12 = Lua_UnityEngine_Mesh.<>f__mg$cache3E;
		if (Lua_UnityEngine_Mesh.<>f__mg$cache3F == null)
		{
			Lua_UnityEngine_Mesh.<>f__mg$cache3F = new LuaCSFunction(Lua_UnityEngine_Mesh.set_uv4);
		}
		LuaObject.addMember(l, name16, get12, Lua_UnityEngine_Mesh.<>f__mg$cache3F, true);
		string name17 = "colors";
		if (Lua_UnityEngine_Mesh.<>f__mg$cache40 == null)
		{
			Lua_UnityEngine_Mesh.<>f__mg$cache40 = new LuaCSFunction(Lua_UnityEngine_Mesh.get_colors);
		}
		LuaCSFunction get13 = Lua_UnityEngine_Mesh.<>f__mg$cache40;
		if (Lua_UnityEngine_Mesh.<>f__mg$cache41 == null)
		{
			Lua_UnityEngine_Mesh.<>f__mg$cache41 = new LuaCSFunction(Lua_UnityEngine_Mesh.set_colors);
		}
		LuaObject.addMember(l, name17, get13, Lua_UnityEngine_Mesh.<>f__mg$cache41, true);
		string name18 = "colors32";
		if (Lua_UnityEngine_Mesh.<>f__mg$cache42 == null)
		{
			Lua_UnityEngine_Mesh.<>f__mg$cache42 = new LuaCSFunction(Lua_UnityEngine_Mesh.get_colors32);
		}
		LuaCSFunction get14 = Lua_UnityEngine_Mesh.<>f__mg$cache42;
		if (Lua_UnityEngine_Mesh.<>f__mg$cache43 == null)
		{
			Lua_UnityEngine_Mesh.<>f__mg$cache43 = new LuaCSFunction(Lua_UnityEngine_Mesh.set_colors32);
		}
		LuaObject.addMember(l, name18, get14, Lua_UnityEngine_Mesh.<>f__mg$cache43, true);
		string name19 = "triangles";
		if (Lua_UnityEngine_Mesh.<>f__mg$cache44 == null)
		{
			Lua_UnityEngine_Mesh.<>f__mg$cache44 = new LuaCSFunction(Lua_UnityEngine_Mesh.get_triangles);
		}
		LuaCSFunction get15 = Lua_UnityEngine_Mesh.<>f__mg$cache44;
		if (Lua_UnityEngine_Mesh.<>f__mg$cache45 == null)
		{
			Lua_UnityEngine_Mesh.<>f__mg$cache45 = new LuaCSFunction(Lua_UnityEngine_Mesh.set_triangles);
		}
		LuaObject.addMember(l, name19, get15, Lua_UnityEngine_Mesh.<>f__mg$cache45, true);
		if (Lua_UnityEngine_Mesh.<>f__mg$cache46 == null)
		{
			Lua_UnityEngine_Mesh.<>f__mg$cache46 = new LuaCSFunction(Lua_UnityEngine_Mesh.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_Mesh.<>f__mg$cache46, typeof(Mesh), typeof(UnityEngine.Object));
	}

	// Token: 0x0401944C RID: 103500
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401944D RID: 103501
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401944E RID: 103502
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0401944F RID: 103503
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019450 RID: 103504
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04019451 RID: 103505
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04019452 RID: 103506
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04019453 RID: 103507
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04019454 RID: 103508
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04019455 RID: 103509
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04019456 RID: 103510
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04019457 RID: 103511
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04019458 RID: 103512
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04019459 RID: 103513
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0401945A RID: 103514
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0401945B RID: 103515
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0401945C RID: 103516
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0401945D RID: 103517
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0401945E RID: 103518
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0401945F RID: 103519
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04019460 RID: 103520
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04019461 RID: 103521
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04019462 RID: 103522
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04019463 RID: 103523
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04019464 RID: 103524
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04019465 RID: 103525
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04019466 RID: 103526
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04019467 RID: 103527
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04019468 RID: 103528
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04019469 RID: 103529
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0401946A RID: 103530
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0401946B RID: 103531
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0401946C RID: 103532
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0401946D RID: 103533
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0401946E RID: 103534
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0401946F RID: 103535
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04019470 RID: 103536
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04019471 RID: 103537
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04019472 RID: 103538
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04019473 RID: 103539
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04019474 RID: 103540
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04019475 RID: 103541
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04019476 RID: 103542
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04019477 RID: 103543
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04019478 RID: 103544
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04019479 RID: 103545
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0401947A RID: 103546
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x0401947B RID: 103547
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x0401947C RID: 103548
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x0401947D RID: 103549
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x0401947E RID: 103550
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x0401947F RID: 103551
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04019480 RID: 103552
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04019481 RID: 103553
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04019482 RID: 103554
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04019483 RID: 103555
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04019484 RID: 103556
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04019485 RID: 103557
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x04019486 RID: 103558
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x04019487 RID: 103559
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x04019488 RID: 103560
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x04019489 RID: 103561
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x0401948A RID: 103562
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x0401948B RID: 103563
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x0401948C RID: 103564
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x0401948D RID: 103565
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x0401948E RID: 103566
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x0401948F RID: 103567
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x04019490 RID: 103568
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x04019491 RID: 103569
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x04019492 RID: 103570
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;
}
