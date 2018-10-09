using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x020017E0 RID: 6112
[Preserve]
public class Lua_UnityEngine_Sprite : LuaObject
{
	// Token: 0x06023D8E RID: 146830 RVA: 0x00C906B8 File Offset: 0x00C8E8B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			Sprite o = new Sprite();
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

	// Token: 0x06023D8F RID: 146831 RVA: 0x00C90700 File Offset: 0x00C8E900
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OverrideGeometry(IntPtr l)
	{
		int result;
		try
		{
			Sprite sprite = (Sprite)LuaObject.checkSelf(l);
			Vector2[] vertices;
			LuaObject.checkArray<Vector2>(l, 2, out vertices);
			ushort[] triangles;
			LuaObject.checkArray<ushort>(l, 3, out triangles);
			sprite.OverrideGeometry(vertices, triangles);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D90 RID: 146832 RVA: 0x00C90764 File Offset: 0x00C8E964
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetPhysicsShapeCount(IntPtr l)
	{
		int result;
		try
		{
			Sprite sprite = (Sprite)LuaObject.checkSelf(l);
			int physicsShapeCount = sprite.GetPhysicsShapeCount();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, physicsShapeCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D91 RID: 146833 RVA: 0x00C907B8 File Offset: 0x00C8E9B8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetPhysicsShapePointCount(IntPtr l)
	{
		int result;
		try
		{
			Sprite sprite = (Sprite)LuaObject.checkSelf(l);
			int shapeIdx;
			LuaObject.checkType(l, 2, out shapeIdx);
			int physicsShapePointCount = sprite.GetPhysicsShapePointCount(shapeIdx);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, physicsShapePointCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D92 RID: 146834 RVA: 0x00C9081C File Offset: 0x00C8EA1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetPhysicsShape(IntPtr l)
	{
		int result;
		try
		{
			Sprite sprite = (Sprite)LuaObject.checkSelf(l);
			int shapeIdx;
			LuaObject.checkType(l, 2, out shapeIdx);
			List<Vector2> physicsShape;
			LuaObject.checkType<List<Vector2>>(l, 3, out physicsShape);
			int physicsShape2 = sprite.GetPhysicsShape(shapeIdx, physicsShape);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, physicsShape2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D93 RID: 146835 RVA: 0x00C9088C File Offset: 0x00C8EA8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OverridePhysicsShape(IntPtr l)
	{
		int result;
		try
		{
			Sprite sprite = (Sprite)LuaObject.checkSelf(l);
			IList<Vector2[]> physicsShapes;
			LuaObject.checkType<IList<Vector2[]>>(l, 2, out physicsShapes);
			sprite.OverridePhysicsShape(physicsShapes);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D94 RID: 146836 RVA: 0x00C908E4 File Offset: 0x00C8EAE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Create_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 3)
			{
				Texture2D texture;
				LuaObject.checkType<Texture2D>(l, 1, out texture);
				Rect rect;
				LuaObject.checkValueType<Rect>(l, 2, out rect);
				Vector2 pivot;
				LuaObject.checkType(l, 3, out pivot);
				Sprite o = Sprite.Create(texture, rect, pivot);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (num == 4)
			{
				Texture2D texture2;
				LuaObject.checkType<Texture2D>(l, 1, out texture2);
				Rect rect2;
				LuaObject.checkValueType<Rect>(l, 2, out rect2);
				Vector2 pivot2;
				LuaObject.checkType(l, 3, out pivot2);
				float pixelsPerUnit;
				LuaObject.checkType(l, 4, out pixelsPerUnit);
				Sprite o2 = Sprite.Create(texture2, rect2, pivot2, pixelsPerUnit);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o2);
				result = 2;
			}
			else if (num == 5)
			{
				Texture2D texture3;
				LuaObject.checkType<Texture2D>(l, 1, out texture3);
				Rect rect3;
				LuaObject.checkValueType<Rect>(l, 2, out rect3);
				Vector2 pivot3;
				LuaObject.checkType(l, 3, out pivot3);
				float pixelsPerUnit2;
				LuaObject.checkType(l, 4, out pixelsPerUnit2);
				uint extrude;
				LuaObject.checkType(l, 5, out extrude);
				Sprite o3 = Sprite.Create(texture3, rect3, pivot3, pixelsPerUnit2, extrude);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o3);
				result = 2;
			}
			else if (num == 6)
			{
				Texture2D texture4;
				LuaObject.checkType<Texture2D>(l, 1, out texture4);
				Rect rect4;
				LuaObject.checkValueType<Rect>(l, 2, out rect4);
				Vector2 pivot4;
				LuaObject.checkType(l, 3, out pivot4);
				float pixelsPerUnit3;
				LuaObject.checkType(l, 4, out pixelsPerUnit3);
				uint extrude2;
				LuaObject.checkType(l, 5, out extrude2);
				SpriteMeshType meshType;
				LuaObject.checkEnum<SpriteMeshType>(l, 6, out meshType);
				Sprite o4 = Sprite.Create(texture4, rect4, pivot4, pixelsPerUnit3, extrude2, meshType);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o4);
				result = 2;
			}
			else if (num == 7)
			{
				Texture2D texture5;
				LuaObject.checkType<Texture2D>(l, 1, out texture5);
				Rect rect5;
				LuaObject.checkValueType<Rect>(l, 2, out rect5);
				Vector2 pivot5;
				LuaObject.checkType(l, 3, out pivot5);
				float pixelsPerUnit4;
				LuaObject.checkType(l, 4, out pixelsPerUnit4);
				uint extrude3;
				LuaObject.checkType(l, 5, out extrude3);
				SpriteMeshType meshType2;
				LuaObject.checkEnum<SpriteMeshType>(l, 6, out meshType2);
				Vector4 border;
				LuaObject.checkType(l, 7, out border);
				Sprite o5 = Sprite.Create(texture5, rect5, pivot5, pixelsPerUnit4, extrude3, meshType2, border);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o5);
				result = 2;
			}
			else if (num == 8)
			{
				Texture2D texture6;
				LuaObject.checkType<Texture2D>(l, 1, out texture6);
				Rect rect6;
				LuaObject.checkValueType<Rect>(l, 2, out rect6);
				Vector2 pivot6;
				LuaObject.checkType(l, 3, out pivot6);
				float pixelsPerUnit5;
				LuaObject.checkType(l, 4, out pixelsPerUnit5);
				uint extrude4;
				LuaObject.checkType(l, 5, out extrude4);
				SpriteMeshType meshType3;
				LuaObject.checkEnum<SpriteMeshType>(l, 6, out meshType3);
				Vector4 border2;
				LuaObject.checkType(l, 7, out border2);
				bool generateFallbackPhysicsShape;
				LuaObject.checkType(l, 8, out generateFallbackPhysicsShape);
				Sprite o6 = Sprite.Create(texture6, rect6, pivot6, pixelsPerUnit5, extrude4, meshType3, border2, generateFallbackPhysicsShape);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o6);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function Create to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D95 RID: 146837 RVA: 0x00C90BA8 File Offset: 0x00C8EDA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_bounds(IntPtr l)
	{
		int result;
		try
		{
			Sprite sprite = (Sprite)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, sprite.bounds);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D96 RID: 146838 RVA: 0x00C90C00 File Offset: 0x00C8EE00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_rect(IntPtr l)
	{
		int result;
		try
		{
			Sprite sprite = (Sprite)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, sprite.rect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D97 RID: 146839 RVA: 0x00C90C58 File Offset: 0x00C8EE58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_texture(IntPtr l)
	{
		int result;
		try
		{
			Sprite sprite = (Sprite)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, sprite.texture);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D98 RID: 146840 RVA: 0x00C90CAC File Offset: 0x00C8EEAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_associatedAlphaSplitTexture(IntPtr l)
	{
		int result;
		try
		{
			Sprite sprite = (Sprite)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, sprite.associatedAlphaSplitTexture);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D99 RID: 146841 RVA: 0x00C90D00 File Offset: 0x00C8EF00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_textureRect(IntPtr l)
	{
		int result;
		try
		{
			Sprite sprite = (Sprite)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, sprite.textureRect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D9A RID: 146842 RVA: 0x00C90D58 File Offset: 0x00C8EF58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_textureRectOffset(IntPtr l)
	{
		int result;
		try
		{
			Sprite sprite = (Sprite)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, sprite.textureRectOffset);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D9B RID: 146843 RVA: 0x00C90DAC File Offset: 0x00C8EFAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_packed(IntPtr l)
	{
		int result;
		try
		{
			Sprite sprite = (Sprite)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, sprite.packed);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D9C RID: 146844 RVA: 0x00C90E00 File Offset: 0x00C8F000
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_packingMode(IntPtr l)
	{
		int result;
		try
		{
			Sprite sprite = (Sprite)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)sprite.packingMode);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D9D RID: 146845 RVA: 0x00C90E54 File Offset: 0x00C8F054
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_packingRotation(IntPtr l)
	{
		int result;
		try
		{
			Sprite sprite = (Sprite)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)sprite.packingRotation);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D9E RID: 146846 RVA: 0x00C90EA8 File Offset: 0x00C8F0A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_pivot(IntPtr l)
	{
		int result;
		try
		{
			Sprite sprite = (Sprite)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, sprite.pivot);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D9F RID: 146847 RVA: 0x00C90EFC File Offset: 0x00C8F0FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_border(IntPtr l)
	{
		int result;
		try
		{
			Sprite sprite = (Sprite)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, sprite.border);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023DA0 RID: 146848 RVA: 0x00C90F50 File Offset: 0x00C8F150
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_vertices(IntPtr l)
	{
		int result;
		try
		{
			Sprite sprite = (Sprite)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, sprite.vertices);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023DA1 RID: 146849 RVA: 0x00C90FA4 File Offset: 0x00C8F1A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_triangles(IntPtr l)
	{
		int result;
		try
		{
			Sprite sprite = (Sprite)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, sprite.triangles);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023DA2 RID: 146850 RVA: 0x00C90FF8 File Offset: 0x00C8F1F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_uv(IntPtr l)
	{
		int result;
		try
		{
			Sprite sprite = (Sprite)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, sprite.uv);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023DA3 RID: 146851 RVA: 0x00C9104C File Offset: 0x00C8F24C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_pixelsPerUnit(IntPtr l)
	{
		int result;
		try
		{
			Sprite sprite = (Sprite)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, sprite.pixelsPerUnit);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023DA4 RID: 146852 RVA: 0x00C910A0 File Offset: 0x00C8F2A0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Sprite");
		if (Lua_UnityEngine_Sprite.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_Sprite.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_Sprite.OverrideGeometry);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Sprite.<>f__mg$cache0);
		if (Lua_UnityEngine_Sprite.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_Sprite.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_Sprite.GetPhysicsShapeCount);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Sprite.<>f__mg$cache1);
		if (Lua_UnityEngine_Sprite.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_Sprite.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_Sprite.GetPhysicsShapePointCount);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Sprite.<>f__mg$cache2);
		if (Lua_UnityEngine_Sprite.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_Sprite.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_Sprite.GetPhysicsShape);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Sprite.<>f__mg$cache3);
		if (Lua_UnityEngine_Sprite.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_Sprite.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_Sprite.OverridePhysicsShape);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Sprite.<>f__mg$cache4);
		if (Lua_UnityEngine_Sprite.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_Sprite.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_Sprite.Create_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Sprite.<>f__mg$cache5);
		string name = "bounds";
		if (Lua_UnityEngine_Sprite.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_Sprite.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_Sprite.get_bounds);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_Sprite.<>f__mg$cache6, null, true);
		string name2 = "rect";
		if (Lua_UnityEngine_Sprite.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_Sprite.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_Sprite.get_rect);
		}
		LuaObject.addMember(l, name2, Lua_UnityEngine_Sprite.<>f__mg$cache7, null, true);
		string name3 = "texture";
		if (Lua_UnityEngine_Sprite.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_Sprite.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_Sprite.get_texture);
		}
		LuaObject.addMember(l, name3, Lua_UnityEngine_Sprite.<>f__mg$cache8, null, true);
		string name4 = "associatedAlphaSplitTexture";
		if (Lua_UnityEngine_Sprite.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_Sprite.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_Sprite.get_associatedAlphaSplitTexture);
		}
		LuaObject.addMember(l, name4, Lua_UnityEngine_Sprite.<>f__mg$cache9, null, true);
		string name5 = "textureRect";
		if (Lua_UnityEngine_Sprite.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_Sprite.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_Sprite.get_textureRect);
		}
		LuaObject.addMember(l, name5, Lua_UnityEngine_Sprite.<>f__mg$cacheA, null, true);
		string name6 = "textureRectOffset";
		if (Lua_UnityEngine_Sprite.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_Sprite.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_Sprite.get_textureRectOffset);
		}
		LuaObject.addMember(l, name6, Lua_UnityEngine_Sprite.<>f__mg$cacheB, null, true);
		string name7 = "packed";
		if (Lua_UnityEngine_Sprite.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_Sprite.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_Sprite.get_packed);
		}
		LuaObject.addMember(l, name7, Lua_UnityEngine_Sprite.<>f__mg$cacheC, null, true);
		string name8 = "packingMode";
		if (Lua_UnityEngine_Sprite.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_Sprite.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_Sprite.get_packingMode);
		}
		LuaObject.addMember(l, name8, Lua_UnityEngine_Sprite.<>f__mg$cacheD, null, true);
		string name9 = "packingRotation";
		if (Lua_UnityEngine_Sprite.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_Sprite.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_Sprite.get_packingRotation);
		}
		LuaObject.addMember(l, name9, Lua_UnityEngine_Sprite.<>f__mg$cacheE, null, true);
		string name10 = "pivot";
		if (Lua_UnityEngine_Sprite.<>f__mg$cacheF == null)
		{
			Lua_UnityEngine_Sprite.<>f__mg$cacheF = new LuaCSFunction(Lua_UnityEngine_Sprite.get_pivot);
		}
		LuaObject.addMember(l, name10, Lua_UnityEngine_Sprite.<>f__mg$cacheF, null, true);
		string name11 = "border";
		if (Lua_UnityEngine_Sprite.<>f__mg$cache10 == null)
		{
			Lua_UnityEngine_Sprite.<>f__mg$cache10 = new LuaCSFunction(Lua_UnityEngine_Sprite.get_border);
		}
		LuaObject.addMember(l, name11, Lua_UnityEngine_Sprite.<>f__mg$cache10, null, true);
		string name12 = "vertices";
		if (Lua_UnityEngine_Sprite.<>f__mg$cache11 == null)
		{
			Lua_UnityEngine_Sprite.<>f__mg$cache11 = new LuaCSFunction(Lua_UnityEngine_Sprite.get_vertices);
		}
		LuaObject.addMember(l, name12, Lua_UnityEngine_Sprite.<>f__mg$cache11, null, true);
		string name13 = "triangles";
		if (Lua_UnityEngine_Sprite.<>f__mg$cache12 == null)
		{
			Lua_UnityEngine_Sprite.<>f__mg$cache12 = new LuaCSFunction(Lua_UnityEngine_Sprite.get_triangles);
		}
		LuaObject.addMember(l, name13, Lua_UnityEngine_Sprite.<>f__mg$cache12, null, true);
		string name14 = "uv";
		if (Lua_UnityEngine_Sprite.<>f__mg$cache13 == null)
		{
			Lua_UnityEngine_Sprite.<>f__mg$cache13 = new LuaCSFunction(Lua_UnityEngine_Sprite.get_uv);
		}
		LuaObject.addMember(l, name14, Lua_UnityEngine_Sprite.<>f__mg$cache13, null, true);
		string name15 = "pixelsPerUnit";
		if (Lua_UnityEngine_Sprite.<>f__mg$cache14 == null)
		{
			Lua_UnityEngine_Sprite.<>f__mg$cache14 = new LuaCSFunction(Lua_UnityEngine_Sprite.get_pixelsPerUnit);
		}
		LuaObject.addMember(l, name15, Lua_UnityEngine_Sprite.<>f__mg$cache14, null, true);
		if (Lua_UnityEngine_Sprite.<>f__mg$cache15 == null)
		{
			Lua_UnityEngine_Sprite.<>f__mg$cache15 = new LuaCSFunction(Lua_UnityEngine_Sprite.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_Sprite.<>f__mg$cache15, typeof(Sprite), typeof(UnityEngine.Object));
	}

	// Token: 0x04019A2C RID: 105004
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019A2D RID: 105005
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019A2E RID: 105006
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019A2F RID: 105007
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019A30 RID: 105008
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04019A31 RID: 105009
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04019A32 RID: 105010
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04019A33 RID: 105011
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04019A34 RID: 105012
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04019A35 RID: 105013
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04019A36 RID: 105014
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04019A37 RID: 105015
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04019A38 RID: 105016
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04019A39 RID: 105017
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04019A3A RID: 105018
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04019A3B RID: 105019
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04019A3C RID: 105020
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04019A3D RID: 105021
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04019A3E RID: 105022
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04019A3F RID: 105023
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04019A40 RID: 105024
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04019A41 RID: 105025
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;
}
