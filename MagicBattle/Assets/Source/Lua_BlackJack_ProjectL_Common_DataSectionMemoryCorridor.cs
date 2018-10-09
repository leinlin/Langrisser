using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001206 RID: 4614
[Preserve]
public class Lua_BlackJack_ProjectL_Common_DataSectionMemoryCorridor : LuaObject
{
	// Token: 0x06017EFB RID: 98043 RVA: 0x0069F5EC File Offset: 0x0069D7EC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			DataSectionMemoryCorridor o = new DataSectionMemoryCorridor();
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

	// Token: 0x06017EFC RID: 98044 RVA: 0x0069F634 File Offset: 0x0069D834
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearInitedData(IntPtr l)
	{
		int result;
		try
		{
			DataSectionMemoryCorridor dataSectionMemoryCorridor = (DataSectionMemoryCorridor)LuaObject.checkSelf(l);
			dataSectionMemoryCorridor.ClearInitedData();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017EFD RID: 98045 RVA: 0x0069F680 File Offset: 0x0069D880
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SerializeToClient(IntPtr l)
	{
		int result;
		try
		{
			DataSectionMemoryCorridor dataSectionMemoryCorridor = (DataSectionMemoryCorridor)LuaObject.checkSelf(l);
			object o = dataSectionMemoryCorridor.SerializeToClient();
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

	// Token: 0x06017EFE RID: 98046 RVA: 0x0069F6D4 File Offset: 0x0069D8D4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int InitFinishedLevels(IntPtr l)
	{
		int result;
		try
		{
			DataSectionMemoryCorridor dataSectionMemoryCorridor = (DataSectionMemoryCorridor)LuaObject.checkSelf(l);
			List<int> levels;
			LuaObject.checkType<List<int>>(l, 2, out levels);
			dataSectionMemoryCorridor.InitFinishedLevels(levels);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017EFF RID: 98047 RVA: 0x0069F72C File Offset: 0x0069D92C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsLevelFinished(IntPtr l)
	{
		int result;
		try
		{
			DataSectionMemoryCorridor dataSectionMemoryCorridor = (DataSectionMemoryCorridor)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			bool b = dataSectionMemoryCorridor.IsLevelFinished(levelId);
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

	// Token: 0x06017F00 RID: 98048 RVA: 0x0069F790 File Offset: 0x0069D990
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddFinishedLevel(IntPtr l)
	{
		int result;
		try
		{
			DataSectionMemoryCorridor dataSectionMemoryCorridor = (DataSectionMemoryCorridor)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			dataSectionMemoryCorridor.AddFinishedLevel(levelId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F01 RID: 98049 RVA: 0x0069F7E8 File Offset: 0x0069D9E8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetAllFinishedLevels(IntPtr l)
	{
		int result;
		try
		{
			DataSectionMemoryCorridor dataSectionMemoryCorridor = (DataSectionMemoryCorridor)LuaObject.checkSelf(l);
			HashSet<int> allFinishedLevels = dataSectionMemoryCorridor.GetAllFinishedLevels();
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

	// Token: 0x06017F02 RID: 98050 RVA: 0x0069F83C File Offset: 0x0069DA3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitChallengedNums(IntPtr l)
	{
		int result;
		try
		{
			DataSectionMemoryCorridor dataSectionMemoryCorridor = (DataSectionMemoryCorridor)LuaObject.checkSelf(l);
			int nums;
			LuaObject.checkType(l, 2, out nums);
			dataSectionMemoryCorridor.InitChallengedNums(nums);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F03 RID: 98051 RVA: 0x0069F894 File Offset: 0x0069DA94
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetChallengedNums(IntPtr l)
	{
		int result;
		try
		{
			DataSectionMemoryCorridor dataSectionMemoryCorridor = (DataSectionMemoryCorridor)LuaObject.checkSelf(l);
			int challengedNums;
			LuaObject.checkType(l, 2, out challengedNums);
			dataSectionMemoryCorridor.SetChallengedNums(challengedNums);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F04 RID: 98052 RVA: 0x0069F8EC File Offset: 0x0069DAEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddChallengedNums(IntPtr l)
	{
		int result;
		try
		{
			DataSectionMemoryCorridor dataSectionMemoryCorridor = (DataSectionMemoryCorridor)LuaObject.checkSelf(l);
			int nums;
			LuaObject.checkType(l, 2, out nums);
			dataSectionMemoryCorridor.AddChallengedNums(nums);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F05 RID: 98053 RVA: 0x0069F944 File Offset: 0x0069DB44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ChallengedNums(IntPtr l)
	{
		int result;
		try
		{
			DataSectionMemoryCorridor dataSectionMemoryCorridor = (DataSectionMemoryCorridor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionMemoryCorridor.ChallengedNums);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F06 RID: 98054 RVA: 0x0069F998 File Offset: 0x0069DB98
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.DataSectionMemoryCorridor");
		if (Lua_BlackJack_ProjectL_Common_DataSectionMemoryCorridor.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionMemoryCorridor.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionMemoryCorridor.ClearInitedData);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionMemoryCorridor.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_DataSectionMemoryCorridor.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionMemoryCorridor.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionMemoryCorridor.SerializeToClient);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionMemoryCorridor.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_DataSectionMemoryCorridor.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionMemoryCorridor.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionMemoryCorridor.InitFinishedLevels);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionMemoryCorridor.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_DataSectionMemoryCorridor.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionMemoryCorridor.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionMemoryCorridor.IsLevelFinished);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionMemoryCorridor.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Common_DataSectionMemoryCorridor.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionMemoryCorridor.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionMemoryCorridor.AddFinishedLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionMemoryCorridor.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Common_DataSectionMemoryCorridor.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionMemoryCorridor.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionMemoryCorridor.GetAllFinishedLevels);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionMemoryCorridor.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Common_DataSectionMemoryCorridor.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionMemoryCorridor.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionMemoryCorridor.InitChallengedNums);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionMemoryCorridor.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_Common_DataSectionMemoryCorridor.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionMemoryCorridor.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionMemoryCorridor.SetChallengedNums);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionMemoryCorridor.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_Common_DataSectionMemoryCorridor.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionMemoryCorridor.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionMemoryCorridor.AddChallengedNums);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionMemoryCorridor.<>f__mg$cache8);
		string name = "ChallengedNums";
		if (Lua_BlackJack_ProjectL_Common_DataSectionMemoryCorridor.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionMemoryCorridor.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionMemoryCorridor.get_ChallengedNums);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_ProjectL_Common_DataSectionMemoryCorridor.<>f__mg$cache9, null, true);
		if (Lua_BlackJack_ProjectL_Common_DataSectionMemoryCorridor.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionMemoryCorridor.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionMemoryCorridor.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_DataSectionMemoryCorridor.<>f__mg$cacheA, typeof(DataSectionMemoryCorridor), typeof(DataSection));
	}

	// Token: 0x0400E4D1 RID: 58577
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E4D2 RID: 58578
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E4D3 RID: 58579
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400E4D4 RID: 58580
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400E4D5 RID: 58581
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400E4D6 RID: 58582
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400E4D7 RID: 58583
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400E4D8 RID: 58584
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400E4D9 RID: 58585
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400E4DA RID: 58586
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400E4DB RID: 58587
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;
}
