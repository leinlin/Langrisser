using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001654 RID: 5716
[Preserve]
public class Lua_UnityEngine_CapsuleCollider : LuaObject
{
	// Token: 0x06022DDF RID: 142815 RVA: 0x00C0D308 File Offset: 0x00C0B508
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_center(IntPtr l)
	{
		int result;
		try
		{
			CapsuleCollider capsuleCollider = (CapsuleCollider)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, capsuleCollider.center);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022DE0 RID: 142816 RVA: 0x00C0D35C File Offset: 0x00C0B55C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_center(IntPtr l)
	{
		int result;
		try
		{
			CapsuleCollider capsuleCollider = (CapsuleCollider)LuaObject.checkSelf(l);
			Vector3 center;
			LuaObject.checkType(l, 2, out center);
			capsuleCollider.center = center;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022DE1 RID: 142817 RVA: 0x00C0D3B4 File Offset: 0x00C0B5B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_radius(IntPtr l)
	{
		int result;
		try
		{
			CapsuleCollider capsuleCollider = (CapsuleCollider)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, capsuleCollider.radius);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022DE2 RID: 142818 RVA: 0x00C0D408 File Offset: 0x00C0B608
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_radius(IntPtr l)
	{
		int result;
		try
		{
			CapsuleCollider capsuleCollider = (CapsuleCollider)LuaObject.checkSelf(l);
			float radius;
			LuaObject.checkType(l, 2, out radius);
			capsuleCollider.radius = radius;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022DE3 RID: 142819 RVA: 0x00C0D460 File Offset: 0x00C0B660
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_height(IntPtr l)
	{
		int result;
		try
		{
			CapsuleCollider capsuleCollider = (CapsuleCollider)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, capsuleCollider.height);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022DE4 RID: 142820 RVA: 0x00C0D4B4 File Offset: 0x00C0B6B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_height(IntPtr l)
	{
		int result;
		try
		{
			CapsuleCollider capsuleCollider = (CapsuleCollider)LuaObject.checkSelf(l);
			float height;
			LuaObject.checkType(l, 2, out height);
			capsuleCollider.height = height;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022DE5 RID: 142821 RVA: 0x00C0D50C File Offset: 0x00C0B70C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_direction(IntPtr l)
	{
		int result;
		try
		{
			CapsuleCollider capsuleCollider = (CapsuleCollider)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, capsuleCollider.direction);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022DE6 RID: 142822 RVA: 0x00C0D560 File Offset: 0x00C0B760
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_direction(IntPtr l)
	{
		int result;
		try
		{
			CapsuleCollider capsuleCollider = (CapsuleCollider)LuaObject.checkSelf(l);
			int direction;
			LuaObject.checkType(l, 2, out direction);
			capsuleCollider.direction = direction;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022DE7 RID: 142823 RVA: 0x00C0D5B8 File Offset: 0x00C0B7B8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.CapsuleCollider");
		string name = "center";
		if (Lua_UnityEngine_CapsuleCollider.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_CapsuleCollider.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_CapsuleCollider.get_center);
		}
		LuaCSFunction get = Lua_UnityEngine_CapsuleCollider.<>f__mg$cache0;
		if (Lua_UnityEngine_CapsuleCollider.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_CapsuleCollider.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_CapsuleCollider.set_center);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_CapsuleCollider.<>f__mg$cache1, true);
		string name2 = "radius";
		if (Lua_UnityEngine_CapsuleCollider.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_CapsuleCollider.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_CapsuleCollider.get_radius);
		}
		LuaCSFunction get2 = Lua_UnityEngine_CapsuleCollider.<>f__mg$cache2;
		if (Lua_UnityEngine_CapsuleCollider.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_CapsuleCollider.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_CapsuleCollider.set_radius);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_CapsuleCollider.<>f__mg$cache3, true);
		string name3 = "height";
		if (Lua_UnityEngine_CapsuleCollider.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_CapsuleCollider.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_CapsuleCollider.get_height);
		}
		LuaCSFunction get3 = Lua_UnityEngine_CapsuleCollider.<>f__mg$cache4;
		if (Lua_UnityEngine_CapsuleCollider.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_CapsuleCollider.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_CapsuleCollider.set_height);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_CapsuleCollider.<>f__mg$cache5, true);
		string name4 = "direction";
		if (Lua_UnityEngine_CapsuleCollider.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_CapsuleCollider.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_CapsuleCollider.get_direction);
		}
		LuaCSFunction get4 = Lua_UnityEngine_CapsuleCollider.<>f__mg$cache6;
		if (Lua_UnityEngine_CapsuleCollider.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_CapsuleCollider.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_CapsuleCollider.set_direction);
		}
		LuaObject.addMember(l, name4, get4, Lua_UnityEngine_CapsuleCollider.<>f__mg$cache7, true);
		LuaObject.createTypeMetatable(l, null, typeof(CapsuleCollider), typeof(Collider));
	}

	// Token: 0x04018D95 RID: 101781
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04018D96 RID: 101782
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04018D97 RID: 101783
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04018D98 RID: 101784
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04018D99 RID: 101785
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04018D9A RID: 101786
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04018D9B RID: 101787
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04018D9C RID: 101788
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;
}
