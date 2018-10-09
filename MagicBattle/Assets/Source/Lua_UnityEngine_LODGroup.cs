using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x0200171F RID: 5919
[Preserve]
public class Lua_UnityEngine_LODGroup : LuaObject
{
	// Token: 0x0602353F RID: 144703 RVA: 0x00C45418 File Offset: 0x00C43618
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int RecalculateBounds(IntPtr l)
	{
		int result;
		try
		{
			LODGroup lodgroup = (LODGroup)LuaObject.checkSelf(l);
			lodgroup.RecalculateBounds();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023540 RID: 144704 RVA: 0x00C45464 File Offset: 0x00C43664
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetLODs(IntPtr l)
	{
		int result;
		try
		{
			LODGroup lodgroup = (LODGroup)LuaObject.checkSelf(l);
			LOD[] lods = lodgroup.GetLODs();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, lods);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023541 RID: 144705 RVA: 0x00C454B8 File Offset: 0x00C436B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetLODs(IntPtr l)
	{
		int result;
		try
		{
			LODGroup lodgroup = (LODGroup)LuaObject.checkSelf(l);
			LOD[] lods;
			LuaObject.checkArray<LOD>(l, 2, out lods);
			lodgroup.SetLODs(lods);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023542 RID: 144706 RVA: 0x00C45510 File Offset: 0x00C43710
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ForceLOD(IntPtr l)
	{
		int result;
		try
		{
			LODGroup lodgroup = (LODGroup)LuaObject.checkSelf(l);
			int index;
			LuaObject.checkType(l, 2, out index);
			lodgroup.ForceLOD(index);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023543 RID: 144707 RVA: 0x00C45568 File Offset: 0x00C43768
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_localReferencePoint(IntPtr l)
	{
		int result;
		try
		{
			LODGroup lodgroup = (LODGroup)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, lodgroup.localReferencePoint);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023544 RID: 144708 RVA: 0x00C455BC File Offset: 0x00C437BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_localReferencePoint(IntPtr l)
	{
		int result;
		try
		{
			LODGroup lodgroup = (LODGroup)LuaObject.checkSelf(l);
			Vector3 localReferencePoint;
			LuaObject.checkType(l, 2, out localReferencePoint);
			lodgroup.localReferencePoint = localReferencePoint;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023545 RID: 144709 RVA: 0x00C45614 File Offset: 0x00C43814
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_size(IntPtr l)
	{
		int result;
		try
		{
			LODGroup lodgroup = (LODGroup)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, lodgroup.size);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023546 RID: 144710 RVA: 0x00C45668 File Offset: 0x00C43868
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_size(IntPtr l)
	{
		int result;
		try
		{
			LODGroup lodgroup = (LODGroup)LuaObject.checkSelf(l);
			float size;
			LuaObject.checkType(l, 2, out size);
			lodgroup.size = size;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023547 RID: 144711 RVA: 0x00C456C0 File Offset: 0x00C438C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_lodCount(IntPtr l)
	{
		int result;
		try
		{
			LODGroup lodgroup = (LODGroup)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, lodgroup.lodCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023548 RID: 144712 RVA: 0x00C45714 File Offset: 0x00C43914
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_fadeMode(IntPtr l)
	{
		int result;
		try
		{
			LODGroup lodgroup = (LODGroup)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)lodgroup.fadeMode);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023549 RID: 144713 RVA: 0x00C45768 File Offset: 0x00C43968
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_fadeMode(IntPtr l)
	{
		int result;
		try
		{
			LODGroup lodgroup = (LODGroup)LuaObject.checkSelf(l);
			LODFadeMode fadeMode;
			LuaObject.checkEnum<LODFadeMode>(l, 2, out fadeMode);
			lodgroup.fadeMode = fadeMode;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602354A RID: 144714 RVA: 0x00C457C0 File Offset: 0x00C439C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_animateCrossFading(IntPtr l)
	{
		int result;
		try
		{
			LODGroup lodgroup = (LODGroup)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, lodgroup.animateCrossFading);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602354B RID: 144715 RVA: 0x00C45814 File Offset: 0x00C43A14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_animateCrossFading(IntPtr l)
	{
		int result;
		try
		{
			LODGroup lodgroup = (LODGroup)LuaObject.checkSelf(l);
			bool animateCrossFading;
			LuaObject.checkType(l, 2, out animateCrossFading);
			lodgroup.animateCrossFading = animateCrossFading;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602354C RID: 144716 RVA: 0x00C4586C File Offset: 0x00C43A6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_enabled(IntPtr l)
	{
		int result;
		try
		{
			LODGroup lodgroup = (LODGroup)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, lodgroup.enabled);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602354D RID: 144717 RVA: 0x00C458C0 File Offset: 0x00C43AC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_enabled(IntPtr l)
	{
		int result;
		try
		{
			LODGroup lodgroup = (LODGroup)LuaObject.checkSelf(l);
			bool enabled;
			LuaObject.checkType(l, 2, out enabled);
			lodgroup.enabled = enabled;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602354E RID: 144718 RVA: 0x00C45918 File Offset: 0x00C43B18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_crossFadeAnimationDuration(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, LODGroup.crossFadeAnimationDuration);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602354F RID: 144719 RVA: 0x00C45960 File Offset: 0x00C43B60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_crossFadeAnimationDuration(IntPtr l)
	{
		int result;
		try
		{
			float crossFadeAnimationDuration;
			LuaObject.checkType(l, 2, out crossFadeAnimationDuration);
			LODGroup.crossFadeAnimationDuration = crossFadeAnimationDuration;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023550 RID: 144720 RVA: 0x00C459AC File Offset: 0x00C43BAC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.LODGroup");
		if (Lua_UnityEngine_LODGroup.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_LODGroup.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_LODGroup.RecalculateBounds);
		}
		LuaObject.addMember(l, Lua_UnityEngine_LODGroup.<>f__mg$cache0);
		if (Lua_UnityEngine_LODGroup.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_LODGroup.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_LODGroup.GetLODs);
		}
		LuaObject.addMember(l, Lua_UnityEngine_LODGroup.<>f__mg$cache1);
		if (Lua_UnityEngine_LODGroup.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_LODGroup.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_LODGroup.SetLODs);
		}
		LuaObject.addMember(l, Lua_UnityEngine_LODGroup.<>f__mg$cache2);
		if (Lua_UnityEngine_LODGroup.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_LODGroup.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_LODGroup.ForceLOD);
		}
		LuaObject.addMember(l, Lua_UnityEngine_LODGroup.<>f__mg$cache3);
		string name = "localReferencePoint";
		if (Lua_UnityEngine_LODGroup.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_LODGroup.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_LODGroup.get_localReferencePoint);
		}
		LuaCSFunction get = Lua_UnityEngine_LODGroup.<>f__mg$cache4;
		if (Lua_UnityEngine_LODGroup.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_LODGroup.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_LODGroup.set_localReferencePoint);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_LODGroup.<>f__mg$cache5, true);
		string name2 = "size";
		if (Lua_UnityEngine_LODGroup.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_LODGroup.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_LODGroup.get_size);
		}
		LuaCSFunction get2 = Lua_UnityEngine_LODGroup.<>f__mg$cache6;
		if (Lua_UnityEngine_LODGroup.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_LODGroup.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_LODGroup.set_size);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_LODGroup.<>f__mg$cache7, true);
		string name3 = "lodCount";
		if (Lua_UnityEngine_LODGroup.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_LODGroup.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_LODGroup.get_lodCount);
		}
		LuaObject.addMember(l, name3, Lua_UnityEngine_LODGroup.<>f__mg$cache8, null, true);
		string name4 = "fadeMode";
		if (Lua_UnityEngine_LODGroup.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_LODGroup.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_LODGroup.get_fadeMode);
		}
		LuaCSFunction get3 = Lua_UnityEngine_LODGroup.<>f__mg$cache9;
		if (Lua_UnityEngine_LODGroup.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_LODGroup.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_LODGroup.set_fadeMode);
		}
		LuaObject.addMember(l, name4, get3, Lua_UnityEngine_LODGroup.<>f__mg$cacheA, true);
		string name5 = "animateCrossFading";
		if (Lua_UnityEngine_LODGroup.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_LODGroup.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_LODGroup.get_animateCrossFading);
		}
		LuaCSFunction get4 = Lua_UnityEngine_LODGroup.<>f__mg$cacheB;
		if (Lua_UnityEngine_LODGroup.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_LODGroup.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_LODGroup.set_animateCrossFading);
		}
		LuaObject.addMember(l, name5, get4, Lua_UnityEngine_LODGroup.<>f__mg$cacheC, true);
		string name6 = "enabled";
		if (Lua_UnityEngine_LODGroup.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_LODGroup.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_LODGroup.get_enabled);
		}
		LuaCSFunction get5 = Lua_UnityEngine_LODGroup.<>f__mg$cacheD;
		if (Lua_UnityEngine_LODGroup.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_LODGroup.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_LODGroup.set_enabled);
		}
		LuaObject.addMember(l, name6, get5, Lua_UnityEngine_LODGroup.<>f__mg$cacheE, true);
		string name7 = "crossFadeAnimationDuration";
		if (Lua_UnityEngine_LODGroup.<>f__mg$cacheF == null)
		{
			Lua_UnityEngine_LODGroup.<>f__mg$cacheF = new LuaCSFunction(Lua_UnityEngine_LODGroup.get_crossFadeAnimationDuration);
		}
		LuaCSFunction get6 = Lua_UnityEngine_LODGroup.<>f__mg$cacheF;
		if (Lua_UnityEngine_LODGroup.<>f__mg$cache10 == null)
		{
			Lua_UnityEngine_LODGroup.<>f__mg$cache10 = new LuaCSFunction(Lua_UnityEngine_LODGroup.set_crossFadeAnimationDuration);
		}
		LuaObject.addMember(l, name7, get6, Lua_UnityEngine_LODGroup.<>f__mg$cache10, false);
		LuaObject.createTypeMetatable(l, null, typeof(LODGroup), typeof(Component));
	}

	// Token: 0x0401935F RID: 103263
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019360 RID: 103264
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019361 RID: 103265
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019362 RID: 103266
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019363 RID: 103267
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04019364 RID: 103268
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04019365 RID: 103269
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04019366 RID: 103270
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04019367 RID: 103271
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04019368 RID: 103272
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04019369 RID: 103273
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0401936A RID: 103274
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0401936B RID: 103275
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0401936C RID: 103276
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0401936D RID: 103277
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0401936E RID: 103278
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0401936F RID: 103279
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;
}
