using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001675 RID: 5749
[Preserve]
public class Lua_UnityEngine_ConstantForce2D : LuaObject
{
	// Token: 0x06022F84 RID: 143236 RVA: 0x00C1A3B8 File Offset: 0x00C185B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_force(IntPtr l)
	{
		int result;
		try
		{
			ConstantForce2D constantForce2D = (ConstantForce2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, constantForce2D.force);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F85 RID: 143237 RVA: 0x00C1A40C File Offset: 0x00C1860C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_force(IntPtr l)
	{
		int result;
		try
		{
			ConstantForce2D constantForce2D = (ConstantForce2D)LuaObject.checkSelf(l);
			Vector2 force;
			LuaObject.checkType(l, 2, out force);
			constantForce2D.force = force;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F86 RID: 143238 RVA: 0x00C1A464 File Offset: 0x00C18664
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_relativeForce(IntPtr l)
	{
		int result;
		try
		{
			ConstantForce2D constantForce2D = (ConstantForce2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, constantForce2D.relativeForce);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F87 RID: 143239 RVA: 0x00C1A4B8 File Offset: 0x00C186B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_relativeForce(IntPtr l)
	{
		int result;
		try
		{
			ConstantForce2D constantForce2D = (ConstantForce2D)LuaObject.checkSelf(l);
			Vector2 relativeForce;
			LuaObject.checkType(l, 2, out relativeForce);
			constantForce2D.relativeForce = relativeForce;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F88 RID: 143240 RVA: 0x00C1A510 File Offset: 0x00C18710
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_torque(IntPtr l)
	{
		int result;
		try
		{
			ConstantForce2D constantForce2D = (ConstantForce2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, constantForce2D.torque);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F89 RID: 143241 RVA: 0x00C1A564 File Offset: 0x00C18764
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_torque(IntPtr l)
	{
		int result;
		try
		{
			ConstantForce2D constantForce2D = (ConstantForce2D)LuaObject.checkSelf(l);
			float torque;
			LuaObject.checkType(l, 2, out torque);
			constantForce2D.torque = torque;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F8A RID: 143242 RVA: 0x00C1A5BC File Offset: 0x00C187BC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.ConstantForce2D");
		string name = "force";
		if (Lua_UnityEngine_ConstantForce2D.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_ConstantForce2D.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_ConstantForce2D.get_force);
		}
		LuaCSFunction get = Lua_UnityEngine_ConstantForce2D.<>f__mg$cache0;
		if (Lua_UnityEngine_ConstantForce2D.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_ConstantForce2D.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_ConstantForce2D.set_force);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_ConstantForce2D.<>f__mg$cache1, true);
		string name2 = "relativeForce";
		if (Lua_UnityEngine_ConstantForce2D.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_ConstantForce2D.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_ConstantForce2D.get_relativeForce);
		}
		LuaCSFunction get2 = Lua_UnityEngine_ConstantForce2D.<>f__mg$cache2;
		if (Lua_UnityEngine_ConstantForce2D.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_ConstantForce2D.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_ConstantForce2D.set_relativeForce);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_ConstantForce2D.<>f__mg$cache3, true);
		string name3 = "torque";
		if (Lua_UnityEngine_ConstantForce2D.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_ConstantForce2D.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_ConstantForce2D.get_torque);
		}
		LuaCSFunction get3 = Lua_UnityEngine_ConstantForce2D.<>f__mg$cache4;
		if (Lua_UnityEngine_ConstantForce2D.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_ConstantForce2D.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_ConstantForce2D.set_torque);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_ConstantForce2D.<>f__mg$cache5, true);
		LuaObject.createTypeMetatable(l, null, typeof(ConstantForce2D), typeof(PhysicsUpdateBehaviour2D));
	}

	// Token: 0x04018EF8 RID: 102136
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04018EF9 RID: 102137
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04018EFA RID: 102138
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04018EFB RID: 102139
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04018EFC RID: 102140
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04018EFD RID: 102141
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;
}
