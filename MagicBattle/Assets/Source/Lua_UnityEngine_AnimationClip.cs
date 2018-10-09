using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001610 RID: 5648
[Preserve]
public class Lua_UnityEngine_AnimationClip : LuaObject
{
	// Token: 0x06022A11 RID: 141841 RVA: 0x00BEDD68 File Offset: 0x00BEBF68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			AnimationClip o = new AnimationClip();
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

	// Token: 0x06022A12 RID: 141842 RVA: 0x00BEDDB0 File Offset: 0x00BEBFB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SampleAnimation(IntPtr l)
	{
		int result;
		try
		{
			AnimationClip animationClip = (AnimationClip)LuaObject.checkSelf(l);
			GameObject go;
			LuaObject.checkType<GameObject>(l, 2, out go);
			float time;
			LuaObject.checkType(l, 3, out time);
			animationClip.SampleAnimation(go, time);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022A13 RID: 141843 RVA: 0x00BEDE14 File Offset: 0x00BEC014
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetCurve(IntPtr l)
	{
		int result;
		try
		{
			AnimationClip animationClip = (AnimationClip)LuaObject.checkSelf(l);
			string relativePath;
			LuaObject.checkType(l, 2, out relativePath);
			Type type;
			LuaObject.checkType(l, 3, out type);
			string propertyName;
			LuaObject.checkType(l, 4, out propertyName);
			AnimationCurve curve;
			LuaObject.checkType<AnimationCurve>(l, 5, out curve);
			animationClip.SetCurve(relativePath, type, propertyName, curve);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022A14 RID: 141844 RVA: 0x00BEDE94 File Offset: 0x00BEC094
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int EnsureQuaternionContinuity(IntPtr l)
	{
		int result;
		try
		{
			AnimationClip animationClip = (AnimationClip)LuaObject.checkSelf(l);
			animationClip.EnsureQuaternionContinuity();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022A15 RID: 141845 RVA: 0x00BEDEE0 File Offset: 0x00BEC0E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearCurves(IntPtr l)
	{
		int result;
		try
		{
			AnimationClip animationClip = (AnimationClip)LuaObject.checkSelf(l);
			animationClip.ClearCurves();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022A16 RID: 141846 RVA: 0x00BEDF2C File Offset: 0x00BEC12C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddEvent(IntPtr l)
	{
		int result;
		try
		{
			AnimationClip animationClip = (AnimationClip)LuaObject.checkSelf(l);
			AnimationEvent evt;
			LuaObject.checkType<AnimationEvent>(l, 2, out evt);
			animationClip.AddEvent(evt);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022A17 RID: 141847 RVA: 0x00BEDF84 File Offset: 0x00BEC184
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_length(IntPtr l)
	{
		int result;
		try
		{
			AnimationClip animationClip = (AnimationClip)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animationClip.length);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022A18 RID: 141848 RVA: 0x00BEDFD8 File Offset: 0x00BEC1D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_frameRate(IntPtr l)
	{
		int result;
		try
		{
			AnimationClip animationClip = (AnimationClip)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animationClip.frameRate);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022A19 RID: 141849 RVA: 0x00BEE02C File Offset: 0x00BEC22C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_frameRate(IntPtr l)
	{
		int result;
		try
		{
			AnimationClip animationClip = (AnimationClip)LuaObject.checkSelf(l);
			float frameRate;
			LuaObject.checkType(l, 2, out frameRate);
			animationClip.frameRate = frameRate;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022A1A RID: 141850 RVA: 0x00BEE084 File Offset: 0x00BEC284
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_wrapMode(IntPtr l)
	{
		int result;
		try
		{
			AnimationClip animationClip = (AnimationClip)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)animationClip.wrapMode);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022A1B RID: 141851 RVA: 0x00BEE0D8 File Offset: 0x00BEC2D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_wrapMode(IntPtr l)
	{
		int result;
		try
		{
			AnimationClip animationClip = (AnimationClip)LuaObject.checkSelf(l);
			WrapMode wrapMode;
			LuaObject.checkEnum<WrapMode>(l, 2, out wrapMode);
			animationClip.wrapMode = wrapMode;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022A1C RID: 141852 RVA: 0x00BEE130 File Offset: 0x00BEC330
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_localBounds(IntPtr l)
	{
		int result;
		try
		{
			AnimationClip animationClip = (AnimationClip)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animationClip.localBounds);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022A1D RID: 141853 RVA: 0x00BEE188 File Offset: 0x00BEC388
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_localBounds(IntPtr l)
	{
		int result;
		try
		{
			AnimationClip animationClip = (AnimationClip)LuaObject.checkSelf(l);
			Bounds localBounds;
			LuaObject.checkValueType<Bounds>(l, 2, out localBounds);
			animationClip.localBounds = localBounds;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022A1E RID: 141854 RVA: 0x00BEE1E0 File Offset: 0x00BEC3E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_legacy(IntPtr l)
	{
		int result;
		try
		{
			AnimationClip animationClip = (AnimationClip)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animationClip.legacy);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022A1F RID: 141855 RVA: 0x00BEE234 File Offset: 0x00BEC434
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_legacy(IntPtr l)
	{
		int result;
		try
		{
			AnimationClip animationClip = (AnimationClip)LuaObject.checkSelf(l);
			bool legacy;
			LuaObject.checkType(l, 2, out legacy);
			animationClip.legacy = legacy;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022A20 RID: 141856 RVA: 0x00BEE28C File Offset: 0x00BEC48C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_humanMotion(IntPtr l)
	{
		int result;
		try
		{
			AnimationClip animationClip = (AnimationClip)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animationClip.humanMotion);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022A21 RID: 141857 RVA: 0x00BEE2E0 File Offset: 0x00BEC4E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_empty(IntPtr l)
	{
		int result;
		try
		{
			AnimationClip animationClip = (AnimationClip)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animationClip.empty);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022A22 RID: 141858 RVA: 0x00BEE334 File Offset: 0x00BEC534
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_events(IntPtr l)
	{
		int result;
		try
		{
			AnimationClip animationClip = (AnimationClip)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animationClip.events);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022A23 RID: 141859 RVA: 0x00BEE388 File Offset: 0x00BEC588
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_events(IntPtr l)
	{
		int result;
		try
		{
			AnimationClip animationClip = (AnimationClip)LuaObject.checkSelf(l);
			AnimationEvent[] events;
			LuaObject.checkArray<AnimationEvent>(l, 2, out events);
			animationClip.events = events;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022A24 RID: 141860 RVA: 0x00BEE3E0 File Offset: 0x00BEC5E0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.AnimationClip");
		if (Lua_UnityEngine_AnimationClip.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_AnimationClip.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_AnimationClip.SampleAnimation);
		}
		LuaObject.addMember(l, Lua_UnityEngine_AnimationClip.<>f__mg$cache0);
		if (Lua_UnityEngine_AnimationClip.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_AnimationClip.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_AnimationClip.SetCurve);
		}
		LuaObject.addMember(l, Lua_UnityEngine_AnimationClip.<>f__mg$cache1);
		if (Lua_UnityEngine_AnimationClip.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_AnimationClip.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_AnimationClip.EnsureQuaternionContinuity);
		}
		LuaObject.addMember(l, Lua_UnityEngine_AnimationClip.<>f__mg$cache2);
		if (Lua_UnityEngine_AnimationClip.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_AnimationClip.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_AnimationClip.ClearCurves);
		}
		LuaObject.addMember(l, Lua_UnityEngine_AnimationClip.<>f__mg$cache3);
		if (Lua_UnityEngine_AnimationClip.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_AnimationClip.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_AnimationClip.AddEvent);
		}
		LuaObject.addMember(l, Lua_UnityEngine_AnimationClip.<>f__mg$cache4);
		string name = "length";
		if (Lua_UnityEngine_AnimationClip.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_AnimationClip.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_AnimationClip.get_length);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_AnimationClip.<>f__mg$cache5, null, true);
		string name2 = "frameRate";
		if (Lua_UnityEngine_AnimationClip.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_AnimationClip.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_AnimationClip.get_frameRate);
		}
		LuaCSFunction get = Lua_UnityEngine_AnimationClip.<>f__mg$cache6;
		if (Lua_UnityEngine_AnimationClip.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_AnimationClip.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_AnimationClip.set_frameRate);
		}
		LuaObject.addMember(l, name2, get, Lua_UnityEngine_AnimationClip.<>f__mg$cache7, true);
		string name3 = "wrapMode";
		if (Lua_UnityEngine_AnimationClip.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_AnimationClip.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_AnimationClip.get_wrapMode);
		}
		LuaCSFunction get2 = Lua_UnityEngine_AnimationClip.<>f__mg$cache8;
		if (Lua_UnityEngine_AnimationClip.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_AnimationClip.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_AnimationClip.set_wrapMode);
		}
		LuaObject.addMember(l, name3, get2, Lua_UnityEngine_AnimationClip.<>f__mg$cache9, true);
		string name4 = "localBounds";
		if (Lua_UnityEngine_AnimationClip.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_AnimationClip.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_AnimationClip.get_localBounds);
		}
		LuaCSFunction get3 = Lua_UnityEngine_AnimationClip.<>f__mg$cacheA;
		if (Lua_UnityEngine_AnimationClip.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_AnimationClip.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_AnimationClip.set_localBounds);
		}
		LuaObject.addMember(l, name4, get3, Lua_UnityEngine_AnimationClip.<>f__mg$cacheB, true);
		string name5 = "legacy";
		if (Lua_UnityEngine_AnimationClip.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_AnimationClip.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_AnimationClip.get_legacy);
		}
		LuaCSFunction get4 = Lua_UnityEngine_AnimationClip.<>f__mg$cacheC;
		if (Lua_UnityEngine_AnimationClip.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_AnimationClip.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_AnimationClip.set_legacy);
		}
		LuaObject.addMember(l, name5, get4, Lua_UnityEngine_AnimationClip.<>f__mg$cacheD, true);
		string name6 = "humanMotion";
		if (Lua_UnityEngine_AnimationClip.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_AnimationClip.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_AnimationClip.get_humanMotion);
		}
		LuaObject.addMember(l, name6, Lua_UnityEngine_AnimationClip.<>f__mg$cacheE, null, true);
		string name7 = "empty";
		if (Lua_UnityEngine_AnimationClip.<>f__mg$cacheF == null)
		{
			Lua_UnityEngine_AnimationClip.<>f__mg$cacheF = new LuaCSFunction(Lua_UnityEngine_AnimationClip.get_empty);
		}
		LuaObject.addMember(l, name7, Lua_UnityEngine_AnimationClip.<>f__mg$cacheF, null, true);
		string name8 = "events";
		if (Lua_UnityEngine_AnimationClip.<>f__mg$cache10 == null)
		{
			Lua_UnityEngine_AnimationClip.<>f__mg$cache10 = new LuaCSFunction(Lua_UnityEngine_AnimationClip.get_events);
		}
		LuaCSFunction get5 = Lua_UnityEngine_AnimationClip.<>f__mg$cache10;
		if (Lua_UnityEngine_AnimationClip.<>f__mg$cache11 == null)
		{
			Lua_UnityEngine_AnimationClip.<>f__mg$cache11 = new LuaCSFunction(Lua_UnityEngine_AnimationClip.set_events);
		}
		LuaObject.addMember(l, name8, get5, Lua_UnityEngine_AnimationClip.<>f__mg$cache11, true);
		if (Lua_UnityEngine_AnimationClip.<>f__mg$cache12 == null)
		{
			Lua_UnityEngine_AnimationClip.<>f__mg$cache12 = new LuaCSFunction(Lua_UnityEngine_AnimationClip.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_AnimationClip.<>f__mg$cache12, typeof(AnimationClip), typeof(Motion));
	}

	// Token: 0x04018A4F RID: 100943
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04018A50 RID: 100944
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04018A51 RID: 100945
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04018A52 RID: 100946
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04018A53 RID: 100947
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04018A54 RID: 100948
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04018A55 RID: 100949
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04018A56 RID: 100950
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04018A57 RID: 100951
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04018A58 RID: 100952
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04018A59 RID: 100953
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04018A5A RID: 100954
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04018A5B RID: 100955
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04018A5C RID: 100956
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04018A5D RID: 100957
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04018A5E RID: 100958
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04018A5F RID: 100959
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04018A60 RID: 100960
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04018A61 RID: 100961
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;
}
