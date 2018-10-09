using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

// Token: 0x0200179F RID: 6047
[Preserve]
public class Lua_UnityEngine_Rendering_RenderTargetIdentifier : LuaObject
{
	// Token: 0x06023B0C RID: 146188 RVA: 0x00C7CF18 File Offset: 0x00C7B118
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, num, 2, typeof(BuiltinRenderTextureType)))
			{
				BuiltinRenderTextureType type;
				LuaObject.checkEnum<BuiltinRenderTextureType>(l, 2, out type);
				RenderTargetIdentifier renderTargetIdentifier = new RenderTargetIdentifier(type);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, renderTargetIdentifier);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(string)))
			{
				string name;
				LuaObject.checkType(l, 2, out name);
				RenderTargetIdentifier renderTargetIdentifier = new RenderTargetIdentifier(name);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, renderTargetIdentifier);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(string), typeof(int), typeof(CubemapFace), typeof(int)))
			{
				string name2;
				LuaObject.checkType(l, 2, out name2);
				int mipLevel;
				LuaObject.checkType(l, 3, out mipLevel);
				CubemapFace cubeFace;
				LuaObject.checkEnum<CubemapFace>(l, 4, out cubeFace);
				int depthSlice;
				LuaObject.checkType(l, 5, out depthSlice);
				RenderTargetIdentifier renderTargetIdentifier = new RenderTargetIdentifier(name2, mipLevel, cubeFace, depthSlice);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, renderTargetIdentifier);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(int)))
			{
				int nameID;
				LuaObject.checkType(l, 2, out nameID);
				RenderTargetIdentifier renderTargetIdentifier = new RenderTargetIdentifier(nameID);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, renderTargetIdentifier);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(int), typeof(int), typeof(CubemapFace), typeof(int)))
			{
				int nameID2;
				LuaObject.checkType(l, 2, out nameID2);
				int mipLevel2;
				LuaObject.checkType(l, 3, out mipLevel2);
				CubemapFace cubeFace2;
				LuaObject.checkEnum<CubemapFace>(l, 4, out cubeFace2);
				int depthSlice2;
				LuaObject.checkType(l, 5, out depthSlice2);
				RenderTargetIdentifier renderTargetIdentifier = new RenderTargetIdentifier(nameID2, mipLevel2, cubeFace2, depthSlice2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, renderTargetIdentifier);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(Texture)))
			{
				Texture tex;
				LuaObject.checkType<Texture>(l, 2, out tex);
				RenderTargetIdentifier renderTargetIdentifier = new RenderTargetIdentifier(tex);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, renderTargetIdentifier);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(Texture), typeof(int), typeof(CubemapFace), typeof(int)))
			{
				Texture tex2;
				LuaObject.checkType<Texture>(l, 2, out tex2);
				int mipLevel3;
				LuaObject.checkType(l, 3, out mipLevel3);
				CubemapFace cubeFace3;
				LuaObject.checkEnum<CubemapFace>(l, 4, out cubeFace3);
				int depthSlice3;
				LuaObject.checkType(l, 5, out depthSlice3);
				RenderTargetIdentifier renderTargetIdentifier = new RenderTargetIdentifier(tex2, mipLevel3, cubeFace3, depthSlice3);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, renderTargetIdentifier);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(RenderBuffer), typeof(int), typeof(CubemapFace), typeof(int)))
			{
				RenderBuffer buf;
				LuaObject.checkValueType<RenderBuffer>(l, 2, out buf);
				int mipLevel4;
				LuaObject.checkType(l, 3, out mipLevel4);
				CubemapFace cubeFace4;
				LuaObject.checkEnum<CubemapFace>(l, 4, out cubeFace4);
				int depthSlice4;
				LuaObject.checkType(l, 5, out depthSlice4);
				RenderTargetIdentifier renderTargetIdentifier = new RenderTargetIdentifier(buf, mipLevel4, cubeFace4, depthSlice4);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, renderTargetIdentifier);
				result = 2;
			}
			else if (num == 0)
			{
				RenderTargetIdentifier renderTargetIdentifier = default(RenderTargetIdentifier);
				LuaObject.pushValue(l, true);
				LuaObject.pushObject(l, renderTargetIdentifier);
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

	// Token: 0x06023B0D RID: 146189 RVA: 0x00C7D2BC File Offset: 0x00C7B4BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int op_Equality(IntPtr l)
	{
		int result;
		try
		{
			RenderTargetIdentifier lhs;
			LuaObject.checkValueType<RenderTargetIdentifier>(l, 1, out lhs);
			RenderTargetIdentifier rhs;
			LuaObject.checkValueType<RenderTargetIdentifier>(l, 2, out rhs);
			bool b = lhs == rhs;
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

	// Token: 0x06023B0E RID: 146190 RVA: 0x00C7D31C File Offset: 0x00C7B51C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int op_Inequality(IntPtr l)
	{
		int result;
		try
		{
			RenderTargetIdentifier lhs;
			LuaObject.checkValueType<RenderTargetIdentifier>(l, 1, out lhs);
			RenderTargetIdentifier rhs;
			LuaObject.checkValueType<RenderTargetIdentifier>(l, 2, out rhs);
			bool b = lhs != rhs;
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

	// Token: 0x06023B0F RID: 146191 RVA: 0x00C7D37C File Offset: 0x00C7B57C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Rendering.RenderTargetIdentifier");
		if (Lua_UnityEngine_Rendering_RenderTargetIdentifier.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_Rendering_RenderTargetIdentifier.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_Rendering_RenderTargetIdentifier.op_Equality);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rendering_RenderTargetIdentifier.<>f__mg$cache0);
		if (Lua_UnityEngine_Rendering_RenderTargetIdentifier.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_Rendering_RenderTargetIdentifier.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_Rendering_RenderTargetIdentifier.op_Inequality);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Rendering_RenderTargetIdentifier.<>f__mg$cache1);
		if (Lua_UnityEngine_Rendering_RenderTargetIdentifier.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_Rendering_RenderTargetIdentifier.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_Rendering_RenderTargetIdentifier.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_Rendering_RenderTargetIdentifier.<>f__mg$cache2, typeof(RenderTargetIdentifier), typeof(ValueType));
	}

	// Token: 0x0401982C RID: 104492
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401982D RID: 104493
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401982E RID: 104494
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;
}
