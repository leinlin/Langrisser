using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x020017D3 RID: 6099
[Preserve]
public class Lua_UnityEngine_SkinnedMeshRenderer : LuaObject
{
	// Token: 0x06023D1A RID: 146714 RVA: 0x00C8D7B8 File Offset: 0x00C8B9B8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetBlendShapeWeight(IntPtr l)
	{
		int result;
		try
		{
			SkinnedMeshRenderer skinnedMeshRenderer = (SkinnedMeshRenderer)LuaObject.checkSelf(l);
			int index;
			LuaObject.checkType(l, 2, out index);
			float blendShapeWeight = skinnedMeshRenderer.GetBlendShapeWeight(index);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, blendShapeWeight);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D1B RID: 146715 RVA: 0x00C8D81C File Offset: 0x00C8BA1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetBlendShapeWeight(IntPtr l)
	{
		int result;
		try
		{
			SkinnedMeshRenderer skinnedMeshRenderer = (SkinnedMeshRenderer)LuaObject.checkSelf(l);
			int index;
			LuaObject.checkType(l, 2, out index);
			float value;
			LuaObject.checkType(l, 3, out value);
			skinnedMeshRenderer.SetBlendShapeWeight(index, value);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D1C RID: 146716 RVA: 0x00C8D880 File Offset: 0x00C8BA80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BakeMesh(IntPtr l)
	{
		int result;
		try
		{
			SkinnedMeshRenderer skinnedMeshRenderer = (SkinnedMeshRenderer)LuaObject.checkSelf(l);
			Mesh mesh;
			LuaObject.checkType<Mesh>(l, 2, out mesh);
			skinnedMeshRenderer.BakeMesh(mesh);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D1D RID: 146717 RVA: 0x00C8D8D8 File Offset: 0x00C8BAD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_bones(IntPtr l)
	{
		int result;
		try
		{
			SkinnedMeshRenderer skinnedMeshRenderer = (SkinnedMeshRenderer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, skinnedMeshRenderer.bones);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D1E RID: 146718 RVA: 0x00C8D92C File Offset: 0x00C8BB2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_bones(IntPtr l)
	{
		int result;
		try
		{
			SkinnedMeshRenderer skinnedMeshRenderer = (SkinnedMeshRenderer)LuaObject.checkSelf(l);
			Transform[] bones;
			LuaObject.checkArray<Transform>(l, 2, out bones);
			skinnedMeshRenderer.bones = bones;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D1F RID: 146719 RVA: 0x00C8D984 File Offset: 0x00C8BB84
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_quality(IntPtr l)
	{
		int result;
		try
		{
			SkinnedMeshRenderer skinnedMeshRenderer = (SkinnedMeshRenderer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)skinnedMeshRenderer.quality);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D20 RID: 146720 RVA: 0x00C8D9D8 File Offset: 0x00C8BBD8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_quality(IntPtr l)
	{
		int result;
		try
		{
			SkinnedMeshRenderer skinnedMeshRenderer = (SkinnedMeshRenderer)LuaObject.checkSelf(l);
			SkinQuality quality;
			LuaObject.checkEnum<SkinQuality>(l, 2, out quality);
			skinnedMeshRenderer.quality = quality;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D21 RID: 146721 RVA: 0x00C8DA30 File Offset: 0x00C8BC30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_updateWhenOffscreen(IntPtr l)
	{
		int result;
		try
		{
			SkinnedMeshRenderer skinnedMeshRenderer = (SkinnedMeshRenderer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, skinnedMeshRenderer.updateWhenOffscreen);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D22 RID: 146722 RVA: 0x00C8DA84 File Offset: 0x00C8BC84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_updateWhenOffscreen(IntPtr l)
	{
		int result;
		try
		{
			SkinnedMeshRenderer skinnedMeshRenderer = (SkinnedMeshRenderer)LuaObject.checkSelf(l);
			bool updateWhenOffscreen;
			LuaObject.checkType(l, 2, out updateWhenOffscreen);
			skinnedMeshRenderer.updateWhenOffscreen = updateWhenOffscreen;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D23 RID: 146723 RVA: 0x00C8DADC File Offset: 0x00C8BCDC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_rootBone(IntPtr l)
	{
		int result;
		try
		{
			SkinnedMeshRenderer skinnedMeshRenderer = (SkinnedMeshRenderer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, skinnedMeshRenderer.rootBone);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D24 RID: 146724 RVA: 0x00C8DB30 File Offset: 0x00C8BD30
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_rootBone(IntPtr l)
	{
		int result;
		try
		{
			SkinnedMeshRenderer skinnedMeshRenderer = (SkinnedMeshRenderer)LuaObject.checkSelf(l);
			Transform rootBone;
			LuaObject.checkType<Transform>(l, 2, out rootBone);
			skinnedMeshRenderer.rootBone = rootBone;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D25 RID: 146725 RVA: 0x00C8DB88 File Offset: 0x00C8BD88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_sharedMesh(IntPtr l)
	{
		int result;
		try
		{
			SkinnedMeshRenderer skinnedMeshRenderer = (SkinnedMeshRenderer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, skinnedMeshRenderer.sharedMesh);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D26 RID: 146726 RVA: 0x00C8DBDC File Offset: 0x00C8BDDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_sharedMesh(IntPtr l)
	{
		int result;
		try
		{
			SkinnedMeshRenderer skinnedMeshRenderer = (SkinnedMeshRenderer)LuaObject.checkSelf(l);
			Mesh sharedMesh;
			LuaObject.checkType<Mesh>(l, 2, out sharedMesh);
			skinnedMeshRenderer.sharedMesh = sharedMesh;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D27 RID: 146727 RVA: 0x00C8DC34 File Offset: 0x00C8BE34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_skinnedMotionVectors(IntPtr l)
	{
		int result;
		try
		{
			SkinnedMeshRenderer skinnedMeshRenderer = (SkinnedMeshRenderer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, skinnedMeshRenderer.skinnedMotionVectors);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D28 RID: 146728 RVA: 0x00C8DC88 File Offset: 0x00C8BE88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_skinnedMotionVectors(IntPtr l)
	{
		int result;
		try
		{
			SkinnedMeshRenderer skinnedMeshRenderer = (SkinnedMeshRenderer)LuaObject.checkSelf(l);
			bool skinnedMotionVectors;
			LuaObject.checkType(l, 2, out skinnedMotionVectors);
			skinnedMeshRenderer.skinnedMotionVectors = skinnedMotionVectors;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D29 RID: 146729 RVA: 0x00C8DCE0 File Offset: 0x00C8BEE0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_localBounds(IntPtr l)
	{
		int result;
		try
		{
			SkinnedMeshRenderer skinnedMeshRenderer = (SkinnedMeshRenderer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, skinnedMeshRenderer.localBounds);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D2A RID: 146730 RVA: 0x00C8DD38 File Offset: 0x00C8BF38
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_localBounds(IntPtr l)
	{
		int result;
		try
		{
			SkinnedMeshRenderer skinnedMeshRenderer = (SkinnedMeshRenderer)LuaObject.checkSelf(l);
			Bounds localBounds;
			LuaObject.checkValueType<Bounds>(l, 2, out localBounds);
			skinnedMeshRenderer.localBounds = localBounds;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D2B RID: 146731 RVA: 0x00C8DD90 File Offset: 0x00C8BF90
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.SkinnedMeshRenderer");
		if (Lua_UnityEngine_SkinnedMeshRenderer.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_SkinnedMeshRenderer.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_SkinnedMeshRenderer.GetBlendShapeWeight);
		}
		LuaObject.addMember(l, Lua_UnityEngine_SkinnedMeshRenderer.<>f__mg$cache0);
		if (Lua_UnityEngine_SkinnedMeshRenderer.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_SkinnedMeshRenderer.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_SkinnedMeshRenderer.SetBlendShapeWeight);
		}
		LuaObject.addMember(l, Lua_UnityEngine_SkinnedMeshRenderer.<>f__mg$cache1);
		if (Lua_UnityEngine_SkinnedMeshRenderer.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_SkinnedMeshRenderer.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_SkinnedMeshRenderer.BakeMesh);
		}
		LuaObject.addMember(l, Lua_UnityEngine_SkinnedMeshRenderer.<>f__mg$cache2);
		string name = "bones";
		if (Lua_UnityEngine_SkinnedMeshRenderer.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_SkinnedMeshRenderer.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_SkinnedMeshRenderer.get_bones);
		}
		LuaCSFunction get = Lua_UnityEngine_SkinnedMeshRenderer.<>f__mg$cache3;
		if (Lua_UnityEngine_SkinnedMeshRenderer.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_SkinnedMeshRenderer.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_SkinnedMeshRenderer.set_bones);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_SkinnedMeshRenderer.<>f__mg$cache4, true);
		string name2 = "quality";
		if (Lua_UnityEngine_SkinnedMeshRenderer.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_SkinnedMeshRenderer.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_SkinnedMeshRenderer.get_quality);
		}
		LuaCSFunction get2 = Lua_UnityEngine_SkinnedMeshRenderer.<>f__mg$cache5;
		if (Lua_UnityEngine_SkinnedMeshRenderer.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_SkinnedMeshRenderer.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_SkinnedMeshRenderer.set_quality);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_SkinnedMeshRenderer.<>f__mg$cache6, true);
		string name3 = "updateWhenOffscreen";
		if (Lua_UnityEngine_SkinnedMeshRenderer.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_SkinnedMeshRenderer.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_SkinnedMeshRenderer.get_updateWhenOffscreen);
		}
		LuaCSFunction get3 = Lua_UnityEngine_SkinnedMeshRenderer.<>f__mg$cache7;
		if (Lua_UnityEngine_SkinnedMeshRenderer.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_SkinnedMeshRenderer.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_SkinnedMeshRenderer.set_updateWhenOffscreen);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_SkinnedMeshRenderer.<>f__mg$cache8, true);
		string name4 = "rootBone";
		if (Lua_UnityEngine_SkinnedMeshRenderer.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_SkinnedMeshRenderer.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_SkinnedMeshRenderer.get_rootBone);
		}
		LuaCSFunction get4 = Lua_UnityEngine_SkinnedMeshRenderer.<>f__mg$cache9;
		if (Lua_UnityEngine_SkinnedMeshRenderer.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_SkinnedMeshRenderer.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_SkinnedMeshRenderer.set_rootBone);
		}
		LuaObject.addMember(l, name4, get4, Lua_UnityEngine_SkinnedMeshRenderer.<>f__mg$cacheA, true);
		string name5 = "sharedMesh";
		if (Lua_UnityEngine_SkinnedMeshRenderer.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_SkinnedMeshRenderer.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_SkinnedMeshRenderer.get_sharedMesh);
		}
		LuaCSFunction get5 = Lua_UnityEngine_SkinnedMeshRenderer.<>f__mg$cacheB;
		if (Lua_UnityEngine_SkinnedMeshRenderer.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_SkinnedMeshRenderer.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_SkinnedMeshRenderer.set_sharedMesh);
		}
		LuaObject.addMember(l, name5, get5, Lua_UnityEngine_SkinnedMeshRenderer.<>f__mg$cacheC, true);
		string name6 = "skinnedMotionVectors";
		if (Lua_UnityEngine_SkinnedMeshRenderer.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_SkinnedMeshRenderer.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_SkinnedMeshRenderer.get_skinnedMotionVectors);
		}
		LuaCSFunction get6 = Lua_UnityEngine_SkinnedMeshRenderer.<>f__mg$cacheD;
		if (Lua_UnityEngine_SkinnedMeshRenderer.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_SkinnedMeshRenderer.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_SkinnedMeshRenderer.set_skinnedMotionVectors);
		}
		LuaObject.addMember(l, name6, get6, Lua_UnityEngine_SkinnedMeshRenderer.<>f__mg$cacheE, true);
		string name7 = "localBounds";
		if (Lua_UnityEngine_SkinnedMeshRenderer.<>f__mg$cacheF == null)
		{
			Lua_UnityEngine_SkinnedMeshRenderer.<>f__mg$cacheF = new LuaCSFunction(Lua_UnityEngine_SkinnedMeshRenderer.get_localBounds);
		}
		LuaCSFunction get7 = Lua_UnityEngine_SkinnedMeshRenderer.<>f__mg$cacheF;
		if (Lua_UnityEngine_SkinnedMeshRenderer.<>f__mg$cache10 == null)
		{
			Lua_UnityEngine_SkinnedMeshRenderer.<>f__mg$cache10 = new LuaCSFunction(Lua_UnityEngine_SkinnedMeshRenderer.set_localBounds);
		}
		LuaObject.addMember(l, name7, get7, Lua_UnityEngine_SkinnedMeshRenderer.<>f__mg$cache10, true);
		LuaObject.createTypeMetatable(l, null, typeof(SkinnedMeshRenderer), typeof(Renderer));
	}

	// Token: 0x040199D2 RID: 104914
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040199D3 RID: 104915
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040199D4 RID: 104916
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040199D5 RID: 104917
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040199D6 RID: 104918
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040199D7 RID: 104919
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040199D8 RID: 104920
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040199D9 RID: 104921
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040199DA RID: 104922
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040199DB RID: 104923
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040199DC RID: 104924
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040199DD RID: 104925
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040199DE RID: 104926
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040199DF RID: 104927
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040199E0 RID: 104928
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040199E1 RID: 104929
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040199E2 RID: 104930
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;
}
