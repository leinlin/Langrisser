using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001215 RID: 4629
[Preserve]
public class Lua_BlackJack_ProjectL_Common_DataSectionThearchyTrail : LuaObject
{
	// Token: 0x0601807E RID: 98430 RVA: 0x006AA674 File Offset: 0x006A8874
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			DataSectionThearchyTrail o = new DataSectionThearchyTrail();
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

	// Token: 0x0601807F RID: 98431 RVA: 0x006AA6BC File Offset: 0x006A88BC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ClearInitedData(IntPtr l)
	{
		int result;
		try
		{
			DataSectionThearchyTrail dataSectionThearchyTrail = (DataSectionThearchyTrail)LuaObject.checkSelf(l);
			dataSectionThearchyTrail.ClearInitedData();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018080 RID: 98432 RVA: 0x006AA708 File Offset: 0x006A8908
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SerializeToClient(IntPtr l)
	{
		int result;
		try
		{
			DataSectionThearchyTrail dataSectionThearchyTrail = (DataSectionThearchyTrail)LuaObject.checkSelf(l);
			object o = dataSectionThearchyTrail.SerializeToClient();
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

	// Token: 0x06018081 RID: 98433 RVA: 0x006AA75C File Offset: 0x006A895C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int InitFinishedLevels(IntPtr l)
	{
		int result;
		try
		{
			DataSectionThearchyTrail dataSectionThearchyTrail = (DataSectionThearchyTrail)LuaObject.checkSelf(l);
			List<int> levels;
			LuaObject.checkType<List<int>>(l, 2, out levels);
			dataSectionThearchyTrail.InitFinishedLevels(levels);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018082 RID: 98434 RVA: 0x006AA7B4 File Offset: 0x006A89B4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsLevelFinished(IntPtr l)
	{
		int result;
		try
		{
			DataSectionThearchyTrail dataSectionThearchyTrail = (DataSectionThearchyTrail)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			bool b = dataSectionThearchyTrail.IsLevelFinished(levelId);
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

	// Token: 0x06018083 RID: 98435 RVA: 0x006AA818 File Offset: 0x006A8A18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddFinishedLevel(IntPtr l)
	{
		int result;
		try
		{
			DataSectionThearchyTrail dataSectionThearchyTrail = (DataSectionThearchyTrail)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			dataSectionThearchyTrail.AddFinishedLevel(levelId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018084 RID: 98436 RVA: 0x006AA870 File Offset: 0x006A8A70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetAllFinishedLevels(IntPtr l)
	{
		int result;
		try
		{
			DataSectionThearchyTrail dataSectionThearchyTrail = (DataSectionThearchyTrail)LuaObject.checkSelf(l);
			HashSet<int> allFinishedLevels = dataSectionThearchyTrail.GetAllFinishedLevels();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, allFinishedLevels);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018085 RID: 98437 RVA: 0x006AA8C4 File Offset: 0x006A8AC4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int InitChallengedNums(IntPtr l)
	{
		int result;
		try
		{
			DataSectionThearchyTrail dataSectionThearchyTrail = (DataSectionThearchyTrail)LuaObject.checkSelf(l);
			int nums;
			LuaObject.checkType(l, 2, out nums);
			dataSectionThearchyTrail.InitChallengedNums(nums);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018086 RID: 98438 RVA: 0x006AA91C File Offset: 0x006A8B1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetChallengedNums(IntPtr l)
	{
		int result;
		try
		{
			DataSectionThearchyTrail dataSectionThearchyTrail = (DataSectionThearchyTrail)LuaObject.checkSelf(l);
			int challengedNums;
			LuaObject.checkType(l, 2, out challengedNums);
			dataSectionThearchyTrail.SetChallengedNums(challengedNums);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018087 RID: 98439 RVA: 0x006AA974 File Offset: 0x006A8B74
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AddChallengedNums(IntPtr l)
	{
		int result;
		try
		{
			DataSectionThearchyTrail dataSectionThearchyTrail = (DataSectionThearchyTrail)LuaObject.checkSelf(l);
			int nums;
			LuaObject.checkType(l, 2, out nums);
			dataSectionThearchyTrail.AddChallengedNums(nums);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018088 RID: 98440 RVA: 0x006AA9CC File Offset: 0x006A8BCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ChallengedNums(IntPtr l)
	{
		int result;
		try
		{
			DataSectionThearchyTrail dataSectionThearchyTrail = (DataSectionThearchyTrail)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionThearchyTrail.ChallengedNums);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018089 RID: 98441 RVA: 0x006AAA20 File Offset: 0x006A8C20
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.DataSectionThearchyTrail");
		if (Lua_BlackJack_ProjectL_Common_DataSectionThearchyTrail.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionThearchyTrail.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionThearchyTrail.ClearInitedData);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionThearchyTrail.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_DataSectionThearchyTrail.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionThearchyTrail.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionThearchyTrail.SerializeToClient);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionThearchyTrail.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_DataSectionThearchyTrail.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionThearchyTrail.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionThearchyTrail.InitFinishedLevels);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionThearchyTrail.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_DataSectionThearchyTrail.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionThearchyTrail.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionThearchyTrail.IsLevelFinished);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionThearchyTrail.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Common_DataSectionThearchyTrail.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionThearchyTrail.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionThearchyTrail.AddFinishedLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionThearchyTrail.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Common_DataSectionThearchyTrail.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionThearchyTrail.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionThearchyTrail.GetAllFinishedLevels);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionThearchyTrail.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Common_DataSectionThearchyTrail.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionThearchyTrail.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionThearchyTrail.InitChallengedNums);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionThearchyTrail.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_Common_DataSectionThearchyTrail.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionThearchyTrail.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionThearchyTrail.SetChallengedNums);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionThearchyTrail.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_Common_DataSectionThearchyTrail.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionThearchyTrail.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionThearchyTrail.AddChallengedNums);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionThearchyTrail.<>f__mg$cache8);
		string name = "ChallengedNums";
		if (Lua_BlackJack_ProjectL_Common_DataSectionThearchyTrail.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionThearchyTrail.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionThearchyTrail.get_ChallengedNums);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_ProjectL_Common_DataSectionThearchyTrail.<>f__mg$cache9, null, true);
		if (Lua_BlackJack_ProjectL_Common_DataSectionThearchyTrail.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionThearchyTrail.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionThearchyTrail.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_DataSectionThearchyTrail.<>f__mg$cacheA, typeof(DataSectionThearchyTrail), typeof(DataSection));
	}

	// Token: 0x0400E636 RID: 58934
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E637 RID: 58935
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E638 RID: 58936
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400E639 RID: 58937
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400E63A RID: 58938
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400E63B RID: 58939
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400E63C RID: 58940
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400E63D RID: 58941
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400E63E RID: 58942
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400E63F RID: 58943
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400E640 RID: 58944
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;
}
