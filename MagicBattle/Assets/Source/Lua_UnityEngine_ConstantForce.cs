using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001674 RID: 5748
[Preserve]
public class Lua_UnityEngine_ConstantForce : LuaObject
{
	// Token: 0x06022F7A RID: 143226 RVA: 0x00C19FB4 File Offset: 0x00C181B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_force(IntPtr l)
	{
		int result;
		try
		{
			ConstantForce constantForce = (ConstantForce)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, constantForce.force);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F7B RID: 143227 RVA: 0x00C1A008 File Offset: 0x00C18208
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_force(IntPtr l)
	{
		int result;
		try
		{
			ConstantForce constantForce = (ConstantForce)LuaObject.checkSelf(l);
			Vector3 force;
			LuaObject.checkType(l, 2, out force);
			constantForce.force = force;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F7C RID: 143228 RVA: 0x00C1A060 File Offset: 0x00C18260
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_relativeForce(IntPtr l)
	{
		int result;
		try
		{
			ConstantForce constantForce = (ConstantForce)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, constantForce.relativeForce);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F7D RID: 143229 RVA: 0x00C1A0B4 File Offset: 0x00C182B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_relativeForce(IntPtr l)
	{
		int result;
		try
		{
			ConstantForce constantForce = (ConstantForce)LuaObject.checkSelf(l);
			Vector3 relativeForce;
			LuaObject.checkType(l, 2, out relativeForce);
			constantForce.relativeForce = relativeForce;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F7E RID: 143230 RVA: 0x00C1A10C File Offset: 0x00C1830C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_torque(IntPtr l)
	{
		int result;
		try
		{
			ConstantForce constantForce = (ConstantForce)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, constantForce.torque);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F7F RID: 143231 RVA: 0x00C1A160 File Offset: 0x00C18360
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_torque(IntPtr l)
	{
		int result;
		try
		{
			ConstantForce constantForce = (ConstantForce)LuaObject.checkSelf(l);
			Vector3 torque;
			LuaObject.checkType(l, 2, out torque);
			constantForce.torque = torque;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F80 RID: 143232 RVA: 0x00C1A1B8 File Offset: 0x00C183B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_relativeTorque(IntPtr l)
	{
		int result;
		try
		{
			ConstantForce constantForce = (ConstantForce)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, constantForce.relativeTorque);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F81 RID: 143233 RVA: 0x00C1A20C File Offset: 0x00C1840C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_relativeTorque(IntPtr l)
	{
		int result;
		try
		{
			ConstantForce constantForce = (ConstantForce)LuaObject.checkSelf(l);
			Vector3 relativeTorque;
			LuaObject.checkType(l, 2, out relativeTorque);
			constantForce.relativeTorque = relativeTorque;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022F82 RID: 143234 RVA: 0x00C1A264 File Offset: 0x00C18464
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.ConstantForce");
		string name = "force";
		if (Lua_UnityEngine_ConstantForce.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_ConstantForce.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_ConstantForce.get_force);
		}
		LuaCSFunction get = Lua_UnityEngine_ConstantForce.<>f__mg$cache0;
		if (Lua_UnityEngine_ConstantForce.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_ConstantForce.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_ConstantForce.set_force);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_ConstantForce.<>f__mg$cache1, true);
		string name2 = "relativeForce";
		if (Lua_UnityEngine_ConstantForce.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_ConstantForce.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_ConstantForce.get_relativeForce);
		}
		LuaCSFunction get2 = Lua_UnityEngine_ConstantForce.<>f__mg$cache2;
		if (Lua_UnityEngine_ConstantForce.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_ConstantForce.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_ConstantForce.set_relativeForce);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_ConstantForce.<>f__mg$cache3, true);
		string name3 = "torque";
		if (Lua_UnityEngine_ConstantForce.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_ConstantForce.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_ConstantForce.get_torque);
		}
		LuaCSFunction get3 = Lua_UnityEngine_ConstantForce.<>f__mg$cache4;
		if (Lua_UnityEngine_ConstantForce.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_ConstantForce.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_ConstantForce.set_torque);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_ConstantForce.<>f__mg$cache5, true);
		string name4 = "relativeTorque";
		if (Lua_UnityEngine_ConstantForce.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_ConstantForce.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_ConstantForce.get_relativeTorque);
		}
		LuaCSFunction get4 = Lua_UnityEngine_ConstantForce.<>f__mg$cache6;
		if (Lua_UnityEngine_ConstantForce.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_ConstantForce.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_ConstantForce.set_relativeTorque);
		}
		LuaObject.addMember(l, name4, get4, Lua_UnityEngine_ConstantForce.<>f__mg$cache7, true);
		LuaObject.createTypeMetatable(l, null, typeof(ConstantForce), typeof(Behaviour));
	}

	// Token: 0x04018EF0 RID: 102128
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04018EF1 RID: 102129
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04018EF2 RID: 102130
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04018EF3 RID: 102131
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04018EF4 RID: 102132
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04018EF5 RID: 102133
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04018EF6 RID: 102134
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04018EF7 RID: 102135
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;
}
