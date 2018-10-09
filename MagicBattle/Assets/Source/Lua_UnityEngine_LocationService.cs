using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x0200171B RID: 5915
[Preserve]
public class Lua_UnityEngine_LocationService : LuaObject
{
	// Token: 0x0602352A RID: 144682 RVA: 0x00C44C30 File Offset: 0x00C42E30
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			LocationService o = new LocationService();
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

	// Token: 0x0602352B RID: 144683 RVA: 0x00C44C78 File Offset: 0x00C42E78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Start(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 1)
			{
				LocationService locationService = (LocationService)LuaObject.checkSelf(l);
				locationService.Start();
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 2)
			{
				LocationService locationService2 = (LocationService)LuaObject.checkSelf(l);
				float desiredAccuracyInMeters;
				LuaObject.checkType(l, 2, out desiredAccuracyInMeters);
				locationService2.Start(desiredAccuracyInMeters);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 3)
			{
				LocationService locationService3 = (LocationService)LuaObject.checkSelf(l);
				float desiredAccuracyInMeters2;
				LuaObject.checkType(l, 2, out desiredAccuracyInMeters2);
				float updateDistanceInMeters;
				LuaObject.checkType(l, 3, out updateDistanceInMeters);
				locationService3.Start(desiredAccuracyInMeters2, updateDistanceInMeters);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function Start to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602352C RID: 144684 RVA: 0x00C44D64 File Offset: 0x00C42F64
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Stop(IntPtr l)
	{
		int result;
		try
		{
			LocationService locationService = (LocationService)LuaObject.checkSelf(l);
			locationService.Stop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602352D RID: 144685 RVA: 0x00C44DB0 File Offset: 0x00C42FB0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_isEnabledByUser(IntPtr l)
	{
		int result;
		try
		{
			LocationService locationService = (LocationService)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, locationService.isEnabledByUser);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602352E RID: 144686 RVA: 0x00C44E04 File Offset: 0x00C43004
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_status(IntPtr l)
	{
		int result;
		try
		{
			LocationService locationService = (LocationService)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)locationService.status);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602352F RID: 144687 RVA: 0x00C44E58 File Offset: 0x00C43058
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_lastData(IntPtr l)
	{
		int result;
		try
		{
			LocationService locationService = (LocationService)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, locationService.lastData);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023530 RID: 144688 RVA: 0x00C44EB0 File Offset: 0x00C430B0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.LocationService");
		if (Lua_UnityEngine_LocationService.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_LocationService.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_LocationService.Start);
		}
		LuaObject.addMember(l, Lua_UnityEngine_LocationService.<>f__mg$cache0);
		if (Lua_UnityEngine_LocationService.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_LocationService.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_LocationService.Stop);
		}
		LuaObject.addMember(l, Lua_UnityEngine_LocationService.<>f__mg$cache1);
		string name = "isEnabledByUser";
		if (Lua_UnityEngine_LocationService.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_LocationService.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_LocationService.get_isEnabledByUser);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_LocationService.<>f__mg$cache2, null, true);
		string name2 = "status";
		if (Lua_UnityEngine_LocationService.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_LocationService.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_LocationService.get_status);
		}
		LuaObject.addMember(l, name2, Lua_UnityEngine_LocationService.<>f__mg$cache3, null, true);
		string name3 = "lastData";
		if (Lua_UnityEngine_LocationService.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_LocationService.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_LocationService.get_lastData);
		}
		LuaObject.addMember(l, name3, Lua_UnityEngine_LocationService.<>f__mg$cache4, null, true);
		if (Lua_UnityEngine_LocationService.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_LocationService.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_LocationService.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_LocationService.<>f__mg$cache5, typeof(LocationService));
	}

	// Token: 0x04019352 RID: 103250
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019353 RID: 103251
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019354 RID: 103252
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019355 RID: 103253
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019356 RID: 103254
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04019357 RID: 103255
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;
}
