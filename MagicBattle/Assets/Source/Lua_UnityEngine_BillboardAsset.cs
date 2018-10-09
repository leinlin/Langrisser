using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x0200163F RID: 5695
[Preserve]
public class Lua_UnityEngine_BillboardAsset : LuaObject
{
	// Token: 0x06022C40 RID: 142400 RVA: 0x00C00BB4 File Offset: 0x00BFEDB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			BillboardAsset o = new BillboardAsset();
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

	// Token: 0x06022C41 RID: 142401 RVA: 0x00C00BFC File Offset: 0x00BFEDFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetImageTexCoords(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				BillboardAsset billboardAsset = (BillboardAsset)LuaObject.checkSelf(l);
				List<Vector4> imageTexCoords;
				LuaObject.checkType<List<Vector4>>(l, 2, out imageTexCoords);
				billboardAsset.GetImageTexCoords(imageTexCoords);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 1)
			{
				BillboardAsset billboardAsset2 = (BillboardAsset)LuaObject.checkSelf(l);
				Vector4[] imageTexCoords2 = billboardAsset2.GetImageTexCoords();
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, imageTexCoords2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function GetImageTexCoords to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022C42 RID: 142402 RVA: 0x00C00CB0 File Offset: 0x00BFEEB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetImageTexCoords(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(List<Vector4>)))
			{
				BillboardAsset billboardAsset = (BillboardAsset)LuaObject.checkSelf(l);
				List<Vector4> imageTexCoords;
				LuaObject.checkType<List<Vector4>>(l, 2, out imageTexCoords);
				billboardAsset.SetImageTexCoords(imageTexCoords);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(Vector4[])))
			{
				BillboardAsset billboardAsset2 = (BillboardAsset)LuaObject.checkSelf(l);
				Vector4[] imageTexCoords2;
				LuaObject.checkArray<Vector4>(l, 2, out imageTexCoords2);
				billboardAsset2.SetImageTexCoords(imageTexCoords2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function SetImageTexCoords to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022C43 RID: 142403 RVA: 0x00C00D88 File Offset: 0x00BFEF88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetVertices(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				BillboardAsset billboardAsset = (BillboardAsset)LuaObject.checkSelf(l);
				List<Vector2> vertices;
				LuaObject.checkType<List<Vector2>>(l, 2, out vertices);
				billboardAsset.GetVertices(vertices);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 1)
			{
				BillboardAsset billboardAsset2 = (BillboardAsset)LuaObject.checkSelf(l);
				Vector2[] vertices2 = billboardAsset2.GetVertices();
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, vertices2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function GetVertices to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022C44 RID: 142404 RVA: 0x00C00E3C File Offset: 0x00BFF03C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetVertices(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(List<Vector2>)))
			{
				BillboardAsset billboardAsset = (BillboardAsset)LuaObject.checkSelf(l);
				List<Vector2> vertices;
				LuaObject.checkType<List<Vector2>>(l, 2, out vertices);
				billboardAsset.SetVertices(vertices);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(Vector2[])))
			{
				BillboardAsset billboardAsset2 = (BillboardAsset)LuaObject.checkSelf(l);
				Vector2[] vertices2;
				LuaObject.checkArray<Vector2>(l, 2, out vertices2);
				billboardAsset2.SetVertices(vertices2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function SetVertices to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022C45 RID: 142405 RVA: 0x00C00F14 File Offset: 0x00BFF114
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
				BillboardAsset billboardAsset = (BillboardAsset)LuaObject.checkSelf(l);
				List<ushort> indices;
				LuaObject.checkType<List<ushort>>(l, 2, out indices);
				billboardAsset.GetIndices(indices);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 1)
			{
				BillboardAsset billboardAsset2 = (BillboardAsset)LuaObject.checkSelf(l);
				ushort[] indices2 = billboardAsset2.GetIndices();
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, indices2);
				result = 2;
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

	// Token: 0x06022C46 RID: 142406 RVA: 0x00C00FC8 File Offset: 0x00BFF1C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetIndices(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(List<ushort>)))
			{
				BillboardAsset billboardAsset = (BillboardAsset)LuaObject.checkSelf(l);
				List<ushort> indices;
				LuaObject.checkType<List<ushort>>(l, 2, out indices);
				billboardAsset.SetIndices(indices);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(ushort[])))
			{
				BillboardAsset billboardAsset2 = (BillboardAsset)LuaObject.checkSelf(l);
				ushort[] indices2;
				LuaObject.checkArray<ushort>(l, 2, out indices2);
				billboardAsset2.SetIndices(indices2);
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

	// Token: 0x06022C47 RID: 142407 RVA: 0x00C010A0 File Offset: 0x00BFF2A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_width(IntPtr l)
	{
		int result;
		try
		{
			BillboardAsset billboardAsset = (BillboardAsset)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, billboardAsset.width);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022C48 RID: 142408 RVA: 0x00C010F4 File Offset: 0x00BFF2F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_width(IntPtr l)
	{
		int result;
		try
		{
			BillboardAsset billboardAsset = (BillboardAsset)LuaObject.checkSelf(l);
			float width;
			LuaObject.checkType(l, 2, out width);
			billboardAsset.width = width;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022C49 RID: 142409 RVA: 0x00C0114C File Offset: 0x00BFF34C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_height(IntPtr l)
	{
		int result;
		try
		{
			BillboardAsset billboardAsset = (BillboardAsset)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, billboardAsset.height);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022C4A RID: 142410 RVA: 0x00C011A0 File Offset: 0x00BFF3A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_height(IntPtr l)
	{
		int result;
		try
		{
			BillboardAsset billboardAsset = (BillboardAsset)LuaObject.checkSelf(l);
			float height;
			LuaObject.checkType(l, 2, out height);
			billboardAsset.height = height;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022C4B RID: 142411 RVA: 0x00C011F8 File Offset: 0x00BFF3F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_bottom(IntPtr l)
	{
		int result;
		try
		{
			BillboardAsset billboardAsset = (BillboardAsset)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, billboardAsset.bottom);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022C4C RID: 142412 RVA: 0x00C0124C File Offset: 0x00BFF44C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_bottom(IntPtr l)
	{
		int result;
		try
		{
			BillboardAsset billboardAsset = (BillboardAsset)LuaObject.checkSelf(l);
			float bottom;
			LuaObject.checkType(l, 2, out bottom);
			billboardAsset.bottom = bottom;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022C4D RID: 142413 RVA: 0x00C012A4 File Offset: 0x00BFF4A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_imageCount(IntPtr l)
	{
		int result;
		try
		{
			BillboardAsset billboardAsset = (BillboardAsset)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, billboardAsset.imageCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022C4E RID: 142414 RVA: 0x00C012F8 File Offset: 0x00BFF4F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_vertexCount(IntPtr l)
	{
		int result;
		try
		{
			BillboardAsset billboardAsset = (BillboardAsset)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, billboardAsset.vertexCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022C4F RID: 142415 RVA: 0x00C0134C File Offset: 0x00BFF54C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_indexCount(IntPtr l)
	{
		int result;
		try
		{
			BillboardAsset billboardAsset = (BillboardAsset)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, billboardAsset.indexCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022C50 RID: 142416 RVA: 0x00C013A0 File Offset: 0x00BFF5A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_material(IntPtr l)
	{
		int result;
		try
		{
			BillboardAsset billboardAsset = (BillboardAsset)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, billboardAsset.material);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022C51 RID: 142417 RVA: 0x00C013F4 File Offset: 0x00BFF5F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_material(IntPtr l)
	{
		int result;
		try
		{
			BillboardAsset billboardAsset = (BillboardAsset)LuaObject.checkSelf(l);
			Material material;
			LuaObject.checkType<Material>(l, 2, out material);
			billboardAsset.material = material;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022C52 RID: 142418 RVA: 0x00C0144C File Offset: 0x00BFF64C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.BillboardAsset");
		if (Lua_UnityEngine_BillboardAsset.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_BillboardAsset.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_BillboardAsset.GetImageTexCoords);
		}
		LuaObject.addMember(l, Lua_UnityEngine_BillboardAsset.<>f__mg$cache0);
		if (Lua_UnityEngine_BillboardAsset.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_BillboardAsset.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_BillboardAsset.SetImageTexCoords);
		}
		LuaObject.addMember(l, Lua_UnityEngine_BillboardAsset.<>f__mg$cache1);
		if (Lua_UnityEngine_BillboardAsset.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_BillboardAsset.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_BillboardAsset.GetVertices);
		}
		LuaObject.addMember(l, Lua_UnityEngine_BillboardAsset.<>f__mg$cache2);
		if (Lua_UnityEngine_BillboardAsset.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_BillboardAsset.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_BillboardAsset.SetVertices);
		}
		LuaObject.addMember(l, Lua_UnityEngine_BillboardAsset.<>f__mg$cache3);
		if (Lua_UnityEngine_BillboardAsset.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_BillboardAsset.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_BillboardAsset.GetIndices);
		}
		LuaObject.addMember(l, Lua_UnityEngine_BillboardAsset.<>f__mg$cache4);
		if (Lua_UnityEngine_BillboardAsset.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_BillboardAsset.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_BillboardAsset.SetIndices);
		}
		LuaObject.addMember(l, Lua_UnityEngine_BillboardAsset.<>f__mg$cache5);
		string name = "width";
		if (Lua_UnityEngine_BillboardAsset.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_BillboardAsset.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_BillboardAsset.get_width);
		}
		LuaCSFunction get = Lua_UnityEngine_BillboardAsset.<>f__mg$cache6;
		if (Lua_UnityEngine_BillboardAsset.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_BillboardAsset.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_BillboardAsset.set_width);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_BillboardAsset.<>f__mg$cache7, true);
		string name2 = "height";
		if (Lua_UnityEngine_BillboardAsset.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_BillboardAsset.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_BillboardAsset.get_height);
		}
		LuaCSFunction get2 = Lua_UnityEngine_BillboardAsset.<>f__mg$cache8;
		if (Lua_UnityEngine_BillboardAsset.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_BillboardAsset.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_BillboardAsset.set_height);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_BillboardAsset.<>f__mg$cache9, true);
		string name3 = "bottom";
		if (Lua_UnityEngine_BillboardAsset.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_BillboardAsset.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_BillboardAsset.get_bottom);
		}
		LuaCSFunction get3 = Lua_UnityEngine_BillboardAsset.<>f__mg$cacheA;
		if (Lua_UnityEngine_BillboardAsset.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_BillboardAsset.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_BillboardAsset.set_bottom);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_BillboardAsset.<>f__mg$cacheB, true);
		string name4 = "imageCount";
		if (Lua_UnityEngine_BillboardAsset.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_BillboardAsset.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_BillboardAsset.get_imageCount);
		}
		LuaObject.addMember(l, name4, Lua_UnityEngine_BillboardAsset.<>f__mg$cacheC, null, true);
		string name5 = "vertexCount";
		if (Lua_UnityEngine_BillboardAsset.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_BillboardAsset.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_BillboardAsset.get_vertexCount);
		}
		LuaObject.addMember(l, name5, Lua_UnityEngine_BillboardAsset.<>f__mg$cacheD, null, true);
		string name6 = "indexCount";
		if (Lua_UnityEngine_BillboardAsset.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_BillboardAsset.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_BillboardAsset.get_indexCount);
		}
		LuaObject.addMember(l, name6, Lua_UnityEngine_BillboardAsset.<>f__mg$cacheE, null, true);
		string name7 = "material";
		if (Lua_UnityEngine_BillboardAsset.<>f__mg$cacheF == null)
		{
			Lua_UnityEngine_BillboardAsset.<>f__mg$cacheF = new LuaCSFunction(Lua_UnityEngine_BillboardAsset.get_material);
		}
		LuaCSFunction get4 = Lua_UnityEngine_BillboardAsset.<>f__mg$cacheF;
		if (Lua_UnityEngine_BillboardAsset.<>f__mg$cache10 == null)
		{
			Lua_UnityEngine_BillboardAsset.<>f__mg$cache10 = new LuaCSFunction(Lua_UnityEngine_BillboardAsset.set_material);
		}
		LuaObject.addMember(l, name7, get4, Lua_UnityEngine_BillboardAsset.<>f__mg$cache10, true);
		if (Lua_UnityEngine_BillboardAsset.<>f__mg$cache11 == null)
		{
			Lua_UnityEngine_BillboardAsset.<>f__mg$cache11 = new LuaCSFunction(Lua_UnityEngine_BillboardAsset.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_BillboardAsset.<>f__mg$cache11, typeof(BillboardAsset), typeof(UnityEngine.Object));
	}

	// Token: 0x04018C20 RID: 101408
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04018C21 RID: 101409
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04018C22 RID: 101410
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04018C23 RID: 101411
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04018C24 RID: 101412
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04018C25 RID: 101413
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04018C26 RID: 101414
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04018C27 RID: 101415
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04018C28 RID: 101416
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04018C29 RID: 101417
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04018C2A RID: 101418
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04018C2B RID: 101419
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04018C2C RID: 101420
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04018C2D RID: 101421
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04018C2E RID: 101422
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04018C2F RID: 101423
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04018C30 RID: 101424
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04018C31 RID: 101425
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;
}
