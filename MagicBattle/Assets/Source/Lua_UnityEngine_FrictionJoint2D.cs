using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x020016D2 RID: 5842
[Preserve]
public class Lua_UnityEngine_FrictionJoint2D : LuaObject
{
	// Token: 0x0602325B RID: 143963 RVA: 0x00C2D2B0 File Offset: 0x00C2B4B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_maxForce(IntPtr l)
	{
		int result;
		try
		{
			FrictionJoint2D frictionJoint2D = (FrictionJoint2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, frictionJoint2D.maxForce);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602325C RID: 143964 RVA: 0x00C2D304 File Offset: 0x00C2B504
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_maxForce(IntPtr l)
	{
		int result;
		try
		{
			FrictionJoint2D frictionJoint2D = (FrictionJoint2D)LuaObject.checkSelf(l);
			float maxForce;
			LuaObject.checkType(l, 2, out maxForce);
			frictionJoint2D.maxForce = maxForce;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602325D RID: 143965 RVA: 0x00C2D35C File Offset: 0x00C2B55C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_maxTorque(IntPtr l)
	{
		int result;
		try
		{
			FrictionJoint2D frictionJoint2D = (FrictionJoint2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, frictionJoint2D.maxTorque);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602325E RID: 143966 RVA: 0x00C2D3B0 File Offset: 0x00C2B5B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_maxTorque(IntPtr l)
	{
		int result;
		try
		{
			FrictionJoint2D frictionJoint2D = (FrictionJoint2D)LuaObject.checkSelf(l);
			float maxTorque;
			LuaObject.checkType(l, 2, out maxTorque);
			frictionJoint2D.maxTorque = maxTorque;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602325F RID: 143967 RVA: 0x00C2D408 File Offset: 0x00C2B608
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.FrictionJoint2D");
		string name = "maxForce";
		if (Lua_UnityEngine_FrictionJoint2D.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_FrictionJoint2D.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_FrictionJoint2D.get_maxForce);
		}
		LuaCSFunction get = Lua_UnityEngine_FrictionJoint2D.<>f__mg$cache0;
		if (Lua_UnityEngine_FrictionJoint2D.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_FrictionJoint2D.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_FrictionJoint2D.set_maxForce);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_FrictionJoint2D.<>f__mg$cache1, true);
		string name2 = "maxTorque";
		if (Lua_UnityEngine_FrictionJoint2D.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_FrictionJoint2D.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_FrictionJoint2D.get_maxTorque);
		}
		LuaCSFunction get2 = Lua_UnityEngine_FrictionJoint2D.<>f__mg$cache2;
		if (Lua_UnityEngine_FrictionJoint2D.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_FrictionJoint2D.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_FrictionJoint2D.set_maxTorque);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_FrictionJoint2D.<>f__mg$cache3, true);
		LuaObject.createTypeMetatable(l, null, typeof(FrictionJoint2D), typeof(AnchoredJoint2D));
	}

	// Token: 0x04019115 RID: 102677
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019116 RID: 102678
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019117 RID: 102679
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019118 RID: 102680
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;
}
