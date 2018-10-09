using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x020017DC RID: 6108
[Preserve]
public class Lua_UnityEngine_SparseTexture : LuaObject
{
	// Token: 0x06023D69 RID: 146793 RVA: 0x00C8F6F0 File Offset: 0x00C8D8F0
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
				int width;
				LuaObject.checkType(l, 2, out width);
				int height;
				LuaObject.checkType(l, 3, out height);
				TextureFormat format;
				LuaObject.checkEnum<TextureFormat>(l, 4, out format);
				int mipCount;
				LuaObject.checkType(l, 5, out mipCount);
				SparseTexture o = new SparseTexture(width, height, format, mipCount);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (num == 6)
			{
				int width2;
				LuaObject.checkType(l, 2, out width2);
				int height2;
				LuaObject.checkType(l, 3, out height2);
				TextureFormat format2;
				LuaObject.checkEnum<TextureFormat>(l, 4, out format2);
				int mipCount2;
				LuaObject.checkType(l, 5, out mipCount2);
				bool linear;
				LuaObject.checkType(l, 6, out linear);
				SparseTexture o = new SparseTexture(width2, height2, format2, mipCount2, linear);
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

	// Token: 0x06023D6A RID: 146794 RVA: 0x00C8F7EC File Offset: 0x00C8D9EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateTile(IntPtr l)
	{
		int result;
		try
		{
			SparseTexture sparseTexture = (SparseTexture)LuaObject.checkSelf(l);
			int tileX;
			LuaObject.checkType(l, 2, out tileX);
			int tileY;
			LuaObject.checkType(l, 3, out tileY);
			int miplevel;
			LuaObject.checkType(l, 4, out miplevel);
			Color32[] data;
			LuaObject.checkArray<Color32>(l, 5, out data);
			sparseTexture.UpdateTile(tileX, tileY, miplevel, data);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D6B RID: 146795 RVA: 0x00C8F86C File Offset: 0x00C8DA6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateTileRaw(IntPtr l)
	{
		int result;
		try
		{
			SparseTexture sparseTexture = (SparseTexture)LuaObject.checkSelf(l);
			int tileX;
			LuaObject.checkType(l, 2, out tileX);
			int tileY;
			LuaObject.checkType(l, 3, out tileY);
			int miplevel;
			LuaObject.checkType(l, 4, out miplevel);
			byte[] data;
			LuaObject.checkArray<byte>(l, 5, out data);
			sparseTexture.UpdateTileRaw(tileX, tileY, miplevel, data);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D6C RID: 146796 RVA: 0x00C8F8EC File Offset: 0x00C8DAEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UnloadTile(IntPtr l)
	{
		int result;
		try
		{
			SparseTexture sparseTexture = (SparseTexture)LuaObject.checkSelf(l);
			int tileX;
			LuaObject.checkType(l, 2, out tileX);
			int tileY;
			LuaObject.checkType(l, 3, out tileY);
			int miplevel;
			LuaObject.checkType(l, 4, out miplevel);
			sparseTexture.UnloadTile(tileX, tileY, miplevel);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D6D RID: 146797 RVA: 0x00C8F960 File Offset: 0x00C8DB60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_tileWidth(IntPtr l)
	{
		int result;
		try
		{
			SparseTexture sparseTexture = (SparseTexture)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, sparseTexture.tileWidth);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D6E RID: 146798 RVA: 0x00C8F9B4 File Offset: 0x00C8DBB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_tileHeight(IntPtr l)
	{
		int result;
		try
		{
			SparseTexture sparseTexture = (SparseTexture)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, sparseTexture.tileHeight);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D6F RID: 146799 RVA: 0x00C8FA08 File Offset: 0x00C8DC08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_isCreated(IntPtr l)
	{
		int result;
		try
		{
			SparseTexture sparseTexture = (SparseTexture)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, sparseTexture.isCreated);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D70 RID: 146800 RVA: 0x00C8FA5C File Offset: 0x00C8DC5C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.SparseTexture");
		if (Lua_UnityEngine_SparseTexture.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_SparseTexture.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_SparseTexture.UpdateTile);
		}
		LuaObject.addMember(l, Lua_UnityEngine_SparseTexture.<>f__mg$cache0);
		if (Lua_UnityEngine_SparseTexture.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_SparseTexture.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_SparseTexture.UpdateTileRaw);
		}
		LuaObject.addMember(l, Lua_UnityEngine_SparseTexture.<>f__mg$cache1);
		if (Lua_UnityEngine_SparseTexture.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_SparseTexture.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_SparseTexture.UnloadTile);
		}
		LuaObject.addMember(l, Lua_UnityEngine_SparseTexture.<>f__mg$cache2);
		string name = "tileWidth";
		if (Lua_UnityEngine_SparseTexture.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_SparseTexture.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_SparseTexture.get_tileWidth);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_SparseTexture.<>f__mg$cache3, null, true);
		string name2 = "tileHeight";
		if (Lua_UnityEngine_SparseTexture.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_SparseTexture.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_SparseTexture.get_tileHeight);
		}
		LuaObject.addMember(l, name2, Lua_UnityEngine_SparseTexture.<>f__mg$cache4, null, true);
		string name3 = "isCreated";
		if (Lua_UnityEngine_SparseTexture.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_SparseTexture.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_SparseTexture.get_isCreated);
		}
		LuaObject.addMember(l, name3, Lua_UnityEngine_SparseTexture.<>f__mg$cache5, null, true);
		if (Lua_UnityEngine_SparseTexture.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_SparseTexture.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_SparseTexture.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_SparseTexture.<>f__mg$cache6, typeof(SparseTexture), typeof(Texture));
	}

	// Token: 0x04019A0F RID: 104975
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019A10 RID: 104976
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019A11 RID: 104977
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019A12 RID: 104978
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019A13 RID: 104979
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04019A14 RID: 104980
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04019A15 RID: 104981
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;
}
