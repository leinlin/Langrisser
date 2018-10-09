using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x0200167E RID: 5758
[Preserve]
public class Lua_UnityEngine_CullingGroup : LuaObject
{
	// Token: 0x06022FF4 RID: 143348 RVA: 0x00C1DA60 File Offset: 0x00C1BC60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			CullingGroup o = new CullingGroup();
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

	// Token: 0x06022FF5 RID: 143349 RVA: 0x00C1DAA8 File Offset: 0x00C1BCA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Dispose(IntPtr l)
	{
		int result;
		try
		{
			CullingGroup cullingGroup = (CullingGroup)LuaObject.checkSelf(l);
			cullingGroup.Dispose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022FF6 RID: 143350 RVA: 0x00C1DAF4 File Offset: 0x00C1BCF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetBoundingSpheres(IntPtr l)
	{
		int result;
		try
		{
			CullingGroup cullingGroup = (CullingGroup)LuaObject.checkSelf(l);
			BoundingSphere[] boundingSpheres;
			LuaObject.checkArray<BoundingSphere>(l, 2, out boundingSpheres);
			cullingGroup.SetBoundingSpheres(boundingSpheres);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022FF7 RID: 143351 RVA: 0x00C1DB4C File Offset: 0x00C1BD4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetBoundingSphereCount(IntPtr l)
	{
		int result;
		try
		{
			CullingGroup cullingGroup = (CullingGroup)LuaObject.checkSelf(l);
			int boundingSphereCount;
			LuaObject.checkType(l, 2, out boundingSphereCount);
			cullingGroup.SetBoundingSphereCount(boundingSphereCount);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022FF8 RID: 143352 RVA: 0x00C1DBA4 File Offset: 0x00C1BDA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int EraseSwapBack(IntPtr l)
	{
		int result;
		try
		{
			CullingGroup cullingGroup = (CullingGroup)LuaObject.checkSelf(l);
			int index;
			LuaObject.checkType(l, 2, out index);
			cullingGroup.EraseSwapBack(index);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022FF9 RID: 143353 RVA: 0x00C1DBFC File Offset: 0x00C1BDFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int QueryIndices(IntPtr l)
	{
		int result2;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, num, 2, typeof(int), typeof(int[]), typeof(int)))
			{
				CullingGroup cullingGroup = (CullingGroup)LuaObject.checkSelf(l);
				int distanceIndex;
				LuaObject.checkType(l, 2, out distanceIndex);
				int[] result;
				LuaObject.checkArray<int>(l, 3, out result);
				int firstIndex;
				LuaObject.checkType(l, 4, out firstIndex);
				int i = cullingGroup.QueryIndices(distanceIndex, result, firstIndex);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i);
				result2 = 2;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(bool), typeof(int[]), typeof(int)))
			{
				CullingGroup cullingGroup2 = (CullingGroup)LuaObject.checkSelf(l);
				bool visible;
				LuaObject.checkType(l, 2, out visible);
				int[] result3;
				LuaObject.checkArray<int>(l, 3, out result3);
				int firstIndex2;
				LuaObject.checkType(l, 4, out firstIndex2);
				int i2 = cullingGroup2.QueryIndices(visible, result3, firstIndex2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i2);
				result2 = 2;
			}
			else if (num == 5)
			{
				CullingGroup cullingGroup3 = (CullingGroup)LuaObject.checkSelf(l);
				bool visible2;
				LuaObject.checkType(l, 2, out visible2);
				int distanceIndex2;
				LuaObject.checkType(l, 3, out distanceIndex2);
				int[] result4;
				LuaObject.checkArray<int>(l, 4, out result4);
				int firstIndex3;
				LuaObject.checkType(l, 5, out firstIndex3);
				int i3 = cullingGroup3.QueryIndices(visible2, distanceIndex2, result4, firstIndex3);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i3);
				result2 = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function QueryIndices to call");
				result2 = 2;
			}
		}
		catch (Exception e)
		{
			result2 = LuaObject.error(l, e);
		}
		return result2;
	}

	// Token: 0x06022FFA RID: 143354 RVA: 0x00C1DDB4 File Offset: 0x00C1BFB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsVisible(IntPtr l)
	{
		int result;
		try
		{
			CullingGroup cullingGroup = (CullingGroup)LuaObject.checkSelf(l);
			int index;
			LuaObject.checkType(l, 2, out index);
			bool b = cullingGroup.IsVisible(index);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022FFB RID: 143355 RVA: 0x00C1DE18 File Offset: 0x00C1C018
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetDistance(IntPtr l)
	{
		int result;
		try
		{
			CullingGroup cullingGroup = (CullingGroup)LuaObject.checkSelf(l);
			int index;
			LuaObject.checkType(l, 2, out index);
			int distance = cullingGroup.GetDistance(index);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, distance);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022FFC RID: 143356 RVA: 0x00C1DE7C File Offset: 0x00C1C07C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetBoundingDistances(IntPtr l)
	{
		int result;
		try
		{
			CullingGroup cullingGroup = (CullingGroup)LuaObject.checkSelf(l);
			float[] boundingDistances;
			LuaObject.checkArray<float>(l, 2, out boundingDistances);
			cullingGroup.SetBoundingDistances(boundingDistances);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022FFD RID: 143357 RVA: 0x00C1DED4 File Offset: 0x00C1C0D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetDistanceReferencePoint(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(Vector3)))
			{
				CullingGroup cullingGroup = (CullingGroup)LuaObject.checkSelf(l);
				Vector3 distanceReferencePoint;
				LuaObject.checkType(l, 2, out distanceReferencePoint);
				cullingGroup.SetDistanceReferencePoint(distanceReferencePoint);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(Transform)))
			{
				CullingGroup cullingGroup2 = (CullingGroup)LuaObject.checkSelf(l);
				Transform distanceReferencePoint2;
				LuaObject.checkType<Transform>(l, 2, out distanceReferencePoint2);
				cullingGroup2.SetDistanceReferencePoint(distanceReferencePoint2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function SetDistanceReferencePoint to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022FFE RID: 143358 RVA: 0x00C1DFAC File Offset: 0x00C1C1AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_onStateChanged(IntPtr l)
	{
		int result;
		try
		{
			CullingGroup cullingGroup = (CullingGroup)LuaObject.checkSelf(l);
			CullingGroup.StateChanged stateChanged;
			int num = LuaObject.checkDelegate<CullingGroup.StateChanged>(l, 2, out stateChanged);
			if (num == 0)
			{
				cullingGroup.onStateChanged = stateChanged;
			}
			else if (num == 1)
			{
				CullingGroup cullingGroup2 = cullingGroup;
				cullingGroup2.onStateChanged = (CullingGroup.StateChanged)Delegate.Combine(cullingGroup2.onStateChanged, stateChanged);
			}
			else if (num == 2)
			{
				CullingGroup cullingGroup3 = cullingGroup;
				cullingGroup3.onStateChanged = (CullingGroup.StateChanged)Delegate.Remove(cullingGroup3.onStateChanged, stateChanged);
			}
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022FFF RID: 143359 RVA: 0x00C1E054 File Offset: 0x00C1C254
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_enabled(IntPtr l)
	{
		int result;
		try
		{
			CullingGroup cullingGroup = (CullingGroup)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cullingGroup.enabled);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023000 RID: 143360 RVA: 0x00C1E0A8 File Offset: 0x00C1C2A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_enabled(IntPtr l)
	{
		int result;
		try
		{
			CullingGroup cullingGroup = (CullingGroup)LuaObject.checkSelf(l);
			bool enabled;
			LuaObject.checkType(l, 2, out enabled);
			cullingGroup.enabled = enabled;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023001 RID: 143361 RVA: 0x00C1E100 File Offset: 0x00C1C300
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_targetCamera(IntPtr l)
	{
		int result;
		try
		{
			CullingGroup cullingGroup = (CullingGroup)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cullingGroup.targetCamera);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023002 RID: 143362 RVA: 0x00C1E154 File Offset: 0x00C1C354
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_targetCamera(IntPtr l)
	{
		int result;
		try
		{
			CullingGroup cullingGroup = (CullingGroup)LuaObject.checkSelf(l);
			Camera targetCamera;
			LuaObject.checkType<Camera>(l, 2, out targetCamera);
			cullingGroup.targetCamera = targetCamera;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023003 RID: 143363 RVA: 0x00C1E1AC File Offset: 0x00C1C3AC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.CullingGroup");
		if (Lua_UnityEngine_CullingGroup.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_CullingGroup.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_CullingGroup.Dispose);
		}
		LuaObject.addMember(l, Lua_UnityEngine_CullingGroup.<>f__mg$cache0);
		if (Lua_UnityEngine_CullingGroup.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_CullingGroup.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_CullingGroup.SetBoundingSpheres);
		}
		LuaObject.addMember(l, Lua_UnityEngine_CullingGroup.<>f__mg$cache1);
		if (Lua_UnityEngine_CullingGroup.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_CullingGroup.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_CullingGroup.SetBoundingSphereCount);
		}
		LuaObject.addMember(l, Lua_UnityEngine_CullingGroup.<>f__mg$cache2);
		if (Lua_UnityEngine_CullingGroup.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_CullingGroup.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_CullingGroup.EraseSwapBack);
		}
		LuaObject.addMember(l, Lua_UnityEngine_CullingGroup.<>f__mg$cache3);
		if (Lua_UnityEngine_CullingGroup.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_CullingGroup.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_CullingGroup.QueryIndices);
		}
		LuaObject.addMember(l, Lua_UnityEngine_CullingGroup.<>f__mg$cache4);
		if (Lua_UnityEngine_CullingGroup.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_CullingGroup.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_CullingGroup.IsVisible);
		}
		LuaObject.addMember(l, Lua_UnityEngine_CullingGroup.<>f__mg$cache5);
		if (Lua_UnityEngine_CullingGroup.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_CullingGroup.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_CullingGroup.GetDistance);
		}
		LuaObject.addMember(l, Lua_UnityEngine_CullingGroup.<>f__mg$cache6);
		if (Lua_UnityEngine_CullingGroup.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_CullingGroup.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_CullingGroup.SetBoundingDistances);
		}
		LuaObject.addMember(l, Lua_UnityEngine_CullingGroup.<>f__mg$cache7);
		if (Lua_UnityEngine_CullingGroup.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_CullingGroup.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_CullingGroup.SetDistanceReferencePoint);
		}
		LuaObject.addMember(l, Lua_UnityEngine_CullingGroup.<>f__mg$cache8);
		string name = "onStateChanged";
		LuaCSFunction get = null;
		if (Lua_UnityEngine_CullingGroup.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_CullingGroup.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_CullingGroup.set_onStateChanged);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_CullingGroup.<>f__mg$cache9, true);
		string name2 = "enabled";
		if (Lua_UnityEngine_CullingGroup.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_CullingGroup.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_CullingGroup.get_enabled);
		}
		LuaCSFunction get2 = Lua_UnityEngine_CullingGroup.<>f__mg$cacheA;
		if (Lua_UnityEngine_CullingGroup.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_CullingGroup.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_CullingGroup.set_enabled);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_CullingGroup.<>f__mg$cacheB, true);
		string name3 = "targetCamera";
		if (Lua_UnityEngine_CullingGroup.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_CullingGroup.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_CullingGroup.get_targetCamera);
		}
		LuaCSFunction get3 = Lua_UnityEngine_CullingGroup.<>f__mg$cacheC;
		if (Lua_UnityEngine_CullingGroup.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_CullingGroup.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_CullingGroup.set_targetCamera);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_CullingGroup.<>f__mg$cacheD, true);
		if (Lua_UnityEngine_CullingGroup.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_CullingGroup.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_CullingGroup.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_CullingGroup.<>f__mg$cacheE, typeof(CullingGroup));
	}

	// Token: 0x04018F56 RID: 102230
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04018F57 RID: 102231
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04018F58 RID: 102232
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04018F59 RID: 102233
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04018F5A RID: 102234
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04018F5B RID: 102235
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04018F5C RID: 102236
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04018F5D RID: 102237
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04018F5E RID: 102238
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04018F5F RID: 102239
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04018F60 RID: 102240
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04018F61 RID: 102241
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04018F62 RID: 102242
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04018F63 RID: 102243
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04018F64 RID: 102244
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;
}
