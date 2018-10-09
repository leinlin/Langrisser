using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001217 RID: 4631
[Preserve]
public class Lua_BlackJack_ProjectL_Common_DataSectionTreasureMap : LuaObject
{
	// Token: 0x06018096 RID: 98454 RVA: 0x006AB064 File Offset: 0x006A9264
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			DataSectionTreasureMap o = new DataSectionTreasureMap();
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

	// Token: 0x06018097 RID: 98455 RVA: 0x006AB0AC File Offset: 0x006A92AC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ClearInitedData(IntPtr l)
	{
		int result;
		try
		{
			DataSectionTreasureMap dataSectionTreasureMap = (DataSectionTreasureMap)LuaObject.checkSelf(l);
			dataSectionTreasureMap.ClearInitedData();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018098 RID: 98456 RVA: 0x006AB0F8 File Offset: 0x006A92F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SerializeToClient(IntPtr l)
	{
		int result;
		try
		{
			DataSectionTreasureMap dataSectionTreasureMap = (DataSectionTreasureMap)LuaObject.checkSelf(l);
			object o = dataSectionTreasureMap.SerializeToClient();
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

	// Token: 0x06018099 RID: 98457 RVA: 0x006AB14C File Offset: 0x006A934C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitFinishedLevels(IntPtr l)
	{
		int result;
		try
		{
			DataSectionTreasureMap dataSectionTreasureMap = (DataSectionTreasureMap)LuaObject.checkSelf(l);
			List<int> levels;
			LuaObject.checkType<List<int>>(l, 2, out levels);
			dataSectionTreasureMap.InitFinishedLevels(levels);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601809A RID: 98458 RVA: 0x006AB1A4 File Offset: 0x006A93A4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsLevelFinished(IntPtr l)
	{
		int result;
		try
		{
			DataSectionTreasureMap dataSectionTreasureMap = (DataSectionTreasureMap)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			bool b = dataSectionTreasureMap.IsLevelFinished(levelId);
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

	// Token: 0x0601809B RID: 98459 RVA: 0x006AB208 File Offset: 0x006A9408
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AddFinishedLevel(IntPtr l)
	{
		int result;
		try
		{
			DataSectionTreasureMap dataSectionTreasureMap = (DataSectionTreasureMap)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			dataSectionTreasureMap.AddFinishedLevel(levelId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601809C RID: 98460 RVA: 0x006AB260 File Offset: 0x006A9460
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetAllFinishedLevels(IntPtr l)
	{
		int result;
		try
		{
			DataSectionTreasureMap dataSectionTreasureMap = (DataSectionTreasureMap)LuaObject.checkSelf(l);
			HashSet<int> allFinishedLevels = dataSectionTreasureMap.GetAllFinishedLevels();
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

	// Token: 0x0601809D RID: 98461 RVA: 0x006AB2B4 File Offset: 0x006A94B4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.DataSectionTreasureMap");
		if (Lua_BlackJack_ProjectL_Common_DataSectionTreasureMap.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionTreasureMap.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionTreasureMap.ClearInitedData);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionTreasureMap.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_DataSectionTreasureMap.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionTreasureMap.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionTreasureMap.SerializeToClient);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionTreasureMap.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_DataSectionTreasureMap.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionTreasureMap.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionTreasureMap.InitFinishedLevels);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionTreasureMap.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_DataSectionTreasureMap.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionTreasureMap.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionTreasureMap.IsLevelFinished);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionTreasureMap.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Common_DataSectionTreasureMap.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionTreasureMap.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionTreasureMap.AddFinishedLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionTreasureMap.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Common_DataSectionTreasureMap.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionTreasureMap.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionTreasureMap.GetAllFinishedLevels);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionTreasureMap.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Common_DataSectionTreasureMap.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionTreasureMap.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionTreasureMap.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_DataSectionTreasureMap.<>f__mg$cache6, typeof(DataSectionTreasureMap), typeof(DataSection));
	}

	// Token: 0x0400E64A RID: 58954
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E64B RID: 58955
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E64C RID: 58956
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400E64D RID: 58957
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400E64E RID: 58958
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400E64F RID: 58959
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400E650 RID: 58960
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;
}
