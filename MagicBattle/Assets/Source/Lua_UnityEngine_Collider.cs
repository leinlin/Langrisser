using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x0200165D RID: 5725
[Preserve]
public class Lua_UnityEngine_Collider : LuaObject
{
	// Token: 0x06022E49 RID: 142921 RVA: 0x00C0FFB8 File Offset: 0x00C0E1B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClosestPointOnBounds(IntPtr l)
	{
		int result;
		try
		{
			Collider collider = (Collider)LuaObject.checkSelf(l);
			Vector3 position;
			LuaObject.checkType(l, 2, out position);
			Vector3 o = collider.ClosestPointOnBounds(position);
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

	// Token: 0x06022E4A RID: 142922 RVA: 0x00C1001C File Offset: 0x00C0E21C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClosestPoint(IntPtr l)
	{
		int result;
		try
		{
			Collider collider = (Collider)LuaObject.checkSelf(l);
			Vector3 position;
			LuaObject.checkType(l, 2, out position);
			Vector3 o = collider.ClosestPoint(position);
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

	// Token: 0x06022E4B RID: 142923 RVA: 0x00C10080 File Offset: 0x00C0E280
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Raycast(IntPtr l)
	{
		int result;
		try
		{
			Collider collider = (Collider)LuaObject.checkSelf(l);
			Ray ray;
			LuaObject.checkValueType<Ray>(l, 2, out ray);
			float maxDistance;
			LuaObject.checkType(l, 4, out maxDistance);
			RaycastHit r;
			bool b = collider.Raycast(ray, out r, maxDistance);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			LuaObject.pushValue(l, r);
			result = 3;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E4C RID: 142924 RVA: 0x00C100FC File Offset: 0x00C0E2FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_enabled(IntPtr l)
	{
		int result;
		try
		{
			Collider collider = (Collider)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, collider.enabled);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E4D RID: 142925 RVA: 0x00C10150 File Offset: 0x00C0E350
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_enabled(IntPtr l)
	{
		int result;
		try
		{
			Collider collider = (Collider)LuaObject.checkSelf(l);
			bool enabled;
			LuaObject.checkType(l, 2, out enabled);
			collider.enabled = enabled;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E4E RID: 142926 RVA: 0x00C101A8 File Offset: 0x00C0E3A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_attachedRigidbody(IntPtr l)
	{
		int result;
		try
		{
			Collider collider = (Collider)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, collider.attachedRigidbody);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E4F RID: 142927 RVA: 0x00C101FC File Offset: 0x00C0E3FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_isTrigger(IntPtr l)
	{
		int result;
		try
		{
			Collider collider = (Collider)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, collider.isTrigger);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E50 RID: 142928 RVA: 0x00C10250 File Offset: 0x00C0E450
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_isTrigger(IntPtr l)
	{
		int result;
		try
		{
			Collider collider = (Collider)LuaObject.checkSelf(l);
			bool isTrigger;
			LuaObject.checkType(l, 2, out isTrigger);
			collider.isTrigger = isTrigger;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E51 RID: 142929 RVA: 0x00C102A8 File Offset: 0x00C0E4A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_contactOffset(IntPtr l)
	{
		int result;
		try
		{
			Collider collider = (Collider)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, collider.contactOffset);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E52 RID: 142930 RVA: 0x00C102FC File Offset: 0x00C0E4FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_contactOffset(IntPtr l)
	{
		int result;
		try
		{
			Collider collider = (Collider)LuaObject.checkSelf(l);
			float contactOffset;
			LuaObject.checkType(l, 2, out contactOffset);
			collider.contactOffset = contactOffset;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E53 RID: 142931 RVA: 0x00C10354 File Offset: 0x00C0E554
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_material(IntPtr l)
	{
		int result;
		try
		{
			Collider collider = (Collider)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, collider.material);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E54 RID: 142932 RVA: 0x00C103A8 File Offset: 0x00C0E5A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_material(IntPtr l)
	{
		int result;
		try
		{
			Collider collider = (Collider)LuaObject.checkSelf(l);
			PhysicMaterial material;
			LuaObject.checkType<PhysicMaterial>(l, 2, out material);
			collider.material = material;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E55 RID: 142933 RVA: 0x00C10400 File Offset: 0x00C0E600
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_sharedMaterial(IntPtr l)
	{
		int result;
		try
		{
			Collider collider = (Collider)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, collider.sharedMaterial);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E56 RID: 142934 RVA: 0x00C10454 File Offset: 0x00C0E654
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_sharedMaterial(IntPtr l)
	{
		int result;
		try
		{
			Collider collider = (Collider)LuaObject.checkSelf(l);
			PhysicMaterial sharedMaterial;
			LuaObject.checkType<PhysicMaterial>(l, 2, out sharedMaterial);
			collider.sharedMaterial = sharedMaterial;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E57 RID: 142935 RVA: 0x00C104AC File Offset: 0x00C0E6AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_bounds(IntPtr l)
	{
		int result;
		try
		{
			Collider collider = (Collider)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, collider.bounds);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E58 RID: 142936 RVA: 0x00C10504 File Offset: 0x00C0E704
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Collider");
		if (Lua_UnityEngine_Collider.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_Collider.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_Collider.ClosestPointOnBounds);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Collider.<>f__mg$cache0);
		if (Lua_UnityEngine_Collider.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_Collider.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_Collider.ClosestPoint);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Collider.<>f__mg$cache1);
		if (Lua_UnityEngine_Collider.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_Collider.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_Collider.Raycast);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Collider.<>f__mg$cache2);
		string name = "enabled";
		if (Lua_UnityEngine_Collider.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_Collider.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_Collider.get_enabled);
		}
		LuaCSFunction get = Lua_UnityEngine_Collider.<>f__mg$cache3;
		if (Lua_UnityEngine_Collider.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_Collider.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_Collider.set_enabled);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_Collider.<>f__mg$cache4, true);
		string name2 = "attachedRigidbody";
		if (Lua_UnityEngine_Collider.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_Collider.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_Collider.get_attachedRigidbody);
		}
		LuaObject.addMember(l, name2, Lua_UnityEngine_Collider.<>f__mg$cache5, null, true);
		string name3 = "isTrigger";
		if (Lua_UnityEngine_Collider.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_Collider.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_Collider.get_isTrigger);
		}
		LuaCSFunction get2 = Lua_UnityEngine_Collider.<>f__mg$cache6;
		if (Lua_UnityEngine_Collider.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_Collider.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_Collider.set_isTrigger);
		}
		LuaObject.addMember(l, name3, get2, Lua_UnityEngine_Collider.<>f__mg$cache7, true);
		string name4 = "contactOffset";
		if (Lua_UnityEngine_Collider.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_Collider.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_Collider.get_contactOffset);
		}
		LuaCSFunction get3 = Lua_UnityEngine_Collider.<>f__mg$cache8;
		if (Lua_UnityEngine_Collider.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_Collider.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_Collider.set_contactOffset);
		}
		LuaObject.addMember(l, name4, get3, Lua_UnityEngine_Collider.<>f__mg$cache9, true);
		string name5 = "material";
		if (Lua_UnityEngine_Collider.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_Collider.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_Collider.get_material);
		}
		LuaCSFunction get4 = Lua_UnityEngine_Collider.<>f__mg$cacheA;
		if (Lua_UnityEngine_Collider.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_Collider.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_Collider.set_material);
		}
		LuaObject.addMember(l, name5, get4, Lua_UnityEngine_Collider.<>f__mg$cacheB, true);
		string name6 = "sharedMaterial";
		if (Lua_UnityEngine_Collider.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_Collider.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_Collider.get_sharedMaterial);
		}
		LuaCSFunction get5 = Lua_UnityEngine_Collider.<>f__mg$cacheC;
		if (Lua_UnityEngine_Collider.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_Collider.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_Collider.set_sharedMaterial);
		}
		LuaObject.addMember(l, name6, get5, Lua_UnityEngine_Collider.<>f__mg$cacheD, true);
		string name7 = "bounds";
		if (Lua_UnityEngine_Collider.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_Collider.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_Collider.get_bounds);
		}
		LuaObject.addMember(l, name7, Lua_UnityEngine_Collider.<>f__mg$cacheE, null, true);
		LuaObject.createTypeMetatable(l, null, typeof(Collider), typeof(Component));
	}

	// Token: 0x04018DED RID: 101869
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04018DEE RID: 101870
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04018DEF RID: 101871
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04018DF0 RID: 101872
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04018DF1 RID: 101873
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04018DF2 RID: 101874
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04018DF3 RID: 101875
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04018DF4 RID: 101876
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04018DF5 RID: 101877
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04018DF6 RID: 101878
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04018DF7 RID: 101879
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04018DF8 RID: 101880
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04018DF9 RID: 101881
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04018DFA RID: 101882
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04018DFB RID: 101883
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;
}
