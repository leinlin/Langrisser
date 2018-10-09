using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x020016D3 RID: 5843
[Preserve]
public class Lua_UnityEngine_FrustumPlanes : LuaObject
{
	// Token: 0x06023261 RID: 143969 RVA: 0x00C2D4D0 File Offset: 0x00C2B6D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			FrustumPlanes frustumPlanes = default(FrustumPlanes);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, frustumPlanes);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023262 RID: 143970 RVA: 0x00C2D520 File Offset: 0x00C2B720
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_left(IntPtr l)
	{
		int result;
		try
		{
			FrustumPlanes frustumPlanes;
			LuaObject.checkValueType<FrustumPlanes>(l, 1, out frustumPlanes);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, frustumPlanes.left);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023263 RID: 143971 RVA: 0x00C2D574 File Offset: 0x00C2B774
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_left(IntPtr l)
	{
		int result;
		try
		{
			FrustumPlanes frustumPlanes;
			LuaObject.checkValueType<FrustumPlanes>(l, 1, out frustumPlanes);
			float left;
			LuaObject.checkType(l, 2, out left);
			frustumPlanes.left = left;
			LuaObject.setBack(l, frustumPlanes);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023264 RID: 143972 RVA: 0x00C2D5D8 File Offset: 0x00C2B7D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_right(IntPtr l)
	{
		int result;
		try
		{
			FrustumPlanes frustumPlanes;
			LuaObject.checkValueType<FrustumPlanes>(l, 1, out frustumPlanes);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, frustumPlanes.right);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023265 RID: 143973 RVA: 0x00C2D62C File Offset: 0x00C2B82C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_right(IntPtr l)
	{
		int result;
		try
		{
			FrustumPlanes frustumPlanes;
			LuaObject.checkValueType<FrustumPlanes>(l, 1, out frustumPlanes);
			float right;
			LuaObject.checkType(l, 2, out right);
			frustumPlanes.right = right;
			LuaObject.setBack(l, frustumPlanes);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023266 RID: 143974 RVA: 0x00C2D690 File Offset: 0x00C2B890
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_bottom(IntPtr l)
	{
		int result;
		try
		{
			FrustumPlanes frustumPlanes;
			LuaObject.checkValueType<FrustumPlanes>(l, 1, out frustumPlanes);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, frustumPlanes.bottom);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023267 RID: 143975 RVA: 0x00C2D6E4 File Offset: 0x00C2B8E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_bottom(IntPtr l)
	{
		int result;
		try
		{
			FrustumPlanes frustumPlanes;
			LuaObject.checkValueType<FrustumPlanes>(l, 1, out frustumPlanes);
			float bottom;
			LuaObject.checkType(l, 2, out bottom);
			frustumPlanes.bottom = bottom;
			LuaObject.setBack(l, frustumPlanes);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023268 RID: 143976 RVA: 0x00C2D748 File Offset: 0x00C2B948
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_top(IntPtr l)
	{
		int result;
		try
		{
			FrustumPlanes frustumPlanes;
			LuaObject.checkValueType<FrustumPlanes>(l, 1, out frustumPlanes);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, frustumPlanes.top);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023269 RID: 143977 RVA: 0x00C2D79C File Offset: 0x00C2B99C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_top(IntPtr l)
	{
		int result;
		try
		{
			FrustumPlanes frustumPlanes;
			LuaObject.checkValueType<FrustumPlanes>(l, 1, out frustumPlanes);
			float top;
			LuaObject.checkType(l, 2, out top);
			frustumPlanes.top = top;
			LuaObject.setBack(l, frustumPlanes);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602326A RID: 143978 RVA: 0x00C2D800 File Offset: 0x00C2BA00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_zNear(IntPtr l)
	{
		int result;
		try
		{
			FrustumPlanes frustumPlanes;
			LuaObject.checkValueType<FrustumPlanes>(l, 1, out frustumPlanes);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, frustumPlanes.zNear);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602326B RID: 143979 RVA: 0x00C2D854 File Offset: 0x00C2BA54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_zNear(IntPtr l)
	{
		int result;
		try
		{
			FrustumPlanes frustumPlanes;
			LuaObject.checkValueType<FrustumPlanes>(l, 1, out frustumPlanes);
			float zNear;
			LuaObject.checkType(l, 2, out zNear);
			frustumPlanes.zNear = zNear;
			LuaObject.setBack(l, frustumPlanes);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602326C RID: 143980 RVA: 0x00C2D8B8 File Offset: 0x00C2BAB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_zFar(IntPtr l)
	{
		int result;
		try
		{
			FrustumPlanes frustumPlanes;
			LuaObject.checkValueType<FrustumPlanes>(l, 1, out frustumPlanes);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, frustumPlanes.zFar);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602326D RID: 143981 RVA: 0x00C2D90C File Offset: 0x00C2BB0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_zFar(IntPtr l)
	{
		int result;
		try
		{
			FrustumPlanes frustumPlanes;
			LuaObject.checkValueType<FrustumPlanes>(l, 1, out frustumPlanes);
			float zFar;
			LuaObject.checkType(l, 2, out zFar);
			frustumPlanes.zFar = zFar;
			LuaObject.setBack(l, frustumPlanes);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602326E RID: 143982 RVA: 0x00C2D970 File Offset: 0x00C2BB70
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.FrustumPlanes");
		string name = "left";
		if (Lua_UnityEngine_FrustumPlanes.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_FrustumPlanes.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_FrustumPlanes.get_left);
		}
		LuaCSFunction get = Lua_UnityEngine_FrustumPlanes.<>f__mg$cache0;
		if (Lua_UnityEngine_FrustumPlanes.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_FrustumPlanes.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_FrustumPlanes.set_left);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_FrustumPlanes.<>f__mg$cache1, true);
		string name2 = "right";
		if (Lua_UnityEngine_FrustumPlanes.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_FrustumPlanes.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_FrustumPlanes.get_right);
		}
		LuaCSFunction get2 = Lua_UnityEngine_FrustumPlanes.<>f__mg$cache2;
		if (Lua_UnityEngine_FrustumPlanes.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_FrustumPlanes.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_FrustumPlanes.set_right);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_FrustumPlanes.<>f__mg$cache3, true);
		string name3 = "bottom";
		if (Lua_UnityEngine_FrustumPlanes.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_FrustumPlanes.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_FrustumPlanes.get_bottom);
		}
		LuaCSFunction get3 = Lua_UnityEngine_FrustumPlanes.<>f__mg$cache4;
		if (Lua_UnityEngine_FrustumPlanes.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_FrustumPlanes.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_FrustumPlanes.set_bottom);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_FrustumPlanes.<>f__mg$cache5, true);
		string name4 = "top";
		if (Lua_UnityEngine_FrustumPlanes.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_FrustumPlanes.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_FrustumPlanes.get_top);
		}
		LuaCSFunction get4 = Lua_UnityEngine_FrustumPlanes.<>f__mg$cache6;
		if (Lua_UnityEngine_FrustumPlanes.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_FrustumPlanes.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_FrustumPlanes.set_top);
		}
		LuaObject.addMember(l, name4, get4, Lua_UnityEngine_FrustumPlanes.<>f__mg$cache7, true);
		string name5 = "zNear";
		if (Lua_UnityEngine_FrustumPlanes.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_FrustumPlanes.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_FrustumPlanes.get_zNear);
		}
		LuaCSFunction get5 = Lua_UnityEngine_FrustumPlanes.<>f__mg$cache8;
		if (Lua_UnityEngine_FrustumPlanes.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_FrustumPlanes.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_FrustumPlanes.set_zNear);
		}
		LuaObject.addMember(l, name5, get5, Lua_UnityEngine_FrustumPlanes.<>f__mg$cache9, true);
		string name6 = "zFar";
		if (Lua_UnityEngine_FrustumPlanes.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_FrustumPlanes.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_FrustumPlanes.get_zFar);
		}
		LuaCSFunction get6 = Lua_UnityEngine_FrustumPlanes.<>f__mg$cacheA;
		if (Lua_UnityEngine_FrustumPlanes.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_FrustumPlanes.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_FrustumPlanes.set_zFar);
		}
		LuaObject.addMember(l, name6, get6, Lua_UnityEngine_FrustumPlanes.<>f__mg$cacheB, true);
		if (Lua_UnityEngine_FrustumPlanes.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_FrustumPlanes.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_FrustumPlanes.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_FrustumPlanes.<>f__mg$cacheC, typeof(FrustumPlanes), typeof(ValueType));
	}

	// Token: 0x04019119 RID: 102681
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401911A RID: 102682
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401911B RID: 102683
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0401911C RID: 102684
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0401911D RID: 102685
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0401911E RID: 102686
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0401911F RID: 102687
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04019120 RID: 102688
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04019121 RID: 102689
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04019122 RID: 102690
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04019123 RID: 102691
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04019124 RID: 102692
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04019125 RID: 102693
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;
}
