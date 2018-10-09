using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x020016DC RID: 5852
[Preserve]
public class Lua_UnityEngine_Gyroscope : LuaObject
{
	// Token: 0x060232F5 RID: 144117 RVA: 0x00C34E34 File Offset: 0x00C33034
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_rotationRate(IntPtr l)
	{
		int result;
		try
		{
			Gyroscope gyroscope = (Gyroscope)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, gyroscope.rotationRate);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060232F6 RID: 144118 RVA: 0x00C34E88 File Offset: 0x00C33088
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_rotationRateUnbiased(IntPtr l)
	{
		int result;
		try
		{
			Gyroscope gyroscope = (Gyroscope)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, gyroscope.rotationRateUnbiased);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060232F7 RID: 144119 RVA: 0x00C34EDC File Offset: 0x00C330DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_gravity(IntPtr l)
	{
		int result;
		try
		{
			Gyroscope gyroscope = (Gyroscope)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, gyroscope.gravity);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060232F8 RID: 144120 RVA: 0x00C34F30 File Offset: 0x00C33130
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_userAcceleration(IntPtr l)
	{
		int result;
		try
		{
			Gyroscope gyroscope = (Gyroscope)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, gyroscope.userAcceleration);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060232F9 RID: 144121 RVA: 0x00C34F84 File Offset: 0x00C33184
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_attitude(IntPtr l)
	{
		int result;
		try
		{
			Gyroscope gyroscope = (Gyroscope)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, gyroscope.attitude);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060232FA RID: 144122 RVA: 0x00C34FD8 File Offset: 0x00C331D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_enabled(IntPtr l)
	{
		int result;
		try
		{
			Gyroscope gyroscope = (Gyroscope)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, gyroscope.enabled);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060232FB RID: 144123 RVA: 0x00C3502C File Offset: 0x00C3322C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_enabled(IntPtr l)
	{
		int result;
		try
		{
			Gyroscope gyroscope = (Gyroscope)LuaObject.checkSelf(l);
			bool enabled;
			LuaObject.checkType(l, 2, out enabled);
			gyroscope.enabled = enabled;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060232FC RID: 144124 RVA: 0x00C35084 File Offset: 0x00C33284
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_updateInterval(IntPtr l)
	{
		int result;
		try
		{
			Gyroscope gyroscope = (Gyroscope)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, gyroscope.updateInterval);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060232FD RID: 144125 RVA: 0x00C350D8 File Offset: 0x00C332D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_updateInterval(IntPtr l)
	{
		int result;
		try
		{
			Gyroscope gyroscope = (Gyroscope)LuaObject.checkSelf(l);
			float updateInterval;
			LuaObject.checkType(l, 2, out updateInterval);
			gyroscope.updateInterval = updateInterval;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060232FE RID: 144126 RVA: 0x00C35130 File Offset: 0x00C33330
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Gyroscope");
		string name = "rotationRate";
		if (Lua_UnityEngine_Gyroscope.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_Gyroscope.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_Gyroscope.get_rotationRate);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_Gyroscope.<>f__mg$cache0, null, true);
		string name2 = "rotationRateUnbiased";
		if (Lua_UnityEngine_Gyroscope.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_Gyroscope.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_Gyroscope.get_rotationRateUnbiased);
		}
		LuaObject.addMember(l, name2, Lua_UnityEngine_Gyroscope.<>f__mg$cache1, null, true);
		string name3 = "gravity";
		if (Lua_UnityEngine_Gyroscope.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_Gyroscope.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_Gyroscope.get_gravity);
		}
		LuaObject.addMember(l, name3, Lua_UnityEngine_Gyroscope.<>f__mg$cache2, null, true);
		string name4 = "userAcceleration";
		if (Lua_UnityEngine_Gyroscope.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_Gyroscope.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_Gyroscope.get_userAcceleration);
		}
		LuaObject.addMember(l, name4, Lua_UnityEngine_Gyroscope.<>f__mg$cache3, null, true);
		string name5 = "attitude";
		if (Lua_UnityEngine_Gyroscope.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_Gyroscope.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_Gyroscope.get_attitude);
		}
		LuaObject.addMember(l, name5, Lua_UnityEngine_Gyroscope.<>f__mg$cache4, null, true);
		string name6 = "enabled";
		if (Lua_UnityEngine_Gyroscope.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_Gyroscope.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_Gyroscope.get_enabled);
		}
		LuaCSFunction get = Lua_UnityEngine_Gyroscope.<>f__mg$cache5;
		if (Lua_UnityEngine_Gyroscope.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_Gyroscope.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_Gyroscope.set_enabled);
		}
		LuaObject.addMember(l, name6, get, Lua_UnityEngine_Gyroscope.<>f__mg$cache6, true);
		string name7 = "updateInterval";
		if (Lua_UnityEngine_Gyroscope.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_Gyroscope.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_Gyroscope.get_updateInterval);
		}
		LuaCSFunction get2 = Lua_UnityEngine_Gyroscope.<>f__mg$cache7;
		if (Lua_UnityEngine_Gyroscope.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_Gyroscope.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_Gyroscope.set_updateInterval);
		}
		LuaObject.addMember(l, name7, get2, Lua_UnityEngine_Gyroscope.<>f__mg$cache8, true);
		LuaObject.createTypeMetatable(l, null, typeof(Gyroscope));
	}

	// Token: 0x0401919B RID: 102811
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401919C RID: 102812
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401919D RID: 102813
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0401919E RID: 102814
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0401919F RID: 102815
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040191A0 RID: 102816
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040191A1 RID: 102817
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040191A2 RID: 102818
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040191A3 RID: 102819
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;
}
