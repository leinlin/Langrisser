using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x020016E4 RID: 5860
[Preserve]
public class Lua_UnityEngine_HumanDescription : LuaObject
{
	// Token: 0x06023335 RID: 144181 RVA: 0x00C36A80 File Offset: 0x00C34C80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			HumanDescription humanDescription = default(HumanDescription);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, humanDescription);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023336 RID: 144182 RVA: 0x00C36AD0 File Offset: 0x00C34CD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_human(IntPtr l)
	{
		int result;
		try
		{
			HumanDescription humanDescription;
			LuaObject.checkValueType<HumanDescription>(l, 1, out humanDescription);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, humanDescription.human);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023337 RID: 144183 RVA: 0x00C36B24 File Offset: 0x00C34D24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_human(IntPtr l)
	{
		int result;
		try
		{
			HumanDescription humanDescription;
			LuaObject.checkValueType<HumanDescription>(l, 1, out humanDescription);
			HumanBone[] human;
			LuaObject.checkArray<HumanBone>(l, 2, out human);
			humanDescription.human = human;
			LuaObject.setBack(l, humanDescription);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023338 RID: 144184 RVA: 0x00C36B88 File Offset: 0x00C34D88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_skeleton(IntPtr l)
	{
		int result;
		try
		{
			HumanDescription humanDescription;
			LuaObject.checkValueType<HumanDescription>(l, 1, out humanDescription);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, humanDescription.skeleton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023339 RID: 144185 RVA: 0x00C36BDC File Offset: 0x00C34DDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_skeleton(IntPtr l)
	{
		int result;
		try
		{
			HumanDescription humanDescription;
			LuaObject.checkValueType<HumanDescription>(l, 1, out humanDescription);
			SkeletonBone[] skeleton;
			LuaObject.checkArray<SkeletonBone>(l, 2, out skeleton);
			humanDescription.skeleton = skeleton;
			LuaObject.setBack(l, humanDescription);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602333A RID: 144186 RVA: 0x00C36C40 File Offset: 0x00C34E40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_upperArmTwist(IntPtr l)
	{
		int result;
		try
		{
			HumanDescription humanDescription;
			LuaObject.checkValueType<HumanDescription>(l, 1, out humanDescription);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, humanDescription.upperArmTwist);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602333B RID: 144187 RVA: 0x00C36C94 File Offset: 0x00C34E94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_upperArmTwist(IntPtr l)
	{
		int result;
		try
		{
			HumanDescription humanDescription;
			LuaObject.checkValueType<HumanDescription>(l, 1, out humanDescription);
			float upperArmTwist;
			LuaObject.checkType(l, 2, out upperArmTwist);
			humanDescription.upperArmTwist = upperArmTwist;
			LuaObject.setBack(l, humanDescription);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602333C RID: 144188 RVA: 0x00C36CF8 File Offset: 0x00C34EF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_lowerArmTwist(IntPtr l)
	{
		int result;
		try
		{
			HumanDescription humanDescription;
			LuaObject.checkValueType<HumanDescription>(l, 1, out humanDescription);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, humanDescription.lowerArmTwist);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602333D RID: 144189 RVA: 0x00C36D4C File Offset: 0x00C34F4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_lowerArmTwist(IntPtr l)
	{
		int result;
		try
		{
			HumanDescription humanDescription;
			LuaObject.checkValueType<HumanDescription>(l, 1, out humanDescription);
			float lowerArmTwist;
			LuaObject.checkType(l, 2, out lowerArmTwist);
			humanDescription.lowerArmTwist = lowerArmTwist;
			LuaObject.setBack(l, humanDescription);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602333E RID: 144190 RVA: 0x00C36DB0 File Offset: 0x00C34FB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_upperLegTwist(IntPtr l)
	{
		int result;
		try
		{
			HumanDescription humanDescription;
			LuaObject.checkValueType<HumanDescription>(l, 1, out humanDescription);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, humanDescription.upperLegTwist);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602333F RID: 144191 RVA: 0x00C36E04 File Offset: 0x00C35004
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_upperLegTwist(IntPtr l)
	{
		int result;
		try
		{
			HumanDescription humanDescription;
			LuaObject.checkValueType<HumanDescription>(l, 1, out humanDescription);
			float upperLegTwist;
			LuaObject.checkType(l, 2, out upperLegTwist);
			humanDescription.upperLegTwist = upperLegTwist;
			LuaObject.setBack(l, humanDescription);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023340 RID: 144192 RVA: 0x00C36E68 File Offset: 0x00C35068
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_lowerLegTwist(IntPtr l)
	{
		int result;
		try
		{
			HumanDescription humanDescription;
			LuaObject.checkValueType<HumanDescription>(l, 1, out humanDescription);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, humanDescription.lowerLegTwist);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023341 RID: 144193 RVA: 0x00C36EBC File Offset: 0x00C350BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_lowerLegTwist(IntPtr l)
	{
		int result;
		try
		{
			HumanDescription humanDescription;
			LuaObject.checkValueType<HumanDescription>(l, 1, out humanDescription);
			float lowerLegTwist;
			LuaObject.checkType(l, 2, out lowerLegTwist);
			humanDescription.lowerLegTwist = lowerLegTwist;
			LuaObject.setBack(l, humanDescription);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023342 RID: 144194 RVA: 0x00C36F20 File Offset: 0x00C35120
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_armStretch(IntPtr l)
	{
		int result;
		try
		{
			HumanDescription humanDescription;
			LuaObject.checkValueType<HumanDescription>(l, 1, out humanDescription);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, humanDescription.armStretch);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023343 RID: 144195 RVA: 0x00C36F74 File Offset: 0x00C35174
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_armStretch(IntPtr l)
	{
		int result;
		try
		{
			HumanDescription humanDescription;
			LuaObject.checkValueType<HumanDescription>(l, 1, out humanDescription);
			float armStretch;
			LuaObject.checkType(l, 2, out armStretch);
			humanDescription.armStretch = armStretch;
			LuaObject.setBack(l, humanDescription);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023344 RID: 144196 RVA: 0x00C36FD8 File Offset: 0x00C351D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_legStretch(IntPtr l)
	{
		int result;
		try
		{
			HumanDescription humanDescription;
			LuaObject.checkValueType<HumanDescription>(l, 1, out humanDescription);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, humanDescription.legStretch);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023345 RID: 144197 RVA: 0x00C3702C File Offset: 0x00C3522C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_legStretch(IntPtr l)
	{
		int result;
		try
		{
			HumanDescription humanDescription;
			LuaObject.checkValueType<HumanDescription>(l, 1, out humanDescription);
			float legStretch;
			LuaObject.checkType(l, 2, out legStretch);
			humanDescription.legStretch = legStretch;
			LuaObject.setBack(l, humanDescription);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023346 RID: 144198 RVA: 0x00C37090 File Offset: 0x00C35290
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_feetSpacing(IntPtr l)
	{
		int result;
		try
		{
			HumanDescription humanDescription;
			LuaObject.checkValueType<HumanDescription>(l, 1, out humanDescription);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, humanDescription.feetSpacing);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023347 RID: 144199 RVA: 0x00C370E4 File Offset: 0x00C352E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_feetSpacing(IntPtr l)
	{
		int result;
		try
		{
			HumanDescription humanDescription;
			LuaObject.checkValueType<HumanDescription>(l, 1, out humanDescription);
			float feetSpacing;
			LuaObject.checkType(l, 2, out feetSpacing);
			humanDescription.feetSpacing = feetSpacing;
			LuaObject.setBack(l, humanDescription);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023348 RID: 144200 RVA: 0x00C37148 File Offset: 0x00C35348
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_hasTranslationDoF(IntPtr l)
	{
		int result;
		try
		{
			HumanDescription humanDescription;
			LuaObject.checkValueType<HumanDescription>(l, 1, out humanDescription);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, humanDescription.hasTranslationDoF);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023349 RID: 144201 RVA: 0x00C3719C File Offset: 0x00C3539C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_hasTranslationDoF(IntPtr l)
	{
		int result;
		try
		{
			HumanDescription humanDescription;
			LuaObject.checkValueType<HumanDescription>(l, 1, out humanDescription);
			bool hasTranslationDoF;
			LuaObject.checkType(l, 2, out hasTranslationDoF);
			humanDescription.hasTranslationDoF = hasTranslationDoF;
			LuaObject.setBack(l, humanDescription);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602334A RID: 144202 RVA: 0x00C37200 File Offset: 0x00C35400
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.HumanDescription");
		string name = "human";
		if (Lua_UnityEngine_HumanDescription.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_HumanDescription.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_HumanDescription.get_human);
		}
		LuaCSFunction get = Lua_UnityEngine_HumanDescription.<>f__mg$cache0;
		if (Lua_UnityEngine_HumanDescription.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_HumanDescription.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_HumanDescription.set_human);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_HumanDescription.<>f__mg$cache1, true);
		string name2 = "skeleton";
		if (Lua_UnityEngine_HumanDescription.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_HumanDescription.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_HumanDescription.get_skeleton);
		}
		LuaCSFunction get2 = Lua_UnityEngine_HumanDescription.<>f__mg$cache2;
		if (Lua_UnityEngine_HumanDescription.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_HumanDescription.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_HumanDescription.set_skeleton);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_HumanDescription.<>f__mg$cache3, true);
		string name3 = "upperArmTwist";
		if (Lua_UnityEngine_HumanDescription.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_HumanDescription.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_HumanDescription.get_upperArmTwist);
		}
		LuaCSFunction get3 = Lua_UnityEngine_HumanDescription.<>f__mg$cache4;
		if (Lua_UnityEngine_HumanDescription.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_HumanDescription.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_HumanDescription.set_upperArmTwist);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_HumanDescription.<>f__mg$cache5, true);
		string name4 = "lowerArmTwist";
		if (Lua_UnityEngine_HumanDescription.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_HumanDescription.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_HumanDescription.get_lowerArmTwist);
		}
		LuaCSFunction get4 = Lua_UnityEngine_HumanDescription.<>f__mg$cache6;
		if (Lua_UnityEngine_HumanDescription.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_HumanDescription.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_HumanDescription.set_lowerArmTwist);
		}
		LuaObject.addMember(l, name4, get4, Lua_UnityEngine_HumanDescription.<>f__mg$cache7, true);
		string name5 = "upperLegTwist";
		if (Lua_UnityEngine_HumanDescription.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_HumanDescription.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_HumanDescription.get_upperLegTwist);
		}
		LuaCSFunction get5 = Lua_UnityEngine_HumanDescription.<>f__mg$cache8;
		if (Lua_UnityEngine_HumanDescription.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_HumanDescription.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_HumanDescription.set_upperLegTwist);
		}
		LuaObject.addMember(l, name5, get5, Lua_UnityEngine_HumanDescription.<>f__mg$cache9, true);
		string name6 = "lowerLegTwist";
		if (Lua_UnityEngine_HumanDescription.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_HumanDescription.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_HumanDescription.get_lowerLegTwist);
		}
		LuaCSFunction get6 = Lua_UnityEngine_HumanDescription.<>f__mg$cacheA;
		if (Lua_UnityEngine_HumanDescription.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_HumanDescription.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_HumanDescription.set_lowerLegTwist);
		}
		LuaObject.addMember(l, name6, get6, Lua_UnityEngine_HumanDescription.<>f__mg$cacheB, true);
		string name7 = "armStretch";
		if (Lua_UnityEngine_HumanDescription.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_HumanDescription.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_HumanDescription.get_armStretch);
		}
		LuaCSFunction get7 = Lua_UnityEngine_HumanDescription.<>f__mg$cacheC;
		if (Lua_UnityEngine_HumanDescription.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_HumanDescription.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_HumanDescription.set_armStretch);
		}
		LuaObject.addMember(l, name7, get7, Lua_UnityEngine_HumanDescription.<>f__mg$cacheD, true);
		string name8 = "legStretch";
		if (Lua_UnityEngine_HumanDescription.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_HumanDescription.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_HumanDescription.get_legStretch);
		}
		LuaCSFunction get8 = Lua_UnityEngine_HumanDescription.<>f__mg$cacheE;
		if (Lua_UnityEngine_HumanDescription.<>f__mg$cacheF == null)
		{
			Lua_UnityEngine_HumanDescription.<>f__mg$cacheF = new LuaCSFunction(Lua_UnityEngine_HumanDescription.set_legStretch);
		}
		LuaObject.addMember(l, name8, get8, Lua_UnityEngine_HumanDescription.<>f__mg$cacheF, true);
		string name9 = "feetSpacing";
		if (Lua_UnityEngine_HumanDescription.<>f__mg$cache10 == null)
		{
			Lua_UnityEngine_HumanDescription.<>f__mg$cache10 = new LuaCSFunction(Lua_UnityEngine_HumanDescription.get_feetSpacing);
		}
		LuaCSFunction get9 = Lua_UnityEngine_HumanDescription.<>f__mg$cache10;
		if (Lua_UnityEngine_HumanDescription.<>f__mg$cache11 == null)
		{
			Lua_UnityEngine_HumanDescription.<>f__mg$cache11 = new LuaCSFunction(Lua_UnityEngine_HumanDescription.set_feetSpacing);
		}
		LuaObject.addMember(l, name9, get9, Lua_UnityEngine_HumanDescription.<>f__mg$cache11, true);
		string name10 = "hasTranslationDoF";
		if (Lua_UnityEngine_HumanDescription.<>f__mg$cache12 == null)
		{
			Lua_UnityEngine_HumanDescription.<>f__mg$cache12 = new LuaCSFunction(Lua_UnityEngine_HumanDescription.get_hasTranslationDoF);
		}
		LuaCSFunction get10 = Lua_UnityEngine_HumanDescription.<>f__mg$cache12;
		if (Lua_UnityEngine_HumanDescription.<>f__mg$cache13 == null)
		{
			Lua_UnityEngine_HumanDescription.<>f__mg$cache13 = new LuaCSFunction(Lua_UnityEngine_HumanDescription.set_hasTranslationDoF);
		}
		LuaObject.addMember(l, name10, get10, Lua_UnityEngine_HumanDescription.<>f__mg$cache13, true);
		if (Lua_UnityEngine_HumanDescription.<>f__mg$cache14 == null)
		{
			Lua_UnityEngine_HumanDescription.<>f__mg$cache14 = new LuaCSFunction(Lua_UnityEngine_HumanDescription.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_HumanDescription.<>f__mg$cache14, typeof(HumanDescription), typeof(ValueType));
	}

	// Token: 0x040191CB RID: 102859
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040191CC RID: 102860
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040191CD RID: 102861
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040191CE RID: 102862
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040191CF RID: 102863
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040191D0 RID: 102864
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040191D1 RID: 102865
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040191D2 RID: 102866
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040191D3 RID: 102867
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040191D4 RID: 102868
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040191D5 RID: 102869
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040191D6 RID: 102870
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040191D7 RID: 102871
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040191D8 RID: 102872
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040191D9 RID: 102873
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040191DA RID: 102874
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040191DB RID: 102875
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040191DC RID: 102876
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040191DD RID: 102877
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x040191DE RID: 102878
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x040191DF RID: 102879
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;
}
