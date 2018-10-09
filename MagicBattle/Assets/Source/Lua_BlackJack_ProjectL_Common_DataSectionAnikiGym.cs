using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020011F2 RID: 4594
[Preserve]
public class Lua_BlackJack_ProjectL_Common_DataSectionAnikiGym : LuaObject
{
	// Token: 0x06017D2E RID: 97582 RVA: 0x006924E4 File Offset: 0x006906E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			DataSectionAnikiGym o = new DataSectionAnikiGym();
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

	// Token: 0x06017D2F RID: 97583 RVA: 0x0069252C File Offset: 0x0069072C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearInitedData(IntPtr l)
	{
		int result;
		try
		{
			DataSectionAnikiGym dataSectionAnikiGym = (DataSectionAnikiGym)LuaObject.checkSelf(l);
			dataSectionAnikiGym.ClearInitedData();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D30 RID: 97584 RVA: 0x00692578 File Offset: 0x00690778
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SerializeToClient(IntPtr l)
	{
		int result;
		try
		{
			DataSectionAnikiGym dataSectionAnikiGym = (DataSectionAnikiGym)LuaObject.checkSelf(l);
			object o = dataSectionAnikiGym.SerializeToClient();
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

	// Token: 0x06017D31 RID: 97585 RVA: 0x006925CC File Offset: 0x006907CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitFinishedLevels(IntPtr l)
	{
		int result;
		try
		{
			DataSectionAnikiGym dataSectionAnikiGym = (DataSectionAnikiGym)LuaObject.checkSelf(l);
			List<int> levels;
			LuaObject.checkType<List<int>>(l, 2, out levels);
			dataSectionAnikiGym.InitFinishedLevels(levels);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D32 RID: 97586 RVA: 0x00692624 File Offset: 0x00690824
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsLevelFinished(IntPtr l)
	{
		int result;
		try
		{
			DataSectionAnikiGym dataSectionAnikiGym = (DataSectionAnikiGym)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			bool b = dataSectionAnikiGym.IsLevelFinished(levelId);
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

	// Token: 0x06017D33 RID: 97587 RVA: 0x00692688 File Offset: 0x00690888
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AddFinishedLevel(IntPtr l)
	{
		int result;
		try
		{
			DataSectionAnikiGym dataSectionAnikiGym = (DataSectionAnikiGym)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			dataSectionAnikiGym.AddFinishedLevel(levelId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D34 RID: 97588 RVA: 0x006926E0 File Offset: 0x006908E0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetAllFinishedLevels(IntPtr l)
	{
		int result;
		try
		{
			DataSectionAnikiGym dataSectionAnikiGym = (DataSectionAnikiGym)LuaObject.checkSelf(l);
			HashSet<int> allFinishedLevels = dataSectionAnikiGym.GetAllFinishedLevels();
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

	// Token: 0x06017D35 RID: 97589 RVA: 0x00692734 File Offset: 0x00690934
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitChallengedNums(IntPtr l)
	{
		int result;
		try
		{
			DataSectionAnikiGym dataSectionAnikiGym = (DataSectionAnikiGym)LuaObject.checkSelf(l);
			int nums;
			LuaObject.checkType(l, 2, out nums);
			dataSectionAnikiGym.InitChallengedNums(nums);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D36 RID: 97590 RVA: 0x0069278C File Offset: 0x0069098C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetChallengedNums(IntPtr l)
	{
		int result;
		try
		{
			DataSectionAnikiGym dataSectionAnikiGym = (DataSectionAnikiGym)LuaObject.checkSelf(l);
			int challengedNums;
			LuaObject.checkType(l, 2, out challengedNums);
			dataSectionAnikiGym.SetChallengedNums(challengedNums);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D37 RID: 97591 RVA: 0x006927E4 File Offset: 0x006909E4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AddChallengedNums(IntPtr l)
	{
		int result;
		try
		{
			DataSectionAnikiGym dataSectionAnikiGym = (DataSectionAnikiGym)LuaObject.checkSelf(l);
			int nums;
			LuaObject.checkType(l, 2, out nums);
			dataSectionAnikiGym.AddChallengedNums(nums);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D38 RID: 97592 RVA: 0x0069283C File Offset: 0x00690A3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ChallengedNums(IntPtr l)
	{
		int result;
		try
		{
			DataSectionAnikiGym dataSectionAnikiGym = (DataSectionAnikiGym)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionAnikiGym.ChallengedNums);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D39 RID: 97593 RVA: 0x00692890 File Offset: 0x00690A90
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.DataSectionAnikiGym");
		if (Lua_BlackJack_ProjectL_Common_DataSectionAnikiGym.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionAnikiGym.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionAnikiGym.ClearInitedData);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionAnikiGym.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_DataSectionAnikiGym.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionAnikiGym.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionAnikiGym.SerializeToClient);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionAnikiGym.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_DataSectionAnikiGym.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionAnikiGym.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionAnikiGym.InitFinishedLevels);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionAnikiGym.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_DataSectionAnikiGym.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionAnikiGym.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionAnikiGym.IsLevelFinished);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionAnikiGym.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Common_DataSectionAnikiGym.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionAnikiGym.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionAnikiGym.AddFinishedLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionAnikiGym.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Common_DataSectionAnikiGym.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionAnikiGym.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionAnikiGym.GetAllFinishedLevels);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionAnikiGym.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Common_DataSectionAnikiGym.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionAnikiGym.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionAnikiGym.InitChallengedNums);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionAnikiGym.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_Common_DataSectionAnikiGym.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionAnikiGym.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionAnikiGym.SetChallengedNums);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionAnikiGym.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_Common_DataSectionAnikiGym.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionAnikiGym.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionAnikiGym.AddChallengedNums);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionAnikiGym.<>f__mg$cache8);
		string name = "ChallengedNums";
		if (Lua_BlackJack_ProjectL_Common_DataSectionAnikiGym.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionAnikiGym.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionAnikiGym.get_ChallengedNums);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_ProjectL_Common_DataSectionAnikiGym.<>f__mg$cache9, null, true);
		if (Lua_BlackJack_ProjectL_Common_DataSectionAnikiGym.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionAnikiGym.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionAnikiGym.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_DataSectionAnikiGym.<>f__mg$cacheA, typeof(DataSectionAnikiGym), typeof(DataSection));
	}

	// Token: 0x0400E32C RID: 58156
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E32D RID: 58157
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E32E RID: 58158
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400E32F RID: 58159
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400E330 RID: 58160
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400E331 RID: 58161
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400E332 RID: 58162
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400E333 RID: 58163
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400E334 RID: 58164
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400E335 RID: 58165
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400E336 RID: 58166
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;
}
