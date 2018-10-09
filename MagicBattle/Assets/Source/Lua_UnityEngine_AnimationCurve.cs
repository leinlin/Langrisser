using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001612 RID: 5650
[Preserve]
public class Lua_UnityEngine_AnimationCurve : LuaObject
{
	// Token: 0x06022A28 RID: 141864 RVA: 0x00BEE71C File Offset: 0x00BEC91C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				Keyframe[] keys;
				LuaObject.checkValueParams<Keyframe>(l, 2, out keys);
				AnimationCurve o = new AnimationCurve(keys);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (num == 1)
			{
				AnimationCurve o = new AnimationCurve();
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else
			{
				result = LuaObject.error(l, "New object failed.");
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022A29 RID: 141865 RVA: 0x00BEE7B4 File Offset: 0x00BEC9B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Evaluate(IntPtr l)
	{
		int result;
		try
		{
			AnimationCurve animationCurve = (AnimationCurve)LuaObject.checkSelf(l);
			float time;
			LuaObject.checkType(l, 2, out time);
			float o = animationCurve.Evaluate(time);
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

	// Token: 0x06022A2A RID: 141866 RVA: 0x00BEE818 File Offset: 0x00BECA18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddKey(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				AnimationCurve animationCurve = (AnimationCurve)LuaObject.checkSelf(l);
				Keyframe key;
				LuaObject.checkValueType<Keyframe>(l, 2, out key);
				int i = animationCurve.AddKey(key);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i);
				result = 2;
			}
			else if (num == 3)
			{
				AnimationCurve animationCurve2 = (AnimationCurve)LuaObject.checkSelf(l);
				float time;
				LuaObject.checkType(l, 2, out time);
				float value;
				LuaObject.checkType(l, 3, out value);
				int i2 = animationCurve2.AddKey(time, value);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function AddKey to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022A2B RID: 141867 RVA: 0x00BEE8F0 File Offset: 0x00BECAF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int MoveKey(IntPtr l)
	{
		int result;
		try
		{
			AnimationCurve animationCurve = (AnimationCurve)LuaObject.checkSelf(l);
			int index;
			LuaObject.checkType(l, 2, out index);
			Keyframe key;
			LuaObject.checkValueType<Keyframe>(l, 3, out key);
			int i = animationCurve.MoveKey(index, key);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022A2C RID: 141868 RVA: 0x00BEE960 File Offset: 0x00BECB60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RemoveKey(IntPtr l)
	{
		int result;
		try
		{
			AnimationCurve animationCurve = (AnimationCurve)LuaObject.checkSelf(l);
			int index;
			LuaObject.checkType(l, 2, out index);
			animationCurve.RemoveKey(index);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022A2D RID: 141869 RVA: 0x00BEE9B8 File Offset: 0x00BECBB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SmoothTangents(IntPtr l)
	{
		int result;
		try
		{
			AnimationCurve animationCurve = (AnimationCurve)LuaObject.checkSelf(l);
			int index;
			LuaObject.checkType(l, 2, out index);
			float weight;
			LuaObject.checkType(l, 3, out weight);
			animationCurve.SmoothTangents(index, weight);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022A2E RID: 141870 RVA: 0x00BEEA1C File Offset: 0x00BECC1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Constant_s(IntPtr l)
	{
		int result;
		try
		{
			float timeStart;
			LuaObject.checkType(l, 1, out timeStart);
			float timeEnd;
			LuaObject.checkType(l, 2, out timeEnd);
			float value;
			LuaObject.checkType(l, 3, out value);
			AnimationCurve o = AnimationCurve.Constant(timeStart, timeEnd, value);
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

	// Token: 0x06022A2F RID: 141871 RVA: 0x00BEEA8C File Offset: 0x00BECC8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Linear_s(IntPtr l)
	{
		int result;
		try
		{
			float timeStart;
			LuaObject.checkType(l, 1, out timeStart);
			float valueStart;
			LuaObject.checkType(l, 2, out valueStart);
			float timeEnd;
			LuaObject.checkType(l, 3, out timeEnd);
			float valueEnd;
			LuaObject.checkType(l, 4, out valueEnd);
			AnimationCurve o = AnimationCurve.Linear(timeStart, valueStart, timeEnd, valueEnd);
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

	// Token: 0x06022A30 RID: 141872 RVA: 0x00BEEB08 File Offset: 0x00BECD08
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int EaseInOut_s(IntPtr l)
	{
		int result;
		try
		{
			float timeStart;
			LuaObject.checkType(l, 1, out timeStart);
			float valueStart;
			LuaObject.checkType(l, 2, out valueStart);
			float timeEnd;
			LuaObject.checkType(l, 3, out timeEnd);
			float valueEnd;
			LuaObject.checkType(l, 4, out valueEnd);
			AnimationCurve o = AnimationCurve.EaseInOut(timeStart, valueStart, timeEnd, valueEnd);
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

	// Token: 0x06022A31 RID: 141873 RVA: 0x00BEEB84 File Offset: 0x00BECD84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_keys(IntPtr l)
	{
		int result;
		try
		{
			AnimationCurve animationCurve = (AnimationCurve)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animationCurve.keys);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022A32 RID: 141874 RVA: 0x00BEEBD8 File Offset: 0x00BECDD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_keys(IntPtr l)
	{
		int result;
		try
		{
			AnimationCurve animationCurve = (AnimationCurve)LuaObject.checkSelf(l);
			Keyframe[] keys;
			LuaObject.checkArray<Keyframe>(l, 2, out keys);
			animationCurve.keys = keys;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022A33 RID: 141875 RVA: 0x00BEEC30 File Offset: 0x00BECE30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_length(IntPtr l)
	{
		int result;
		try
		{
			AnimationCurve animationCurve = (AnimationCurve)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animationCurve.length);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022A34 RID: 141876 RVA: 0x00BEEC84 File Offset: 0x00BECE84
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_preWrapMode(IntPtr l)
	{
		int result;
		try
		{
			AnimationCurve animationCurve = (AnimationCurve)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)animationCurve.preWrapMode);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022A35 RID: 141877 RVA: 0x00BEECD8 File Offset: 0x00BECED8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_preWrapMode(IntPtr l)
	{
		int result;
		try
		{
			AnimationCurve animationCurve = (AnimationCurve)LuaObject.checkSelf(l);
			WrapMode preWrapMode;
			LuaObject.checkEnum<WrapMode>(l, 2, out preWrapMode);
			animationCurve.preWrapMode = preWrapMode;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022A36 RID: 141878 RVA: 0x00BEED30 File Offset: 0x00BECF30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_postWrapMode(IntPtr l)
	{
		int result;
		try
		{
			AnimationCurve animationCurve = (AnimationCurve)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)animationCurve.postWrapMode);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022A37 RID: 141879 RVA: 0x00BEED84 File Offset: 0x00BECF84
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_postWrapMode(IntPtr l)
	{
		int result;
		try
		{
			AnimationCurve animationCurve = (AnimationCurve)LuaObject.checkSelf(l);
			WrapMode postWrapMode;
			LuaObject.checkEnum<WrapMode>(l, 2, out postWrapMode);
			animationCurve.postWrapMode = postWrapMode;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022A38 RID: 141880 RVA: 0x00BEEDDC File Offset: 0x00BECFDC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int getItem(IntPtr l)
	{
		int result;
		try
		{
			AnimationCurve animationCurve = (AnimationCurve)LuaObject.checkSelf(l);
			int index;
			LuaObject.checkType(l, 2, out index);
			Keyframe keyframe = animationCurve[index];
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, keyframe);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022A39 RID: 141881 RVA: 0x00BEEE44 File Offset: 0x00BED044
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.AnimationCurve");
		if (Lua_UnityEngine_AnimationCurve.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_AnimationCurve.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_AnimationCurve.Evaluate);
		}
		LuaObject.addMember(l, Lua_UnityEngine_AnimationCurve.<>f__mg$cache0);
		if (Lua_UnityEngine_AnimationCurve.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_AnimationCurve.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_AnimationCurve.AddKey);
		}
		LuaObject.addMember(l, Lua_UnityEngine_AnimationCurve.<>f__mg$cache1);
		if (Lua_UnityEngine_AnimationCurve.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_AnimationCurve.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_AnimationCurve.MoveKey);
		}
		LuaObject.addMember(l, Lua_UnityEngine_AnimationCurve.<>f__mg$cache2);
		if (Lua_UnityEngine_AnimationCurve.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_AnimationCurve.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_AnimationCurve.RemoveKey);
		}
		LuaObject.addMember(l, Lua_UnityEngine_AnimationCurve.<>f__mg$cache3);
		if (Lua_UnityEngine_AnimationCurve.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_AnimationCurve.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_AnimationCurve.SmoothTangents);
		}
		LuaObject.addMember(l, Lua_UnityEngine_AnimationCurve.<>f__mg$cache4);
		if (Lua_UnityEngine_AnimationCurve.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_AnimationCurve.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_AnimationCurve.Constant_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_AnimationCurve.<>f__mg$cache5);
		if (Lua_UnityEngine_AnimationCurve.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_AnimationCurve.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_AnimationCurve.Linear_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_AnimationCurve.<>f__mg$cache6);
		if (Lua_UnityEngine_AnimationCurve.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_AnimationCurve.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_AnimationCurve.EaseInOut_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_AnimationCurve.<>f__mg$cache7);
		if (Lua_UnityEngine_AnimationCurve.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_AnimationCurve.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_AnimationCurve.getItem);
		}
		LuaObject.addMember(l, Lua_UnityEngine_AnimationCurve.<>f__mg$cache8);
		string name = "keys";
		if (Lua_UnityEngine_AnimationCurve.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_AnimationCurve.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_AnimationCurve.get_keys);
		}
		LuaCSFunction get = Lua_UnityEngine_AnimationCurve.<>f__mg$cache9;
		if (Lua_UnityEngine_AnimationCurve.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_AnimationCurve.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_AnimationCurve.set_keys);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_AnimationCurve.<>f__mg$cacheA, true);
		string name2 = "length";
		if (Lua_UnityEngine_AnimationCurve.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_AnimationCurve.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_AnimationCurve.get_length);
		}
		LuaObject.addMember(l, name2, Lua_UnityEngine_AnimationCurve.<>f__mg$cacheB, null, true);
		string name3 = "preWrapMode";
		if (Lua_UnityEngine_AnimationCurve.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_AnimationCurve.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_AnimationCurve.get_preWrapMode);
		}
		LuaCSFunction get2 = Lua_UnityEngine_AnimationCurve.<>f__mg$cacheC;
		if (Lua_UnityEngine_AnimationCurve.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_AnimationCurve.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_AnimationCurve.set_preWrapMode);
		}
		LuaObject.addMember(l, name3, get2, Lua_UnityEngine_AnimationCurve.<>f__mg$cacheD, true);
		string name4 = "postWrapMode";
		if (Lua_UnityEngine_AnimationCurve.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_AnimationCurve.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_AnimationCurve.get_postWrapMode);
		}
		LuaCSFunction get3 = Lua_UnityEngine_AnimationCurve.<>f__mg$cacheE;
		if (Lua_UnityEngine_AnimationCurve.<>f__mg$cacheF == null)
		{
			Lua_UnityEngine_AnimationCurve.<>f__mg$cacheF = new LuaCSFunction(Lua_UnityEngine_AnimationCurve.set_postWrapMode);
		}
		LuaObject.addMember(l, name4, get3, Lua_UnityEngine_AnimationCurve.<>f__mg$cacheF, true);
		if (Lua_UnityEngine_AnimationCurve.<>f__mg$cache10 == null)
		{
			Lua_UnityEngine_AnimationCurve.<>f__mg$cache10 = new LuaCSFunction(Lua_UnityEngine_AnimationCurve.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_AnimationCurve.<>f__mg$cache10, typeof(AnimationCurve));
	}

	// Token: 0x04018A62 RID: 100962
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04018A63 RID: 100963
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04018A64 RID: 100964
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04018A65 RID: 100965
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04018A66 RID: 100966
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04018A67 RID: 100967
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04018A68 RID: 100968
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04018A69 RID: 100969
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04018A6A RID: 100970
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04018A6B RID: 100971
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04018A6C RID: 100972
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04018A6D RID: 100973
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04018A6E RID: 100974
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04018A6F RID: 100975
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04018A70 RID: 100976
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04018A71 RID: 100977
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04018A72 RID: 100978
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;
}
