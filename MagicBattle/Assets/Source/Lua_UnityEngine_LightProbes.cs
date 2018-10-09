using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

// Token: 0x02001712 RID: 5906
[Preserve]
public class Lua_UnityEngine_LightProbes : LuaObject
{
	// Token: 0x060234E5 RID: 144613 RVA: 0x00C43004 File Offset: 0x00C41204
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			LightProbes o = new LightProbes();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, o);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060234E6 RID: 144614 RVA: 0x00C4304C File Offset: 0x00C4124C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetInterpolatedProbe_s(IntPtr l)
	{
		int result;
		try
		{
			Vector3 position;
			LuaObject.checkType(l, 1, out position);
			Renderer renderer;
			LuaObject.checkType<Renderer>(l, 2, out renderer);
			SphericalHarmonicsL2 sphericalHarmonicsL;
			LightProbes.GetInterpolatedProbe(position, renderer, out sphericalHarmonicsL);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, sphericalHarmonicsL);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060234E7 RID: 144615 RVA: 0x00C430B4 File Offset: 0x00C412B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_positions(IntPtr l)
	{
		int result;
		try
		{
			LightProbes lightProbes = (LightProbes)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, lightProbes.positions);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060234E8 RID: 144616 RVA: 0x00C43108 File Offset: 0x00C41308
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_bakedProbes(IntPtr l)
	{
		int result;
		try
		{
			LightProbes lightProbes = (LightProbes)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, lightProbes.bakedProbes);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060234E9 RID: 144617 RVA: 0x00C4315C File Offset: 0x00C4135C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_bakedProbes(IntPtr l)
	{
		int result;
		try
		{
			LightProbes lightProbes = (LightProbes)LuaObject.checkSelf(l);
			SphericalHarmonicsL2[] bakedProbes;
			LuaObject.checkArray<SphericalHarmonicsL2>(l, 2, out bakedProbes);
			lightProbes.bakedProbes = bakedProbes;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060234EA RID: 144618 RVA: 0x00C431B4 File Offset: 0x00C413B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_count(IntPtr l)
	{
		int result;
		try
		{
			LightProbes lightProbes = (LightProbes)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, lightProbes.count);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060234EB RID: 144619 RVA: 0x00C43208 File Offset: 0x00C41408
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_cellCount(IntPtr l)
	{
		int result;
		try
		{
			LightProbes lightProbes = (LightProbes)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, lightProbes.cellCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060234EC RID: 144620 RVA: 0x00C4325C File Offset: 0x00C4145C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.LightProbes");
		if (Lua_UnityEngine_LightProbes.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_LightProbes.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_LightProbes.GetInterpolatedProbe_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_LightProbes.<>f__mg$cache0);
		string name = "positions";
		if (Lua_UnityEngine_LightProbes.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_LightProbes.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_LightProbes.get_positions);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_LightProbes.<>f__mg$cache1, null, true);
		string name2 = "bakedProbes";
		if (Lua_UnityEngine_LightProbes.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_LightProbes.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_LightProbes.get_bakedProbes);
		}
		LuaCSFunction get = Lua_UnityEngine_LightProbes.<>f__mg$cache2;
		if (Lua_UnityEngine_LightProbes.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_LightProbes.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_LightProbes.set_bakedProbes);
		}
		LuaObject.addMember(l, name2, get, Lua_UnityEngine_LightProbes.<>f__mg$cache3, true);
		string name3 = "count";
		if (Lua_UnityEngine_LightProbes.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_LightProbes.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_LightProbes.get_count);
		}
		LuaObject.addMember(l, name3, Lua_UnityEngine_LightProbes.<>f__mg$cache4, null, true);
		string name4 = "cellCount";
		if (Lua_UnityEngine_LightProbes.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_LightProbes.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_LightProbes.get_cellCount);
		}
		LuaObject.addMember(l, name4, Lua_UnityEngine_LightProbes.<>f__mg$cache5, null, true);
		if (Lua_UnityEngine_LightProbes.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_LightProbes.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_LightProbes.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_LightProbes.<>f__mg$cache6, typeof(LightProbes), typeof(UnityEngine.Object));
	}

	// Token: 0x0401931F RID: 103199
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019320 RID: 103200
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019321 RID: 103201
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019322 RID: 103202
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019323 RID: 103203
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04019324 RID: 103204
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04019325 RID: 103205
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;
}
