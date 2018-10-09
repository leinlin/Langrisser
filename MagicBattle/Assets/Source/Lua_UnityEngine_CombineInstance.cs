using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x0200166A RID: 5738
[Preserve]
public class Lua_UnityEngine_CombineInstance : LuaObject
{
	// Token: 0x06022EDD RID: 143069 RVA: 0x00C14A1C File Offset: 0x00C12C1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			CombineInstance combineInstance = default(CombineInstance);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combineInstance);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022EDE RID: 143070 RVA: 0x00C14A6C File Offset: 0x00C12C6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_mesh(IntPtr l)
	{
		int result;
		try
		{
			CombineInstance combineInstance;
			LuaObject.checkValueType<CombineInstance>(l, 1, out combineInstance);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combineInstance.mesh);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022EDF RID: 143071 RVA: 0x00C14AC0 File Offset: 0x00C12CC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_mesh(IntPtr l)
	{
		int result;
		try
		{
			CombineInstance combineInstance;
			LuaObject.checkValueType<CombineInstance>(l, 1, out combineInstance);
			Mesh mesh;
			LuaObject.checkType<Mesh>(l, 2, out mesh);
			combineInstance.mesh = mesh;
			LuaObject.setBack(l, combineInstance);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022EE0 RID: 143072 RVA: 0x00C14B24 File Offset: 0x00C12D24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_subMeshIndex(IntPtr l)
	{
		int result;
		try
		{
			CombineInstance combineInstance;
			LuaObject.checkValueType<CombineInstance>(l, 1, out combineInstance);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combineInstance.subMeshIndex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022EE1 RID: 143073 RVA: 0x00C14B78 File Offset: 0x00C12D78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_subMeshIndex(IntPtr l)
	{
		int result;
		try
		{
			CombineInstance combineInstance;
			LuaObject.checkValueType<CombineInstance>(l, 1, out combineInstance);
			int subMeshIndex;
			LuaObject.checkType(l, 2, out subMeshIndex);
			combineInstance.subMeshIndex = subMeshIndex;
			LuaObject.setBack(l, combineInstance);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022EE2 RID: 143074 RVA: 0x00C14BDC File Offset: 0x00C12DDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_transform(IntPtr l)
	{
		int result;
		try
		{
			CombineInstance combineInstance;
			LuaObject.checkValueType<CombineInstance>(l, 1, out combineInstance);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combineInstance.transform);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022EE3 RID: 143075 RVA: 0x00C14C34 File Offset: 0x00C12E34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_transform(IntPtr l)
	{
		int result;
		try
		{
			CombineInstance combineInstance;
			LuaObject.checkValueType<CombineInstance>(l, 1, out combineInstance);
			Matrix4x4 transform;
			LuaObject.checkValueType<Matrix4x4>(l, 2, out transform);
			combineInstance.transform = transform;
			LuaObject.setBack(l, combineInstance);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022EE4 RID: 143076 RVA: 0x00C14C98 File Offset: 0x00C12E98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_lightmapScaleOffset(IntPtr l)
	{
		int result;
		try
		{
			CombineInstance combineInstance;
			LuaObject.checkValueType<CombineInstance>(l, 1, out combineInstance);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combineInstance.lightmapScaleOffset);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022EE5 RID: 143077 RVA: 0x00C14CEC File Offset: 0x00C12EEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_lightmapScaleOffset(IntPtr l)
	{
		int result;
		try
		{
			CombineInstance combineInstance;
			LuaObject.checkValueType<CombineInstance>(l, 1, out combineInstance);
			Vector4 lightmapScaleOffset;
			LuaObject.checkType(l, 2, out lightmapScaleOffset);
			combineInstance.lightmapScaleOffset = lightmapScaleOffset;
			LuaObject.setBack(l, combineInstance);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022EE6 RID: 143078 RVA: 0x00C14D50 File Offset: 0x00C12F50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_realtimeLightmapScaleOffset(IntPtr l)
	{
		int result;
		try
		{
			CombineInstance combineInstance;
			LuaObject.checkValueType<CombineInstance>(l, 1, out combineInstance);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, combineInstance.realtimeLightmapScaleOffset);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022EE7 RID: 143079 RVA: 0x00C14DA4 File Offset: 0x00C12FA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_realtimeLightmapScaleOffset(IntPtr l)
	{
		int result;
		try
		{
			CombineInstance combineInstance;
			LuaObject.checkValueType<CombineInstance>(l, 1, out combineInstance);
			Vector4 realtimeLightmapScaleOffset;
			LuaObject.checkType(l, 2, out realtimeLightmapScaleOffset);
			combineInstance.realtimeLightmapScaleOffset = realtimeLightmapScaleOffset;
			LuaObject.setBack(l, combineInstance);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022EE8 RID: 143080 RVA: 0x00C14E08 File Offset: 0x00C13008
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.CombineInstance");
		string name = "mesh";
		if (Lua_UnityEngine_CombineInstance.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_CombineInstance.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_CombineInstance.get_mesh);
		}
		LuaCSFunction get = Lua_UnityEngine_CombineInstance.<>f__mg$cache0;
		if (Lua_UnityEngine_CombineInstance.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_CombineInstance.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_CombineInstance.set_mesh);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_CombineInstance.<>f__mg$cache1, true);
		string name2 = "subMeshIndex";
		if (Lua_UnityEngine_CombineInstance.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_CombineInstance.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_CombineInstance.get_subMeshIndex);
		}
		LuaCSFunction get2 = Lua_UnityEngine_CombineInstance.<>f__mg$cache2;
		if (Lua_UnityEngine_CombineInstance.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_CombineInstance.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_CombineInstance.set_subMeshIndex);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_CombineInstance.<>f__mg$cache3, true);
		string name3 = "transform";
		if (Lua_UnityEngine_CombineInstance.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_CombineInstance.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_CombineInstance.get_transform);
		}
		LuaCSFunction get3 = Lua_UnityEngine_CombineInstance.<>f__mg$cache4;
		if (Lua_UnityEngine_CombineInstance.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_CombineInstance.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_CombineInstance.set_transform);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_CombineInstance.<>f__mg$cache5, true);
		string name4 = "lightmapScaleOffset";
		if (Lua_UnityEngine_CombineInstance.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_CombineInstance.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_CombineInstance.get_lightmapScaleOffset);
		}
		LuaCSFunction get4 = Lua_UnityEngine_CombineInstance.<>f__mg$cache6;
		if (Lua_UnityEngine_CombineInstance.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_CombineInstance.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_CombineInstance.set_lightmapScaleOffset);
		}
		LuaObject.addMember(l, name4, get4, Lua_UnityEngine_CombineInstance.<>f__mg$cache7, true);
		string name5 = "realtimeLightmapScaleOffset";
		if (Lua_UnityEngine_CombineInstance.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_CombineInstance.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_CombineInstance.get_realtimeLightmapScaleOffset);
		}
		LuaCSFunction get5 = Lua_UnityEngine_CombineInstance.<>f__mg$cache8;
		if (Lua_UnityEngine_CombineInstance.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_CombineInstance.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_CombineInstance.set_realtimeLightmapScaleOffset);
		}
		LuaObject.addMember(l, name5, get5, Lua_UnityEngine_CombineInstance.<>f__mg$cache9, true);
		if (Lua_UnityEngine_CombineInstance.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_CombineInstance.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_CombineInstance.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_CombineInstance.<>f__mg$cacheA, typeof(CombineInstance), typeof(ValueType));
	}

	// Token: 0x04018E67 RID: 101991
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04018E68 RID: 101992
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04018E69 RID: 101993
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04018E6A RID: 101994
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04018E6B RID: 101995
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04018E6C RID: 101996
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04018E6D RID: 101997
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04018E6E RID: 101998
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04018E6F RID: 101999
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04018E70 RID: 102000
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04018E71 RID: 102001
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;
}
