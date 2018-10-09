using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200126E RID: 4718
[Preserve]
public class Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReportPlayerData : LuaObject
{
	// Token: 0x0601894D RID: 100685 RVA: 0x006EC5F0 File Offset: 0x006EA7F0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPBattleReportPlayerData o = new RealTimePVPBattleReportPlayerData();
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

	// Token: 0x0601894E RID: 100686 RVA: 0x006EC638 File Offset: 0x006EA838
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DeepCopy(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPBattleReportPlayerData realTimePVPBattleReportPlayerData = (RealTimePVPBattleReportPlayerData)LuaObject.checkSelf(l);
			RealTimePVPBattleReportPlayerData o = realTimePVPBattleReportPlayerData.DeepCopy();
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

	// Token: 0x0601894F RID: 100687 RVA: 0x006EC68C File Offset: 0x006EA88C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ToPro(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPBattleReportPlayerData data = (RealTimePVPBattleReportPlayerData)LuaObject.checkSelf(l);
			ProRealTimePVPBattleReportPlayerData o = data.ToPro();
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

	// Token: 0x06018950 RID: 100688 RVA: 0x006EC6E0 File Offset: 0x006EA8E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Heroes(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPBattleReportPlayerData realTimePVPBattleReportPlayerData = (RealTimePVPBattleReportPlayerData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, realTimePVPBattleReportPlayerData.Heroes);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018951 RID: 100689 RVA: 0x006EC734 File Offset: 0x006EA934
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Heroes(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPBattleReportPlayerData realTimePVPBattleReportPlayerData = (RealTimePVPBattleReportPlayerData)LuaObject.checkSelf(l);
			List<BattleHero> heroes;
			LuaObject.checkType<List<BattleHero>>(l, 2, out heroes);
			realTimePVPBattleReportPlayerData.Heroes = heroes;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018952 RID: 100690 RVA: 0x006EC78C File Offset: 0x006EA98C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Techs(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPBattleReportPlayerData realTimePVPBattleReportPlayerData = (RealTimePVPBattleReportPlayerData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, realTimePVPBattleReportPlayerData.Techs);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018953 RID: 100691 RVA: 0x006EC7E0 File Offset: 0x006EA9E0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Techs(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPBattleReportPlayerData realTimePVPBattleReportPlayerData = (RealTimePVPBattleReportPlayerData)LuaObject.checkSelf(l);
			List<TrainingTech> techs;
			LuaObject.checkType<List<TrainingTech>>(l, 2, out techs);
			realTimePVPBattleReportPlayerData.Techs = techs;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018954 RID: 100692 RVA: 0x006EC838 File Offset: 0x006EAA38
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ScoreDiff(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPBattleReportPlayerData realTimePVPBattleReportPlayerData = (RealTimePVPBattleReportPlayerData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, realTimePVPBattleReportPlayerData.ScoreDiff);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018955 RID: 100693 RVA: 0x006EC88C File Offset: 0x006EAA8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ScoreDiff(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPBattleReportPlayerData realTimePVPBattleReportPlayerData = (RealTimePVPBattleReportPlayerData)LuaObject.checkSelf(l);
			int scoreDiff;
			LuaObject.checkType(l, 2, out scoreDiff);
			realTimePVPBattleReportPlayerData.ScoreDiff = scoreDiff;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018956 RID: 100694 RVA: 0x006EC8E4 File Offset: 0x006EAAE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UserId(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPBattleReportPlayerData realTimePVPBattleReportPlayerData = (RealTimePVPBattleReportPlayerData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, realTimePVPBattleReportPlayerData.UserId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018957 RID: 100695 RVA: 0x006EC938 File Offset: 0x006EAB38
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_UserId(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPBattleReportPlayerData realTimePVPBattleReportPlayerData = (RealTimePVPBattleReportPlayerData)LuaObject.checkSelf(l);
			string userId;
			LuaObject.checkType(l, 2, out userId);
			realTimePVPBattleReportPlayerData.UserId = userId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018958 RID: 100696 RVA: 0x006EC990 File Offset: 0x006EAB90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Name(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPBattleReportPlayerData realTimePVPBattleReportPlayerData = (RealTimePVPBattleReportPlayerData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, realTimePVPBattleReportPlayerData.Name);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018959 RID: 100697 RVA: 0x006EC9E4 File Offset: 0x006EABE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Name(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPBattleReportPlayerData realTimePVPBattleReportPlayerData = (RealTimePVPBattleReportPlayerData)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			realTimePVPBattleReportPlayerData.Name = name;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601895A RID: 100698 RVA: 0x006ECA3C File Offset: 0x006EAC3C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_HeadIcon(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPBattleReportPlayerData realTimePVPBattleReportPlayerData = (RealTimePVPBattleReportPlayerData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, realTimePVPBattleReportPlayerData.HeadIcon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601895B RID: 100699 RVA: 0x006ECA90 File Offset: 0x006EAC90
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_HeadIcon(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPBattleReportPlayerData realTimePVPBattleReportPlayerData = (RealTimePVPBattleReportPlayerData)LuaObject.checkSelf(l);
			int headIcon;
			LuaObject.checkType(l, 2, out headIcon);
			realTimePVPBattleReportPlayerData.HeadIcon = headIcon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601895C RID: 100700 RVA: 0x006ECAE8 File Offset: 0x006EACE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Level(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPBattleReportPlayerData realTimePVPBattleReportPlayerData = (RealTimePVPBattleReportPlayerData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, realTimePVPBattleReportPlayerData.Level);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601895D RID: 100701 RVA: 0x006ECB3C File Offset: 0x006EAD3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Level(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPBattleReportPlayerData realTimePVPBattleReportPlayerData = (RealTimePVPBattleReportPlayerData)LuaObject.checkSelf(l);
			int level;
			LuaObject.checkType(l, 2, out level);
			realTimePVPBattleReportPlayerData.Level = level;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601895E RID: 100702 RVA: 0x006ECB94 File Offset: 0x006EAD94
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.RealTimePVPBattleReportPlayerData");
		if (Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReportPlayerData.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReportPlayerData.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReportPlayerData.DeepCopy);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReportPlayerData.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReportPlayerData.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReportPlayerData.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReportPlayerData.ToPro);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReportPlayerData.<>f__mg$cache1);
		string name = "Heroes";
		if (Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReportPlayerData.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReportPlayerData.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReportPlayerData.get_Heroes);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReportPlayerData.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReportPlayerData.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReportPlayerData.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReportPlayerData.set_Heroes);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReportPlayerData.<>f__mg$cache3, true);
		string name2 = "Techs";
		if (Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReportPlayerData.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReportPlayerData.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReportPlayerData.get_Techs);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReportPlayerData.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReportPlayerData.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReportPlayerData.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReportPlayerData.set_Techs);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReportPlayerData.<>f__mg$cache5, true);
		string name3 = "ScoreDiff";
		if (Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReportPlayerData.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReportPlayerData.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReportPlayerData.get_ScoreDiff);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReportPlayerData.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReportPlayerData.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReportPlayerData.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReportPlayerData.set_ScoreDiff);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReportPlayerData.<>f__mg$cache7, true);
		string name4 = "UserId";
		if (Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReportPlayerData.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReportPlayerData.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReportPlayerData.get_UserId);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReportPlayerData.<>f__mg$cache8;
		if (Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReportPlayerData.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReportPlayerData.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReportPlayerData.set_UserId);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReportPlayerData.<>f__mg$cache9, true);
		string name5 = "Name";
		if (Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReportPlayerData.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReportPlayerData.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReportPlayerData.get_Name);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReportPlayerData.<>f__mg$cacheA;
		if (Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReportPlayerData.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReportPlayerData.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReportPlayerData.set_Name);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReportPlayerData.<>f__mg$cacheB, true);
		string name6 = "HeadIcon";
		if (Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReportPlayerData.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReportPlayerData.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReportPlayerData.get_HeadIcon);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReportPlayerData.<>f__mg$cacheC;
		if (Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReportPlayerData.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReportPlayerData.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReportPlayerData.set_HeadIcon);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReportPlayerData.<>f__mg$cacheD, true);
		string name7 = "Level";
		if (Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReportPlayerData.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReportPlayerData.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReportPlayerData.get_Level);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReportPlayerData.<>f__mg$cacheE;
		if (Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReportPlayerData.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReportPlayerData.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReportPlayerData.set_Level);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReportPlayerData.<>f__mg$cacheF, true);
		if (Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReportPlayerData.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReportPlayerData.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReportPlayerData.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReportPlayerData.<>f__mg$cache10, typeof(RealTimePVPBattleReportPlayerData));
	}

	// Token: 0x0400EE53 RID: 61011
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400EE54 RID: 61012
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400EE55 RID: 61013
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400EE56 RID: 61014
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400EE57 RID: 61015
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400EE58 RID: 61016
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400EE59 RID: 61017
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400EE5A RID: 61018
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400EE5B RID: 61019
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400EE5C RID: 61020
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400EE5D RID: 61021
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400EE5E RID: 61022
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400EE5F RID: 61023
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400EE60 RID: 61024
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400EE61 RID: 61025
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400EE62 RID: 61026
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400EE63 RID: 61027
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;
}
