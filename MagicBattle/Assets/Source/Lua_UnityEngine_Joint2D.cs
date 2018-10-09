using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x020016F6 RID: 5878
[Preserve]
public class Lua_UnityEngine_Joint2D : LuaObject
{
	// Token: 0x060233F0 RID: 144368 RVA: 0x00C3BA7C File Offset: 0x00C39C7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetReactionForce(IntPtr l)
	{
		int result;
		try
		{
			Joint2D joint2D = (Joint2D)LuaObject.checkSelf(l);
			float timeStep;
			LuaObject.checkType(l, 2, out timeStep);
			Vector2 reactionForce = joint2D.GetReactionForce(timeStep);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, reactionForce);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060233F1 RID: 144369 RVA: 0x00C3BAE0 File Offset: 0x00C39CE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetReactionTorque(IntPtr l)
	{
		int result;
		try
		{
			Joint2D joint2D = (Joint2D)LuaObject.checkSelf(l);
			float timeStep;
			LuaObject.checkType(l, 2, out timeStep);
			float reactionTorque = joint2D.GetReactionTorque(timeStep);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, reactionTorque);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060233F2 RID: 144370 RVA: 0x00C3BB44 File Offset: 0x00C39D44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_attachedRigidbody(IntPtr l)
	{
		int result;
		try
		{
			Joint2D joint2D = (Joint2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, joint2D.attachedRigidbody);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060233F3 RID: 144371 RVA: 0x00C3BB98 File Offset: 0x00C39D98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_connectedBody(IntPtr l)
	{
		int result;
		try
		{
			Joint2D joint2D = (Joint2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, joint2D.connectedBody);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060233F4 RID: 144372 RVA: 0x00C3BBEC File Offset: 0x00C39DEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_connectedBody(IntPtr l)
	{
		int result;
		try
		{
			Joint2D joint2D = (Joint2D)LuaObject.checkSelf(l);
			Rigidbody2D connectedBody;
			LuaObject.checkType<Rigidbody2D>(l, 2, out connectedBody);
			joint2D.connectedBody = connectedBody;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060233F5 RID: 144373 RVA: 0x00C3BC44 File Offset: 0x00C39E44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_enableCollision(IntPtr l)
	{
		int result;
		try
		{
			Joint2D joint2D = (Joint2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, joint2D.enableCollision);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060233F6 RID: 144374 RVA: 0x00C3BC98 File Offset: 0x00C39E98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_enableCollision(IntPtr l)
	{
		int result;
		try
		{
			Joint2D joint2D = (Joint2D)LuaObject.checkSelf(l);
			bool enableCollision;
			LuaObject.checkType(l, 2, out enableCollision);
			joint2D.enableCollision = enableCollision;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060233F7 RID: 144375 RVA: 0x00C3BCF0 File Offset: 0x00C39EF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_breakForce(IntPtr l)
	{
		int result;
		try
		{
			Joint2D joint2D = (Joint2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, joint2D.breakForce);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060233F8 RID: 144376 RVA: 0x00C3BD44 File Offset: 0x00C39F44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_breakForce(IntPtr l)
	{
		int result;
		try
		{
			Joint2D joint2D = (Joint2D)LuaObject.checkSelf(l);
			float breakForce;
			LuaObject.checkType(l, 2, out breakForce);
			joint2D.breakForce = breakForce;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060233F9 RID: 144377 RVA: 0x00C3BD9C File Offset: 0x00C39F9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_breakTorque(IntPtr l)
	{
		int result;
		try
		{
			Joint2D joint2D = (Joint2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, joint2D.breakTorque);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060233FA RID: 144378 RVA: 0x00C3BDF0 File Offset: 0x00C39FF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_breakTorque(IntPtr l)
	{
		int result;
		try
		{
			Joint2D joint2D = (Joint2D)LuaObject.checkSelf(l);
			float breakTorque;
			LuaObject.checkType(l, 2, out breakTorque);
			joint2D.breakTorque = breakTorque;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060233FB RID: 144379 RVA: 0x00C3BE48 File Offset: 0x00C3A048
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_reactionForce(IntPtr l)
	{
		int result;
		try
		{
			Joint2D joint2D = (Joint2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, joint2D.reactionForce);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060233FC RID: 144380 RVA: 0x00C3BE9C File Offset: 0x00C3A09C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_reactionTorque(IntPtr l)
	{
		int result;
		try
		{
			Joint2D joint2D = (Joint2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, joint2D.reactionTorque);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060233FD RID: 144381 RVA: 0x00C3BEF0 File Offset: 0x00C3A0F0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Joint2D");
		if (Lua_UnityEngine_Joint2D.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_Joint2D.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_Joint2D.GetReactionForce);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Joint2D.<>f__mg$cache0);
		if (Lua_UnityEngine_Joint2D.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_Joint2D.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_Joint2D.GetReactionTorque);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Joint2D.<>f__mg$cache1);
		string name = "attachedRigidbody";
		if (Lua_UnityEngine_Joint2D.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_Joint2D.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_Joint2D.get_attachedRigidbody);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_Joint2D.<>f__mg$cache2, null, true);
		string name2 = "connectedBody";
		if (Lua_UnityEngine_Joint2D.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_Joint2D.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_Joint2D.get_connectedBody);
		}
		LuaCSFunction get = Lua_UnityEngine_Joint2D.<>f__mg$cache3;
		if (Lua_UnityEngine_Joint2D.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_Joint2D.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_Joint2D.set_connectedBody);
		}
		LuaObject.addMember(l, name2, get, Lua_UnityEngine_Joint2D.<>f__mg$cache4, true);
		string name3 = "enableCollision";
		if (Lua_UnityEngine_Joint2D.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_Joint2D.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_Joint2D.get_enableCollision);
		}
		LuaCSFunction get2 = Lua_UnityEngine_Joint2D.<>f__mg$cache5;
		if (Lua_UnityEngine_Joint2D.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_Joint2D.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_Joint2D.set_enableCollision);
		}
		LuaObject.addMember(l, name3, get2, Lua_UnityEngine_Joint2D.<>f__mg$cache6, true);
		string name4 = "breakForce";
		if (Lua_UnityEngine_Joint2D.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_Joint2D.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_Joint2D.get_breakForce);
		}
		LuaCSFunction get3 = Lua_UnityEngine_Joint2D.<>f__mg$cache7;
		if (Lua_UnityEngine_Joint2D.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_Joint2D.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_Joint2D.set_breakForce);
		}
		LuaObject.addMember(l, name4, get3, Lua_UnityEngine_Joint2D.<>f__mg$cache8, true);
		string name5 = "breakTorque";
		if (Lua_UnityEngine_Joint2D.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_Joint2D.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_Joint2D.get_breakTorque);
		}
		LuaCSFunction get4 = Lua_UnityEngine_Joint2D.<>f__mg$cache9;
		if (Lua_UnityEngine_Joint2D.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_Joint2D.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_Joint2D.set_breakTorque);
		}
		LuaObject.addMember(l, name5, get4, Lua_UnityEngine_Joint2D.<>f__mg$cacheA, true);
		string name6 = "reactionForce";
		if (Lua_UnityEngine_Joint2D.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_Joint2D.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_Joint2D.get_reactionForce);
		}
		LuaObject.addMember(l, name6, Lua_UnityEngine_Joint2D.<>f__mg$cacheB, null, true);
		string name7 = "reactionTorque";
		if (Lua_UnityEngine_Joint2D.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_Joint2D.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_Joint2D.get_reactionTorque);
		}
		LuaObject.addMember(l, name7, Lua_UnityEngine_Joint2D.<>f__mg$cacheC, null, true);
		LuaObject.createTypeMetatable(l, null, typeof(Joint2D), typeof(Behaviour));
	}

	// Token: 0x04019262 RID: 103010
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019263 RID: 103011
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019264 RID: 103012
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019265 RID: 103013
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019266 RID: 103014
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04019267 RID: 103015
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04019268 RID: 103016
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04019269 RID: 103017
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0401926A RID: 103018
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0401926B RID: 103019
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0401926C RID: 103020
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0401926D RID: 103021
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0401926E RID: 103022
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;
}
