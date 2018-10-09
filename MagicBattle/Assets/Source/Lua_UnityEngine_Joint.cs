using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x020016F5 RID: 5877
[Preserve]
public class Lua_UnityEngine_Joint : LuaObject
{
	// Token: 0x060233D6 RID: 144342 RVA: 0x00C3AEDC File Offset: 0x00C390DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_connectedBody(IntPtr l)
	{
		int result;
		try
		{
			Joint joint = (Joint)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, joint.connectedBody);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060233D7 RID: 144343 RVA: 0x00C3AF30 File Offset: 0x00C39130
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_connectedBody(IntPtr l)
	{
		int result;
		try
		{
			Joint joint = (Joint)LuaObject.checkSelf(l);
			Rigidbody connectedBody;
			LuaObject.checkType<Rigidbody>(l, 2, out connectedBody);
			joint.connectedBody = connectedBody;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060233D8 RID: 144344 RVA: 0x00C3AF88 File Offset: 0x00C39188
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_axis(IntPtr l)
	{
		int result;
		try
		{
			Joint joint = (Joint)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, joint.axis);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060233D9 RID: 144345 RVA: 0x00C3AFDC File Offset: 0x00C391DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_axis(IntPtr l)
	{
		int result;
		try
		{
			Joint joint = (Joint)LuaObject.checkSelf(l);
			Vector3 axis;
			LuaObject.checkType(l, 2, out axis);
			joint.axis = axis;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060233DA RID: 144346 RVA: 0x00C3B034 File Offset: 0x00C39234
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_anchor(IntPtr l)
	{
		int result;
		try
		{
			Joint joint = (Joint)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, joint.anchor);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060233DB RID: 144347 RVA: 0x00C3B088 File Offset: 0x00C39288
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_anchor(IntPtr l)
	{
		int result;
		try
		{
			Joint joint = (Joint)LuaObject.checkSelf(l);
			Vector3 anchor;
			LuaObject.checkType(l, 2, out anchor);
			joint.anchor = anchor;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060233DC RID: 144348 RVA: 0x00C3B0E0 File Offset: 0x00C392E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_connectedAnchor(IntPtr l)
	{
		int result;
		try
		{
			Joint joint = (Joint)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, joint.connectedAnchor);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060233DD RID: 144349 RVA: 0x00C3B134 File Offset: 0x00C39334
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_connectedAnchor(IntPtr l)
	{
		int result;
		try
		{
			Joint joint = (Joint)LuaObject.checkSelf(l);
			Vector3 connectedAnchor;
			LuaObject.checkType(l, 2, out connectedAnchor);
			joint.connectedAnchor = connectedAnchor;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060233DE RID: 144350 RVA: 0x00C3B18C File Offset: 0x00C3938C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_autoConfigureConnectedAnchor(IntPtr l)
	{
		int result;
		try
		{
			Joint joint = (Joint)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, joint.autoConfigureConnectedAnchor);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060233DF RID: 144351 RVA: 0x00C3B1E0 File Offset: 0x00C393E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_autoConfigureConnectedAnchor(IntPtr l)
	{
		int result;
		try
		{
			Joint joint = (Joint)LuaObject.checkSelf(l);
			bool autoConfigureConnectedAnchor;
			LuaObject.checkType(l, 2, out autoConfigureConnectedAnchor);
			joint.autoConfigureConnectedAnchor = autoConfigureConnectedAnchor;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060233E0 RID: 144352 RVA: 0x00C3B238 File Offset: 0x00C39438
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_breakForce(IntPtr l)
	{
		int result;
		try
		{
			Joint joint = (Joint)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, joint.breakForce);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060233E1 RID: 144353 RVA: 0x00C3B28C File Offset: 0x00C3948C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_breakForce(IntPtr l)
	{
		int result;
		try
		{
			Joint joint = (Joint)LuaObject.checkSelf(l);
			float breakForce;
			LuaObject.checkType(l, 2, out breakForce);
			joint.breakForce = breakForce;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060233E2 RID: 144354 RVA: 0x00C3B2E4 File Offset: 0x00C394E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_breakTorque(IntPtr l)
	{
		int result;
		try
		{
			Joint joint = (Joint)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, joint.breakTorque);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060233E3 RID: 144355 RVA: 0x00C3B338 File Offset: 0x00C39538
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_breakTorque(IntPtr l)
	{
		int result;
		try
		{
			Joint joint = (Joint)LuaObject.checkSelf(l);
			float breakTorque;
			LuaObject.checkType(l, 2, out breakTorque);
			joint.breakTorque = breakTorque;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060233E4 RID: 144356 RVA: 0x00C3B390 File Offset: 0x00C39590
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_enableCollision(IntPtr l)
	{
		int result;
		try
		{
			Joint joint = (Joint)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, joint.enableCollision);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060233E5 RID: 144357 RVA: 0x00C3B3E4 File Offset: 0x00C395E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_enableCollision(IntPtr l)
	{
		int result;
		try
		{
			Joint joint = (Joint)LuaObject.checkSelf(l);
			bool enableCollision;
			LuaObject.checkType(l, 2, out enableCollision);
			joint.enableCollision = enableCollision;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060233E6 RID: 144358 RVA: 0x00C3B43C File Offset: 0x00C3963C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_enablePreprocessing(IntPtr l)
	{
		int result;
		try
		{
			Joint joint = (Joint)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, joint.enablePreprocessing);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060233E7 RID: 144359 RVA: 0x00C3B490 File Offset: 0x00C39690
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_enablePreprocessing(IntPtr l)
	{
		int result;
		try
		{
			Joint joint = (Joint)LuaObject.checkSelf(l);
			bool enablePreprocessing;
			LuaObject.checkType(l, 2, out enablePreprocessing);
			joint.enablePreprocessing = enablePreprocessing;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060233E8 RID: 144360 RVA: 0x00C3B4E8 File Offset: 0x00C396E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_currentForce(IntPtr l)
	{
		int result;
		try
		{
			Joint joint = (Joint)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, joint.currentForce);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060233E9 RID: 144361 RVA: 0x00C3B53C File Offset: 0x00C3973C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_currentTorque(IntPtr l)
	{
		int result;
		try
		{
			Joint joint = (Joint)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, joint.currentTorque);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060233EA RID: 144362 RVA: 0x00C3B590 File Offset: 0x00C39790
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_massScale(IntPtr l)
	{
		int result;
		try
		{
			Joint joint = (Joint)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, joint.massScale);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060233EB RID: 144363 RVA: 0x00C3B5E4 File Offset: 0x00C397E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_massScale(IntPtr l)
	{
		int result;
		try
		{
			Joint joint = (Joint)LuaObject.checkSelf(l);
			float massScale;
			LuaObject.checkType(l, 2, out massScale);
			joint.massScale = massScale;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060233EC RID: 144364 RVA: 0x00C3B63C File Offset: 0x00C3983C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_connectedMassScale(IntPtr l)
	{
		int result;
		try
		{
			Joint joint = (Joint)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, joint.connectedMassScale);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060233ED RID: 144365 RVA: 0x00C3B690 File Offset: 0x00C39890
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_connectedMassScale(IntPtr l)
	{
		int result;
		try
		{
			Joint joint = (Joint)LuaObject.checkSelf(l);
			float connectedMassScale;
			LuaObject.checkType(l, 2, out connectedMassScale);
			joint.connectedMassScale = connectedMassScale;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060233EE RID: 144366 RVA: 0x00C3B6E8 File Offset: 0x00C398E8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Joint");
		string name = "connectedBody";
		if (Lua_UnityEngine_Joint.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_Joint.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_Joint.get_connectedBody);
		}
		LuaCSFunction get = Lua_UnityEngine_Joint.<>f__mg$cache0;
		if (Lua_UnityEngine_Joint.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_Joint.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_Joint.set_connectedBody);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_Joint.<>f__mg$cache1, true);
		string name2 = "axis";
		if (Lua_UnityEngine_Joint.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_Joint.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_Joint.get_axis);
		}
		LuaCSFunction get2 = Lua_UnityEngine_Joint.<>f__mg$cache2;
		if (Lua_UnityEngine_Joint.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_Joint.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_Joint.set_axis);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_Joint.<>f__mg$cache3, true);
		string name3 = "anchor";
		if (Lua_UnityEngine_Joint.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_Joint.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_Joint.get_anchor);
		}
		LuaCSFunction get3 = Lua_UnityEngine_Joint.<>f__mg$cache4;
		if (Lua_UnityEngine_Joint.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_Joint.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_Joint.set_anchor);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_Joint.<>f__mg$cache5, true);
		string name4 = "connectedAnchor";
		if (Lua_UnityEngine_Joint.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_Joint.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_Joint.get_connectedAnchor);
		}
		LuaCSFunction get4 = Lua_UnityEngine_Joint.<>f__mg$cache6;
		if (Lua_UnityEngine_Joint.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_Joint.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_Joint.set_connectedAnchor);
		}
		LuaObject.addMember(l, name4, get4, Lua_UnityEngine_Joint.<>f__mg$cache7, true);
		string name5 = "autoConfigureConnectedAnchor";
		if (Lua_UnityEngine_Joint.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_Joint.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_Joint.get_autoConfigureConnectedAnchor);
		}
		LuaCSFunction get5 = Lua_UnityEngine_Joint.<>f__mg$cache8;
		if (Lua_UnityEngine_Joint.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_Joint.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_Joint.set_autoConfigureConnectedAnchor);
		}
		LuaObject.addMember(l, name5, get5, Lua_UnityEngine_Joint.<>f__mg$cache9, true);
		string name6 = "breakForce";
		if (Lua_UnityEngine_Joint.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_Joint.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_Joint.get_breakForce);
		}
		LuaCSFunction get6 = Lua_UnityEngine_Joint.<>f__mg$cacheA;
		if (Lua_UnityEngine_Joint.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_Joint.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_Joint.set_breakForce);
		}
		LuaObject.addMember(l, name6, get6, Lua_UnityEngine_Joint.<>f__mg$cacheB, true);
		string name7 = "breakTorque";
		if (Lua_UnityEngine_Joint.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_Joint.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_Joint.get_breakTorque);
		}
		LuaCSFunction get7 = Lua_UnityEngine_Joint.<>f__mg$cacheC;
		if (Lua_UnityEngine_Joint.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_Joint.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_Joint.set_breakTorque);
		}
		LuaObject.addMember(l, name7, get7, Lua_UnityEngine_Joint.<>f__mg$cacheD, true);
		string name8 = "enableCollision";
		if (Lua_UnityEngine_Joint.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_Joint.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_Joint.get_enableCollision);
		}
		LuaCSFunction get8 = Lua_UnityEngine_Joint.<>f__mg$cacheE;
		if (Lua_UnityEngine_Joint.<>f__mg$cacheF == null)
		{
			Lua_UnityEngine_Joint.<>f__mg$cacheF = new LuaCSFunction(Lua_UnityEngine_Joint.set_enableCollision);
		}
		LuaObject.addMember(l, name8, get8, Lua_UnityEngine_Joint.<>f__mg$cacheF, true);
		string name9 = "enablePreprocessing";
		if (Lua_UnityEngine_Joint.<>f__mg$cache10 == null)
		{
			Lua_UnityEngine_Joint.<>f__mg$cache10 = new LuaCSFunction(Lua_UnityEngine_Joint.get_enablePreprocessing);
		}
		LuaCSFunction get9 = Lua_UnityEngine_Joint.<>f__mg$cache10;
		if (Lua_UnityEngine_Joint.<>f__mg$cache11 == null)
		{
			Lua_UnityEngine_Joint.<>f__mg$cache11 = new LuaCSFunction(Lua_UnityEngine_Joint.set_enablePreprocessing);
		}
		LuaObject.addMember(l, name9, get9, Lua_UnityEngine_Joint.<>f__mg$cache11, true);
		string name10 = "currentForce";
		if (Lua_UnityEngine_Joint.<>f__mg$cache12 == null)
		{
			Lua_UnityEngine_Joint.<>f__mg$cache12 = new LuaCSFunction(Lua_UnityEngine_Joint.get_currentForce);
		}
		LuaObject.addMember(l, name10, Lua_UnityEngine_Joint.<>f__mg$cache12, null, true);
		string name11 = "currentTorque";
		if (Lua_UnityEngine_Joint.<>f__mg$cache13 == null)
		{
			Lua_UnityEngine_Joint.<>f__mg$cache13 = new LuaCSFunction(Lua_UnityEngine_Joint.get_currentTorque);
		}
		LuaObject.addMember(l, name11, Lua_UnityEngine_Joint.<>f__mg$cache13, null, true);
		string name12 = "massScale";
		if (Lua_UnityEngine_Joint.<>f__mg$cache14 == null)
		{
			Lua_UnityEngine_Joint.<>f__mg$cache14 = new LuaCSFunction(Lua_UnityEngine_Joint.get_massScale);
		}
		LuaCSFunction get10 = Lua_UnityEngine_Joint.<>f__mg$cache14;
		if (Lua_UnityEngine_Joint.<>f__mg$cache15 == null)
		{
			Lua_UnityEngine_Joint.<>f__mg$cache15 = new LuaCSFunction(Lua_UnityEngine_Joint.set_massScale);
		}
		LuaObject.addMember(l, name12, get10, Lua_UnityEngine_Joint.<>f__mg$cache15, true);
		string name13 = "connectedMassScale";
		if (Lua_UnityEngine_Joint.<>f__mg$cache16 == null)
		{
			Lua_UnityEngine_Joint.<>f__mg$cache16 = new LuaCSFunction(Lua_UnityEngine_Joint.get_connectedMassScale);
		}
		LuaCSFunction get11 = Lua_UnityEngine_Joint.<>f__mg$cache16;
		if (Lua_UnityEngine_Joint.<>f__mg$cache17 == null)
		{
			Lua_UnityEngine_Joint.<>f__mg$cache17 = new LuaCSFunction(Lua_UnityEngine_Joint.set_connectedMassScale);
		}
		LuaObject.addMember(l, name13, get11, Lua_UnityEngine_Joint.<>f__mg$cache17, true);
		LuaObject.createTypeMetatable(l, null, typeof(Joint), typeof(Component));
	}

	// Token: 0x0401924A RID: 102986
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401924B RID: 102987
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401924C RID: 102988
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0401924D RID: 102989
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0401924E RID: 102990
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0401924F RID: 102991
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04019250 RID: 102992
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04019251 RID: 102993
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04019252 RID: 102994
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04019253 RID: 102995
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04019254 RID: 102996
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04019255 RID: 102997
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04019256 RID: 102998
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04019257 RID: 102999
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04019258 RID: 103000
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04019259 RID: 103001
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0401925A RID: 103002
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0401925B RID: 103003
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0401925C RID: 103004
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0401925D RID: 103005
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0401925E RID: 103006
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0401925F RID: 103007
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04019260 RID: 103008
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04019261 RID: 103009
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;
}
