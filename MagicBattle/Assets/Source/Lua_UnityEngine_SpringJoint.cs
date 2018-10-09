using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x020017DE RID: 6110
[Preserve]
public class Lua_UnityEngine_SpringJoint : LuaObject
{
	// Token: 0x06023D78 RID: 146808 RVA: 0x00C8FDBC File Offset: 0x00C8DFBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_spring(IntPtr l)
	{
		int result;
		try
		{
			SpringJoint springJoint = (SpringJoint)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, springJoint.spring);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D79 RID: 146809 RVA: 0x00C8FE10 File Offset: 0x00C8E010
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_spring(IntPtr l)
	{
		int result;
		try
		{
			SpringJoint springJoint = (SpringJoint)LuaObject.checkSelf(l);
			float spring;
			LuaObject.checkType(l, 2, out spring);
			springJoint.spring = spring;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D7A RID: 146810 RVA: 0x00C8FE68 File Offset: 0x00C8E068
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_damper(IntPtr l)
	{
		int result;
		try
		{
			SpringJoint springJoint = (SpringJoint)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, springJoint.damper);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D7B RID: 146811 RVA: 0x00C8FEBC File Offset: 0x00C8E0BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_damper(IntPtr l)
	{
		int result;
		try
		{
			SpringJoint springJoint = (SpringJoint)LuaObject.checkSelf(l);
			float damper;
			LuaObject.checkType(l, 2, out damper);
			springJoint.damper = damper;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D7C RID: 146812 RVA: 0x00C8FF14 File Offset: 0x00C8E114
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_minDistance(IntPtr l)
	{
		int result;
		try
		{
			SpringJoint springJoint = (SpringJoint)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, springJoint.minDistance);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D7D RID: 146813 RVA: 0x00C8FF68 File Offset: 0x00C8E168
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_minDistance(IntPtr l)
	{
		int result;
		try
		{
			SpringJoint springJoint = (SpringJoint)LuaObject.checkSelf(l);
			float minDistance;
			LuaObject.checkType(l, 2, out minDistance);
			springJoint.minDistance = minDistance;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D7E RID: 146814 RVA: 0x00C8FFC0 File Offset: 0x00C8E1C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_maxDistance(IntPtr l)
	{
		int result;
		try
		{
			SpringJoint springJoint = (SpringJoint)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, springJoint.maxDistance);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D7F RID: 146815 RVA: 0x00C90014 File Offset: 0x00C8E214
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_maxDistance(IntPtr l)
	{
		int result;
		try
		{
			SpringJoint springJoint = (SpringJoint)LuaObject.checkSelf(l);
			float maxDistance;
			LuaObject.checkType(l, 2, out maxDistance);
			springJoint.maxDistance = maxDistance;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D80 RID: 146816 RVA: 0x00C9006C File Offset: 0x00C8E26C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_tolerance(IntPtr l)
	{
		int result;
		try
		{
			SpringJoint springJoint = (SpringJoint)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, springJoint.tolerance);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D81 RID: 146817 RVA: 0x00C900C0 File Offset: 0x00C8E2C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_tolerance(IntPtr l)
	{
		int result;
		try
		{
			SpringJoint springJoint = (SpringJoint)LuaObject.checkSelf(l);
			float tolerance;
			LuaObject.checkType(l, 2, out tolerance);
			springJoint.tolerance = tolerance;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D82 RID: 146818 RVA: 0x00C90118 File Offset: 0x00C8E318
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.SpringJoint");
		string name = "spring";
		if (Lua_UnityEngine_SpringJoint.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_SpringJoint.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_SpringJoint.get_spring);
		}
		LuaCSFunction get = Lua_UnityEngine_SpringJoint.<>f__mg$cache0;
		if (Lua_UnityEngine_SpringJoint.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_SpringJoint.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_SpringJoint.set_spring);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_SpringJoint.<>f__mg$cache1, true);
		string name2 = "damper";
		if (Lua_UnityEngine_SpringJoint.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_SpringJoint.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_SpringJoint.get_damper);
		}
		LuaCSFunction get2 = Lua_UnityEngine_SpringJoint.<>f__mg$cache2;
		if (Lua_UnityEngine_SpringJoint.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_SpringJoint.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_SpringJoint.set_damper);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_SpringJoint.<>f__mg$cache3, true);
		string name3 = "minDistance";
		if (Lua_UnityEngine_SpringJoint.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_SpringJoint.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_SpringJoint.get_minDistance);
		}
		LuaCSFunction get3 = Lua_UnityEngine_SpringJoint.<>f__mg$cache4;
		if (Lua_UnityEngine_SpringJoint.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_SpringJoint.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_SpringJoint.set_minDistance);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_SpringJoint.<>f__mg$cache5, true);
		string name4 = "maxDistance";
		if (Lua_UnityEngine_SpringJoint.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_SpringJoint.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_SpringJoint.get_maxDistance);
		}
		LuaCSFunction get4 = Lua_UnityEngine_SpringJoint.<>f__mg$cache6;
		if (Lua_UnityEngine_SpringJoint.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_SpringJoint.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_SpringJoint.set_maxDistance);
		}
		LuaObject.addMember(l, name4, get4, Lua_UnityEngine_SpringJoint.<>f__mg$cache7, true);
		string name5 = "tolerance";
		if (Lua_UnityEngine_SpringJoint.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_SpringJoint.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_SpringJoint.get_tolerance);
		}
		LuaCSFunction get5 = Lua_UnityEngine_SpringJoint.<>f__mg$cache8;
		if (Lua_UnityEngine_SpringJoint.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_SpringJoint.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_SpringJoint.set_tolerance);
		}
		LuaObject.addMember(l, name5, get5, Lua_UnityEngine_SpringJoint.<>f__mg$cache9, true);
		LuaObject.createTypeMetatable(l, null, typeof(SpringJoint), typeof(Joint));
	}

	// Token: 0x04019A1A RID: 104986
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019A1B RID: 104987
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019A1C RID: 104988
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019A1D RID: 104989
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019A1E RID: 104990
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04019A1F RID: 104991
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04019A20 RID: 104992
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04019A21 RID: 104993
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04019A22 RID: 104994
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04019A23 RID: 104995
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;
}
