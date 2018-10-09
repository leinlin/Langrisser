using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001679 RID: 5753
[Preserve]
public class Lua_UnityEngine_ControllerColliderHit : LuaObject
{
	// Token: 0x06022FC8 RID: 143304 RVA: 0x00C1C2B4 File Offset: 0x00C1A4B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ControllerColliderHit o = new ControllerColliderHit();
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

	// Token: 0x06022FC9 RID: 143305 RVA: 0x00C1C2FC File Offset: 0x00C1A4FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_controller(IntPtr l)
	{
		int result;
		try
		{
			ControllerColliderHit controllerColliderHit = (ControllerColliderHit)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, controllerColliderHit.controller);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022FCA RID: 143306 RVA: 0x00C1C350 File Offset: 0x00C1A550
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_collider(IntPtr l)
	{
		int result;
		try
		{
			ControllerColliderHit controllerColliderHit = (ControllerColliderHit)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, controllerColliderHit.collider);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022FCB RID: 143307 RVA: 0x00C1C3A4 File Offset: 0x00C1A5A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_rigidbody(IntPtr l)
	{
		int result;
		try
		{
			ControllerColliderHit controllerColliderHit = (ControllerColliderHit)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, controllerColliderHit.rigidbody);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022FCC RID: 143308 RVA: 0x00C1C3F8 File Offset: 0x00C1A5F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_gameObject(IntPtr l)
	{
		int result;
		try
		{
			ControllerColliderHit controllerColliderHit = (ControllerColliderHit)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, controllerColliderHit.gameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022FCD RID: 143309 RVA: 0x00C1C44C File Offset: 0x00C1A64C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_transform(IntPtr l)
	{
		int result;
		try
		{
			ControllerColliderHit controllerColliderHit = (ControllerColliderHit)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, controllerColliderHit.transform);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022FCE RID: 143310 RVA: 0x00C1C4A0 File Offset: 0x00C1A6A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_point(IntPtr l)
	{
		int result;
		try
		{
			ControllerColliderHit controllerColliderHit = (ControllerColliderHit)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, controllerColliderHit.point);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022FCF RID: 143311 RVA: 0x00C1C4F4 File Offset: 0x00C1A6F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_normal(IntPtr l)
	{
		int result;
		try
		{
			ControllerColliderHit controllerColliderHit = (ControllerColliderHit)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, controllerColliderHit.normal);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022FD0 RID: 143312 RVA: 0x00C1C548 File Offset: 0x00C1A748
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_moveDirection(IntPtr l)
	{
		int result;
		try
		{
			ControllerColliderHit controllerColliderHit = (ControllerColliderHit)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, controllerColliderHit.moveDirection);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022FD1 RID: 143313 RVA: 0x00C1C59C File Offset: 0x00C1A79C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_moveLength(IntPtr l)
	{
		int result;
		try
		{
			ControllerColliderHit controllerColliderHit = (ControllerColliderHit)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, controllerColliderHit.moveLength);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022FD2 RID: 143314 RVA: 0x00C1C5F0 File Offset: 0x00C1A7F0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.ControllerColliderHit");
		string name = "controller";
		if (Lua_UnityEngine_ControllerColliderHit.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_ControllerColliderHit.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_ControllerColliderHit.get_controller);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_ControllerColliderHit.<>f__mg$cache0, null, true);
		string name2 = "collider";
		if (Lua_UnityEngine_ControllerColliderHit.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_ControllerColliderHit.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_ControllerColliderHit.get_collider);
		}
		LuaObject.addMember(l, name2, Lua_UnityEngine_ControllerColliderHit.<>f__mg$cache1, null, true);
		string name3 = "rigidbody";
		if (Lua_UnityEngine_ControllerColliderHit.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_ControllerColliderHit.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_ControllerColliderHit.get_rigidbody);
		}
		LuaObject.addMember(l, name3, Lua_UnityEngine_ControllerColliderHit.<>f__mg$cache2, null, true);
		string name4 = "gameObject";
		if (Lua_UnityEngine_ControllerColliderHit.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_ControllerColliderHit.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_ControllerColliderHit.get_gameObject);
		}
		LuaObject.addMember(l, name4, Lua_UnityEngine_ControllerColliderHit.<>f__mg$cache3, null, true);
		string name5 = "transform";
		if (Lua_UnityEngine_ControllerColliderHit.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_ControllerColliderHit.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_ControllerColliderHit.get_transform);
		}
		LuaObject.addMember(l, name5, Lua_UnityEngine_ControllerColliderHit.<>f__mg$cache4, null, true);
		string name6 = "point";
		if (Lua_UnityEngine_ControllerColliderHit.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_ControllerColliderHit.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_ControllerColliderHit.get_point);
		}
		LuaObject.addMember(l, name6, Lua_UnityEngine_ControllerColliderHit.<>f__mg$cache5, null, true);
		string name7 = "normal";
		if (Lua_UnityEngine_ControllerColliderHit.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_ControllerColliderHit.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_ControllerColliderHit.get_normal);
		}
		LuaObject.addMember(l, name7, Lua_UnityEngine_ControllerColliderHit.<>f__mg$cache6, null, true);
		string name8 = "moveDirection";
		if (Lua_UnityEngine_ControllerColliderHit.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_ControllerColliderHit.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_ControllerColliderHit.get_moveDirection);
		}
		LuaObject.addMember(l, name8, Lua_UnityEngine_ControllerColliderHit.<>f__mg$cache7, null, true);
		string name9 = "moveLength";
		if (Lua_UnityEngine_ControllerColliderHit.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_ControllerColliderHit.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_ControllerColliderHit.get_moveLength);
		}
		LuaObject.addMember(l, name9, Lua_UnityEngine_ControllerColliderHit.<>f__mg$cache8, null, true);
		if (Lua_UnityEngine_ControllerColliderHit.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_ControllerColliderHit.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_ControllerColliderHit.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_ControllerColliderHit.<>f__mg$cache9, typeof(ControllerColliderHit));
	}

	// Token: 0x04018F34 RID: 102196
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04018F35 RID: 102197
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04018F36 RID: 102198
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04018F37 RID: 102199
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04018F38 RID: 102200
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04018F39 RID: 102201
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04018F3A RID: 102202
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04018F3B RID: 102203
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04018F3C RID: 102204
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04018F3D RID: 102205
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;
}
