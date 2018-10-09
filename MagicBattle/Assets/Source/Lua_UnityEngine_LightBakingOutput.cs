using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001706 RID: 5894
[Preserve]
public class Lua_UnityEngine_LightBakingOutput : LuaObject
{
	// Token: 0x0602349B RID: 144539 RVA: 0x00C415AC File Offset: 0x00C3F7AC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			LightBakingOutput lightBakingOutput = default(LightBakingOutput);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, lightBakingOutput);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602349C RID: 144540 RVA: 0x00C415FC File Offset: 0x00C3F7FC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_probeOcclusionLightIndex(IntPtr l)
	{
		int result;
		try
		{
			LightBakingOutput lightBakingOutput;
			LuaObject.checkValueType<LightBakingOutput>(l, 1, out lightBakingOutput);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, lightBakingOutput.probeOcclusionLightIndex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602349D RID: 144541 RVA: 0x00C41650 File Offset: 0x00C3F850
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_probeOcclusionLightIndex(IntPtr l)
	{
		int result;
		try
		{
			LightBakingOutput lightBakingOutput;
			LuaObject.checkValueType<LightBakingOutput>(l, 1, out lightBakingOutput);
			int probeOcclusionLightIndex;
			LuaObject.checkType(l, 2, out probeOcclusionLightIndex);
			lightBakingOutput.probeOcclusionLightIndex = probeOcclusionLightIndex;
			LuaObject.setBack(l, lightBakingOutput);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602349E RID: 144542 RVA: 0x00C416B4 File Offset: 0x00C3F8B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_occlusionMaskChannel(IntPtr l)
	{
		int result;
		try
		{
			LightBakingOutput lightBakingOutput;
			LuaObject.checkValueType<LightBakingOutput>(l, 1, out lightBakingOutput);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, lightBakingOutput.occlusionMaskChannel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602349F RID: 144543 RVA: 0x00C41708 File Offset: 0x00C3F908
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_occlusionMaskChannel(IntPtr l)
	{
		int result;
		try
		{
			LightBakingOutput lightBakingOutput;
			LuaObject.checkValueType<LightBakingOutput>(l, 1, out lightBakingOutput);
			int occlusionMaskChannel;
			LuaObject.checkType(l, 2, out occlusionMaskChannel);
			lightBakingOutput.occlusionMaskChannel = occlusionMaskChannel;
			LuaObject.setBack(l, lightBakingOutput);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060234A0 RID: 144544 RVA: 0x00C4176C File Offset: 0x00C3F96C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_lightmapBakeType(IntPtr l)
	{
		int result;
		try
		{
			LightBakingOutput lightBakingOutput;
			LuaObject.checkValueType<LightBakingOutput>(l, 1, out lightBakingOutput);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)lightBakingOutput.lightmapBakeType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060234A1 RID: 144545 RVA: 0x00C417C0 File Offset: 0x00C3F9C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_lightmapBakeType(IntPtr l)
	{
		int result;
		try
		{
			LightBakingOutput lightBakingOutput;
			LuaObject.checkValueType<LightBakingOutput>(l, 1, out lightBakingOutput);
			LightmapBakeType lightmapBakeType;
			LuaObject.checkEnum<LightmapBakeType>(l, 2, out lightmapBakeType);
			lightBakingOutput.lightmapBakeType = lightmapBakeType;
			LuaObject.setBack(l, lightBakingOutput);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060234A2 RID: 144546 RVA: 0x00C41824 File Offset: 0x00C3FA24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_mixedLightingMode(IntPtr l)
	{
		int result;
		try
		{
			LightBakingOutput lightBakingOutput;
			LuaObject.checkValueType<LightBakingOutput>(l, 1, out lightBakingOutput);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)lightBakingOutput.mixedLightingMode);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060234A3 RID: 144547 RVA: 0x00C41878 File Offset: 0x00C3FA78
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_mixedLightingMode(IntPtr l)
	{
		int result;
		try
		{
			LightBakingOutput lightBakingOutput;
			LuaObject.checkValueType<LightBakingOutput>(l, 1, out lightBakingOutput);
			MixedLightingMode mixedLightingMode;
			LuaObject.checkEnum<MixedLightingMode>(l, 2, out mixedLightingMode);
			lightBakingOutput.mixedLightingMode = mixedLightingMode;
			LuaObject.setBack(l, lightBakingOutput);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060234A4 RID: 144548 RVA: 0x00C418DC File Offset: 0x00C3FADC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_isBaked(IntPtr l)
	{
		int result;
		try
		{
			LightBakingOutput lightBakingOutput;
			LuaObject.checkValueType<LightBakingOutput>(l, 1, out lightBakingOutput);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, lightBakingOutput.isBaked);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060234A5 RID: 144549 RVA: 0x00C41930 File Offset: 0x00C3FB30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_isBaked(IntPtr l)
	{
		int result;
		try
		{
			LightBakingOutput lightBakingOutput;
			LuaObject.checkValueType<LightBakingOutput>(l, 1, out lightBakingOutput);
			bool isBaked;
			LuaObject.checkType(l, 2, out isBaked);
			lightBakingOutput.isBaked = isBaked;
			LuaObject.setBack(l, lightBakingOutput);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060234A6 RID: 144550 RVA: 0x00C41994 File Offset: 0x00C3FB94
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.LightBakingOutput");
		string name = "probeOcclusionLightIndex";
		if (Lua_UnityEngine_LightBakingOutput.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_LightBakingOutput.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_LightBakingOutput.get_probeOcclusionLightIndex);
		}
		LuaCSFunction get = Lua_UnityEngine_LightBakingOutput.<>f__mg$cache0;
		if (Lua_UnityEngine_LightBakingOutput.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_LightBakingOutput.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_LightBakingOutput.set_probeOcclusionLightIndex);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_LightBakingOutput.<>f__mg$cache1, true);
		string name2 = "occlusionMaskChannel";
		if (Lua_UnityEngine_LightBakingOutput.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_LightBakingOutput.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_LightBakingOutput.get_occlusionMaskChannel);
		}
		LuaCSFunction get2 = Lua_UnityEngine_LightBakingOutput.<>f__mg$cache2;
		if (Lua_UnityEngine_LightBakingOutput.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_LightBakingOutput.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_LightBakingOutput.set_occlusionMaskChannel);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_LightBakingOutput.<>f__mg$cache3, true);
		string name3 = "lightmapBakeType";
		if (Lua_UnityEngine_LightBakingOutput.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_LightBakingOutput.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_LightBakingOutput.get_lightmapBakeType);
		}
		LuaCSFunction get3 = Lua_UnityEngine_LightBakingOutput.<>f__mg$cache4;
		if (Lua_UnityEngine_LightBakingOutput.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_LightBakingOutput.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_LightBakingOutput.set_lightmapBakeType);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_LightBakingOutput.<>f__mg$cache5, true);
		string name4 = "mixedLightingMode";
		if (Lua_UnityEngine_LightBakingOutput.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_LightBakingOutput.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_LightBakingOutput.get_mixedLightingMode);
		}
		LuaCSFunction get4 = Lua_UnityEngine_LightBakingOutput.<>f__mg$cache6;
		if (Lua_UnityEngine_LightBakingOutput.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_LightBakingOutput.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_LightBakingOutput.set_mixedLightingMode);
		}
		LuaObject.addMember(l, name4, get4, Lua_UnityEngine_LightBakingOutput.<>f__mg$cache7, true);
		string name5 = "isBaked";
		if (Lua_UnityEngine_LightBakingOutput.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_LightBakingOutput.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_LightBakingOutput.get_isBaked);
		}
		LuaCSFunction get5 = Lua_UnityEngine_LightBakingOutput.<>f__mg$cache8;
		if (Lua_UnityEngine_LightBakingOutput.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_LightBakingOutput.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_LightBakingOutput.set_isBaked);
		}
		LuaObject.addMember(l, name5, get5, Lua_UnityEngine_LightBakingOutput.<>f__mg$cache9, true);
		if (Lua_UnityEngine_LightBakingOutput.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_LightBakingOutput.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_LightBakingOutput.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_LightBakingOutput.<>f__mg$cacheA, typeof(LightBakingOutput), typeof(ValueType));
	}

	// Token: 0x040192ED RID: 103149
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040192EE RID: 103150
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040192EF RID: 103151
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040192F0 RID: 103152
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040192F1 RID: 103153
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040192F2 RID: 103154
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040192F3 RID: 103155
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040192F4 RID: 103156
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040192F5 RID: 103157
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040192F6 RID: 103158
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040192F7 RID: 103159
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;
}
