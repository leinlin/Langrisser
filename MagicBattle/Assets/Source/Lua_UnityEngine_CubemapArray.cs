using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x0200167C RID: 5756
[Preserve]
public class Lua_UnityEngine_CubemapArray : LuaObject
{
	// Token: 0x06022FE8 RID: 143336 RVA: 0x00C1D220 File Offset: 0x00C1B420
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 5)
			{
				int faceSize;
				LuaObject.checkType(l, 2, out faceSize);
				int cubemapCount;
				LuaObject.checkType(l, 3, out cubemapCount);
				TextureFormat format;
				LuaObject.checkEnum<TextureFormat>(l, 4, out format);
				bool mipmap;
				LuaObject.checkType(l, 5, out mipmap);
				CubemapArray o = new CubemapArray(faceSize, cubemapCount, format, mipmap);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (num == 6)
			{
				int faceSize2;
				LuaObject.checkType(l, 2, out faceSize2);
				int cubemapCount2;
				LuaObject.checkType(l, 3, out cubemapCount2);
				TextureFormat format2;
				LuaObject.checkEnum<TextureFormat>(l, 4, out format2);
				bool mipmap2;
				LuaObject.checkType(l, 5, out mipmap2);
				bool linear;
				LuaObject.checkType(l, 6, out linear);
				CubemapArray o = new CubemapArray(faceSize2, cubemapCount2, format2, mipmap2, linear);
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

	// Token: 0x06022FE9 RID: 143337 RVA: 0x00C1D31C File Offset: 0x00C1B51C
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
				CubemapArray cubemapArray = (CubemapArray)LuaObject.checkSelf(l);
				cubemapArray.Apply();
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 2)
			{
				CubemapArray cubemapArray2 = (CubemapArray)LuaObject.checkSelf(l);
				bool updateMipmaps;
				LuaObject.checkType(l, 2, out updateMipmaps);
				cubemapArray2.Apply(updateMipmaps);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 3)
			{
				CubemapArray cubemapArray3 = (CubemapArray)LuaObject.checkSelf(l);
				bool updateMipmaps2;
				LuaObject.checkType(l, 2, out updateMipmaps2);
				bool makeNoLongerReadable;
				LuaObject.checkType(l, 3, out makeNoLongerReadable);
				cubemapArray3.Apply(updateMipmaps2, makeNoLongerReadable);
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

	// Token: 0x06022FEA RID: 143338 RVA: 0x00C1D408 File Offset: 0x00C1B608
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetPixels(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 4)
			{
				CubemapArray cubemapArray = (CubemapArray)LuaObject.checkSelf(l);
				Color[] colors;
				LuaObject.checkArray<Color>(l, 2, out colors);
				CubemapFace face;
				LuaObject.checkEnum<CubemapFace>(l, 3, out face);
				int arrayElement;
				LuaObject.checkType(l, 4, out arrayElement);
				cubemapArray.SetPixels(colors, face, arrayElement);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 5)
			{
				CubemapArray cubemapArray2 = (CubemapArray)LuaObject.checkSelf(l);
				Color[] colors2;
				LuaObject.checkArray<Color>(l, 2, out colors2);
				CubemapFace face2;
				LuaObject.checkEnum<CubemapFace>(l, 3, out face2);
				int arrayElement2;
				LuaObject.checkType(l, 4, out arrayElement2);
				int miplevel;
				LuaObject.checkType(l, 5, out miplevel);
				cubemapArray2.SetPixels(colors2, face2, arrayElement2, miplevel);
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

	// Token: 0x06022FEB RID: 143339 RVA: 0x00C1D500 File Offset: 0x00C1B700
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetPixels32(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 4)
			{
				CubemapArray cubemapArray = (CubemapArray)LuaObject.checkSelf(l);
				Color32[] colors;
				LuaObject.checkArray<Color32>(l, 2, out colors);
				CubemapFace face;
				LuaObject.checkEnum<CubemapFace>(l, 3, out face);
				int arrayElement;
				LuaObject.checkType(l, 4, out arrayElement);
				cubemapArray.SetPixels32(colors, face, arrayElement);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 5)
			{
				CubemapArray cubemapArray2 = (CubemapArray)LuaObject.checkSelf(l);
				Color32[] colors2;
				LuaObject.checkArray<Color32>(l, 2, out colors2);
				CubemapFace face2;
				LuaObject.checkEnum<CubemapFace>(l, 3, out face2);
				int arrayElement2;
				LuaObject.checkType(l, 4, out arrayElement2);
				int miplevel;
				LuaObject.checkType(l, 5, out miplevel);
				cubemapArray2.SetPixels32(colors2, face2, arrayElement2, miplevel);
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

	// Token: 0x06022FEC RID: 143340 RVA: 0x00C1D5F8 File Offset: 0x00C1B7F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetPixels(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 3)
			{
				CubemapArray cubemapArray = (CubemapArray)LuaObject.checkSelf(l);
				CubemapFace face;
				LuaObject.checkEnum<CubemapFace>(l, 2, out face);
				int arrayElement;
				LuaObject.checkType(l, 3, out arrayElement);
				Color[] pixels = cubemapArray.GetPixels(face, arrayElement);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, pixels);
				result = 2;
			}
			else if (num == 4)
			{
				CubemapArray cubemapArray2 = (CubemapArray)LuaObject.checkSelf(l);
				CubemapFace face2;
				LuaObject.checkEnum<CubemapFace>(l, 2, out face2);
				int arrayElement2;
				LuaObject.checkType(l, 3, out arrayElement2);
				int miplevel;
				LuaObject.checkType(l, 4, out miplevel);
				Color[] pixels2 = cubemapArray2.GetPixels(face2, arrayElement2, miplevel);
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

	// Token: 0x06022FED RID: 143341 RVA: 0x00C1D6EC File Offset: 0x00C1B8EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetPixels32(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 3)
			{
				CubemapArray cubemapArray = (CubemapArray)LuaObject.checkSelf(l);
				CubemapFace face;
				LuaObject.checkEnum<CubemapFace>(l, 2, out face);
				int arrayElement;
				LuaObject.checkType(l, 3, out arrayElement);
				Color32[] pixels = cubemapArray.GetPixels32(face, arrayElement);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, pixels);
				result = 2;
			}
			else if (num == 4)
			{
				CubemapArray cubemapArray2 = (CubemapArray)LuaObject.checkSelf(l);
				CubemapFace face2;
				LuaObject.checkEnum<CubemapFace>(l, 2, out face2);
				int arrayElement2;
				LuaObject.checkType(l, 3, out arrayElement2);
				int miplevel;
				LuaObject.checkType(l, 4, out miplevel);
				Color32[] pixels2 = cubemapArray2.GetPixels32(face2, arrayElement2, miplevel);
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

	// Token: 0x06022FEE RID: 143342 RVA: 0x00C1D7E0 File Offset: 0x00C1B9E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_cubemapCount(IntPtr l)
	{
		int result;
		try
		{
			CubemapArray cubemapArray = (CubemapArray)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cubemapArray.cubemapCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022FEF RID: 143343 RVA: 0x00C1D834 File Offset: 0x00C1BA34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_format(IntPtr l)
	{
		int result;
		try
		{
			CubemapArray cubemapArray = (CubemapArray)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)cubemapArray.format);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022FF0 RID: 143344 RVA: 0x00C1D888 File Offset: 0x00C1BA88
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.CubemapArray");
		if (Lua_UnityEngine_CubemapArray.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_CubemapArray.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_CubemapArray.Apply);
		}
		LuaObject.addMember(l, Lua_UnityEngine_CubemapArray.<>f__mg$cache0);
		if (Lua_UnityEngine_CubemapArray.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_CubemapArray.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_CubemapArray.SetPixels);
		}
		LuaObject.addMember(l, Lua_UnityEngine_CubemapArray.<>f__mg$cache1);
		if (Lua_UnityEngine_CubemapArray.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_CubemapArray.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_CubemapArray.SetPixels32);
		}
		LuaObject.addMember(l, Lua_UnityEngine_CubemapArray.<>f__mg$cache2);
		if (Lua_UnityEngine_CubemapArray.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_CubemapArray.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_CubemapArray.GetPixels);
		}
		LuaObject.addMember(l, Lua_UnityEngine_CubemapArray.<>f__mg$cache3);
		if (Lua_UnityEngine_CubemapArray.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_CubemapArray.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_CubemapArray.GetPixels32);
		}
		LuaObject.addMember(l, Lua_UnityEngine_CubemapArray.<>f__mg$cache4);
		string name = "cubemapCount";
		if (Lua_UnityEngine_CubemapArray.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_CubemapArray.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_CubemapArray.get_cubemapCount);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_CubemapArray.<>f__mg$cache5, null, true);
		string name2 = "format";
		if (Lua_UnityEngine_CubemapArray.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_CubemapArray.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_CubemapArray.get_format);
		}
		LuaObject.addMember(l, name2, Lua_UnityEngine_CubemapArray.<>f__mg$cache6, null, true);
		if (Lua_UnityEngine_CubemapArray.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_CubemapArray.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_CubemapArray.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_CubemapArray.<>f__mg$cache7, typeof(CubemapArray), typeof(Texture));
	}

	// Token: 0x04018F4E RID: 102222
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04018F4F RID: 102223
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04018F50 RID: 102224
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04018F51 RID: 102225
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04018F52 RID: 102226
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04018F53 RID: 102227
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04018F54 RID: 102228
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04018F55 RID: 102229
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;
}
