using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001642 RID: 5698
[Preserve]
public class Lua_UnityEngine_BoneWeight : LuaObject
{
	// Token: 0x06022C5A RID: 142426 RVA: 0x00C0187C File Offset: 0x00BFFA7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			BoneWeight boneWeight = default(BoneWeight);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, boneWeight);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022C5B RID: 142427 RVA: 0x00C018CC File Offset: 0x00BFFACC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int op_Equality(IntPtr l)
	{
		int result;
		try
		{
			BoneWeight lhs;
			LuaObject.checkValueType<BoneWeight>(l, 1, out lhs);
			BoneWeight rhs;
			LuaObject.checkValueType<BoneWeight>(l, 2, out rhs);
			bool b = lhs == rhs;
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

	// Token: 0x06022C5C RID: 142428 RVA: 0x00C0192C File Offset: 0x00BFFB2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int op_Inequality(IntPtr l)
	{
		int result;
		try
		{
			BoneWeight lhs;
			LuaObject.checkValueType<BoneWeight>(l, 1, out lhs);
			BoneWeight rhs;
			LuaObject.checkValueType<BoneWeight>(l, 2, out rhs);
			bool b = lhs != rhs;
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

	// Token: 0x06022C5D RID: 142429 RVA: 0x00C0198C File Offset: 0x00BFFB8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_weight0(IntPtr l)
	{
		int result;
		try
		{
			BoneWeight boneWeight;
			LuaObject.checkValueType<BoneWeight>(l, 1, out boneWeight);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, boneWeight.weight0);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022C5E RID: 142430 RVA: 0x00C019E0 File Offset: 0x00BFFBE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_weight0(IntPtr l)
	{
		int result;
		try
		{
			BoneWeight boneWeight;
			LuaObject.checkValueType<BoneWeight>(l, 1, out boneWeight);
			float weight;
			LuaObject.checkType(l, 2, out weight);
			boneWeight.weight0 = weight;
			LuaObject.setBack(l, boneWeight);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022C5F RID: 142431 RVA: 0x00C01A44 File Offset: 0x00BFFC44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_weight1(IntPtr l)
	{
		int result;
		try
		{
			BoneWeight boneWeight;
			LuaObject.checkValueType<BoneWeight>(l, 1, out boneWeight);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, boneWeight.weight1);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022C60 RID: 142432 RVA: 0x00C01A98 File Offset: 0x00BFFC98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_weight1(IntPtr l)
	{
		int result;
		try
		{
			BoneWeight boneWeight;
			LuaObject.checkValueType<BoneWeight>(l, 1, out boneWeight);
			float weight;
			LuaObject.checkType(l, 2, out weight);
			boneWeight.weight1 = weight;
			LuaObject.setBack(l, boneWeight);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022C61 RID: 142433 RVA: 0x00C01AFC File Offset: 0x00BFFCFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_weight2(IntPtr l)
	{
		int result;
		try
		{
			BoneWeight boneWeight;
			LuaObject.checkValueType<BoneWeight>(l, 1, out boneWeight);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, boneWeight.weight2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022C62 RID: 142434 RVA: 0x00C01B50 File Offset: 0x00BFFD50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_weight2(IntPtr l)
	{
		int result;
		try
		{
			BoneWeight boneWeight;
			LuaObject.checkValueType<BoneWeight>(l, 1, out boneWeight);
			float weight;
			LuaObject.checkType(l, 2, out weight);
			boneWeight.weight2 = weight;
			LuaObject.setBack(l, boneWeight);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022C63 RID: 142435 RVA: 0x00C01BB4 File Offset: 0x00BFFDB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_weight3(IntPtr l)
	{
		int result;
		try
		{
			BoneWeight boneWeight;
			LuaObject.checkValueType<BoneWeight>(l, 1, out boneWeight);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, boneWeight.weight3);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022C64 RID: 142436 RVA: 0x00C01C08 File Offset: 0x00BFFE08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_weight3(IntPtr l)
	{
		int result;
		try
		{
			BoneWeight boneWeight;
			LuaObject.checkValueType<BoneWeight>(l, 1, out boneWeight);
			float weight;
			LuaObject.checkType(l, 2, out weight);
			boneWeight.weight3 = weight;
			LuaObject.setBack(l, boneWeight);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022C65 RID: 142437 RVA: 0x00C01C6C File Offset: 0x00BFFE6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_boneIndex0(IntPtr l)
	{
		int result;
		try
		{
			BoneWeight boneWeight;
			LuaObject.checkValueType<BoneWeight>(l, 1, out boneWeight);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, boneWeight.boneIndex0);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022C66 RID: 142438 RVA: 0x00C01CC0 File Offset: 0x00BFFEC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_boneIndex0(IntPtr l)
	{
		int result;
		try
		{
			BoneWeight boneWeight;
			LuaObject.checkValueType<BoneWeight>(l, 1, out boneWeight);
			int boneIndex;
			LuaObject.checkType(l, 2, out boneIndex);
			boneWeight.boneIndex0 = boneIndex;
			LuaObject.setBack(l, boneWeight);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022C67 RID: 142439 RVA: 0x00C01D24 File Offset: 0x00BFFF24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_boneIndex1(IntPtr l)
	{
		int result;
		try
		{
			BoneWeight boneWeight;
			LuaObject.checkValueType<BoneWeight>(l, 1, out boneWeight);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, boneWeight.boneIndex1);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022C68 RID: 142440 RVA: 0x00C01D78 File Offset: 0x00BFFF78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_boneIndex1(IntPtr l)
	{
		int result;
		try
		{
			BoneWeight boneWeight;
			LuaObject.checkValueType<BoneWeight>(l, 1, out boneWeight);
			int boneIndex;
			LuaObject.checkType(l, 2, out boneIndex);
			boneWeight.boneIndex1 = boneIndex;
			LuaObject.setBack(l, boneWeight);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022C69 RID: 142441 RVA: 0x00C01DDC File Offset: 0x00BFFFDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_boneIndex2(IntPtr l)
	{
		int result;
		try
		{
			BoneWeight boneWeight;
			LuaObject.checkValueType<BoneWeight>(l, 1, out boneWeight);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, boneWeight.boneIndex2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022C6A RID: 142442 RVA: 0x00C01E30 File Offset: 0x00C00030
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_boneIndex2(IntPtr l)
	{
		int result;
		try
		{
			BoneWeight boneWeight;
			LuaObject.checkValueType<BoneWeight>(l, 1, out boneWeight);
			int boneIndex;
			LuaObject.checkType(l, 2, out boneIndex);
			boneWeight.boneIndex2 = boneIndex;
			LuaObject.setBack(l, boneWeight);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022C6B RID: 142443 RVA: 0x00C01E94 File Offset: 0x00C00094
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_boneIndex3(IntPtr l)
	{
		int result;
		try
		{
			BoneWeight boneWeight;
			LuaObject.checkValueType<BoneWeight>(l, 1, out boneWeight);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, boneWeight.boneIndex3);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022C6C RID: 142444 RVA: 0x00C01EE8 File Offset: 0x00C000E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_boneIndex3(IntPtr l)
	{
		int result;
		try
		{
			BoneWeight boneWeight;
			LuaObject.checkValueType<BoneWeight>(l, 1, out boneWeight);
			int boneIndex;
			LuaObject.checkType(l, 2, out boneIndex);
			boneWeight.boneIndex3 = boneIndex;
			LuaObject.setBack(l, boneWeight);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022C6D RID: 142445 RVA: 0x00C01F4C File Offset: 0x00C0014C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.BoneWeight");
		if (Lua_UnityEngine_BoneWeight.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_BoneWeight.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_BoneWeight.op_Equality);
		}
		LuaObject.addMember(l, Lua_UnityEngine_BoneWeight.<>f__mg$cache0);
		if (Lua_UnityEngine_BoneWeight.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_BoneWeight.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_BoneWeight.op_Inequality);
		}
		LuaObject.addMember(l, Lua_UnityEngine_BoneWeight.<>f__mg$cache1);
		string name = "weight0";
		if (Lua_UnityEngine_BoneWeight.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_BoneWeight.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_BoneWeight.get_weight0);
		}
		LuaCSFunction get = Lua_UnityEngine_BoneWeight.<>f__mg$cache2;
		if (Lua_UnityEngine_BoneWeight.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_BoneWeight.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_BoneWeight.set_weight0);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_BoneWeight.<>f__mg$cache3, true);
		string name2 = "weight1";
		if (Lua_UnityEngine_BoneWeight.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_BoneWeight.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_BoneWeight.get_weight1);
		}
		LuaCSFunction get2 = Lua_UnityEngine_BoneWeight.<>f__mg$cache4;
		if (Lua_UnityEngine_BoneWeight.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_BoneWeight.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_BoneWeight.set_weight1);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_BoneWeight.<>f__mg$cache5, true);
		string name3 = "weight2";
		if (Lua_UnityEngine_BoneWeight.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_BoneWeight.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_BoneWeight.get_weight2);
		}
		LuaCSFunction get3 = Lua_UnityEngine_BoneWeight.<>f__mg$cache6;
		if (Lua_UnityEngine_BoneWeight.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_BoneWeight.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_BoneWeight.set_weight2);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_BoneWeight.<>f__mg$cache7, true);
		string name4 = "weight3";
		if (Lua_UnityEngine_BoneWeight.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_BoneWeight.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_BoneWeight.get_weight3);
		}
		LuaCSFunction get4 = Lua_UnityEngine_BoneWeight.<>f__mg$cache8;
		if (Lua_UnityEngine_BoneWeight.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_BoneWeight.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_BoneWeight.set_weight3);
		}
		LuaObject.addMember(l, name4, get4, Lua_UnityEngine_BoneWeight.<>f__mg$cache9, true);
		string name5 = "boneIndex0";
		if (Lua_UnityEngine_BoneWeight.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_BoneWeight.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_BoneWeight.get_boneIndex0);
		}
		LuaCSFunction get5 = Lua_UnityEngine_BoneWeight.<>f__mg$cacheA;
		if (Lua_UnityEngine_BoneWeight.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_BoneWeight.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_BoneWeight.set_boneIndex0);
		}
		LuaObject.addMember(l, name5, get5, Lua_UnityEngine_BoneWeight.<>f__mg$cacheB, true);
		string name6 = "boneIndex1";
		if (Lua_UnityEngine_BoneWeight.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_BoneWeight.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_BoneWeight.get_boneIndex1);
		}
		LuaCSFunction get6 = Lua_UnityEngine_BoneWeight.<>f__mg$cacheC;
		if (Lua_UnityEngine_BoneWeight.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_BoneWeight.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_BoneWeight.set_boneIndex1);
		}
		LuaObject.addMember(l, name6, get6, Lua_UnityEngine_BoneWeight.<>f__mg$cacheD, true);
		string name7 = "boneIndex2";
		if (Lua_UnityEngine_BoneWeight.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_BoneWeight.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_BoneWeight.get_boneIndex2);
		}
		LuaCSFunction get7 = Lua_UnityEngine_BoneWeight.<>f__mg$cacheE;
		if (Lua_UnityEngine_BoneWeight.<>f__mg$cacheF == null)
		{
			Lua_UnityEngine_BoneWeight.<>f__mg$cacheF = new LuaCSFunction(Lua_UnityEngine_BoneWeight.set_boneIndex2);
		}
		LuaObject.addMember(l, name7, get7, Lua_UnityEngine_BoneWeight.<>f__mg$cacheF, true);
		string name8 = "boneIndex3";
		if (Lua_UnityEngine_BoneWeight.<>f__mg$cache10 == null)
		{
			Lua_UnityEngine_BoneWeight.<>f__mg$cache10 = new LuaCSFunction(Lua_UnityEngine_BoneWeight.get_boneIndex3);
		}
		LuaCSFunction get8 = Lua_UnityEngine_BoneWeight.<>f__mg$cache10;
		if (Lua_UnityEngine_BoneWeight.<>f__mg$cache11 == null)
		{
			Lua_UnityEngine_BoneWeight.<>f__mg$cache11 = new LuaCSFunction(Lua_UnityEngine_BoneWeight.set_boneIndex3);
		}
		LuaObject.addMember(l, name8, get8, Lua_UnityEngine_BoneWeight.<>f__mg$cache11, true);
		if (Lua_UnityEngine_BoneWeight.<>f__mg$cache12 == null)
		{
			Lua_UnityEngine_BoneWeight.<>f__mg$cache12 = new LuaCSFunction(Lua_UnityEngine_BoneWeight.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_BoneWeight.<>f__mg$cache12, typeof(BoneWeight), typeof(ValueType));
	}

	// Token: 0x04018C34 RID: 101428
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04018C35 RID: 101429
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04018C36 RID: 101430
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04018C37 RID: 101431
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04018C38 RID: 101432
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04018C39 RID: 101433
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04018C3A RID: 101434
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04018C3B RID: 101435
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04018C3C RID: 101436
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04018C3D RID: 101437
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04018C3E RID: 101438
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04018C3F RID: 101439
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04018C40 RID: 101440
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04018C41 RID: 101441
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04018C42 RID: 101442
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04018C43 RID: 101443
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04018C44 RID: 101444
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04018C45 RID: 101445
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04018C46 RID: 101446
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;
}
