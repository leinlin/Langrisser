using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x0200170D RID: 5901
[Preserve]
public class Lua_UnityEngine_LightProbeProxyVolume : LuaObject
{
	// Token: 0x060234C4 RID: 144580 RVA: 0x00C42408 File Offset: 0x00C40608
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Update(IntPtr l)
	{
		int result;
		try
		{
			LightProbeProxyVolume lightProbeProxyVolume = (LightProbeProxyVolume)LuaObject.checkSelf(l);
			lightProbeProxyVolume.Update();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060234C5 RID: 144581 RVA: 0x00C42454 File Offset: 0x00C40654
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_boundsGlobal(IntPtr l)
	{
		int result;
		try
		{
			LightProbeProxyVolume lightProbeProxyVolume = (LightProbeProxyVolume)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, lightProbeProxyVolume.boundsGlobal);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060234C6 RID: 144582 RVA: 0x00C424AC File Offset: 0x00C406AC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_sizeCustom(IntPtr l)
	{
		int result;
		try
		{
			LightProbeProxyVolume lightProbeProxyVolume = (LightProbeProxyVolume)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, lightProbeProxyVolume.sizeCustom);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060234C7 RID: 144583 RVA: 0x00C42500 File Offset: 0x00C40700
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_sizeCustom(IntPtr l)
	{
		int result;
		try
		{
			LightProbeProxyVolume lightProbeProxyVolume = (LightProbeProxyVolume)LuaObject.checkSelf(l);
			Vector3 sizeCustom;
			LuaObject.checkType(l, 2, out sizeCustom);
			lightProbeProxyVolume.sizeCustom = sizeCustom;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060234C8 RID: 144584 RVA: 0x00C42558 File Offset: 0x00C40758
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_originCustom(IntPtr l)
	{
		int result;
		try
		{
			LightProbeProxyVolume lightProbeProxyVolume = (LightProbeProxyVolume)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, lightProbeProxyVolume.originCustom);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060234C9 RID: 144585 RVA: 0x00C425AC File Offset: 0x00C407AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_originCustom(IntPtr l)
	{
		int result;
		try
		{
			LightProbeProxyVolume lightProbeProxyVolume = (LightProbeProxyVolume)LuaObject.checkSelf(l);
			Vector3 originCustom;
			LuaObject.checkType(l, 2, out originCustom);
			lightProbeProxyVolume.originCustom = originCustom;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060234CA RID: 144586 RVA: 0x00C42604 File Offset: 0x00C40804
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_boundingBoxMode(IntPtr l)
	{
		int result;
		try
		{
			LightProbeProxyVolume lightProbeProxyVolume = (LightProbeProxyVolume)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)lightProbeProxyVolume.boundingBoxMode);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060234CB RID: 144587 RVA: 0x00C42658 File Offset: 0x00C40858
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_boundingBoxMode(IntPtr l)
	{
		int result;
		try
		{
			LightProbeProxyVolume lightProbeProxyVolume = (LightProbeProxyVolume)LuaObject.checkSelf(l);
			LightProbeProxyVolume.BoundingBoxMode boundingBoxMode;
			LuaObject.checkEnum<LightProbeProxyVolume.BoundingBoxMode>(l, 2, out boundingBoxMode);
			lightProbeProxyVolume.boundingBoxMode = boundingBoxMode;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060234CC RID: 144588 RVA: 0x00C426B0 File Offset: 0x00C408B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_resolutionMode(IntPtr l)
	{
		int result;
		try
		{
			LightProbeProxyVolume lightProbeProxyVolume = (LightProbeProxyVolume)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)lightProbeProxyVolume.resolutionMode);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060234CD RID: 144589 RVA: 0x00C42704 File Offset: 0x00C40904
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_resolutionMode(IntPtr l)
	{
		int result;
		try
		{
			LightProbeProxyVolume lightProbeProxyVolume = (LightProbeProxyVolume)LuaObject.checkSelf(l);
			LightProbeProxyVolume.ResolutionMode resolutionMode;
			LuaObject.checkEnum<LightProbeProxyVolume.ResolutionMode>(l, 2, out resolutionMode);
			lightProbeProxyVolume.resolutionMode = resolutionMode;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060234CE RID: 144590 RVA: 0x00C4275C File Offset: 0x00C4095C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_probePositionMode(IntPtr l)
	{
		int result;
		try
		{
			LightProbeProxyVolume lightProbeProxyVolume = (LightProbeProxyVolume)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)lightProbeProxyVolume.probePositionMode);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060234CF RID: 144591 RVA: 0x00C427B0 File Offset: 0x00C409B0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_probePositionMode(IntPtr l)
	{
		int result;
		try
		{
			LightProbeProxyVolume lightProbeProxyVolume = (LightProbeProxyVolume)LuaObject.checkSelf(l);
			LightProbeProxyVolume.ProbePositionMode probePositionMode;
			LuaObject.checkEnum<LightProbeProxyVolume.ProbePositionMode>(l, 2, out probePositionMode);
			lightProbeProxyVolume.probePositionMode = probePositionMode;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060234D0 RID: 144592 RVA: 0x00C42808 File Offset: 0x00C40A08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_refreshMode(IntPtr l)
	{
		int result;
		try
		{
			LightProbeProxyVolume lightProbeProxyVolume = (LightProbeProxyVolume)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)lightProbeProxyVolume.refreshMode);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060234D1 RID: 144593 RVA: 0x00C4285C File Offset: 0x00C40A5C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_refreshMode(IntPtr l)
	{
		int result;
		try
		{
			LightProbeProxyVolume lightProbeProxyVolume = (LightProbeProxyVolume)LuaObject.checkSelf(l);
			LightProbeProxyVolume.RefreshMode refreshMode;
			LuaObject.checkEnum<LightProbeProxyVolume.RefreshMode>(l, 2, out refreshMode);
			lightProbeProxyVolume.refreshMode = refreshMode;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060234D2 RID: 144594 RVA: 0x00C428B4 File Offset: 0x00C40AB4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_probeDensity(IntPtr l)
	{
		int result;
		try
		{
			LightProbeProxyVolume lightProbeProxyVolume = (LightProbeProxyVolume)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, lightProbeProxyVolume.probeDensity);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060234D3 RID: 144595 RVA: 0x00C42908 File Offset: 0x00C40B08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_probeDensity(IntPtr l)
	{
		int result;
		try
		{
			LightProbeProxyVolume lightProbeProxyVolume = (LightProbeProxyVolume)LuaObject.checkSelf(l);
			float probeDensity;
			LuaObject.checkType(l, 2, out probeDensity);
			lightProbeProxyVolume.probeDensity = probeDensity;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060234D4 RID: 144596 RVA: 0x00C42960 File Offset: 0x00C40B60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_gridResolutionX(IntPtr l)
	{
		int result;
		try
		{
			LightProbeProxyVolume lightProbeProxyVolume = (LightProbeProxyVolume)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, lightProbeProxyVolume.gridResolutionX);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060234D5 RID: 144597 RVA: 0x00C429B4 File Offset: 0x00C40BB4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_gridResolutionX(IntPtr l)
	{
		int result;
		try
		{
			LightProbeProxyVolume lightProbeProxyVolume = (LightProbeProxyVolume)LuaObject.checkSelf(l);
			int gridResolutionX;
			LuaObject.checkType(l, 2, out gridResolutionX);
			lightProbeProxyVolume.gridResolutionX = gridResolutionX;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060234D6 RID: 144598 RVA: 0x00C42A0C File Offset: 0x00C40C0C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_gridResolutionY(IntPtr l)
	{
		int result;
		try
		{
			LightProbeProxyVolume lightProbeProxyVolume = (LightProbeProxyVolume)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, lightProbeProxyVolume.gridResolutionY);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060234D7 RID: 144599 RVA: 0x00C42A60 File Offset: 0x00C40C60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_gridResolutionY(IntPtr l)
	{
		int result;
		try
		{
			LightProbeProxyVolume lightProbeProxyVolume = (LightProbeProxyVolume)LuaObject.checkSelf(l);
			int gridResolutionY;
			LuaObject.checkType(l, 2, out gridResolutionY);
			lightProbeProxyVolume.gridResolutionY = gridResolutionY;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060234D8 RID: 144600 RVA: 0x00C42AB8 File Offset: 0x00C40CB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_gridResolutionZ(IntPtr l)
	{
		int result;
		try
		{
			LightProbeProxyVolume lightProbeProxyVolume = (LightProbeProxyVolume)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, lightProbeProxyVolume.gridResolutionZ);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060234D9 RID: 144601 RVA: 0x00C42B0C File Offset: 0x00C40D0C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_gridResolutionZ(IntPtr l)
	{
		int result;
		try
		{
			LightProbeProxyVolume lightProbeProxyVolume = (LightProbeProxyVolume)LuaObject.checkSelf(l);
			int gridResolutionZ;
			LuaObject.checkType(l, 2, out gridResolutionZ);
			lightProbeProxyVolume.gridResolutionZ = gridResolutionZ;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060234DA RID: 144602 RVA: 0x00C42B64 File Offset: 0x00C40D64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_isFeatureSupported(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, LightProbeProxyVolume.isFeatureSupported);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060234DB RID: 144603 RVA: 0x00C42BAC File Offset: 0x00C40DAC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.LightProbeProxyVolume");
		if (Lua_UnityEngine_LightProbeProxyVolume.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_LightProbeProxyVolume.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_LightProbeProxyVolume.Update);
		}
		LuaObject.addMember(l, Lua_UnityEngine_LightProbeProxyVolume.<>f__mg$cache0);
		string name = "boundsGlobal";
		if (Lua_UnityEngine_LightProbeProxyVolume.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_LightProbeProxyVolume.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_LightProbeProxyVolume.get_boundsGlobal);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_LightProbeProxyVolume.<>f__mg$cache1, null, true);
		string name2 = "sizeCustom";
		if (Lua_UnityEngine_LightProbeProxyVolume.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_LightProbeProxyVolume.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_LightProbeProxyVolume.get_sizeCustom);
		}
		LuaCSFunction get = Lua_UnityEngine_LightProbeProxyVolume.<>f__mg$cache2;
		if (Lua_UnityEngine_LightProbeProxyVolume.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_LightProbeProxyVolume.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_LightProbeProxyVolume.set_sizeCustom);
		}
		LuaObject.addMember(l, name2, get, Lua_UnityEngine_LightProbeProxyVolume.<>f__mg$cache3, true);
		string name3 = "originCustom";
		if (Lua_UnityEngine_LightProbeProxyVolume.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_LightProbeProxyVolume.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_LightProbeProxyVolume.get_originCustom);
		}
		LuaCSFunction get2 = Lua_UnityEngine_LightProbeProxyVolume.<>f__mg$cache4;
		if (Lua_UnityEngine_LightProbeProxyVolume.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_LightProbeProxyVolume.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_LightProbeProxyVolume.set_originCustom);
		}
		LuaObject.addMember(l, name3, get2, Lua_UnityEngine_LightProbeProxyVolume.<>f__mg$cache5, true);
		string name4 = "boundingBoxMode";
		if (Lua_UnityEngine_LightProbeProxyVolume.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_LightProbeProxyVolume.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_LightProbeProxyVolume.get_boundingBoxMode);
		}
		LuaCSFunction get3 = Lua_UnityEngine_LightProbeProxyVolume.<>f__mg$cache6;
		if (Lua_UnityEngine_LightProbeProxyVolume.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_LightProbeProxyVolume.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_LightProbeProxyVolume.set_boundingBoxMode);
		}
		LuaObject.addMember(l, name4, get3, Lua_UnityEngine_LightProbeProxyVolume.<>f__mg$cache7, true);
		string name5 = "resolutionMode";
		if (Lua_UnityEngine_LightProbeProxyVolume.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_LightProbeProxyVolume.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_LightProbeProxyVolume.get_resolutionMode);
		}
		LuaCSFunction get4 = Lua_UnityEngine_LightProbeProxyVolume.<>f__mg$cache8;
		if (Lua_UnityEngine_LightProbeProxyVolume.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_LightProbeProxyVolume.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_LightProbeProxyVolume.set_resolutionMode);
		}
		LuaObject.addMember(l, name5, get4, Lua_UnityEngine_LightProbeProxyVolume.<>f__mg$cache9, true);
		string name6 = "probePositionMode";
		if (Lua_UnityEngine_LightProbeProxyVolume.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_LightProbeProxyVolume.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_LightProbeProxyVolume.get_probePositionMode);
		}
		LuaCSFunction get5 = Lua_UnityEngine_LightProbeProxyVolume.<>f__mg$cacheA;
		if (Lua_UnityEngine_LightProbeProxyVolume.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_LightProbeProxyVolume.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_LightProbeProxyVolume.set_probePositionMode);
		}
		LuaObject.addMember(l, name6, get5, Lua_UnityEngine_LightProbeProxyVolume.<>f__mg$cacheB, true);
		string name7 = "refreshMode";
		if (Lua_UnityEngine_LightProbeProxyVolume.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_LightProbeProxyVolume.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_LightProbeProxyVolume.get_refreshMode);
		}
		LuaCSFunction get6 = Lua_UnityEngine_LightProbeProxyVolume.<>f__mg$cacheC;
		if (Lua_UnityEngine_LightProbeProxyVolume.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_LightProbeProxyVolume.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_LightProbeProxyVolume.set_refreshMode);
		}
		LuaObject.addMember(l, name7, get6, Lua_UnityEngine_LightProbeProxyVolume.<>f__mg$cacheD, true);
		string name8 = "probeDensity";
		if (Lua_UnityEngine_LightProbeProxyVolume.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_LightProbeProxyVolume.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_LightProbeProxyVolume.get_probeDensity);
		}
		LuaCSFunction get7 = Lua_UnityEngine_LightProbeProxyVolume.<>f__mg$cacheE;
		if (Lua_UnityEngine_LightProbeProxyVolume.<>f__mg$cacheF == null)
		{
			Lua_UnityEngine_LightProbeProxyVolume.<>f__mg$cacheF = new LuaCSFunction(Lua_UnityEngine_LightProbeProxyVolume.set_probeDensity);
		}
		LuaObject.addMember(l, name8, get7, Lua_UnityEngine_LightProbeProxyVolume.<>f__mg$cacheF, true);
		string name9 = "gridResolutionX";
		if (Lua_UnityEngine_LightProbeProxyVolume.<>f__mg$cache10 == null)
		{
			Lua_UnityEngine_LightProbeProxyVolume.<>f__mg$cache10 = new LuaCSFunction(Lua_UnityEngine_LightProbeProxyVolume.get_gridResolutionX);
		}
		LuaCSFunction get8 = Lua_UnityEngine_LightProbeProxyVolume.<>f__mg$cache10;
		if (Lua_UnityEngine_LightProbeProxyVolume.<>f__mg$cache11 == null)
		{
			Lua_UnityEngine_LightProbeProxyVolume.<>f__mg$cache11 = new LuaCSFunction(Lua_UnityEngine_LightProbeProxyVolume.set_gridResolutionX);
		}
		LuaObject.addMember(l, name9, get8, Lua_UnityEngine_LightProbeProxyVolume.<>f__mg$cache11, true);
		string name10 = "gridResolutionY";
		if (Lua_UnityEngine_LightProbeProxyVolume.<>f__mg$cache12 == null)
		{
			Lua_UnityEngine_LightProbeProxyVolume.<>f__mg$cache12 = new LuaCSFunction(Lua_UnityEngine_LightProbeProxyVolume.get_gridResolutionY);
		}
		LuaCSFunction get9 = Lua_UnityEngine_LightProbeProxyVolume.<>f__mg$cache12;
		if (Lua_UnityEngine_LightProbeProxyVolume.<>f__mg$cache13 == null)
		{
			Lua_UnityEngine_LightProbeProxyVolume.<>f__mg$cache13 = new LuaCSFunction(Lua_UnityEngine_LightProbeProxyVolume.set_gridResolutionY);
		}
		LuaObject.addMember(l, name10, get9, Lua_UnityEngine_LightProbeProxyVolume.<>f__mg$cache13, true);
		string name11 = "gridResolutionZ";
		if (Lua_UnityEngine_LightProbeProxyVolume.<>f__mg$cache14 == null)
		{
			Lua_UnityEngine_LightProbeProxyVolume.<>f__mg$cache14 = new LuaCSFunction(Lua_UnityEngine_LightProbeProxyVolume.get_gridResolutionZ);
		}
		LuaCSFunction get10 = Lua_UnityEngine_LightProbeProxyVolume.<>f__mg$cache14;
		if (Lua_UnityEngine_LightProbeProxyVolume.<>f__mg$cache15 == null)
		{
			Lua_UnityEngine_LightProbeProxyVolume.<>f__mg$cache15 = new LuaCSFunction(Lua_UnityEngine_LightProbeProxyVolume.set_gridResolutionZ);
		}
		LuaObject.addMember(l, name11, get10, Lua_UnityEngine_LightProbeProxyVolume.<>f__mg$cache15, true);
		string name12 = "isFeatureSupported";
		if (Lua_UnityEngine_LightProbeProxyVolume.<>f__mg$cache16 == null)
		{
			Lua_UnityEngine_LightProbeProxyVolume.<>f__mg$cache16 = new LuaCSFunction(Lua_UnityEngine_LightProbeProxyVolume.get_isFeatureSupported);
		}
		LuaObject.addMember(l, name12, Lua_UnityEngine_LightProbeProxyVolume.<>f__mg$cache16, null, false);
		LuaObject.createTypeMetatable(l, null, typeof(LightProbeProxyVolume), typeof(Behaviour));
	}

	// Token: 0x04019308 RID: 103176
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019309 RID: 103177
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401930A RID: 103178
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0401930B RID: 103179
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0401930C RID: 103180
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0401930D RID: 103181
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0401930E RID: 103182
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0401930F RID: 103183
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04019310 RID: 103184
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04019311 RID: 103185
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04019312 RID: 103186
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04019313 RID: 103187
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04019314 RID: 103188
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04019315 RID: 103189
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04019316 RID: 103190
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04019317 RID: 103191
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04019318 RID: 103192
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04019319 RID: 103193
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0401931A RID: 103194
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0401931B RID: 103195
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0401931C RID: 103196
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0401931D RID: 103197
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0401931E RID: 103198
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;
}
