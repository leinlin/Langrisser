using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x020016E8 RID: 5864
[Preserve]
public class Lua_UnityEngine_HumanTrait : LuaObject
{
	// Token: 0x06023368 RID: 144232 RVA: 0x00C38084 File Offset: 0x00C36284
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			HumanTrait o = new HumanTrait();
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

	// Token: 0x06023369 RID: 144233 RVA: 0x00C380CC File Offset: 0x00C362CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int MuscleFromBone_s(IntPtr l)
	{
		int result;
		try
		{
			int i;
			LuaObject.checkType(l, 1, out i);
			int dofIndex;
			LuaObject.checkType(l, 2, out dofIndex);
			int i2 = HumanTrait.MuscleFromBone(i, dofIndex);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602336A RID: 144234 RVA: 0x00C3812C File Offset: 0x00C3632C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BoneFromMuscle_s(IntPtr l)
	{
		int result;
		try
		{
			int i;
			LuaObject.checkType(l, 1, out i);
			int i2 = HumanTrait.BoneFromMuscle(i);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602336B RID: 144235 RVA: 0x00C38180 File Offset: 0x00C36380
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RequiredBone_s(IntPtr l)
	{
		int result;
		try
		{
			int i;
			LuaObject.checkType(l, 1, out i);
			bool b = HumanTrait.RequiredBone(i);
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

	// Token: 0x0602336C RID: 144236 RVA: 0x00C381D4 File Offset: 0x00C363D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetMuscleDefaultMin_s(IntPtr l)
	{
		int result;
		try
		{
			int i;
			LuaObject.checkType(l, 1, out i);
			float muscleDefaultMin = HumanTrait.GetMuscleDefaultMin(i);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, muscleDefaultMin);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602336D RID: 144237 RVA: 0x00C38228 File Offset: 0x00C36428
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetMuscleDefaultMax_s(IntPtr l)
	{
		int result;
		try
		{
			int i;
			LuaObject.checkType(l, 1, out i);
			float muscleDefaultMax = HumanTrait.GetMuscleDefaultMax(i);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, muscleDefaultMax);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602336E RID: 144238 RVA: 0x00C3827C File Offset: 0x00C3647C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetParentBone_s(IntPtr l)
	{
		int result;
		try
		{
			int i;
			LuaObject.checkType(l, 1, out i);
			int parentBone = HumanTrait.GetParentBone(i);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, parentBone);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602336F RID: 144239 RVA: 0x00C382D0 File Offset: 0x00C364D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_MuscleCount(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, HumanTrait.MuscleCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023370 RID: 144240 RVA: 0x00C38318 File Offset: 0x00C36518
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_MuscleName(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, HumanTrait.MuscleName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023371 RID: 144241 RVA: 0x00C38360 File Offset: 0x00C36560
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BoneCount(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, HumanTrait.BoneCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023372 RID: 144242 RVA: 0x00C383A8 File Offset: 0x00C365A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BoneName(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, HumanTrait.BoneName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023373 RID: 144243 RVA: 0x00C383F0 File Offset: 0x00C365F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_RequiredBoneCount(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, HumanTrait.RequiredBoneCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023374 RID: 144244 RVA: 0x00C38438 File Offset: 0x00C36638
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.HumanTrait");
		if (Lua_UnityEngine_HumanTrait.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_HumanTrait.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_HumanTrait.MuscleFromBone_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_HumanTrait.<>f__mg$cache0);
		if (Lua_UnityEngine_HumanTrait.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_HumanTrait.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_HumanTrait.BoneFromMuscle_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_HumanTrait.<>f__mg$cache1);
		if (Lua_UnityEngine_HumanTrait.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_HumanTrait.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_HumanTrait.RequiredBone_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_HumanTrait.<>f__mg$cache2);
		if (Lua_UnityEngine_HumanTrait.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_HumanTrait.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_HumanTrait.GetMuscleDefaultMin_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_HumanTrait.<>f__mg$cache3);
		if (Lua_UnityEngine_HumanTrait.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_HumanTrait.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_HumanTrait.GetMuscleDefaultMax_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_HumanTrait.<>f__mg$cache4);
		if (Lua_UnityEngine_HumanTrait.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_HumanTrait.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_HumanTrait.GetParentBone_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_HumanTrait.<>f__mg$cache5);
		string name = "MuscleCount";
		if (Lua_UnityEngine_HumanTrait.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_HumanTrait.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_HumanTrait.get_MuscleCount);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_HumanTrait.<>f__mg$cache6, null, false);
		string name2 = "MuscleName";
		if (Lua_UnityEngine_HumanTrait.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_HumanTrait.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_HumanTrait.get_MuscleName);
		}
		LuaObject.addMember(l, name2, Lua_UnityEngine_HumanTrait.<>f__mg$cache7, null, false);
		string name3 = "BoneCount";
		if (Lua_UnityEngine_HumanTrait.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_HumanTrait.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_HumanTrait.get_BoneCount);
		}
		LuaObject.addMember(l, name3, Lua_UnityEngine_HumanTrait.<>f__mg$cache8, null, false);
		string name4 = "BoneName";
		if (Lua_UnityEngine_HumanTrait.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_HumanTrait.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_HumanTrait.get_BoneName);
		}
		LuaObject.addMember(l, name4, Lua_UnityEngine_HumanTrait.<>f__mg$cache9, null, false);
		string name5 = "RequiredBoneCount";
		if (Lua_UnityEngine_HumanTrait.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_HumanTrait.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_HumanTrait.get_RequiredBoneCount);
		}
		LuaObject.addMember(l, name5, Lua_UnityEngine_HumanTrait.<>f__mg$cacheA, null, false);
		if (Lua_UnityEngine_HumanTrait.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_HumanTrait.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_HumanTrait.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_HumanTrait.<>f__mg$cacheB, typeof(HumanTrait));
	}

	// Token: 0x040191F6 RID: 102902
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040191F7 RID: 102903
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040191F8 RID: 102904
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040191F9 RID: 102905
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040191FA RID: 102906
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040191FB RID: 102907
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040191FC RID: 102908
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040191FD RID: 102909
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040191FE RID: 102910
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040191FF RID: 102911
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04019200 RID: 102912
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04019201 RID: 102913
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;
}
