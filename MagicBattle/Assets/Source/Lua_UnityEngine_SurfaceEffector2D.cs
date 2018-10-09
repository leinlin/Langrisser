using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x020017EF RID: 6127
[Preserve]
public class Lua_UnityEngine_SurfaceEffector2D : LuaObject
{
	// Token: 0x06023DE4 RID: 146916 RVA: 0x00C92C38 File Offset: 0x00C90E38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_speed(IntPtr l)
	{
		int result;
		try
		{
			SurfaceEffector2D surfaceEffector2D = (SurfaceEffector2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, surfaceEffector2D.speed);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023DE5 RID: 146917 RVA: 0x00C92C8C File Offset: 0x00C90E8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_speed(IntPtr l)
	{
		int result;
		try
		{
			SurfaceEffector2D surfaceEffector2D = (SurfaceEffector2D)LuaObject.checkSelf(l);
			float speed;
			LuaObject.checkType(l, 2, out speed);
			surfaceEffector2D.speed = speed;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023DE6 RID: 146918 RVA: 0x00C92CE4 File Offset: 0x00C90EE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_speedVariation(IntPtr l)
	{
		int result;
		try
		{
			SurfaceEffector2D surfaceEffector2D = (SurfaceEffector2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, surfaceEffector2D.speedVariation);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023DE7 RID: 146919 RVA: 0x00C92D38 File Offset: 0x00C90F38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_speedVariation(IntPtr l)
	{
		int result;
		try
		{
			SurfaceEffector2D surfaceEffector2D = (SurfaceEffector2D)LuaObject.checkSelf(l);
			float speedVariation;
			LuaObject.checkType(l, 2, out speedVariation);
			surfaceEffector2D.speedVariation = speedVariation;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023DE8 RID: 146920 RVA: 0x00C92D90 File Offset: 0x00C90F90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_forceScale(IntPtr l)
	{
		int result;
		try
		{
			SurfaceEffector2D surfaceEffector2D = (SurfaceEffector2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, surfaceEffector2D.forceScale);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023DE9 RID: 146921 RVA: 0x00C92DE4 File Offset: 0x00C90FE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_forceScale(IntPtr l)
	{
		int result;
		try
		{
			SurfaceEffector2D surfaceEffector2D = (SurfaceEffector2D)LuaObject.checkSelf(l);
			float forceScale;
			LuaObject.checkType(l, 2, out forceScale);
			surfaceEffector2D.forceScale = forceScale;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023DEA RID: 146922 RVA: 0x00C92E3C File Offset: 0x00C9103C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_useContactForce(IntPtr l)
	{
		int result;
		try
		{
			SurfaceEffector2D surfaceEffector2D = (SurfaceEffector2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, surfaceEffector2D.useContactForce);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023DEB RID: 146923 RVA: 0x00C92E90 File Offset: 0x00C91090
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_useContactForce(IntPtr l)
	{
		int result;
		try
		{
			SurfaceEffector2D surfaceEffector2D = (SurfaceEffector2D)LuaObject.checkSelf(l);
			bool useContactForce;
			LuaObject.checkType(l, 2, out useContactForce);
			surfaceEffector2D.useContactForce = useContactForce;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023DEC RID: 146924 RVA: 0x00C92EE8 File Offset: 0x00C910E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_useFriction(IntPtr l)
	{
		int result;
		try
		{
			SurfaceEffector2D surfaceEffector2D = (SurfaceEffector2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, surfaceEffector2D.useFriction);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023DED RID: 146925 RVA: 0x00C92F3C File Offset: 0x00C9113C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_useFriction(IntPtr l)
	{
		int result;
		try
		{
			SurfaceEffector2D surfaceEffector2D = (SurfaceEffector2D)LuaObject.checkSelf(l);
			bool useFriction;
			LuaObject.checkType(l, 2, out useFriction);
			surfaceEffector2D.useFriction = useFriction;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023DEE RID: 146926 RVA: 0x00C92F94 File Offset: 0x00C91194
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_useBounce(IntPtr l)
	{
		int result;
		try
		{
			SurfaceEffector2D surfaceEffector2D = (SurfaceEffector2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, surfaceEffector2D.useBounce);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023DEF RID: 146927 RVA: 0x00C92FE8 File Offset: 0x00C911E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_useBounce(IntPtr l)
	{
		int result;
		try
		{
			SurfaceEffector2D surfaceEffector2D = (SurfaceEffector2D)LuaObject.checkSelf(l);
			bool useBounce;
			LuaObject.checkType(l, 2, out useBounce);
			surfaceEffector2D.useBounce = useBounce;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023DF0 RID: 146928 RVA: 0x00C93040 File Offset: 0x00C91240
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.SurfaceEffector2D");
		string name = "speed";
		if (Lua_UnityEngine_SurfaceEffector2D.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_SurfaceEffector2D.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_SurfaceEffector2D.get_speed);
		}
		LuaCSFunction get = Lua_UnityEngine_SurfaceEffector2D.<>f__mg$cache0;
		if (Lua_UnityEngine_SurfaceEffector2D.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_SurfaceEffector2D.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_SurfaceEffector2D.set_speed);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_SurfaceEffector2D.<>f__mg$cache1, true);
		string name2 = "speedVariation";
		if (Lua_UnityEngine_SurfaceEffector2D.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_SurfaceEffector2D.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_SurfaceEffector2D.get_speedVariation);
		}
		LuaCSFunction get2 = Lua_UnityEngine_SurfaceEffector2D.<>f__mg$cache2;
		if (Lua_UnityEngine_SurfaceEffector2D.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_SurfaceEffector2D.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_SurfaceEffector2D.set_speedVariation);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_SurfaceEffector2D.<>f__mg$cache3, true);
		string name3 = "forceScale";
		if (Lua_UnityEngine_SurfaceEffector2D.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_SurfaceEffector2D.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_SurfaceEffector2D.get_forceScale);
		}
		LuaCSFunction get3 = Lua_UnityEngine_SurfaceEffector2D.<>f__mg$cache4;
		if (Lua_UnityEngine_SurfaceEffector2D.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_SurfaceEffector2D.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_SurfaceEffector2D.set_forceScale);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_SurfaceEffector2D.<>f__mg$cache5, true);
		string name4 = "useContactForce";
		if (Lua_UnityEngine_SurfaceEffector2D.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_SurfaceEffector2D.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_SurfaceEffector2D.get_useContactForce);
		}
		LuaCSFunction get4 = Lua_UnityEngine_SurfaceEffector2D.<>f__mg$cache6;
		if (Lua_UnityEngine_SurfaceEffector2D.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_SurfaceEffector2D.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_SurfaceEffector2D.set_useContactForce);
		}
		LuaObject.addMember(l, name4, get4, Lua_UnityEngine_SurfaceEffector2D.<>f__mg$cache7, true);
		string name5 = "useFriction";
		if (Lua_UnityEngine_SurfaceEffector2D.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_SurfaceEffector2D.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_SurfaceEffector2D.get_useFriction);
		}
		LuaCSFunction get5 = Lua_UnityEngine_SurfaceEffector2D.<>f__mg$cache8;
		if (Lua_UnityEngine_SurfaceEffector2D.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_SurfaceEffector2D.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_SurfaceEffector2D.set_useFriction);
		}
		LuaObject.addMember(l, name5, get5, Lua_UnityEngine_SurfaceEffector2D.<>f__mg$cache9, true);
		string name6 = "useBounce";
		if (Lua_UnityEngine_SurfaceEffector2D.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_SurfaceEffector2D.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_SurfaceEffector2D.get_useBounce);
		}
		LuaCSFunction get6 = Lua_UnityEngine_SurfaceEffector2D.<>f__mg$cacheA;
		if (Lua_UnityEngine_SurfaceEffector2D.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_SurfaceEffector2D.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_SurfaceEffector2D.set_useBounce);
		}
		LuaObject.addMember(l, name6, get6, Lua_UnityEngine_SurfaceEffector2D.<>f__mg$cacheB, true);
		LuaObject.createTypeMetatable(l, null, typeof(SurfaceEffector2D), typeof(Effector2D));
	}

	// Token: 0x04019A64 RID: 105060
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019A65 RID: 105061
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019A66 RID: 105062
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019A67 RID: 105063
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019A68 RID: 105064
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04019A69 RID: 105065
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04019A6A RID: 105066
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04019A6B RID: 105067
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04019A6C RID: 105068
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04019A6D RID: 105069
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04019A6E RID: 105070
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04019A6F RID: 105071
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;
}
