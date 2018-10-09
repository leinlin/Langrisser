using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x0200172B RID: 5931
[Preserve]
public class Lua_UnityEngine_MeshFilter : LuaObject
{
	// Token: 0x06023695 RID: 145045 RVA: 0x00C530A4 File Offset: 0x00C512A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_sharedMesh(IntPtr l)
	{
		int result;
		try
		{
			MeshFilter meshFilter = (MeshFilter)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, meshFilter.sharedMesh);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023696 RID: 145046 RVA: 0x00C530F8 File Offset: 0x00C512F8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_sharedMesh(IntPtr l)
	{
		int result;
		try
		{
			MeshFilter meshFilter = (MeshFilter)LuaObject.checkSelf(l);
			Mesh sharedMesh;
			LuaObject.checkType<Mesh>(l, 2, out sharedMesh);
			meshFilter.sharedMesh = sharedMesh;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023697 RID: 145047 RVA: 0x00C53150 File Offset: 0x00C51350
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_mesh(IntPtr l)
	{
		int result;
		try
		{
			MeshFilter meshFilter = (MeshFilter)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, meshFilter.mesh);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023698 RID: 145048 RVA: 0x00C531A4 File Offset: 0x00C513A4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_mesh(IntPtr l)
	{
		int result;
		try
		{
			MeshFilter meshFilter = (MeshFilter)LuaObject.checkSelf(l);
			Mesh mesh;
			LuaObject.checkType<Mesh>(l, 2, out mesh);
			meshFilter.mesh = mesh;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023699 RID: 145049 RVA: 0x00C531FC File Offset: 0x00C513FC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.MeshFilter");
		string name = "sharedMesh";
		if (Lua_UnityEngine_MeshFilter.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_MeshFilter.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_MeshFilter.get_sharedMesh);
		}
		LuaCSFunction get = Lua_UnityEngine_MeshFilter.<>f__mg$cache0;
		if (Lua_UnityEngine_MeshFilter.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_MeshFilter.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_MeshFilter.set_sharedMesh);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_MeshFilter.<>f__mg$cache1, true);
		string name2 = "mesh";
		if (Lua_UnityEngine_MeshFilter.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_MeshFilter.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_MeshFilter.get_mesh);
		}
		LuaCSFunction get2 = Lua_UnityEngine_MeshFilter.<>f__mg$cache2;
		if (Lua_UnityEngine_MeshFilter.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_MeshFilter.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_MeshFilter.set_mesh);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_MeshFilter.<>f__mg$cache3, true);
		LuaObject.createTypeMetatable(l, null, typeof(MeshFilter), typeof(Component));
	}

	// Token: 0x0401949D RID: 103581
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401949E RID: 103582
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401949F RID: 103583
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040194A0 RID: 103584
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;
}
