using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001203 RID: 4611
[Preserve]
public class Lua_BlackJack_ProjectL_Common_DataSectionHeroTrainning : LuaObject
{
	// Token: 0x06017EB4 RID: 97972 RVA: 0x0069D600 File Offset: 0x0069B800
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHeroTrainning o = new DataSectionHeroTrainning();
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

	// Token: 0x06017EB5 RID: 97973 RVA: 0x0069D648 File Offset: 0x0069B848
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ClearInitedData(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHeroTrainning dataSectionHeroTrainning = (DataSectionHeroTrainning)LuaObject.checkSelf(l);
			dataSectionHeroTrainning.ClearInitedData();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017EB6 RID: 97974 RVA: 0x0069D694 File Offset: 0x0069B894
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SerializeToClient(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHeroTrainning dataSectionHeroTrainning = (DataSectionHeroTrainning)LuaObject.checkSelf(l);
			object o = dataSectionHeroTrainning.SerializeToClient();
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

	// Token: 0x06017EB7 RID: 97975 RVA: 0x0069D6E8 File Offset: 0x0069B8E8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int InitFinishedLevels(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHeroTrainning dataSectionHeroTrainning = (DataSectionHeroTrainning)LuaObject.checkSelf(l);
			List<int> levels;
			LuaObject.checkType<List<int>>(l, 2, out levels);
			dataSectionHeroTrainning.InitFinishedLevels(levels);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017EB8 RID: 97976 RVA: 0x0069D740 File Offset: 0x0069B940
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsLevelFinished(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHeroTrainning dataSectionHeroTrainning = (DataSectionHeroTrainning)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			bool b = dataSectionHeroTrainning.IsLevelFinished(levelId);
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

	// Token: 0x06017EB9 RID: 97977 RVA: 0x0069D7A4 File Offset: 0x0069B9A4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AddFinishedLevel(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHeroTrainning dataSectionHeroTrainning = (DataSectionHeroTrainning)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			dataSectionHeroTrainning.AddFinishedLevel(levelId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017EBA RID: 97978 RVA: 0x0069D7FC File Offset: 0x0069B9FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetAllFinishedLevels(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHeroTrainning dataSectionHeroTrainning = (DataSectionHeroTrainning)LuaObject.checkSelf(l);
			HashSet<int> allFinishedLevels = dataSectionHeroTrainning.GetAllFinishedLevels();
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

	// Token: 0x06017EBB RID: 97979 RVA: 0x0069D850 File Offset: 0x0069BA50
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int InitChallengedNums(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHeroTrainning dataSectionHeroTrainning = (DataSectionHeroTrainning)LuaObject.checkSelf(l);
			int nums;
			LuaObject.checkType(l, 2, out nums);
			dataSectionHeroTrainning.InitChallengedNums(nums);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017EBC RID: 97980 RVA: 0x0069D8A8 File Offset: 0x0069BAA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetChallengedNums(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHeroTrainning dataSectionHeroTrainning = (DataSectionHeroTrainning)LuaObject.checkSelf(l);
			int challengedNums;
			LuaObject.checkType(l, 2, out challengedNums);
			dataSectionHeroTrainning.SetChallengedNums(challengedNums);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017EBD RID: 97981 RVA: 0x0069D900 File Offset: 0x0069BB00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddChallengedNums(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHeroTrainning dataSectionHeroTrainning = (DataSectionHeroTrainning)LuaObject.checkSelf(l);
			int nums;
			LuaObject.checkType(l, 2, out nums);
			dataSectionHeroTrainning.AddChallengedNums(nums);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017EBE RID: 97982 RVA: 0x0069D958 File Offset: 0x0069BB58
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ChallengedNums(IntPtr l)
	{
		int result;
		try
		{
			DataSectionHeroTrainning dataSectionHeroTrainning = (DataSectionHeroTrainning)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionHeroTrainning.ChallengedNums);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017EBF RID: 97983 RVA: 0x0069D9AC File Offset: 0x0069BBAC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.DataSectionHeroTrainning");
		if (Lua_BlackJack_ProjectL_Common_DataSectionHeroTrainning.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHeroTrainning.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHeroTrainning.ClearInitedData);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionHeroTrainning.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_DataSectionHeroTrainning.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHeroTrainning.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHeroTrainning.SerializeToClient);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionHeroTrainning.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_DataSectionHeroTrainning.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHeroTrainning.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHeroTrainning.InitFinishedLevels);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionHeroTrainning.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_DataSectionHeroTrainning.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHeroTrainning.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHeroTrainning.IsLevelFinished);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionHeroTrainning.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Common_DataSectionHeroTrainning.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHeroTrainning.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHeroTrainning.AddFinishedLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionHeroTrainning.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Common_DataSectionHeroTrainning.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHeroTrainning.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHeroTrainning.GetAllFinishedLevels);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionHeroTrainning.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Common_DataSectionHeroTrainning.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHeroTrainning.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHeroTrainning.InitChallengedNums);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionHeroTrainning.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_Common_DataSectionHeroTrainning.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHeroTrainning.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHeroTrainning.SetChallengedNums);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionHeroTrainning.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_Common_DataSectionHeroTrainning.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHeroTrainning.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHeroTrainning.AddChallengedNums);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionHeroTrainning.<>f__mg$cache8);
		string name = "ChallengedNums";
		if (Lua_BlackJack_ProjectL_Common_DataSectionHeroTrainning.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHeroTrainning.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHeroTrainning.get_ChallengedNums);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_ProjectL_Common_DataSectionHeroTrainning.<>f__mg$cache9, null, true);
		if (Lua_BlackJack_ProjectL_Common_DataSectionHeroTrainning.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionHeroTrainning.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionHeroTrainning.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_DataSectionHeroTrainning.<>f__mg$cacheA, typeof(DataSectionHeroTrainning), typeof(DataSection));
	}

	// Token: 0x0400E490 RID: 58512
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E491 RID: 58513
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E492 RID: 58514
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400E493 RID: 58515
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400E494 RID: 58516
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400E495 RID: 58517
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400E496 RID: 58518
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400E497 RID: 58519
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400E498 RID: 58520
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400E499 RID: 58521
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400E49A RID: 58522
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;
}
