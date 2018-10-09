using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001729 RID: 5929
[Preserve]
public class Lua_UnityEngine_MeshCollider : LuaObject
{
	// Token: 0x06023687 RID: 145031 RVA: 0x00C52B48 File Offset: 0x00C50D48
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_sharedMesh(IntPtr l)
	{
		int result;
		try
		{
			MeshCollider meshCollider = (MeshCollider)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, meshCollider.sharedMesh);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023688 RID: 145032 RVA: 0x00C52B9C File Offset: 0x00C50D9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_sharedMesh(IntPtr l)
	{
		int result;
		try
		{
			MeshCollider meshCollider = (MeshCollider)LuaObject.checkSelf(l);
			Mesh sharedMesh;
			LuaObject.checkType<Mesh>(l, 2, out sharedMesh);
			meshCollider.sharedMesh = sharedMesh;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023689 RID: 145033 RVA: 0x00C52BF4 File Offset: 0x00C50DF4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_convex(IntPtr l)
	{
		int result;
		try
		{
			MeshCollider meshCollider = (MeshCollider)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, meshCollider.convex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602368A RID: 145034 RVA: 0x00C52C48 File Offset: 0x00C50E48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_convex(IntPtr l)
	{
		int result;
		try
		{
			MeshCollider meshCollider = (MeshCollider)LuaObject.checkSelf(l);
			bool convex;
			LuaObject.checkType(l, 2, out convex);
			meshCollider.convex = convex;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602368B RID: 145035 RVA: 0x00C52CA0 File Offset: 0x00C50EA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_cookingOptions(IntPtr l)
	{
		int result;
		try
		{
			MeshCollider meshCollider = (MeshCollider)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)meshCollider.cookingOptions);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602368C RID: 145036 RVA: 0x00C52CF4 File Offset: 0x00C50EF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_cookingOptions(IntPtr l)
	{
		int result;
		try
		{
			MeshCollider meshCollider = (MeshCollider)LuaObject.checkSelf(l);
			MeshColliderCookingOptions cookingOptions;
			LuaObject.checkEnum<MeshColliderCookingOptions>(l, 2, out cookingOptions);
			meshCollider.cookingOptions = cookingOptions;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602368D RID: 145037 RVA: 0x00C52D4C File Offset: 0x00C50F4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_inflateMesh(IntPtr l)
	{
		int result;
		try
		{
			MeshCollider meshCollider = (MeshCollider)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, meshCollider.inflateMesh);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602368E RID: 145038 RVA: 0x00C52DA0 File Offset: 0x00C50FA0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_inflateMesh(IntPtr l)
	{
		int result;
		try
		{
			MeshCollider meshCollider = (MeshCollider)LuaObject.checkSelf(l);
			bool inflateMesh;
			LuaObject.checkType(l, 2, out inflateMesh);
			meshCollider.inflateMesh = inflateMesh;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602368F RID: 145039 RVA: 0x00C52DF8 File Offset: 0x00C50FF8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_skinWidth(IntPtr l)
	{
		int result;
		try
		{
			MeshCollider meshCollider = (MeshCollider)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, meshCollider.skinWidth);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023690 RID: 145040 RVA: 0x00C52E4C File Offset: 0x00C5104C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_skinWidth(IntPtr l)
	{
		int result;
		try
		{
			MeshCollider meshCollider = (MeshCollider)LuaObject.checkSelf(l);
			float skinWidth;
			LuaObject.checkType(l, 2, out skinWidth);
			meshCollider.skinWidth = skinWidth;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023691 RID: 145041 RVA: 0x00C52EA4 File Offset: 0x00C510A4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.MeshCollider");
		string name = "sharedMesh";
		if (Lua_UnityEngine_MeshCollider.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_MeshCollider.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_MeshCollider.get_sharedMesh);
		}
		LuaCSFunction get = Lua_UnityEngine_MeshCollider.<>f__mg$cache0;
		if (Lua_UnityEngine_MeshCollider.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_MeshCollider.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_MeshCollider.set_sharedMesh);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_MeshCollider.<>f__mg$cache1, true);
		string name2 = "convex";
		if (Lua_UnityEngine_MeshCollider.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_MeshCollider.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_MeshCollider.get_convex);
		}
		LuaCSFunction get2 = Lua_UnityEngine_MeshCollider.<>f__mg$cache2;
		if (Lua_UnityEngine_MeshCollider.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_MeshCollider.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_MeshCollider.set_convex);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_MeshCollider.<>f__mg$cache3, true);
		string name3 = "cookingOptions";
		if (Lua_UnityEngine_MeshCollider.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_MeshCollider.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_MeshCollider.get_cookingOptions);
		}
		LuaCSFunction get3 = Lua_UnityEngine_MeshCollider.<>f__mg$cache4;
		if (Lua_UnityEngine_MeshCollider.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_MeshCollider.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_MeshCollider.set_cookingOptions);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_MeshCollider.<>f__mg$cache5, true);
		string name4 = "inflateMesh";
		if (Lua_UnityEngine_MeshCollider.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_MeshCollider.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_MeshCollider.get_inflateMesh);
		}
		LuaCSFunction get4 = Lua_UnityEngine_MeshCollider.<>f__mg$cache6;
		if (Lua_UnityEngine_MeshCollider.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_MeshCollider.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_MeshCollider.set_inflateMesh);
		}
		LuaObject.addMember(l, name4, get4, Lua_UnityEngine_MeshCollider.<>f__mg$cache7, true);
		string name5 = "skinWidth";
		if (Lua_UnityEngine_MeshCollider.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_MeshCollider.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_MeshCollider.get_skinWidth);
		}
		LuaCSFunction get5 = Lua_UnityEngine_MeshCollider.<>f__mg$cache8;
		if (Lua_UnityEngine_MeshCollider.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_MeshCollider.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_MeshCollider.set_skinWidth);
		}
		LuaObject.addMember(l, name5, get5, Lua_UnityEngine_MeshCollider.<>f__mg$cache9, true);
		LuaObject.createTypeMetatable(l, null, typeof(MeshCollider), typeof(Collider));
	}

	// Token: 0x04019493 RID: 103571
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019494 RID: 103572
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019495 RID: 103573
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019496 RID: 103574
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019497 RID: 103575
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04019498 RID: 103576
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04019499 RID: 103577
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0401949A RID: 103578
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0401949B RID: 103579
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0401949C RID: 103580
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;
}
