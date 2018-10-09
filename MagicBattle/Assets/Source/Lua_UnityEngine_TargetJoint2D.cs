using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x020017F2 RID: 6130
[Preserve]
public class Lua_UnityEngine_TargetJoint2D : LuaObject
{
	// Token: 0x06023E2C RID: 146988 RVA: 0x00C94CBC File Offset: 0x00C92EBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_anchor(IntPtr l)
	{
		int result;
		try
		{
			TargetJoint2D targetJoint2D = (TargetJoint2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, targetJoint2D.anchor);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E2D RID: 146989 RVA: 0x00C94D10 File Offset: 0x00C92F10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_anchor(IntPtr l)
	{
		int result;
		try
		{
			TargetJoint2D targetJoint2D = (TargetJoint2D)LuaObject.checkSelf(l);
			Vector2 anchor;
			LuaObject.checkType(l, 2, out anchor);
			targetJoint2D.anchor = anchor;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E2E RID: 146990 RVA: 0x00C94D68 File Offset: 0x00C92F68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_target(IntPtr l)
	{
		int result;
		try
		{
			TargetJoint2D targetJoint2D = (TargetJoint2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, targetJoint2D.target);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E2F RID: 146991 RVA: 0x00C94DBC File Offset: 0x00C92FBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_target(IntPtr l)
	{
		int result;
		try
		{
			TargetJoint2D targetJoint2D = (TargetJoint2D)LuaObject.checkSelf(l);
			Vector2 target;
			LuaObject.checkType(l, 2, out target);
			targetJoint2D.target = target;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E30 RID: 146992 RVA: 0x00C94E14 File Offset: 0x00C93014
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_autoConfigureTarget(IntPtr l)
	{
		int result;
		try
		{
			TargetJoint2D targetJoint2D = (TargetJoint2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, targetJoint2D.autoConfigureTarget);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E31 RID: 146993 RVA: 0x00C94E68 File Offset: 0x00C93068
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_autoConfigureTarget(IntPtr l)
	{
		int result;
		try
		{
			TargetJoint2D targetJoint2D = (TargetJoint2D)LuaObject.checkSelf(l);
			bool autoConfigureTarget;
			LuaObject.checkType(l, 2, out autoConfigureTarget);
			targetJoint2D.autoConfigureTarget = autoConfigureTarget;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E32 RID: 146994 RVA: 0x00C94EC0 File Offset: 0x00C930C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_maxForce(IntPtr l)
	{
		int result;
		try
		{
			TargetJoint2D targetJoint2D = (TargetJoint2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, targetJoint2D.maxForce);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E33 RID: 146995 RVA: 0x00C94F14 File Offset: 0x00C93114
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_maxForce(IntPtr l)
	{
		int result;
		try
		{
			TargetJoint2D targetJoint2D = (TargetJoint2D)LuaObject.checkSelf(l);
			float maxForce;
			LuaObject.checkType(l, 2, out maxForce);
			targetJoint2D.maxForce = maxForce;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E34 RID: 146996 RVA: 0x00C94F6C File Offset: 0x00C9316C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_dampingRatio(IntPtr l)
	{
		int result;
		try
		{
			TargetJoint2D targetJoint2D = (TargetJoint2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, targetJoint2D.dampingRatio);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E35 RID: 146997 RVA: 0x00C94FC0 File Offset: 0x00C931C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_dampingRatio(IntPtr l)
	{
		int result;
		try
		{
			TargetJoint2D targetJoint2D = (TargetJoint2D)LuaObject.checkSelf(l);
			float dampingRatio;
			LuaObject.checkType(l, 2, out dampingRatio);
			targetJoint2D.dampingRatio = dampingRatio;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E36 RID: 146998 RVA: 0x00C95018 File Offset: 0x00C93218
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_frequency(IntPtr l)
	{
		int result;
		try
		{
			TargetJoint2D targetJoint2D = (TargetJoint2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, targetJoint2D.frequency);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E37 RID: 146999 RVA: 0x00C9506C File Offset: 0x00C9326C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_frequency(IntPtr l)
	{
		int result;
		try
		{
			TargetJoint2D targetJoint2D = (TargetJoint2D)LuaObject.checkSelf(l);
			float frequency;
			LuaObject.checkType(l, 2, out frequency);
			targetJoint2D.frequency = frequency;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023E38 RID: 147000 RVA: 0x00C950C4 File Offset: 0x00C932C4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.TargetJoint2D");
		string name = "anchor";
		if (Lua_UnityEngine_TargetJoint2D.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_TargetJoint2D.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_TargetJoint2D.get_anchor);
		}
		LuaCSFunction get = Lua_UnityEngine_TargetJoint2D.<>f__mg$cache0;
		if (Lua_UnityEngine_TargetJoint2D.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_TargetJoint2D.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_TargetJoint2D.set_anchor);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_TargetJoint2D.<>f__mg$cache1, true);
		string name2 = "target";
		if (Lua_UnityEngine_TargetJoint2D.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_TargetJoint2D.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_TargetJoint2D.get_target);
		}
		LuaCSFunction get2 = Lua_UnityEngine_TargetJoint2D.<>f__mg$cache2;
		if (Lua_UnityEngine_TargetJoint2D.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_TargetJoint2D.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_TargetJoint2D.set_target);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_TargetJoint2D.<>f__mg$cache3, true);
		string name3 = "autoConfigureTarget";
		if (Lua_UnityEngine_TargetJoint2D.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_TargetJoint2D.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_TargetJoint2D.get_autoConfigureTarget);
		}
		LuaCSFunction get3 = Lua_UnityEngine_TargetJoint2D.<>f__mg$cache4;
		if (Lua_UnityEngine_TargetJoint2D.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_TargetJoint2D.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_TargetJoint2D.set_autoConfigureTarget);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_TargetJoint2D.<>f__mg$cache5, true);
		string name4 = "maxForce";
		if (Lua_UnityEngine_TargetJoint2D.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_TargetJoint2D.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_TargetJoint2D.get_maxForce);
		}
		LuaCSFunction get4 = Lua_UnityEngine_TargetJoint2D.<>f__mg$cache6;
		if (Lua_UnityEngine_TargetJoint2D.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_TargetJoint2D.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_TargetJoint2D.set_maxForce);
		}
		LuaObject.addMember(l, name4, get4, Lua_UnityEngine_TargetJoint2D.<>f__mg$cache7, true);
		string name5 = "dampingRatio";
		if (Lua_UnityEngine_TargetJoint2D.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_TargetJoint2D.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_TargetJoint2D.get_dampingRatio);
		}
		LuaCSFunction get5 = Lua_UnityEngine_TargetJoint2D.<>f__mg$cache8;
		if (Lua_UnityEngine_TargetJoint2D.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_TargetJoint2D.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_TargetJoint2D.set_dampingRatio);
		}
		LuaObject.addMember(l, name5, get5, Lua_UnityEngine_TargetJoint2D.<>f__mg$cache9, true);
		string name6 = "frequency";
		if (Lua_UnityEngine_TargetJoint2D.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_TargetJoint2D.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_TargetJoint2D.get_frequency);
		}
		LuaCSFunction get6 = Lua_UnityEngine_TargetJoint2D.<>f__mg$cacheA;
		if (Lua_UnityEngine_TargetJoint2D.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_TargetJoint2D.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_TargetJoint2D.set_frequency);
		}
		LuaObject.addMember(l, name6, get6, Lua_UnityEngine_TargetJoint2D.<>f__mg$cacheB, true);
		LuaObject.createTypeMetatable(l, null, typeof(TargetJoint2D), typeof(Joint2D));
	}

	// Token: 0x04019AA6 RID: 105126
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019AA7 RID: 105127
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019AA8 RID: 105128
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019AA9 RID: 105129
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019AAA RID: 105130
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04019AAB RID: 105131
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04019AAC RID: 105132
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04019AAD RID: 105133
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04019AAE RID: 105134
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04019AAF RID: 105135
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04019AB0 RID: 105136
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04019AB1 RID: 105137
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;
}
