using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x020017FC RID: 6140
[Preserve]
public class Lua_UnityEngine_Texture3D : LuaObject
{
	// Token: 0x06023EC6 RID: 147142 RVA: 0x00C99C58 File Offset: 0x00C97E58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
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
			Texture3D o = new Texture3D(width, height, depth, format, mipmap);
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

	// Token: 0x06023EC7 RID: 147143 RVA: 0x00C99CE0 File Offset: 0x00C97EE0
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
				Texture3D texture3D = (Texture3D)LuaObject.checkSelf(l);
				int miplevel;
				LuaObject.checkType(l, 2, out miplevel);
				Color[] pixels = texture3D.GetPixels(miplevel);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, pixels);
				result = 2;
			}
			else if (num == 1)
			{
				Texture3D texture3D2 = (Texture3D)LuaObject.checkSelf(l);
				Color[] pixels2 = texture3D2.GetPixels();
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

	// Token: 0x06023EC8 RID: 147144 RVA: 0x00C99DA0 File Offset: 0x00C97FA0
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
				Texture3D texture3D = (Texture3D)LuaObject.checkSelf(l);
				int miplevel;
				LuaObject.checkType(l, 2, out miplevel);
				Color32[] pixels = texture3D.GetPixels32(miplevel);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, pixels);
				result = 2;
			}
			else if (num == 1)
			{
				Texture3D texture3D2 = (Texture3D)LuaObject.checkSelf(l);
				Color32[] pixels2 = texture3D2.GetPixels32();
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

	// Token: 0x06023EC9 RID: 147145 RVA: 0x00C99E60 File Offset: 0x00C98060
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
				Texture3D texture3D = (Texture3D)LuaObject.checkSelf(l);
				Color[] pixels;
				LuaObject.checkArray<Color>(l, 2, out pixels);
				texture3D.SetPixels(pixels);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 3)
			{
				Texture3D texture3D2 = (Texture3D)LuaObject.checkSelf(l);
				Color[] colors;
				LuaObject.checkArray<Color>(l, 2, out colors);
				int miplevel;
				LuaObject.checkType(l, 3, out miplevel);
				texture3D2.SetPixels(colors, miplevel);
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

	// Token: 0x06023ECA RID: 147146 RVA: 0x00C99F24 File Offset: 0x00C98124
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
				Texture3D texture3D = (Texture3D)LuaObject.checkSelf(l);
				Color32[] pixels;
				LuaObject.checkArray<Color32>(l, 2, out pixels);
				texture3D.SetPixels32(pixels);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 3)
			{
				Texture3D texture3D2 = (Texture3D)LuaObject.checkSelf(l);
				Color32[] colors;
				LuaObject.checkArray<Color32>(l, 2, out colors);
				int miplevel;
				LuaObject.checkType(l, 3, out miplevel);
				texture3D2.SetPixels32(colors, miplevel);
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

	// Token: 0x06023ECB RID: 147147 RVA: 0x00C99FE8 File Offset: 0x00C981E8
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
				Texture3D texture3D = (Texture3D)LuaObject.checkSelf(l);
				texture3D.Apply();
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 2)
			{
				Texture3D texture3D2 = (Texture3D)LuaObject.checkSelf(l);
				bool updateMipmaps;
				LuaObject.checkType(l, 2, out updateMipmaps);
				texture3D2.Apply(updateMipmaps);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 3)
			{
				Texture3D texture3D3 = (Texture3D)LuaObject.checkSelf(l);
				bool updateMipmaps2;
				LuaObject.checkType(l, 2, out updateMipmaps2);
				bool makeNoLongerReadable;
				LuaObject.checkType(l, 3, out makeNoLongerReadable);
				texture3D3.Apply(updateMipmaps2, makeNoLongerReadable);
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

	// Token: 0x06023ECC RID: 147148 RVA: 0x00C9A0D4 File Offset: 0x00C982D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_depth(IntPtr l)
	{
		int result;
		try
		{
			Texture3D texture3D = (Texture3D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, texture3D.depth);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023ECD RID: 147149 RVA: 0x00C9A128 File Offset: 0x00C98328
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_format(IntPtr l)
	{
		int result;
		try
		{
			Texture3D texture3D = (Texture3D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)texture3D.format);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023ECE RID: 147150 RVA: 0x00C9A17C File Offset: 0x00C9837C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Texture3D");
		if (Lua_UnityEngine_Texture3D.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_Texture3D.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_Texture3D.GetPixels);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Texture3D.<>f__mg$cache0);
		if (Lua_UnityEngine_Texture3D.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_Texture3D.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_Texture3D.GetPixels32);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Texture3D.<>f__mg$cache1);
		if (Lua_UnityEngine_Texture3D.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_Texture3D.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_Texture3D.SetPixels);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Texture3D.<>f__mg$cache2);
		if (Lua_UnityEngine_Texture3D.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_Texture3D.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_Texture3D.SetPixels32);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Texture3D.<>f__mg$cache3);
		if (Lua_UnityEngine_Texture3D.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_Texture3D.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_Texture3D.Apply);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Texture3D.<>f__mg$cache4);
		string name = "depth";
		if (Lua_UnityEngine_Texture3D.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_Texture3D.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_Texture3D.get_depth);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_Texture3D.<>f__mg$cache5, null, true);
		string name2 = "format";
		if (Lua_UnityEngine_Texture3D.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_Texture3D.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_Texture3D.get_format);
		}
		LuaObject.addMember(l, name2, Lua_UnityEngine_Texture3D.<>f__mg$cache6, null, true);
		if (Lua_UnityEngine_Texture3D.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_Texture3D.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_Texture3D.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_Texture3D.<>f__mg$cache7, typeof(Texture3D), typeof(Texture));
	}

	// Token: 0x04019B2C RID: 105260
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019B2D RID: 105261
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019B2E RID: 105262
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019B2F RID: 105263
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019B30 RID: 105264
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04019B31 RID: 105265
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04019B32 RID: 105266
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04019B33 RID: 105267
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;
}
