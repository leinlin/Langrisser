using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020011CF RID: 4559
[Preserve]
public class Lua_BlackJack_ProjectL_Common_BattleReport : LuaObject
{
	// Token: 0x06017A75 RID: 96885 RVA: 0x0067F008 File Offset: 0x0067D208
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			BattleReport o = new BattleReport();
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

	// Token: 0x06017A76 RID: 96886 RVA: 0x0067F050 File Offset: 0x0067D250
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Commands(IntPtr l)
	{
		int result;
		try
		{
			BattleReport battleReport = (BattleReport)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleReport.Commands);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A77 RID: 96887 RVA: 0x0067F0A4 File Offset: 0x0067D2A4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Commands(IntPtr l)
	{
		int result;
		try
		{
			BattleReport battleReport = (BattleReport)LuaObject.checkSelf(l);
			List<BattleCommand> commands;
			LuaObject.checkType<List<BattleCommand>>(l, 2, out commands);
			battleReport.Commands = commands;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A78 RID: 96888 RVA: 0x0067F0FC File Offset: 0x0067D2FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Version(IntPtr l)
	{
		int result;
		try
		{
			BattleReport battleReport = (BattleReport)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleReport.Version);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A79 RID: 96889 RVA: 0x0067F150 File Offset: 0x0067D350
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Version(IntPtr l)
	{
		int result;
		try
		{
			BattleReport battleReport = (BattleReport)LuaObject.checkSelf(l);
			int version;
			LuaObject.checkType(l, 2, out version);
			battleReport.Version = version;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A7A RID: 96890 RVA: 0x0067F1A8 File Offset: 0x0067D3A8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_InstanceId(IntPtr l)
	{
		int result;
		try
		{
			BattleReport battleReport = (BattleReport)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleReport.InstanceId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A7B RID: 96891 RVA: 0x0067F1FC File Offset: 0x0067D3FC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_InstanceId(IntPtr l)
	{
		int result;
		try
		{
			BattleReport battleReport = (BattleReport)LuaObject.checkSelf(l);
			ulong instanceId;
			LuaObject.checkType(l, 2, out instanceId);
			battleReport.InstanceId = instanceId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A7C RID: 96892 RVA: 0x0067F254 File Offset: 0x0067D454
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BattleType(IntPtr l)
	{
		int result;
		try
		{
			BattleReport battleReport = (BattleReport)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)battleReport.BattleType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A7D RID: 96893 RVA: 0x0067F2A8 File Offset: 0x0067D4A8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_BattleType(IntPtr l)
	{
		int result;
		try
		{
			BattleReport battleReport = (BattleReport)LuaObject.checkSelf(l);
			BattleType battleType;
			LuaObject.checkEnum<BattleType>(l, 2, out battleType);
			battleReport.BattleType = battleType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A7E RID: 96894 RVA: 0x0067F300 File Offset: 0x0067D500
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BattleId(IntPtr l)
	{
		int result;
		try
		{
			BattleReport battleReport = (BattleReport)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleReport.BattleId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A7F RID: 96895 RVA: 0x0067F354 File Offset: 0x0067D554
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_BattleId(IntPtr l)
	{
		int result;
		try
		{
			BattleReport battleReport = (BattleReport)LuaObject.checkSelf(l);
			int battleId;
			LuaObject.checkType(l, 2, out battleId);
			battleReport.BattleId = battleId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A80 RID: 96896 RVA: 0x0067F3AC File Offset: 0x0067D5AC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_RandomSeed(IntPtr l)
	{
		int result;
		try
		{
			BattleReport battleReport = (BattleReport)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleReport.RandomSeed);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A81 RID: 96897 RVA: 0x0067F400 File Offset: 0x0067D600
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_RandomSeed(IntPtr l)
	{
		int result;
		try
		{
			BattleReport battleReport = (BattleReport)LuaObject.checkSelf(l);
			int randomSeed;
			LuaObject.checkType(l, 2, out randomSeed);
			battleReport.RandomSeed = randomSeed;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A82 RID: 96898 RVA: 0x0067F458 File Offset: 0x0067D658
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.BattleReport");
		string name = "Commands";
		if (Lua_BlackJack_ProjectL_Common_BattleReport.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleReport.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleReport.get_Commands);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_BattleReport.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_Common_BattleReport.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleReport.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleReport.set_Commands);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_BattleReport.<>f__mg$cache1, true);
		string name2 = "Version";
		if (Lua_BlackJack_ProjectL_Common_BattleReport.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleReport.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleReport.get_Version);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_BattleReport.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Common_BattleReport.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleReport.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleReport.set_Version);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_BattleReport.<>f__mg$cache3, true);
		string name3 = "InstanceId";
		if (Lua_BlackJack_ProjectL_Common_BattleReport.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleReport.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleReport.get_InstanceId);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_BattleReport.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Common_BattleReport.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleReport.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleReport.set_InstanceId);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_BattleReport.<>f__mg$cache5, true);
		string name4 = "BattleType";
		if (Lua_BlackJack_ProjectL_Common_BattleReport.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleReport.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleReport.get_BattleType);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Common_BattleReport.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_Common_BattleReport.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleReport.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleReport.set_BattleType);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Common_BattleReport.<>f__mg$cache7, true);
		string name5 = "BattleId";
		if (Lua_BlackJack_ProjectL_Common_BattleReport.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleReport.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleReport.get_BattleId);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Common_BattleReport.<>f__mg$cache8;
		if (Lua_BlackJack_ProjectL_Common_BattleReport.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleReport.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleReport.set_BattleId);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Common_BattleReport.<>f__mg$cache9, true);
		string name6 = "RandomSeed";
		if (Lua_BlackJack_ProjectL_Common_BattleReport.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleReport.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleReport.get_RandomSeed);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Common_BattleReport.<>f__mg$cacheA;
		if (Lua_BlackJack_ProjectL_Common_BattleReport.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleReport.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleReport.set_RandomSeed);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Common_BattleReport.<>f__mg$cacheB, true);
		if (Lua_BlackJack_ProjectL_Common_BattleReport.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleReport.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleReport.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_BattleReport.<>f__mg$cacheC, typeof(BattleReport));
	}

	// Token: 0x0400E0B9 RID: 57529
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E0BA RID: 57530
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E0BB RID: 57531
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400E0BC RID: 57532
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400E0BD RID: 57533
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400E0BE RID: 57534
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400E0BF RID: 57535
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400E0C0 RID: 57536
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400E0C1 RID: 57537
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400E0C2 RID: 57538
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400E0C3 RID: 57539
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400E0C4 RID: 57540
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400E0C5 RID: 57541
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;
}
