using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x0200176C RID: 5996
[Preserve]
public class Lua_UnityEngine_RaycastHit2D : LuaObject
{
	// Token: 0x06023965 RID: 145765 RVA: 0x00C6E9A8 File Offset: 0x00C6CBA8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			RaycastHit2D r = default(RaycastHit2D);
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

	// Token: 0x06023966 RID: 145766 RVA: 0x00C6E9F4 File Offset: 0x00C6CBF4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CompareTo(IntPtr l)
	{
		int result;
		try
		{
			RaycastHit2D raycastHit2D;
			LuaObject.checkValueType<RaycastHit2D>(l, 1, out raycastHit2D);
			RaycastHit2D other;
			LuaObject.checkValueType<RaycastHit2D>(l, 2, out other);
			int i = raycastHit2D.CompareTo(other);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023967 RID: 145767 RVA: 0x00C6EA54 File Offset: 0x00C6CC54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_centroid(IntPtr l)
	{
		int result;
		try
		{
			RaycastHit2D raycastHit2D;
			LuaObject.checkValueType<RaycastHit2D>(l, 1, out raycastHit2D);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raycastHit2D.centroid);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023968 RID: 145768 RVA: 0x00C6EAA8 File Offset: 0x00C6CCA8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_centroid(IntPtr l)
	{
		int result;
		try
		{
			RaycastHit2D raycastHit2D;
			LuaObject.checkValueType<RaycastHit2D>(l, 1, out raycastHit2D);
			Vector2 centroid;
			LuaObject.checkType(l, 2, out centroid);
			raycastHit2D.centroid = centroid;
			LuaObject.setBack(l, raycastHit2D);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023969 RID: 145769 RVA: 0x00C6EB0C File Offset: 0x00C6CD0C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_point(IntPtr l)
	{
		int result;
		try
		{
			RaycastHit2D raycastHit2D;
			LuaObject.checkValueType<RaycastHit2D>(l, 1, out raycastHit2D);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raycastHit2D.point);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602396A RID: 145770 RVA: 0x00C6EB60 File Offset: 0x00C6CD60
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_point(IntPtr l)
	{
		int result;
		try
		{
			RaycastHit2D raycastHit2D;
			LuaObject.checkValueType<RaycastHit2D>(l, 1, out raycastHit2D);
			Vector2 point;
			LuaObject.checkType(l, 2, out point);
			raycastHit2D.point = point;
			LuaObject.setBack(l, raycastHit2D);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602396B RID: 145771 RVA: 0x00C6EBC4 File Offset: 0x00C6CDC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_normal(IntPtr l)
	{
		int result;
		try
		{
			RaycastHit2D raycastHit2D;
			LuaObject.checkValueType<RaycastHit2D>(l, 1, out raycastHit2D);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raycastHit2D.normal);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602396C RID: 145772 RVA: 0x00C6EC18 File Offset: 0x00C6CE18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_normal(IntPtr l)
	{
		int result;
		try
		{
			RaycastHit2D raycastHit2D;
			LuaObject.checkValueType<RaycastHit2D>(l, 1, out raycastHit2D);
			Vector2 normal;
			LuaObject.checkType(l, 2, out normal);
			raycastHit2D.normal = normal;
			LuaObject.setBack(l, raycastHit2D);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602396D RID: 145773 RVA: 0x00C6EC7C File Offset: 0x00C6CE7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_distance(IntPtr l)
	{
		int result;
		try
		{
			RaycastHit2D raycastHit2D;
			LuaObject.checkValueType<RaycastHit2D>(l, 1, out raycastHit2D);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raycastHit2D.distance);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602396E RID: 145774 RVA: 0x00C6ECD0 File Offset: 0x00C6CED0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_distance(IntPtr l)
	{
		int result;
		try
		{
			RaycastHit2D raycastHit2D;
			LuaObject.checkValueType<RaycastHit2D>(l, 1, out raycastHit2D);
			float distance;
			LuaObject.checkType(l, 2, out distance);
			raycastHit2D.distance = distance;
			LuaObject.setBack(l, raycastHit2D);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602396F RID: 145775 RVA: 0x00C6ED34 File Offset: 0x00C6CF34
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_fraction(IntPtr l)
	{
		int result;
		try
		{
			RaycastHit2D raycastHit2D;
			LuaObject.checkValueType<RaycastHit2D>(l, 1, out raycastHit2D);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raycastHit2D.fraction);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023970 RID: 145776 RVA: 0x00C6ED88 File Offset: 0x00C6CF88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_fraction(IntPtr l)
	{
		int result;
		try
		{
			RaycastHit2D raycastHit2D;
			LuaObject.checkValueType<RaycastHit2D>(l, 1, out raycastHit2D);
			float fraction;
			LuaObject.checkType(l, 2, out fraction);
			raycastHit2D.fraction = fraction;
			LuaObject.setBack(l, raycastHit2D);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023971 RID: 145777 RVA: 0x00C6EDEC File Offset: 0x00C6CFEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_collider(IntPtr l)
	{
		int result;
		try
		{
			RaycastHit2D raycastHit2D;
			LuaObject.checkValueType<RaycastHit2D>(l, 1, out raycastHit2D);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raycastHit2D.collider);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023972 RID: 145778 RVA: 0x00C6EE40 File Offset: 0x00C6D040
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_rigidbody(IntPtr l)
	{
		int result;
		try
		{
			RaycastHit2D raycastHit2D;
			LuaObject.checkValueType<RaycastHit2D>(l, 1, out raycastHit2D);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raycastHit2D.rigidbody);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023973 RID: 145779 RVA: 0x00C6EE94 File Offset: 0x00C6D094
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_transform(IntPtr l)
	{
		int result;
		try
		{
			RaycastHit2D raycastHit2D;
			LuaObject.checkValueType<RaycastHit2D>(l, 1, out raycastHit2D);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raycastHit2D.transform);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023974 RID: 145780 RVA: 0x00C6EEE8 File Offset: 0x00C6D0E8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.RaycastHit2D");
		if (Lua_UnityEngine_RaycastHit2D.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_RaycastHit2D.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_RaycastHit2D.CompareTo);
		}
		LuaObject.addMember(l, Lua_UnityEngine_RaycastHit2D.<>f__mg$cache0);
		string name = "centroid";
		if (Lua_UnityEngine_RaycastHit2D.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_RaycastHit2D.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_RaycastHit2D.get_centroid);
		}
		LuaCSFunction get = Lua_UnityEngine_RaycastHit2D.<>f__mg$cache1;
		if (Lua_UnityEngine_RaycastHit2D.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_RaycastHit2D.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_RaycastHit2D.set_centroid);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_RaycastHit2D.<>f__mg$cache2, true);
		string name2 = "point";
		if (Lua_UnityEngine_RaycastHit2D.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_RaycastHit2D.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_RaycastHit2D.get_point);
		}
		LuaCSFunction get2 = Lua_UnityEngine_RaycastHit2D.<>f__mg$cache3;
		if (Lua_UnityEngine_RaycastHit2D.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_RaycastHit2D.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_RaycastHit2D.set_point);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_RaycastHit2D.<>f__mg$cache4, true);
		string name3 = "normal";
		if (Lua_UnityEngine_RaycastHit2D.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_RaycastHit2D.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_RaycastHit2D.get_normal);
		}
		LuaCSFunction get3 = Lua_UnityEngine_RaycastHit2D.<>f__mg$cache5;
		if (Lua_UnityEngine_RaycastHit2D.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_RaycastHit2D.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_RaycastHit2D.set_normal);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_RaycastHit2D.<>f__mg$cache6, true);
		string name4 = "distance";
		if (Lua_UnityEngine_RaycastHit2D.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_RaycastHit2D.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_RaycastHit2D.get_distance);
		}
		LuaCSFunction get4 = Lua_UnityEngine_RaycastHit2D.<>f__mg$cache7;
		if (Lua_UnityEngine_RaycastHit2D.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_RaycastHit2D.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_RaycastHit2D.set_distance);
		}
		LuaObject.addMember(l, name4, get4, Lua_UnityEngine_RaycastHit2D.<>f__mg$cache8, true);
		string name5 = "fraction";
		if (Lua_UnityEngine_RaycastHit2D.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_RaycastHit2D.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_RaycastHit2D.get_fraction);
		}
		LuaCSFunction get5 = Lua_UnityEngine_RaycastHit2D.<>f__mg$cache9;
		if (Lua_UnityEngine_RaycastHit2D.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_RaycastHit2D.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_RaycastHit2D.set_fraction);
		}
		LuaObject.addMember(l, name5, get5, Lua_UnityEngine_RaycastHit2D.<>f__mg$cacheA, true);
		string name6 = "collider";
		if (Lua_UnityEngine_RaycastHit2D.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_RaycastHit2D.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_RaycastHit2D.get_collider);
		}
		LuaObject.addMember(l, name6, Lua_UnityEngine_RaycastHit2D.<>f__mg$cacheB, null, true);
		string name7 = "rigidbody";
		if (Lua_UnityEngine_RaycastHit2D.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_RaycastHit2D.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_RaycastHit2D.get_rigidbody);
		}
		LuaObject.addMember(l, name7, Lua_UnityEngine_RaycastHit2D.<>f__mg$cacheC, null, true);
		string name8 = "transform";
		if (Lua_UnityEngine_RaycastHit2D.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_RaycastHit2D.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_RaycastHit2D.get_transform);
		}
		LuaObject.addMember(l, name8, Lua_UnityEngine_RaycastHit2D.<>f__mg$cacheD, null, true);
		if (Lua_UnityEngine_RaycastHit2D.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_RaycastHit2D.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_RaycastHit2D.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_RaycastHit2D.<>f__mg$cacheE, typeof(RaycastHit2D), typeof(ValueType));
	}

	// Token: 0x040196EB RID: 104171
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040196EC RID: 104172
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040196ED RID: 104173
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040196EE RID: 104174
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040196EF RID: 104175
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040196F0 RID: 104176
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040196F1 RID: 104177
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040196F2 RID: 104178
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040196F3 RID: 104179
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040196F4 RID: 104180
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040196F5 RID: 104181
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040196F6 RID: 104182
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040196F7 RID: 104183
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040196F8 RID: 104184
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040196F9 RID: 104185
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;
}
