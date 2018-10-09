using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001775 RID: 6005
[Preserve]
public class Lua_UnityEngine_RelativeJoint2D : LuaObject
{
	// Token: 0x06023A25 RID: 145957 RVA: 0x00C74634 File Offset: 0x00C72834
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_maxForce(IntPtr l)
	{
		int result;
		try
		{
			RelativeJoint2D relativeJoint2D = (RelativeJoint2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, relativeJoint2D.maxForce);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A26 RID: 145958 RVA: 0x00C74688 File Offset: 0x00C72888
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_maxForce(IntPtr l)
	{
		int result;
		try
		{
			RelativeJoint2D relativeJoint2D = (RelativeJoint2D)LuaObject.checkSelf(l);
			float maxForce;
			LuaObject.checkType(l, 2, out maxForce);
			relativeJoint2D.maxForce = maxForce;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A27 RID: 145959 RVA: 0x00C746E0 File Offset: 0x00C728E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_maxTorque(IntPtr l)
	{
		int result;
		try
		{
			RelativeJoint2D relativeJoint2D = (RelativeJoint2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, relativeJoint2D.maxTorque);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A28 RID: 145960 RVA: 0x00C74734 File Offset: 0x00C72934
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_maxTorque(IntPtr l)
	{
		int result;
		try
		{
			RelativeJoint2D relativeJoint2D = (RelativeJoint2D)LuaObject.checkSelf(l);
			float maxTorque;
			LuaObject.checkType(l, 2, out maxTorque);
			relativeJoint2D.maxTorque = maxTorque;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A29 RID: 145961 RVA: 0x00C7478C File Offset: 0x00C7298C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_correctionScale(IntPtr l)
	{
		int result;
		try
		{
			RelativeJoint2D relativeJoint2D = (RelativeJoint2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, relativeJoint2D.correctionScale);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A2A RID: 145962 RVA: 0x00C747E0 File Offset: 0x00C729E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_correctionScale(IntPtr l)
	{
		int result;
		try
		{
			RelativeJoint2D relativeJoint2D = (RelativeJoint2D)LuaObject.checkSelf(l);
			float correctionScale;
			LuaObject.checkType(l, 2, out correctionScale);
			relativeJoint2D.correctionScale = correctionScale;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A2B RID: 145963 RVA: 0x00C74838 File Offset: 0x00C72A38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_autoConfigureOffset(IntPtr l)
	{
		int result;
		try
		{
			RelativeJoint2D relativeJoint2D = (RelativeJoint2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, relativeJoint2D.autoConfigureOffset);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A2C RID: 145964 RVA: 0x00C7488C File Offset: 0x00C72A8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_autoConfigureOffset(IntPtr l)
	{
		int result;
		try
		{
			RelativeJoint2D relativeJoint2D = (RelativeJoint2D)LuaObject.checkSelf(l);
			bool autoConfigureOffset;
			LuaObject.checkType(l, 2, out autoConfigureOffset);
			relativeJoint2D.autoConfigureOffset = autoConfigureOffset;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A2D RID: 145965 RVA: 0x00C748E4 File Offset: 0x00C72AE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_linearOffset(IntPtr l)
	{
		int result;
		try
		{
			RelativeJoint2D relativeJoint2D = (RelativeJoint2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, relativeJoint2D.linearOffset);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A2E RID: 145966 RVA: 0x00C74938 File Offset: 0x00C72B38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_linearOffset(IntPtr l)
	{
		int result;
		try
		{
			RelativeJoint2D relativeJoint2D = (RelativeJoint2D)LuaObject.checkSelf(l);
			Vector2 linearOffset;
			LuaObject.checkType(l, 2, out linearOffset);
			relativeJoint2D.linearOffset = linearOffset;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A2F RID: 145967 RVA: 0x00C74990 File Offset: 0x00C72B90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_angularOffset(IntPtr l)
	{
		int result;
		try
		{
			RelativeJoint2D relativeJoint2D = (RelativeJoint2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, relativeJoint2D.angularOffset);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A30 RID: 145968 RVA: 0x00C749E4 File Offset: 0x00C72BE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_angularOffset(IntPtr l)
	{
		int result;
		try
		{
			RelativeJoint2D relativeJoint2D = (RelativeJoint2D)LuaObject.checkSelf(l);
			float angularOffset;
			LuaObject.checkType(l, 2, out angularOffset);
			relativeJoint2D.angularOffset = angularOffset;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A31 RID: 145969 RVA: 0x00C74A3C File Offset: 0x00C72C3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_target(IntPtr l)
	{
		int result;
		try
		{
			RelativeJoint2D relativeJoint2D = (RelativeJoint2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, relativeJoint2D.target);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023A32 RID: 145970 RVA: 0x00C74A90 File Offset: 0x00C72C90
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.RelativeJoint2D");
		string name = "maxForce";
		if (Lua_UnityEngine_RelativeJoint2D.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_RelativeJoint2D.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_RelativeJoint2D.get_maxForce);
		}
		LuaCSFunction get = Lua_UnityEngine_RelativeJoint2D.<>f__mg$cache0;
		if (Lua_UnityEngine_RelativeJoint2D.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_RelativeJoint2D.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_RelativeJoint2D.set_maxForce);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_RelativeJoint2D.<>f__mg$cache1, true);
		string name2 = "maxTorque";
		if (Lua_UnityEngine_RelativeJoint2D.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_RelativeJoint2D.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_RelativeJoint2D.get_maxTorque);
		}
		LuaCSFunction get2 = Lua_UnityEngine_RelativeJoint2D.<>f__mg$cache2;
		if (Lua_UnityEngine_RelativeJoint2D.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_RelativeJoint2D.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_RelativeJoint2D.set_maxTorque);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_RelativeJoint2D.<>f__mg$cache3, true);
		string name3 = "correctionScale";
		if (Lua_UnityEngine_RelativeJoint2D.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_RelativeJoint2D.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_RelativeJoint2D.get_correctionScale);
		}
		LuaCSFunction get3 = Lua_UnityEngine_RelativeJoint2D.<>f__mg$cache4;
		if (Lua_UnityEngine_RelativeJoint2D.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_RelativeJoint2D.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_RelativeJoint2D.set_correctionScale);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_RelativeJoint2D.<>f__mg$cache5, true);
		string name4 = "autoConfigureOffset";
		if (Lua_UnityEngine_RelativeJoint2D.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_RelativeJoint2D.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_RelativeJoint2D.get_autoConfigureOffset);
		}
		LuaCSFunction get4 = Lua_UnityEngine_RelativeJoint2D.<>f__mg$cache6;
		if (Lua_UnityEngine_RelativeJoint2D.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_RelativeJoint2D.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_RelativeJoint2D.set_autoConfigureOffset);
		}
		LuaObject.addMember(l, name4, get4, Lua_UnityEngine_RelativeJoint2D.<>f__mg$cache7, true);
		string name5 = "linearOffset";
		if (Lua_UnityEngine_RelativeJoint2D.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_RelativeJoint2D.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_RelativeJoint2D.get_linearOffset);
		}
		LuaCSFunction get5 = Lua_UnityEngine_RelativeJoint2D.<>f__mg$cache8;
		if (Lua_UnityEngine_RelativeJoint2D.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_RelativeJoint2D.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_RelativeJoint2D.set_linearOffset);
		}
		LuaObject.addMember(l, name5, get5, Lua_UnityEngine_RelativeJoint2D.<>f__mg$cache9, true);
		string name6 = "angularOffset";
		if (Lua_UnityEngine_RelativeJoint2D.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_RelativeJoint2D.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_RelativeJoint2D.get_angularOffset);
		}
		LuaCSFunction get6 = Lua_UnityEngine_RelativeJoint2D.<>f__mg$cacheA;
		if (Lua_UnityEngine_RelativeJoint2D.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_RelativeJoint2D.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_RelativeJoint2D.set_angularOffset);
		}
		LuaObject.addMember(l, name6, get6, Lua_UnityEngine_RelativeJoint2D.<>f__mg$cacheB, true);
		string name7 = "target";
		if (Lua_UnityEngine_RelativeJoint2D.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_RelativeJoint2D.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_RelativeJoint2D.get_target);
		}
		LuaObject.addMember(l, name7, Lua_UnityEngine_RelativeJoint2D.<>f__mg$cacheC, null, true);
		LuaObject.createTypeMetatable(l, null, typeof(RelativeJoint2D), typeof(Joint2D));
	}

	// Token: 0x04019799 RID: 104345
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401979A RID: 104346
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401979B RID: 104347
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0401979C RID: 104348
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0401979D RID: 104349
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0401979E RID: 104350
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0401979F RID: 104351
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040197A0 RID: 104352
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040197A1 RID: 104353
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040197A2 RID: 104354
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040197A3 RID: 104355
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040197A4 RID: 104356
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040197A5 RID: 104357
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;
}
