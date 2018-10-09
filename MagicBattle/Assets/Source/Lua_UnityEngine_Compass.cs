using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x0200166B RID: 5739
[Preserve]
public class Lua_UnityEngine_Compass : LuaObject
{
	// Token: 0x06022EEA RID: 143082 RVA: 0x00C14FC0 File Offset: 0x00C131C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			Compass o = new Compass();
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

	// Token: 0x06022EEB RID: 143083 RVA: 0x00C15008 File Offset: 0x00C13208
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_magneticHeading(IntPtr l)
	{
		int result;
		try
		{
			Compass compass = (Compass)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, compass.magneticHeading);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022EEC RID: 143084 RVA: 0x00C1505C File Offset: 0x00C1325C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_trueHeading(IntPtr l)
	{
		int result;
		try
		{
			Compass compass = (Compass)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, compass.trueHeading);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022EED RID: 143085 RVA: 0x00C150B0 File Offset: 0x00C132B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_headingAccuracy(IntPtr l)
	{
		int result;
		try
		{
			Compass compass = (Compass)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, compass.headingAccuracy);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022EEE RID: 143086 RVA: 0x00C15104 File Offset: 0x00C13304
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_rawVector(IntPtr l)
	{
		int result;
		try
		{
			Compass compass = (Compass)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, compass.rawVector);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022EEF RID: 143087 RVA: 0x00C15158 File Offset: 0x00C13358
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_timestamp(IntPtr l)
	{
		int result;
		try
		{
			Compass compass = (Compass)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, compass.timestamp);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022EF0 RID: 143088 RVA: 0x00C151AC File Offset: 0x00C133AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_enabled(IntPtr l)
	{
		int result;
		try
		{
			Compass compass = (Compass)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, compass.enabled);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022EF1 RID: 143089 RVA: 0x00C15200 File Offset: 0x00C13400
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_enabled(IntPtr l)
	{
		int result;
		try
		{
			Compass compass = (Compass)LuaObject.checkSelf(l);
			bool enabled;
			LuaObject.checkType(l, 2, out enabled);
			compass.enabled = enabled;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022EF2 RID: 143090 RVA: 0x00C15258 File Offset: 0x00C13458
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Compass");
		string name = "magneticHeading";
		if (Lua_UnityEngine_Compass.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_Compass.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_Compass.get_magneticHeading);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_Compass.<>f__mg$cache0, null, true);
		string name2 = "trueHeading";
		if (Lua_UnityEngine_Compass.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_Compass.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_Compass.get_trueHeading);
		}
		LuaObject.addMember(l, name2, Lua_UnityEngine_Compass.<>f__mg$cache1, null, true);
		string name3 = "headingAccuracy";
		if (Lua_UnityEngine_Compass.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_Compass.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_Compass.get_headingAccuracy);
		}
		LuaObject.addMember(l, name3, Lua_UnityEngine_Compass.<>f__mg$cache2, null, true);
		string name4 = "rawVector";
		if (Lua_UnityEngine_Compass.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_Compass.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_Compass.get_rawVector);
		}
		LuaObject.addMember(l, name4, Lua_UnityEngine_Compass.<>f__mg$cache3, null, true);
		string name5 = "timestamp";
		if (Lua_UnityEngine_Compass.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_Compass.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_Compass.get_timestamp);
		}
		LuaObject.addMember(l, name5, Lua_UnityEngine_Compass.<>f__mg$cache4, null, true);
		string name6 = "enabled";
		if (Lua_UnityEngine_Compass.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_Compass.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_Compass.get_enabled);
		}
		LuaCSFunction get = Lua_UnityEngine_Compass.<>f__mg$cache5;
		if (Lua_UnityEngine_Compass.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_Compass.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_Compass.set_enabled);
		}
		LuaObject.addMember(l, name6, get, Lua_UnityEngine_Compass.<>f__mg$cache6, true);
		if (Lua_UnityEngine_Compass.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_Compass.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_Compass.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_Compass.<>f__mg$cache7, typeof(Compass));
	}

	// Token: 0x04018E72 RID: 102002
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04018E73 RID: 102003
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04018E74 RID: 102004
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04018E75 RID: 102005
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04018E76 RID: 102006
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04018E77 RID: 102007
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04018E78 RID: 102008
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04018E79 RID: 102009
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;
}
