using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x020017DF RID: 6111
[Preserve]
public class Lua_UnityEngine_SpringJoint2D : LuaObject
{
	// Token: 0x06023D84 RID: 146820 RVA: 0x00C902B4 File Offset: 0x00C8E4B4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_autoConfigureDistance(IntPtr l)
	{
		int result;
		try
		{
			SpringJoint2D springJoint2D = (SpringJoint2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, springJoint2D.autoConfigureDistance);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D85 RID: 146821 RVA: 0x00C90308 File Offset: 0x00C8E508
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_autoConfigureDistance(IntPtr l)
	{
		int result;
		try
		{
			SpringJoint2D springJoint2D = (SpringJoint2D)LuaObject.checkSelf(l);
			bool autoConfigureDistance;
			LuaObject.checkType(l, 2, out autoConfigureDistance);
			springJoint2D.autoConfigureDistance = autoConfigureDistance;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D86 RID: 146822 RVA: 0x00C90360 File Offset: 0x00C8E560
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_distance(IntPtr l)
	{
		int result;
		try
		{
			SpringJoint2D springJoint2D = (SpringJoint2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, springJoint2D.distance);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D87 RID: 146823 RVA: 0x00C903B4 File Offset: 0x00C8E5B4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_distance(IntPtr l)
	{
		int result;
		try
		{
			SpringJoint2D springJoint2D = (SpringJoint2D)LuaObject.checkSelf(l);
			float distance;
			LuaObject.checkType(l, 2, out distance);
			springJoint2D.distance = distance;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D88 RID: 146824 RVA: 0x00C9040C File Offset: 0x00C8E60C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_dampingRatio(IntPtr l)
	{
		int result;
		try
		{
			SpringJoint2D springJoint2D = (SpringJoint2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, springJoint2D.dampingRatio);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D89 RID: 146825 RVA: 0x00C90460 File Offset: 0x00C8E660
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_dampingRatio(IntPtr l)
	{
		int result;
		try
		{
			SpringJoint2D springJoint2D = (SpringJoint2D)LuaObject.checkSelf(l);
			float dampingRatio;
			LuaObject.checkType(l, 2, out dampingRatio);
			springJoint2D.dampingRatio = dampingRatio;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D8A RID: 146826 RVA: 0x00C904B8 File Offset: 0x00C8E6B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_frequency(IntPtr l)
	{
		int result;
		try
		{
			SpringJoint2D springJoint2D = (SpringJoint2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, springJoint2D.frequency);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D8B RID: 146827 RVA: 0x00C9050C File Offset: 0x00C8E70C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_frequency(IntPtr l)
	{
		int result;
		try
		{
			SpringJoint2D springJoint2D = (SpringJoint2D)LuaObject.checkSelf(l);
			float frequency;
			LuaObject.checkType(l, 2, out frequency);
			springJoint2D.frequency = frequency;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D8C RID: 146828 RVA: 0x00C90564 File Offset: 0x00C8E764
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.SpringJoint2D");
		string name = "autoConfigureDistance";
		if (Lua_UnityEngine_SpringJoint2D.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_SpringJoint2D.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_SpringJoint2D.get_autoConfigureDistance);
		}
		LuaCSFunction get = Lua_UnityEngine_SpringJoint2D.<>f__mg$cache0;
		if (Lua_UnityEngine_SpringJoint2D.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_SpringJoint2D.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_SpringJoint2D.set_autoConfigureDistance);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_SpringJoint2D.<>f__mg$cache1, true);
		string name2 = "distance";
		if (Lua_UnityEngine_SpringJoint2D.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_SpringJoint2D.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_SpringJoint2D.get_distance);
		}
		LuaCSFunction get2 = Lua_UnityEngine_SpringJoint2D.<>f__mg$cache2;
		if (Lua_UnityEngine_SpringJoint2D.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_SpringJoint2D.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_SpringJoint2D.set_distance);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_SpringJoint2D.<>f__mg$cache3, true);
		string name3 = "dampingRatio";
		if (Lua_UnityEngine_SpringJoint2D.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_SpringJoint2D.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_SpringJoint2D.get_dampingRatio);
		}
		LuaCSFunction get3 = Lua_UnityEngine_SpringJoint2D.<>f__mg$cache4;
		if (Lua_UnityEngine_SpringJoint2D.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_SpringJoint2D.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_SpringJoint2D.set_dampingRatio);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_SpringJoint2D.<>f__mg$cache5, true);
		string name4 = "frequency";
		if (Lua_UnityEngine_SpringJoint2D.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_SpringJoint2D.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_SpringJoint2D.get_frequency);
		}
		LuaCSFunction get4 = Lua_UnityEngine_SpringJoint2D.<>f__mg$cache6;
		if (Lua_UnityEngine_SpringJoint2D.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_SpringJoint2D.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_SpringJoint2D.set_frequency);
		}
		LuaObject.addMember(l, name4, get4, Lua_UnityEngine_SpringJoint2D.<>f__mg$cache7, true);
		LuaObject.createTypeMetatable(l, null, typeof(SpringJoint2D), typeof(AnchoredJoint2D));
	}

	// Token: 0x04019A24 RID: 104996
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019A25 RID: 104997
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019A26 RID: 104998
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019A27 RID: 104999
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019A28 RID: 105000
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04019A29 RID: 105001
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04019A2A RID: 105002
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04019A2B RID: 105003
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;
}
