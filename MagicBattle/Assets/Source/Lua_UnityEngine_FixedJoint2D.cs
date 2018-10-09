using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x020016C8 RID: 5832
[Preserve]
public class Lua_UnityEngine_FixedJoint2D : LuaObject
{
	// Token: 0x0602321C RID: 143900 RVA: 0x00C2B938 File Offset: 0x00C29B38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_dampingRatio(IntPtr l)
	{
		int result;
		try
		{
			FixedJoint2D fixedJoint2D = (FixedJoint2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fixedJoint2D.dampingRatio);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602321D RID: 143901 RVA: 0x00C2B98C File Offset: 0x00C29B8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_dampingRatio(IntPtr l)
	{
		int result;
		try
		{
			FixedJoint2D fixedJoint2D = (FixedJoint2D)LuaObject.checkSelf(l);
			float dampingRatio;
			LuaObject.checkType(l, 2, out dampingRatio);
			fixedJoint2D.dampingRatio = dampingRatio;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602321E RID: 143902 RVA: 0x00C2B9E4 File Offset: 0x00C29BE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_frequency(IntPtr l)
	{
		int result;
		try
		{
			FixedJoint2D fixedJoint2D = (FixedJoint2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fixedJoint2D.frequency);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602321F RID: 143903 RVA: 0x00C2BA38 File Offset: 0x00C29C38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_frequency(IntPtr l)
	{
		int result;
		try
		{
			FixedJoint2D fixedJoint2D = (FixedJoint2D)LuaObject.checkSelf(l);
			float frequency;
			LuaObject.checkType(l, 2, out frequency);
			fixedJoint2D.frequency = frequency;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023220 RID: 143904 RVA: 0x00C2BA90 File Offset: 0x00C29C90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_referenceAngle(IntPtr l)
	{
		int result;
		try
		{
			FixedJoint2D fixedJoint2D = (FixedJoint2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, fixedJoint2D.referenceAngle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023221 RID: 143905 RVA: 0x00C2BAE4 File Offset: 0x00C29CE4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.FixedJoint2D");
		string name = "dampingRatio";
		if (Lua_UnityEngine_FixedJoint2D.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_FixedJoint2D.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_FixedJoint2D.get_dampingRatio);
		}
		LuaCSFunction get = Lua_UnityEngine_FixedJoint2D.<>f__mg$cache0;
		if (Lua_UnityEngine_FixedJoint2D.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_FixedJoint2D.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_FixedJoint2D.set_dampingRatio);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_FixedJoint2D.<>f__mg$cache1, true);
		string name2 = "frequency";
		if (Lua_UnityEngine_FixedJoint2D.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_FixedJoint2D.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_FixedJoint2D.get_frequency);
		}
		LuaCSFunction get2 = Lua_UnityEngine_FixedJoint2D.<>f__mg$cache2;
		if (Lua_UnityEngine_FixedJoint2D.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_FixedJoint2D.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_FixedJoint2D.set_frequency);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_FixedJoint2D.<>f__mg$cache3, true);
		string name3 = "referenceAngle";
		if (Lua_UnityEngine_FixedJoint2D.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_FixedJoint2D.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_FixedJoint2D.get_referenceAngle);
		}
		LuaObject.addMember(l, name3, Lua_UnityEngine_FixedJoint2D.<>f__mg$cache4, null, true);
		LuaObject.createTypeMetatable(l, null, typeof(FixedJoint2D), typeof(AnchoredJoint2D));
	}

	// Token: 0x040190EA RID: 102634
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040190EB RID: 102635
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040190EC RID: 102636
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040190ED RID: 102637
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040190EE RID: 102638
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;
}
