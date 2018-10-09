using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x0200176B RID: 5995
[Preserve]
public class Lua_UnityEngine_RaycastHit : LuaObject
{
	// Token: 0x06023953 RID: 145747 RVA: 0x00C6E198 File Offset: 0x00C6C398
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			RaycastHit r = default(RaycastHit);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, r);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023954 RID: 145748 RVA: 0x00C6E1E4 File Offset: 0x00C6C3E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_point(IntPtr l)
	{
		int result;
		try
		{
			RaycastHit raycastHit;
			LuaObject.checkValueType<RaycastHit>(l, 1, out raycastHit);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raycastHit.point);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023955 RID: 145749 RVA: 0x00C6E238 File Offset: 0x00C6C438
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_point(IntPtr l)
	{
		int result;
		try
		{
			RaycastHit raycastHit;
			LuaObject.checkValueType<RaycastHit>(l, 1, out raycastHit);
			Vector3 point;
			LuaObject.checkType(l, 2, out point);
			raycastHit.point = point;
			LuaObject.setBack(l, raycastHit);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023956 RID: 145750 RVA: 0x00C6E29C File Offset: 0x00C6C49C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_normal(IntPtr l)
	{
		int result;
		try
		{
			RaycastHit raycastHit;
			LuaObject.checkValueType<RaycastHit>(l, 1, out raycastHit);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raycastHit.normal);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023957 RID: 145751 RVA: 0x00C6E2F0 File Offset: 0x00C6C4F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_normal(IntPtr l)
	{
		int result;
		try
		{
			RaycastHit raycastHit;
			LuaObject.checkValueType<RaycastHit>(l, 1, out raycastHit);
			Vector3 normal;
			LuaObject.checkType(l, 2, out normal);
			raycastHit.normal = normal;
			LuaObject.setBack(l, raycastHit);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023958 RID: 145752 RVA: 0x00C6E354 File Offset: 0x00C6C554
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_barycentricCoordinate(IntPtr l)
	{
		int result;
		try
		{
			RaycastHit raycastHit;
			LuaObject.checkValueType<RaycastHit>(l, 1, out raycastHit);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raycastHit.barycentricCoordinate);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023959 RID: 145753 RVA: 0x00C6E3A8 File Offset: 0x00C6C5A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_barycentricCoordinate(IntPtr l)
	{
		int result;
		try
		{
			RaycastHit raycastHit;
			LuaObject.checkValueType<RaycastHit>(l, 1, out raycastHit);
			Vector3 barycentricCoordinate;
			LuaObject.checkType(l, 2, out barycentricCoordinate);
			raycastHit.barycentricCoordinate = barycentricCoordinate;
			LuaObject.setBack(l, raycastHit);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602395A RID: 145754 RVA: 0x00C6E40C File Offset: 0x00C6C60C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_distance(IntPtr l)
	{
		int result;
		try
		{
			RaycastHit raycastHit;
			LuaObject.checkValueType<RaycastHit>(l, 1, out raycastHit);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raycastHit.distance);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602395B RID: 145755 RVA: 0x00C6E460 File Offset: 0x00C6C660
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_distance(IntPtr l)
	{
		int result;
		try
		{
			RaycastHit raycastHit;
			LuaObject.checkValueType<RaycastHit>(l, 1, out raycastHit);
			float distance;
			LuaObject.checkType(l, 2, out distance);
			raycastHit.distance = distance;
			LuaObject.setBack(l, raycastHit);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602395C RID: 145756 RVA: 0x00C6E4C4 File Offset: 0x00C6C6C4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_triangleIndex(IntPtr l)
	{
		int result;
		try
		{
			RaycastHit raycastHit;
			LuaObject.checkValueType<RaycastHit>(l, 1, out raycastHit);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raycastHit.triangleIndex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602395D RID: 145757 RVA: 0x00C6E518 File Offset: 0x00C6C718
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_textureCoord(IntPtr l)
	{
		int result;
		try
		{
			RaycastHit raycastHit;
			LuaObject.checkValueType<RaycastHit>(l, 1, out raycastHit);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raycastHit.textureCoord);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602395E RID: 145758 RVA: 0x00C6E56C File Offset: 0x00C6C76C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_textureCoord2(IntPtr l)
	{
		int result;
		try
		{
			RaycastHit raycastHit;
			LuaObject.checkValueType<RaycastHit>(l, 1, out raycastHit);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raycastHit.textureCoord2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602395F RID: 145759 RVA: 0x00C6E5C0 File Offset: 0x00C6C7C0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_lightmapCoord(IntPtr l)
	{
		int result;
		try
		{
			RaycastHit raycastHit;
			LuaObject.checkValueType<RaycastHit>(l, 1, out raycastHit);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raycastHit.lightmapCoord);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023960 RID: 145760 RVA: 0x00C6E614 File Offset: 0x00C6C814
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_collider(IntPtr l)
	{
		int result;
		try
		{
			RaycastHit raycastHit;
			LuaObject.checkValueType<RaycastHit>(l, 1, out raycastHit);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raycastHit.collider);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023961 RID: 145761 RVA: 0x00C6E668 File Offset: 0x00C6C868
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_rigidbody(IntPtr l)
	{
		int result;
		try
		{
			RaycastHit raycastHit;
			LuaObject.checkValueType<RaycastHit>(l, 1, out raycastHit);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raycastHit.rigidbody);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023962 RID: 145762 RVA: 0x00C6E6BC File Offset: 0x00C6C8BC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_transform(IntPtr l)
	{
		int result;
		try
		{
			RaycastHit raycastHit;
			LuaObject.checkValueType<RaycastHit>(l, 1, out raycastHit);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raycastHit.transform);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023963 RID: 145763 RVA: 0x00C6E710 File Offset: 0x00C6C910
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.RaycastHit");
		string name = "point";
		if (Lua_UnityEngine_RaycastHit.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_RaycastHit.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_RaycastHit.get_point);
		}
		LuaCSFunction get = Lua_UnityEngine_RaycastHit.<>f__mg$cache0;
		if (Lua_UnityEngine_RaycastHit.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_RaycastHit.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_RaycastHit.set_point);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_RaycastHit.<>f__mg$cache1, true);
		string name2 = "normal";
		if (Lua_UnityEngine_RaycastHit.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_RaycastHit.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_RaycastHit.get_normal);
		}
		LuaCSFunction get2 = Lua_UnityEngine_RaycastHit.<>f__mg$cache2;
		if (Lua_UnityEngine_RaycastHit.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_RaycastHit.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_RaycastHit.set_normal);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_RaycastHit.<>f__mg$cache3, true);
		string name3 = "barycentricCoordinate";
		if (Lua_UnityEngine_RaycastHit.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_RaycastHit.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_RaycastHit.get_barycentricCoordinate);
		}
		LuaCSFunction get3 = Lua_UnityEngine_RaycastHit.<>f__mg$cache4;
		if (Lua_UnityEngine_RaycastHit.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_RaycastHit.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_RaycastHit.set_barycentricCoordinate);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_RaycastHit.<>f__mg$cache5, true);
		string name4 = "distance";
		if (Lua_UnityEngine_RaycastHit.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_RaycastHit.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_RaycastHit.get_distance);
		}
		LuaCSFunction get4 = Lua_UnityEngine_RaycastHit.<>f__mg$cache6;
		if (Lua_UnityEngine_RaycastHit.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_RaycastHit.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_RaycastHit.set_distance);
		}
		LuaObject.addMember(l, name4, get4, Lua_UnityEngine_RaycastHit.<>f__mg$cache7, true);
		string name5 = "triangleIndex";
		if (Lua_UnityEngine_RaycastHit.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_RaycastHit.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_RaycastHit.get_triangleIndex);
		}
		LuaObject.addMember(l, name5, Lua_UnityEngine_RaycastHit.<>f__mg$cache8, null, true);
		string name6 = "textureCoord";
		if (Lua_UnityEngine_RaycastHit.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_RaycastHit.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_RaycastHit.get_textureCoord);
		}
		LuaObject.addMember(l, name6, Lua_UnityEngine_RaycastHit.<>f__mg$cache9, null, true);
		string name7 = "textureCoord2";
		if (Lua_UnityEngine_RaycastHit.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_RaycastHit.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_RaycastHit.get_textureCoord2);
		}
		LuaObject.addMember(l, name7, Lua_UnityEngine_RaycastHit.<>f__mg$cacheA, null, true);
		string name8 = "lightmapCoord";
		if (Lua_UnityEngine_RaycastHit.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_RaycastHit.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_RaycastHit.get_lightmapCoord);
		}
		LuaObject.addMember(l, name8, Lua_UnityEngine_RaycastHit.<>f__mg$cacheB, null, true);
		string name9 = "collider";
		if (Lua_UnityEngine_RaycastHit.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_RaycastHit.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_RaycastHit.get_collider);
		}
		LuaObject.addMember(l, name9, Lua_UnityEngine_RaycastHit.<>f__mg$cacheC, null, true);
		string name10 = "rigidbody";
		if (Lua_UnityEngine_RaycastHit.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_RaycastHit.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_RaycastHit.get_rigidbody);
		}
		LuaObject.addMember(l, name10, Lua_UnityEngine_RaycastHit.<>f__mg$cacheD, null, true);
		string name11 = "transform";
		if (Lua_UnityEngine_RaycastHit.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_RaycastHit.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_RaycastHit.get_transform);
		}
		LuaObject.addMember(l, name11, Lua_UnityEngine_RaycastHit.<>f__mg$cacheE, null, true);
		if (Lua_UnityEngine_RaycastHit.<>f__mg$cacheF == null)
		{
			Lua_UnityEngine_RaycastHit.<>f__mg$cacheF = new LuaCSFunction(Lua_UnityEngine_RaycastHit.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_RaycastHit.<>f__mg$cacheF, typeof(RaycastHit), typeof(ValueType));
	}

	// Token: 0x040196DB RID: 104155
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040196DC RID: 104156
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040196DD RID: 104157
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040196DE RID: 104158
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040196DF RID: 104159
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040196E0 RID: 104160
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040196E1 RID: 104161
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040196E2 RID: 104162
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040196E3 RID: 104163
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040196E4 RID: 104164
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040196E5 RID: 104165
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040196E6 RID: 104166
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040196E7 RID: 104167
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040196E8 RID: 104168
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040196E9 RID: 104169
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040196EA RID: 104170
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;
}
