using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x0200167B RID: 5755
[Preserve]
public class Lua_UnityEngine_Cubemap : LuaObject
{
	// Token: 0x06022FDC RID: 143324 RVA: 0x00C1CAA0 File Offset: 0x00C1ACA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int size;
			LuaObject.checkType(l, 2, out size);
			TextureFormat format;
			LuaObject.checkEnum<TextureFormat>(l, 3, out format);
			bool mipmap;
			LuaObject.checkType(l, 4, out mipmap);
			Cubemap o = new Cubemap(size, format, mipmap);
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

	// Token: 0x06022FDD RID: 143325 RVA: 0x00C1CB10 File Offset: 0x00C1AD10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetPixel(IntPtr l)
	{
		int result;
		try
		{
			Cubemap cubemap = (Cubemap)LuaObject.checkSelf(l);
			CubemapFace face;
			LuaObject.checkEnum<CubemapFace>(l, 2, out face);
			int x;
			LuaObject.checkType(l, 3, out x);
			int y;
			LuaObject.checkType(l, 4, out y);
			Color color;
			LuaObject.checkType(l, 5, out color);
			cubemap.SetPixel(face, x, y, color);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022FDE RID: 143326 RVA: 0x00C1CB90 File Offset: 0x00C1AD90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetPixel(IntPtr l)
	{
		int result;
		try
		{
			Cubemap cubemap = (Cubemap)LuaObject.checkSelf(l);
			CubemapFace face;
			LuaObject.checkEnum<CubemapFace>(l, 2, out face);
			int x;
			LuaObject.checkType(l, 3, out x);
			int y;
			LuaObject.checkType(l, 4, out y);
			Color pixel = cubemap.GetPixel(face, x, y);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, pixel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022FDF RID: 143327 RVA: 0x00C1CC0C File Offset: 0x00C1AE0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetPixels(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				Cubemap cubemap = (Cubemap)LuaObject.checkSelf(l);
				CubemapFace face;
				LuaObject.checkEnum<CubemapFace>(l, 2, out face);
				Color[] pixels = cubemap.GetPixels(face);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, pixels);
				result = 2;
			}
			else if (num == 3)
			{
				Cubemap cubemap2 = (Cubemap)LuaObject.checkSelf(l);
				CubemapFace face2;
				LuaObject.checkEnum<CubemapFace>(l, 2, out face2);
				int miplevel;
				LuaObject.checkType(l, 3, out miplevel);
				Color[] pixels2 = cubemap2.GetPixels(face2, miplevel);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, pixels2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function GetPixels to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022FE0 RID: 143328 RVA: 0x00C1CCE4 File Offset: 0x00C1AEE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetPixels(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 3)
			{
				Cubemap cubemap = (Cubemap)LuaObject.checkSelf(l);
				Color[] colors;
				LuaObject.checkArray<Color>(l, 2, out colors);
				CubemapFace face;
				LuaObject.checkEnum<CubemapFace>(l, 3, out face);
				cubemap.SetPixels(colors, face);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 4)
			{
				Cubemap cubemap2 = (Cubemap)LuaObject.checkSelf(l);
				Color[] colors2;
				LuaObject.checkArray<Color>(l, 2, out colors2);
				CubemapFace face2;
				LuaObject.checkEnum<CubemapFace>(l, 3, out face2);
				int miplevel;
				LuaObject.checkType(l, 4, out miplevel);
				cubemap2.SetPixels(colors2, face2, miplevel);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function SetPixels to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022FE1 RID: 143329 RVA: 0x00C1CDC4 File Offset: 0x00C1AFC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Apply(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 1)
			{
				Cubemap cubemap = (Cubemap)LuaObject.checkSelf(l);
				cubemap.Apply();
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 2)
			{
				Cubemap cubemap2 = (Cubemap)LuaObject.checkSelf(l);
				bool updateMipmaps;
				LuaObject.checkType(l, 2, out updateMipmaps);
				cubemap2.Apply(updateMipmaps);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 3)
			{
				Cubemap cubemap3 = (Cubemap)LuaObject.checkSelf(l);
				bool updateMipmaps2;
				LuaObject.checkType(l, 2, out updateMipmaps2);
				bool makeNoLongerReadable;
				LuaObject.checkType(l, 3, out makeNoLongerReadable);
				cubemap3.Apply(updateMipmaps2, makeNoLongerReadable);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function Apply to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022FE2 RID: 143330 RVA: 0x00C1CEB0 File Offset: 0x00C1B0B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SmoothEdges(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				Cubemap cubemap = (Cubemap)LuaObject.checkSelf(l);
				int smoothRegionWidthInPixels;
				LuaObject.checkType(l, 2, out smoothRegionWidthInPixels);
				cubemap.SmoothEdges(smoothRegionWidthInPixels);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 1)
			{
				Cubemap cubemap2 = (Cubemap)LuaObject.checkSelf(l);
				cubemap2.SmoothEdges();
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function SmoothEdges to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022FE3 RID: 143331 RVA: 0x00C1CF5C File Offset: 0x00C1B15C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateExternalTexture_s(IntPtr l)
	{
		int result;
		try
		{
			int size;
			LuaObject.checkType(l, 1, out size);
			TextureFormat format;
			LuaObject.checkEnum<TextureFormat>(l, 2, out format);
			bool mipmap;
			LuaObject.checkType(l, 3, out mipmap);
			IntPtr nativeTex;
			LuaObject.checkType(l, 4, out nativeTex);
			Cubemap o = Cubemap.CreateExternalTexture(size, format, mipmap, nativeTex);
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

	// Token: 0x06022FE4 RID: 143332 RVA: 0x00C1CFD8 File Offset: 0x00C1B1D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_mipmapCount(IntPtr l)
	{
		int result;
		try
		{
			Cubemap cubemap = (Cubemap)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cubemap.mipmapCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022FE5 RID: 143333 RVA: 0x00C1D02C File Offset: 0x00C1B22C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_format(IntPtr l)
	{
		int result;
		try
		{
			Cubemap cubemap = (Cubemap)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)cubemap.format);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022FE6 RID: 143334 RVA: 0x00C1D080 File Offset: 0x00C1B280
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Cubemap");
		if (Lua_UnityEngine_Cubemap.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_Cubemap.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_Cubemap.SetPixel);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Cubemap.<>f__mg$cache0);
		if (Lua_UnityEngine_Cubemap.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_Cubemap.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_Cubemap.GetPixel);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Cubemap.<>f__mg$cache1);
		if (Lua_UnityEngine_Cubemap.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_Cubemap.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_Cubemap.GetPixels);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Cubemap.<>f__mg$cache2);
		if (Lua_UnityEngine_Cubemap.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_Cubemap.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_Cubemap.SetPixels);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Cubemap.<>f__mg$cache3);
		if (Lua_UnityEngine_Cubemap.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_Cubemap.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_Cubemap.Apply);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Cubemap.<>f__mg$cache4);
		if (Lua_UnityEngine_Cubemap.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_Cubemap.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_Cubemap.SmoothEdges);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Cubemap.<>f__mg$cache5);
		if (Lua_UnityEngine_Cubemap.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_Cubemap.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_Cubemap.CreateExternalTexture_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Cubemap.<>f__mg$cache6);
		string name = "mipmapCount";
		if (Lua_UnityEngine_Cubemap.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_Cubemap.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_Cubemap.get_mipmapCount);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_Cubemap.<>f__mg$cache7, null, true);
		string name2 = "format";
		if (Lua_UnityEngine_Cubemap.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_Cubemap.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_Cubemap.get_format);
		}
		LuaObject.addMember(l, name2, Lua_UnityEngine_Cubemap.<>f__mg$cache8, null, true);
		if (Lua_UnityEngine_Cubemap.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_Cubemap.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_Cubemap.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_Cubemap.<>f__mg$cache9, typeof(Cubemap), typeof(Texture));
	}

	// Token: 0x04018F44 RID: 102212
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04018F45 RID: 102213
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04018F46 RID: 102214
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04018F47 RID: 102215
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04018F48 RID: 102216
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04018F49 RID: 102217
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04018F4A RID: 102218
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04018F4B RID: 102219
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04018F4C RID: 102220
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04018F4D RID: 102221
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;
}
