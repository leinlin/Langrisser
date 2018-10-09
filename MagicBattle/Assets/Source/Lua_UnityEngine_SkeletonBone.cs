using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x020017D2 RID: 6098
[Preserve]
public class Lua_UnityEngine_SkeletonBone : LuaObject
{
	// Token: 0x06023D0F RID: 146703 RVA: 0x00C8D318 File Offset: 0x00C8B518
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			SkeletonBone skeletonBone = default(SkeletonBone);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, skeletonBone);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D10 RID: 146704 RVA: 0x00C8D368 File Offset: 0x00C8B568
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_name(IntPtr l)
	{
		int result;
		try
		{
			SkeletonBone skeletonBone;
			LuaObject.checkValueType<SkeletonBone>(l, 1, out skeletonBone);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, skeletonBone.name);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D11 RID: 146705 RVA: 0x00C8D3BC File Offset: 0x00C8B5BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_name(IntPtr l)
	{
		int result;
		try
		{
			SkeletonBone skeletonBone;
			LuaObject.checkValueType<SkeletonBone>(l, 1, out skeletonBone);
			string name;
			LuaObject.checkType(l, 2, out name);
			skeletonBone.name = name;
			LuaObject.setBack(l, skeletonBone);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D12 RID: 146706 RVA: 0x00C8D420 File Offset: 0x00C8B620
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_position(IntPtr l)
	{
		int result;
		try
		{
			SkeletonBone skeletonBone;
			LuaObject.checkValueType<SkeletonBone>(l, 1, out skeletonBone);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, skeletonBone.position);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D13 RID: 146707 RVA: 0x00C8D474 File Offset: 0x00C8B674
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_position(IntPtr l)
	{
		int result;
		try
		{
			SkeletonBone skeletonBone;
			LuaObject.checkValueType<SkeletonBone>(l, 1, out skeletonBone);
			Vector3 position;
			LuaObject.checkType(l, 2, out position);
			skeletonBone.position = position;
			LuaObject.setBack(l, skeletonBone);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D14 RID: 146708 RVA: 0x00C8D4D8 File Offset: 0x00C8B6D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_rotation(IntPtr l)
	{
		int result;
		try
		{
			SkeletonBone skeletonBone;
			LuaObject.checkValueType<SkeletonBone>(l, 1, out skeletonBone);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, skeletonBone.rotation);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D15 RID: 146709 RVA: 0x00C8D52C File Offset: 0x00C8B72C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_rotation(IntPtr l)
	{
		int result;
		try
		{
			SkeletonBone skeletonBone;
			LuaObject.checkValueType<SkeletonBone>(l, 1, out skeletonBone);
			Quaternion rotation;
			LuaObject.checkType(l, 2, out rotation);
			skeletonBone.rotation = rotation;
			LuaObject.setBack(l, skeletonBone);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D16 RID: 146710 RVA: 0x00C8D590 File Offset: 0x00C8B790
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_scale(IntPtr l)
	{
		int result;
		try
		{
			SkeletonBone skeletonBone;
			LuaObject.checkValueType<SkeletonBone>(l, 1, out skeletonBone);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, skeletonBone.scale);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D17 RID: 146711 RVA: 0x00C8D5E4 File Offset: 0x00C8B7E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_scale(IntPtr l)
	{
		int result;
		try
		{
			SkeletonBone skeletonBone;
			LuaObject.checkValueType<SkeletonBone>(l, 1, out skeletonBone);
			Vector3 scale;
			LuaObject.checkType(l, 2, out scale);
			skeletonBone.scale = scale;
			LuaObject.setBack(l, skeletonBone);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D18 RID: 146712 RVA: 0x00C8D648 File Offset: 0x00C8B848
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.SkeletonBone");
		string name = "name";
		if (Lua_UnityEngine_SkeletonBone.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_SkeletonBone.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_SkeletonBone.get_name);
		}
		LuaCSFunction get = Lua_UnityEngine_SkeletonBone.<>f__mg$cache0;
		if (Lua_UnityEngine_SkeletonBone.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_SkeletonBone.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_SkeletonBone.set_name);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_SkeletonBone.<>f__mg$cache1, true);
		string name2 = "position";
		if (Lua_UnityEngine_SkeletonBone.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_SkeletonBone.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_SkeletonBone.get_position);
		}
		LuaCSFunction get2 = Lua_UnityEngine_SkeletonBone.<>f__mg$cache2;
		if (Lua_UnityEngine_SkeletonBone.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_SkeletonBone.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_SkeletonBone.set_position);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_SkeletonBone.<>f__mg$cache3, true);
		string name3 = "rotation";
		if (Lua_UnityEngine_SkeletonBone.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_SkeletonBone.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_SkeletonBone.get_rotation);
		}
		LuaCSFunction get3 = Lua_UnityEngine_SkeletonBone.<>f__mg$cache4;
		if (Lua_UnityEngine_SkeletonBone.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_SkeletonBone.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_SkeletonBone.set_rotation);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_SkeletonBone.<>f__mg$cache5, true);
		string name4 = "scale";
		if (Lua_UnityEngine_SkeletonBone.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_SkeletonBone.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_SkeletonBone.get_scale);
		}
		LuaCSFunction get4 = Lua_UnityEngine_SkeletonBone.<>f__mg$cache6;
		if (Lua_UnityEngine_SkeletonBone.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_SkeletonBone.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_SkeletonBone.set_scale);
		}
		LuaObject.addMember(l, name4, get4, Lua_UnityEngine_SkeletonBone.<>f__mg$cache7, true);
		if (Lua_UnityEngine_SkeletonBone.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_SkeletonBone.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_SkeletonBone.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_SkeletonBone.<>f__mg$cache8, typeof(SkeletonBone), typeof(ValueType));
	}

	// Token: 0x040199C9 RID: 104905
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040199CA RID: 104906
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040199CB RID: 104907
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040199CC RID: 104908
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040199CD RID: 104909
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040199CE RID: 104910
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040199CF RID: 104911
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040199D0 RID: 104912
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040199D1 RID: 104913
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;
}
