using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x0200133A RID: 4922
[Preserve]
public class Lua_BlackJack_ProjectL_Scene_ClientWorldConst : LuaObject
{
	// Token: 0x0601A687 RID: 108167 RVA: 0x007D02B0 File Offset: 0x007CE4B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ClientWorldConst o = new ClientWorldConst();
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

	// Token: 0x0601A688 RID: 108168 RVA: 0x007D02F8 File Offset: 0x007CE4F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_TickRate(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 30);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A689 RID: 108169 RVA: 0x007D033C File Offset: 0x007CE53C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_TickTime(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 0.0333333351f);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A68A RID: 108170 RVA: 0x007D0384 File Offset: 0x007CE584
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_CameraAngle(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 20f);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A68B RID: 108171 RVA: 0x007D03CC File Offset: 0x007CE5CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_FaceCameraRotation(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, ClientWorldConst.FaceCameraRotation);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A68C RID: 108172 RVA: 0x007D0414 File Offset: 0x007CE614
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_FaceCameraRotation(IntPtr l)
	{
		int result;
		try
		{
			Quaternion faceCameraRotation;
			LuaObject.checkType(l, 2, out faceCameraRotation);
			ClientWorldConst.FaceCameraRotation = faceCameraRotation;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A68D RID: 108173 RVA: 0x007D0460 File Offset: 0x007CE660
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_WorldActorSortingOrder(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A68E RID: 108174 RVA: 0x007D04A4 File Offset: 0x007CE6A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_WorldScenarioSortingOrder(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 4);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A68F RID: 108175 RVA: 0x007D04E8 File Offset: 0x007CE6E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_WaypointZOffset(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 0f);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A690 RID: 108176 RVA: 0x007D0530 File Offset: 0x007CE730
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_EventActorZOffset(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -0.04f);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A691 RID: 108177 RVA: 0x007D0578 File Offset: 0x007CE778
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PlayerActorZOffset(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -0.08f);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A692 RID: 108178 RVA: 0x007D05C0 File Offset: 0x007CE7C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_WorldActorUIZOffset(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -0.02f);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A693 RID: 108179 RVA: 0x007D0608 File Offset: 0x007CE808
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Scene.ClientWorldConst");
		string name = "TickRate";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldConst.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldConst.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldConst.get_TickRate);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_ProjectL_Scene_ClientWorldConst.<>f__mg$cache0, null, false);
		string name2 = "TickTime";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldConst.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldConst.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldConst.get_TickTime);
		}
		LuaObject.addMember(l, name2, Lua_BlackJack_ProjectL_Scene_ClientWorldConst.<>f__mg$cache1, null, false);
		string name3 = "CameraAngle";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldConst.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldConst.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldConst.get_CameraAngle);
		}
		LuaObject.addMember(l, name3, Lua_BlackJack_ProjectL_Scene_ClientWorldConst.<>f__mg$cache2, null, false);
		string name4 = "FaceCameraRotation";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldConst.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldConst.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldConst.get_FaceCameraRotation);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Scene_ClientWorldConst.<>f__mg$cache3;
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldConst.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldConst.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldConst.set_FaceCameraRotation);
		}
		LuaObject.addMember(l, name4, get, Lua_BlackJack_ProjectL_Scene_ClientWorldConst.<>f__mg$cache4, false);
		string name5 = "WorldActorSortingOrder";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldConst.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldConst.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldConst.get_WorldActorSortingOrder);
		}
		LuaObject.addMember(l, name5, Lua_BlackJack_ProjectL_Scene_ClientWorldConst.<>f__mg$cache5, null, false);
		string name6 = "WorldScenarioSortingOrder";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldConst.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldConst.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldConst.get_WorldScenarioSortingOrder);
		}
		LuaObject.addMember(l, name6, Lua_BlackJack_ProjectL_Scene_ClientWorldConst.<>f__mg$cache6, null, false);
		string name7 = "WaypointZOffset";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldConst.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldConst.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldConst.get_WaypointZOffset);
		}
		LuaObject.addMember(l, name7, Lua_BlackJack_ProjectL_Scene_ClientWorldConst.<>f__mg$cache7, null, false);
		string name8 = "EventActorZOffset";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldConst.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldConst.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldConst.get_EventActorZOffset);
		}
		LuaObject.addMember(l, name8, Lua_BlackJack_ProjectL_Scene_ClientWorldConst.<>f__mg$cache8, null, false);
		string name9 = "PlayerActorZOffset";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldConst.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldConst.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldConst.get_PlayerActorZOffset);
		}
		LuaObject.addMember(l, name9, Lua_BlackJack_ProjectL_Scene_ClientWorldConst.<>f__mg$cache9, null, false);
		string name10 = "WorldActorUIZOffset";
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldConst.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldConst.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldConst.get_WorldActorUIZOffset);
		}
		LuaObject.addMember(l, name10, Lua_BlackJack_ProjectL_Scene_ClientWorldConst.<>f__mg$cacheA, null, false);
		if (Lua_BlackJack_ProjectL_Scene_ClientWorldConst.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientWorldConst.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientWorldConst.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Scene_ClientWorldConst.<>f__mg$cacheB, typeof(ClientWorldConst));
	}

	// Token: 0x040109F5 RID: 68085
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040109F6 RID: 68086
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040109F7 RID: 68087
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040109F8 RID: 68088
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040109F9 RID: 68089
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040109FA RID: 68090
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040109FB RID: 68091
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040109FC RID: 68092
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040109FD RID: 68093
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040109FE RID: 68094
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040109FF RID: 68095
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04010A00 RID: 68096
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;
}
