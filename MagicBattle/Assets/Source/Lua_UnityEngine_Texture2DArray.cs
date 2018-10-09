using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x020017FB RID: 6139
[Preserve]
public class Lua_UnityEngine_Texture2DArray : LuaObject
{
	// Token: 0x06023EBC RID: 147132 RVA: 0x00C994E4 File Offset: 0x00C976E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 6)
			{
				int width;
				LuaObject.checkType(l, 2, out width);
				int height;
				LuaObject.checkType(l, 3, out height);
				int depth;
				LuaObject.checkType(l, 4, out depth);
				TextureFormat format;
				LuaObject.checkEnum<TextureFormat>(l, 5, out format);
				bool mipmap;
				LuaObject.checkType(l, 6, out mipmap);
				Texture2DArray o = new Texture2DArray(width, height, depth, format, mipmap);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (num == 7)
			{
				int width2;
				LuaObject.checkType(l, 2, out width2);
				int height2;
				LuaObject.checkType(l, 3, out height2);
				int depth2;
				LuaObject.checkType(l, 4, out depth2);
				TextureFormat format2;
				LuaObject.checkEnum<TextureFormat>(l, 5, out format2);
				bool mipmap2;
				LuaObject.checkType(l, 6, out mipmap2);
				bool linear;
				LuaObject.checkType(l, 7, out linear);
				Texture2DArray o = new Texture2DArray(width2, height2, depth2, format2, mipmap2, linear);
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

	// Token: 0x06023EBD RID: 147133 RVA: 0x00C995F8 File Offset: 0x00C977F8
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
				Texture2DArray texture2DArray = (Texture2DArray)LuaObject.checkSelf(l);
				texture2DArray.Apply();
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 2)
			{
				Texture2DArray texture2DArray2 = (Texture2DArray)LuaObject.checkSelf(l);
				bool updateMipmaps;
				LuaObject.checkType(l, 2, out updateMipmaps);
				texture2DArray2.Apply(updateMipmaps);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 3)
			{
				Texture2DArray texture2DArray3 = (Texture2DArray)LuaObject.checkSelf(l);
				bool updateMipmaps2;
				LuaObject.checkType(l, 2, out updateMipmaps2);
				bool makeNoLongerReadable;
				LuaObject.checkType(l, 3, out makeNoLongerReadable);
				texture2DArray3.Apply(updateMipmaps2, makeNoLongerReadable);
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

	// Token: 0x06023EBE RID: 147134 RVA: 0x00C996E4 File Offset: 0x00C978E4
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
				Texture2DArray texture2DArray = (Texture2DArray)LuaObject.checkSelf(l);
				Color[] colors;
				LuaObject.checkArray<Color>(l, 2, out colors);
				int arrayElement;
				LuaObject.checkType(l, 3, out arrayElement);
				texture2DArray.SetPixels(colors, arrayElement);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 4)
			{
				Texture2DArray texture2DArray2 = (Texture2DArray)LuaObject.checkSelf(l);
				Color[] colors2;
				LuaObject.checkArray<Color>(l, 2, out colors2);
				int arrayElement2;
				LuaObject.checkType(l, 3, out arrayElement2);
				int miplevel;
				LuaObject.checkType(l, 4, out miplevel);
				texture2DArray2.SetPixels(colors2, arrayElement2, miplevel);
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

	// Token: 0x06023EBF RID: 147135 RVA: 0x00C997C4 File Offset: 0x00C979C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetPixels32(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 3)
			{
				Texture2DArray texture2DArray = (Texture2DArray)LuaObject.checkSelf(l);
				Color32[] colors;
				LuaObject.checkArray<Color32>(l, 2, out colors);
				int arrayElement;
				LuaObject.checkType(l, 3, out arrayElement);
				texture2DArray.SetPixels32(colors, arrayElement);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 4)
			{
				Texture2DArray texture2DArray2 = (Texture2DArray)LuaObject.checkSelf(l);
				Color32[] colors2;
				LuaObject.checkArray<Color32>(l, 2, out colors2);
				int arrayElement2;
				LuaObject.checkType(l, 3, out arrayElement2);
				int miplevel;
				LuaObject.checkType(l, 4, out miplevel);
				texture2DArray2.SetPixels32(colors2, arrayElement2, miplevel);
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

	// Token: 0x06023EC0 RID: 147136 RVA: 0x00C998A4 File Offset: 0x00C97AA4
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
				Texture2DArray texture2DArray = (Texture2DArray)LuaObject.checkSelf(l);
				int arrayElement;
				LuaObject.checkType(l, 2, out arrayElement);
				Color[] pixels = texture2DArray.GetPixels(arrayElement);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, pixels);
				result = 2;
			}
			else if (num == 3)
			{
				Texture2DArray texture2DArray2 = (Texture2DArray)LuaObject.checkSelf(l);
				int arrayElement2;
				LuaObject.checkType(l, 2, out arrayElement2);
				int miplevel;
				LuaObject.checkType(l, 3, out miplevel);
				Color[] pixels2 = texture2DArray2.GetPixels(arrayElement2, miplevel);
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

	// Token: 0x06023EC1 RID: 147137 RVA: 0x00C9997C File Offset: 0x00C97B7C
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
				Texture2DArray texture2DArray = (Texture2DArray)LuaObject.checkSelf(l);
				int arrayElement;
				LuaObject.checkType(l, 2, out arrayElement);
				Color32[] pixels = texture2DArray.GetPixels32(arrayElement);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, pixels);
				result = 2;
			}
			else if (num == 3)
			{
				Texture2DArray texture2DArray2 = (Texture2DArray)LuaObject.checkSelf(l);
				int arrayElement2;
				LuaObject.checkType(l, 2, out arrayElement2);
				int miplevel;
				LuaObject.checkType(l, 3, out miplevel);
				Color32[] pixels2 = texture2DArray2.GetPixels32(arrayElement2, miplevel);
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

	// Token: 0x06023EC2 RID: 147138 RVA: 0x00C99A54 File Offset: 0x00C97C54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_depth(IntPtr l)
	{
		int result;
		try
		{
			Texture2DArray texture2DArray = (Texture2DArray)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, texture2DArray.depth);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023EC3 RID: 147139 RVA: 0x00C99AA8 File Offset: 0x00C97CA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_format(IntPtr l)
	{
		int result;
		try
		{
			Texture2DArray texture2DArray = (Texture2DArray)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)texture2DArray.format);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023EC4 RID: 147140 RVA: 0x00C99AFC File Offset: 0x00C97CFC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Texture2DArray");
		if (Lua_UnityEngine_Texture2DArray.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_Texture2DArray.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_Texture2DArray.Apply);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Texture2DArray.<>f__mg$cache0);
		if (Lua_UnityEngine_Texture2DArray.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_Texture2DArray.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_Texture2DArray.SetPixels);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Texture2DArray.<>f__mg$cache1);
		if (Lua_UnityEngine_Texture2DArray.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_Texture2DArray.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_Texture2DArray.SetPixels32);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Texture2DArray.<>f__mg$cache2);
		if (Lua_UnityEngine_Texture2DArray.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_Texture2DArray.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_Texture2DArray.GetPixels);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Texture2DArray.<>f__mg$cache3);
		if (Lua_UnityEngine_Texture2DArray.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_Texture2DArray.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_Texture2DArray.GetPixels32);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Texture2DArray.<>f__mg$cache4);
		string name = "depth";
		if (Lua_UnityEngine_Texture2DArray.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_Texture2DArray.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_Texture2DArray.get_depth);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_Texture2DArray.<>f__mg$cache5, null, true);
		string name2 = "format";
		if (Lua_UnityEngine_Texture2DArray.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_Texture2DArray.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_Texture2DArray.get_format);
		}
		LuaObject.addMember(l, name2, Lua_UnityEngine_Texture2DArray.<>f__mg$cache6, null, true);
		if (Lua_UnityEngine_Texture2DArray.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_Texture2DArray.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_Texture2DArray.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_Texture2DArray.<>f__mg$cache7, typeof(Texture2DArray), typeof(Texture));
	}

	// Token: 0x04019B24 RID: 105252
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019B25 RID: 105253
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019B26 RID: 105254
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019B27 RID: 105255
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019B28 RID: 105256
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04019B29 RID: 105257
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04019B2A RID: 105258
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04019B2B RID: 105259
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;
}
