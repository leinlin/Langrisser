using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x020017F9 RID: 6137
[Preserve]
public class Lua_UnityEngine_Texture2D : LuaObject
{
	// Token: 0x06023EA2 RID: 147106 RVA: 0x00C9809C File Offset: 0x00C9629C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 3)
			{
				int width;
				LuaObject.checkType(l, 2, out width);
				int height;
				LuaObject.checkType(l, 3, out height);
				Texture2D o = new Texture2D(width, height);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (num == 5)
			{
				int width2;
				LuaObject.checkType(l, 2, out width2);
				int height2;
				LuaObject.checkType(l, 3, out height2);
				TextureFormat format;
				LuaObject.checkEnum<TextureFormat>(l, 4, out format);
				bool mipmap;
				LuaObject.checkType(l, 5, out mipmap);
				Texture2D o = new Texture2D(width2, height2, format, mipmap);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (num == 6)
			{
				int width3;
				LuaObject.checkType(l, 2, out width3);
				int height3;
				LuaObject.checkType(l, 3, out height3);
				TextureFormat format2;
				LuaObject.checkEnum<TextureFormat>(l, 4, out format2);
				bool mipmap2;
				LuaObject.checkType(l, 5, out mipmap2);
				bool linear;
				LuaObject.checkType(l, 6, out linear);
				Texture2D o = new Texture2D(width3, height3, format2, mipmap2, linear);
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

	// Token: 0x06023EA3 RID: 147107 RVA: 0x00C981DC File Offset: 0x00C963DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateExternalTexture(IntPtr l)
	{
		int result;
		try
		{
			Texture2D texture2D = (Texture2D)LuaObject.checkSelf(l);
			IntPtr nativeTex;
			LuaObject.checkType(l, 2, out nativeTex);
			texture2D.UpdateExternalTexture(nativeTex);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023EA4 RID: 147108 RVA: 0x00C98234 File Offset: 0x00C96434
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetPixel(IntPtr l)
	{
		int result;
		try
		{
			Texture2D texture2D = (Texture2D)LuaObject.checkSelf(l);
			int x;
			LuaObject.checkType(l, 2, out x);
			int y;
			LuaObject.checkType(l, 3, out y);
			Color color;
			LuaObject.checkType(l, 4, out color);
			texture2D.SetPixel(x, y, color);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023EA5 RID: 147109 RVA: 0x00C982A8 File Offset: 0x00C964A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetPixel(IntPtr l)
	{
		int result;
		try
		{
			Texture2D texture2D = (Texture2D)LuaObject.checkSelf(l);
			int x;
			LuaObject.checkType(l, 2, out x);
			int y;
			LuaObject.checkType(l, 3, out y);
			Color pixel = texture2D.GetPixel(x, y);
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

	// Token: 0x06023EA6 RID: 147110 RVA: 0x00C98318 File Offset: 0x00C96518
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetPixelBilinear(IntPtr l)
	{
		int result;
		try
		{
			Texture2D texture2D = (Texture2D)LuaObject.checkSelf(l);
			float u;
			LuaObject.checkType(l, 2, out u);
			float v;
			LuaObject.checkType(l, 3, out v);
			Color pixelBilinear = texture2D.GetPixelBilinear(u, v);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, pixelBilinear);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023EA7 RID: 147111 RVA: 0x00C98388 File Offset: 0x00C96588
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetPixels(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				Texture2D texture2D = (Texture2D)LuaObject.checkSelf(l);
				Color[] pixels;
				LuaObject.checkArray<Color>(l, 2, out pixels);
				texture2D.SetPixels(pixels);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 3)
			{
				Texture2D texture2D2 = (Texture2D)LuaObject.checkSelf(l);
				Color[] colors;
				LuaObject.checkArray<Color>(l, 2, out colors);
				int miplevel;
				LuaObject.checkType(l, 3, out miplevel);
				texture2D2.SetPixels(colors, miplevel);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 6)
			{
				Texture2D texture2D3 = (Texture2D)LuaObject.checkSelf(l);
				int x;
				LuaObject.checkType(l, 2, out x);
				int y;
				LuaObject.checkType(l, 3, out y);
				int blockWidth;
				LuaObject.checkType(l, 4, out blockWidth);
				int blockHeight;
				LuaObject.checkType(l, 5, out blockHeight);
				Color[] colors2;
				LuaObject.checkArray<Color>(l, 6, out colors2);
				texture2D3.SetPixels(x, y, blockWidth, blockHeight, colors2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 7)
			{
				Texture2D texture2D4 = (Texture2D)LuaObject.checkSelf(l);
				int x2;
				LuaObject.checkType(l, 2, out x2);
				int y2;
				LuaObject.checkType(l, 3, out y2);
				int blockWidth2;
				LuaObject.checkType(l, 4, out blockWidth2);
				int blockHeight2;
				LuaObject.checkType(l, 5, out blockHeight2);
				Color[] colors3;
				LuaObject.checkArray<Color>(l, 6, out colors3);
				int miplevel2;
				LuaObject.checkType(l, 7, out miplevel2);
				texture2D4.SetPixels(x2, y2, blockWidth2, blockHeight2, colors3, miplevel2);
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

	// Token: 0x06023EA8 RID: 147112 RVA: 0x00C9852C File Offset: 0x00C9672C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetPixels32(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				Texture2D texture2D = (Texture2D)LuaObject.checkSelf(l);
				Color32[] pixels;
				LuaObject.checkArray<Color32>(l, 2, out pixels);
				texture2D.SetPixels32(pixels);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 3)
			{
				Texture2D texture2D2 = (Texture2D)LuaObject.checkSelf(l);
				Color32[] colors;
				LuaObject.checkArray<Color32>(l, 2, out colors);
				int miplevel;
				LuaObject.checkType(l, 3, out miplevel);
				texture2D2.SetPixels32(colors, miplevel);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 6)
			{
				Texture2D texture2D3 = (Texture2D)LuaObject.checkSelf(l);
				int x;
				LuaObject.checkType(l, 2, out x);
				int y;
				LuaObject.checkType(l, 3, out y);
				int blockWidth;
				LuaObject.checkType(l, 4, out blockWidth);
				int blockHeight;
				LuaObject.checkType(l, 5, out blockHeight);
				Color32[] colors2;
				LuaObject.checkArray<Color32>(l, 6, out colors2);
				texture2D3.SetPixels32(x, y, blockWidth, blockHeight, colors2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 7)
			{
				Texture2D texture2D4 = (Texture2D)LuaObject.checkSelf(l);
				int x2;
				LuaObject.checkType(l, 2, out x2);
				int y2;
				LuaObject.checkType(l, 3, out y2);
				int blockWidth2;
				LuaObject.checkType(l, 4, out blockWidth2);
				int blockHeight2;
				LuaObject.checkType(l, 5, out blockHeight2);
				Color32[] colors3;
				LuaObject.checkArray<Color32>(l, 6, out colors3);
				int miplevel2;
				LuaObject.checkType(l, 7, out miplevel2);
				texture2D4.SetPixels32(x2, y2, blockWidth2, blockHeight2, colors3, miplevel2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function SetPixels32 to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023EA9 RID: 147113 RVA: 0x00C986D0 File Offset: 0x00C968D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LoadRawTextureData(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				Texture2D texture2D = (Texture2D)LuaObject.checkSelf(l);
				byte[] data;
				LuaObject.checkArray<byte>(l, 2, out data);
				texture2D.LoadRawTextureData(data);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 3)
			{
				Texture2D texture2D2 = (Texture2D)LuaObject.checkSelf(l);
				IntPtr data2;
				LuaObject.checkType(l, 2, out data2);
				int size;
				LuaObject.checkType(l, 3, out size);
				texture2D2.LoadRawTextureData(data2, size);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function LoadRawTextureData to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023EAA RID: 147114 RVA: 0x00C98794 File Offset: 0x00C96994
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetRawTextureData(IntPtr l)
	{
		int result;
		try
		{
			Texture2D texture2D = (Texture2D)LuaObject.checkSelf(l);
			byte[] rawTextureData = texture2D.GetRawTextureData();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rawTextureData);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023EAB RID: 147115 RVA: 0x00C987E8 File Offset: 0x00C969E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetPixels(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 1)
			{
				Texture2D texture2D = (Texture2D)LuaObject.checkSelf(l);
				Color[] pixels = texture2D.GetPixels();
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, pixels);
				result = 2;
			}
			else if (num == 2)
			{
				Texture2D texture2D2 = (Texture2D)LuaObject.checkSelf(l);
				int miplevel;
				LuaObject.checkType(l, 2, out miplevel);
				Color[] pixels2 = texture2D2.GetPixels(miplevel);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, pixels2);
				result = 2;
			}
			else if (num == 5)
			{
				Texture2D texture2D3 = (Texture2D)LuaObject.checkSelf(l);
				int x;
				LuaObject.checkType(l, 2, out x);
				int y;
				LuaObject.checkType(l, 3, out y);
				int blockWidth;
				LuaObject.checkType(l, 4, out blockWidth);
				int blockHeight;
				LuaObject.checkType(l, 5, out blockHeight);
				Color[] pixels3 = texture2D3.GetPixels(x, y, blockWidth, blockHeight);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, pixels3);
				result = 2;
			}
			else if (num == 6)
			{
				Texture2D texture2D4 = (Texture2D)LuaObject.checkSelf(l);
				int x2;
				LuaObject.checkType(l, 2, out x2);
				int y2;
				LuaObject.checkType(l, 3, out y2);
				int blockWidth2;
				LuaObject.checkType(l, 4, out blockWidth2);
				int blockHeight2;
				LuaObject.checkType(l, 5, out blockHeight2);
				int miplevel2;
				LuaObject.checkType(l, 6, out miplevel2);
				Color[] pixels4 = texture2D4.GetPixels(x2, y2, blockWidth2, blockHeight2, miplevel2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, pixels4);
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

	// Token: 0x06023EAC RID: 147116 RVA: 0x00C98984 File Offset: 0x00C96B84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetPixels32(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				Texture2D texture2D = (Texture2D)LuaObject.checkSelf(l);
				int miplevel;
				LuaObject.checkType(l, 2, out miplevel);
				Color32[] pixels = texture2D.GetPixels32(miplevel);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, pixels);
				result = 2;
			}
			else if (num == 1)
			{
				Texture2D texture2D2 = (Texture2D)LuaObject.checkSelf(l);
				Color32[] pixels2 = texture2D2.GetPixels32();
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, pixels2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function GetPixels32 to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023EAD RID: 147117 RVA: 0x00C98A44 File Offset: 0x00C96C44
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
				Texture2D texture2D = (Texture2D)LuaObject.checkSelf(l);
				texture2D.Apply();
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 2)
			{
				Texture2D texture2D2 = (Texture2D)LuaObject.checkSelf(l);
				bool updateMipmaps;
				LuaObject.checkType(l, 2, out updateMipmaps);
				texture2D2.Apply(updateMipmaps);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 3)
			{
				Texture2D texture2D3 = (Texture2D)LuaObject.checkSelf(l);
				bool updateMipmaps2;
				LuaObject.checkType(l, 2, out updateMipmaps2);
				bool makeNoLongerReadable;
				LuaObject.checkType(l, 3, out makeNoLongerReadable);
				texture2D3.Apply(updateMipmaps2, makeNoLongerReadable);
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

	// Token: 0x06023EAE RID: 147118 RVA: 0x00C98B30 File Offset: 0x00C96D30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Resize(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 3)
			{
				Texture2D texture2D = (Texture2D)LuaObject.checkSelf(l);
				int width;
				LuaObject.checkType(l, 2, out width);
				int height;
				LuaObject.checkType(l, 3, out height);
				bool b = texture2D.Resize(width, height);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b);
				result = 2;
			}
			else if (num == 5)
			{
				Texture2D texture2D2 = (Texture2D)LuaObject.checkSelf(l);
				int width2;
				LuaObject.checkType(l, 2, out width2);
				int height2;
				LuaObject.checkType(l, 3, out height2);
				TextureFormat format;
				LuaObject.checkEnum<TextureFormat>(l, 4, out format);
				bool hasMipMap;
				LuaObject.checkType(l, 5, out hasMipMap);
				bool b2 = texture2D2.Resize(width2, height2, format, hasMipMap);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function Resize to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023EAF RID: 147119 RVA: 0x00C98C30 File Offset: 0x00C96E30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Compress(IntPtr l)
	{
		int result;
		try
		{
			Texture2D texture2D = (Texture2D)LuaObject.checkSelf(l);
			bool highQuality;
			LuaObject.checkType(l, 2, out highQuality);
			texture2D.Compress(highQuality);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023EB0 RID: 147120 RVA: 0x00C98C88 File Offset: 0x00C96E88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PackTextures(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 3)
			{
				Texture2D texture2D = (Texture2D)LuaObject.checkSelf(l);
				Texture2D[] textures;
				LuaObject.checkArray<Texture2D>(l, 2, out textures);
				int padding;
				LuaObject.checkType(l, 3, out padding);
				Rect[] a = texture2D.PackTextures(textures, padding);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, a);
				result = 2;
			}
			else if (num == 4)
			{
				Texture2D texture2D2 = (Texture2D)LuaObject.checkSelf(l);
				Texture2D[] textures2;
				LuaObject.checkArray<Texture2D>(l, 2, out textures2);
				int padding2;
				LuaObject.checkType(l, 3, out padding2);
				int maximumAtlasSize;
				LuaObject.checkType(l, 4, out maximumAtlasSize);
				Rect[] a2 = texture2D2.PackTextures(textures2, padding2, maximumAtlasSize);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, a2);
				result = 2;
			}
			else if (num == 5)
			{
				Texture2D texture2D3 = (Texture2D)LuaObject.checkSelf(l);
				Texture2D[] textures3;
				LuaObject.checkArray<Texture2D>(l, 2, out textures3);
				int padding3;
				LuaObject.checkType(l, 3, out padding3);
				int maximumAtlasSize2;
				LuaObject.checkType(l, 4, out maximumAtlasSize2);
				bool makeNoLongerReadable;
				LuaObject.checkType(l, 5, out makeNoLongerReadable);
				Rect[] a3 = texture2D3.PackTextures(textures3, padding3, maximumAtlasSize2, makeNoLongerReadable);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, a3);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function PackTextures to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023EB1 RID: 147121 RVA: 0x00C98DEC File Offset: 0x00C96FEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ReadPixels(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 4)
			{
				Texture2D texture2D = (Texture2D)LuaObject.checkSelf(l);
				Rect source;
				LuaObject.checkValueType<Rect>(l, 2, out source);
				int destX;
				LuaObject.checkType(l, 3, out destX);
				int destY;
				LuaObject.checkType(l, 4, out destY);
				texture2D.ReadPixels(source, destX, destY);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 5)
			{
				Texture2D texture2D2 = (Texture2D)LuaObject.checkSelf(l);
				Rect source2;
				LuaObject.checkValueType<Rect>(l, 2, out source2);
				int destX2;
				LuaObject.checkType(l, 3, out destX2);
				int destY2;
				LuaObject.checkType(l, 4, out destY2);
				bool recalculateMipMaps;
				LuaObject.checkType(l, 5, out recalculateMipMaps);
				texture2D2.ReadPixels(source2, destX2, destY2, recalculateMipMaps);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function ReadPixels to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023EB2 RID: 147122 RVA: 0x00C98EE4 File Offset: 0x00C970E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateExternalTexture_s(IntPtr l)
	{
		int result;
		try
		{
			int width;
			LuaObject.checkType(l, 1, out width);
			int height;
			LuaObject.checkType(l, 2, out height);
			TextureFormat format;
			LuaObject.checkEnum<TextureFormat>(l, 3, out format);
			bool mipmap;
			LuaObject.checkType(l, 4, out mipmap);
			bool linear;
			LuaObject.checkType(l, 5, out linear);
			IntPtr nativeTex;
			LuaObject.checkType(l, 6, out nativeTex);
			Texture2D o = Texture2D.CreateExternalTexture(width, height, format, mipmap, linear, nativeTex);
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

	// Token: 0x06023EB3 RID: 147123 RVA: 0x00C98F78 File Offset: 0x00C97178
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GenerateAtlas_s(IntPtr l)
	{
		int result;
		try
		{
			Vector2[] sizes;
			LuaObject.checkArray<Vector2>(l, 1, out sizes);
			int padding;
			LuaObject.checkType(l, 2, out padding);
			int atlasSize;
			LuaObject.checkType(l, 3, out atlasSize);
			List<Rect> results;
			LuaObject.checkType<List<Rect>>(l, 4, out results);
			bool b = Texture2D.GenerateAtlas(sizes, padding, atlasSize, results);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023EB4 RID: 147124 RVA: 0x00C98FF4 File Offset: 0x00C971F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_mipmapCount(IntPtr l)
	{
		int result;
		try
		{
			Texture2D texture2D = (Texture2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, texture2D.mipmapCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023EB5 RID: 147125 RVA: 0x00C99048 File Offset: 0x00C97248
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_format(IntPtr l)
	{
		int result;
		try
		{
			Texture2D texture2D = (Texture2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)texture2D.format);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023EB6 RID: 147126 RVA: 0x00C9909C File Offset: 0x00C9729C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_whiteTexture(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Texture2D.whiteTexture);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023EB7 RID: 147127 RVA: 0x00C990E4 File Offset: 0x00C972E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_blackTexture(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Texture2D.blackTexture);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023EB8 RID: 147128 RVA: 0x00C9912C File Offset: 0x00C9732C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Texture2D");
		if (Lua_UnityEngine_Texture2D.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_Texture2D.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_Texture2D.UpdateExternalTexture);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Texture2D.<>f__mg$cache0);
		if (Lua_UnityEngine_Texture2D.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_Texture2D.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_Texture2D.SetPixel);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Texture2D.<>f__mg$cache1);
		if (Lua_UnityEngine_Texture2D.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_Texture2D.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_Texture2D.GetPixel);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Texture2D.<>f__mg$cache2);
		if (Lua_UnityEngine_Texture2D.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_Texture2D.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_Texture2D.GetPixelBilinear);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Texture2D.<>f__mg$cache3);
		if (Lua_UnityEngine_Texture2D.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_Texture2D.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_Texture2D.SetPixels);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Texture2D.<>f__mg$cache4);
		if (Lua_UnityEngine_Texture2D.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_Texture2D.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_Texture2D.SetPixels32);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Texture2D.<>f__mg$cache5);
		if (Lua_UnityEngine_Texture2D.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_Texture2D.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_Texture2D.LoadRawTextureData);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Texture2D.<>f__mg$cache6);
		if (Lua_UnityEngine_Texture2D.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_Texture2D.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_Texture2D.GetRawTextureData);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Texture2D.<>f__mg$cache7);
		if (Lua_UnityEngine_Texture2D.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_Texture2D.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_Texture2D.GetPixels);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Texture2D.<>f__mg$cache8);
		if (Lua_UnityEngine_Texture2D.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_Texture2D.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_Texture2D.GetPixels32);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Texture2D.<>f__mg$cache9);
		if (Lua_UnityEngine_Texture2D.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_Texture2D.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_Texture2D.Apply);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Texture2D.<>f__mg$cacheA);
		if (Lua_UnityEngine_Texture2D.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_Texture2D.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_Texture2D.Resize);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Texture2D.<>f__mg$cacheB);
		if (Lua_UnityEngine_Texture2D.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_Texture2D.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_Texture2D.Compress);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Texture2D.<>f__mg$cacheC);
		if (Lua_UnityEngine_Texture2D.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_Texture2D.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_Texture2D.PackTextures);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Texture2D.<>f__mg$cacheD);
		if (Lua_UnityEngine_Texture2D.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_Texture2D.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_Texture2D.ReadPixels);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Texture2D.<>f__mg$cacheE);
		if (Lua_UnityEngine_Texture2D.<>f__mg$cacheF == null)
		{
			Lua_UnityEngine_Texture2D.<>f__mg$cacheF = new LuaCSFunction(Lua_UnityEngine_Texture2D.CreateExternalTexture_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Texture2D.<>f__mg$cacheF);
		if (Lua_UnityEngine_Texture2D.<>f__mg$cache10 == null)
		{
			Lua_UnityEngine_Texture2D.<>f__mg$cache10 = new LuaCSFunction(Lua_UnityEngine_Texture2D.GenerateAtlas_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Texture2D.<>f__mg$cache10);
		string name = "mipmapCount";
		if (Lua_UnityEngine_Texture2D.<>f__mg$cache11 == null)
		{
			Lua_UnityEngine_Texture2D.<>f__mg$cache11 = new LuaCSFunction(Lua_UnityEngine_Texture2D.get_mipmapCount);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_Texture2D.<>f__mg$cache11, null, true);
		string name2 = "format";
		if (Lua_UnityEngine_Texture2D.<>f__mg$cache12 == null)
		{
			Lua_UnityEngine_Texture2D.<>f__mg$cache12 = new LuaCSFunction(Lua_UnityEngine_Texture2D.get_format);
		}
		LuaObject.addMember(l, name2, Lua_UnityEngine_Texture2D.<>f__mg$cache12, null, true);
		string name3 = "whiteTexture";
		if (Lua_UnityEngine_Texture2D.<>f__mg$cache13 == null)
		{
			Lua_UnityEngine_Texture2D.<>f__mg$cache13 = new LuaCSFunction(Lua_UnityEngine_Texture2D.get_whiteTexture);
		}
		LuaObject.addMember(l, name3, Lua_UnityEngine_Texture2D.<>f__mg$cache13, null, false);
		string name4 = "blackTexture";
		if (Lua_UnityEngine_Texture2D.<>f__mg$cache14 == null)
		{
			Lua_UnityEngine_Texture2D.<>f__mg$cache14 = new LuaCSFunction(Lua_UnityEngine_Texture2D.get_blackTexture);
		}
		LuaObject.addMember(l, name4, Lua_UnityEngine_Texture2D.<>f__mg$cache14, null, false);
		if (Lua_UnityEngine_Texture2D.<>f__mg$cache15 == null)
		{
			Lua_UnityEngine_Texture2D.<>f__mg$cache15 = new LuaCSFunction(Lua_UnityEngine_Texture2D.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_Texture2D.<>f__mg$cache15, typeof(Texture2D), typeof(Texture));
	}

	// Token: 0x04019B0E RID: 105230
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019B0F RID: 105231
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019B10 RID: 105232
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019B11 RID: 105233
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019B12 RID: 105234
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04019B13 RID: 105235
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04019B14 RID: 105236
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04019B15 RID: 105237
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04019B16 RID: 105238
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04019B17 RID: 105239
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04019B18 RID: 105240
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04019B19 RID: 105241
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04019B1A RID: 105242
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04019B1B RID: 105243
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04019B1C RID: 105244
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04019B1D RID: 105245
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04019B1E RID: 105246
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04019B1F RID: 105247
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04019B20 RID: 105248
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04019B21 RID: 105249
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04019B22 RID: 105250
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04019B23 RID: 105251
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;
}
