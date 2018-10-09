using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020011CD RID: 4557
[Preserve]
public class Lua_BlackJack_ProjectL_Common_BattleHeroJob : LuaObject
{
	// Token: 0x06017A55 RID: 96853 RVA: 0x0067E220 File Offset: 0x0067C420
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			BattleHeroJob o = new BattleHeroJob();
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

	// Token: 0x06017A56 RID: 96854 RVA: 0x0067E268 File Offset: 0x0067C468
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsLevelMax(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 1)
			{
				BattleHeroJob battleHeroJob = (BattleHeroJob)LuaObject.checkSelf(l);
				bool b = battleHeroJob.IsLevelMax();
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b);
				result = 2;
			}
			else if (num == 2)
			{
				BattleHeroJob battleHeroJob2 = (BattleHeroJob)LuaObject.checkSelf(l);
				int jobLevel;
				LuaObject.checkType(l, 2, out jobLevel);
				bool b2 = battleHeroJob2.IsLevelMax(jobLevel);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function IsLevelMax to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A57 RID: 96855 RVA: 0x0067E324 File Offset: 0x0067C524
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BattleHeroJobToHeroJob_s(IntPtr l)
	{
		int result;
		try
		{
			BattleHeroJob battleHeroJob;
			LuaObject.checkType<BattleHeroJob>(l, 1, out battleHeroJob);
			HeroJob o = BattleHeroJob.BattleHeroJobToHeroJob(battleHeroJob);
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

	// Token: 0x06017A58 RID: 96856 RVA: 0x0067E378 File Offset: 0x0067C578
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int HeroJobToBattleHeroJob_s(IntPtr l)
	{
		int result;
		try
		{
			HeroJob heroJob;
			LuaObject.checkType<HeroJob>(l, 1, out heroJob);
			BattleHeroJob o = BattleHeroJob.HeroJobToBattleHeroJob(heroJob);
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

	// Token: 0x06017A59 RID: 96857 RVA: 0x0067E3CC File Offset: 0x0067C5CC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PBBattleHeroJobToBattleHeroJob_s(IntPtr l)
	{
		int result;
		try
		{
			ProBattleHeroJob pbBattleHeroJob;
			LuaObject.checkType<ProBattleHeroJob>(l, 1, out pbBattleHeroJob);
			BattleHeroJob o = BattleHeroJob.PBBattleHeroJobToBattleHeroJob(pbBattleHeroJob);
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

	// Token: 0x06017A5A RID: 96858 RVA: 0x0067E420 File Offset: 0x0067C620
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int BattleHeroJobToPBBattleHeroJob_s(IntPtr l)
	{
		int result;
		try
		{
			BattleHeroJob battleHeroJob;
			LuaObject.checkType<BattleHeroJob>(l, 1, out battleHeroJob);
			ProBattleHeroJob o = BattleHeroJob.BattleHeroJobToPBBattleHeroJob(battleHeroJob);
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

	// Token: 0x06017A5B RID: 96859 RVA: 0x0067E474 File Offset: 0x0067C674
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateJobConnectionInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleHeroJob battleHeroJob = (BattleHeroJob)LuaObject.checkSelf(l);
			battleHeroJob.m_luaExportHelper.UpdateJobConnectionInfo();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A5C RID: 96860 RVA: 0x0067E4C8 File Offset: 0x0067C6C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_jobRelatedId(IntPtr l)
	{
		int result;
		try
		{
			BattleHeroJob battleHeroJob = (BattleHeroJob)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleHeroJob.m_luaExportHelper.m_jobRelatedId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A5D RID: 96861 RVA: 0x0067E520 File Offset: 0x0067C720
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_jobRelatedId(IntPtr l)
	{
		int result;
		try
		{
			BattleHeroJob battleHeroJob = (BattleHeroJob)LuaObject.checkSelf(l);
			int jobRelatedId;
			LuaObject.checkType(l, 2, out jobRelatedId);
			battleHeroJob.m_luaExportHelper.m_jobRelatedId = jobRelatedId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A5E RID: 96862 RVA: 0x0067E57C File Offset: 0x0067C77C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_JobRelatedId(IntPtr l)
	{
		int result;
		try
		{
			BattleHeroJob battleHeroJob = (BattleHeroJob)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleHeroJob.JobRelatedId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A5F RID: 96863 RVA: 0x0067E5D0 File Offset: 0x0067C7D0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_JobRelatedId(IntPtr l)
	{
		int result;
		try
		{
			BattleHeroJob battleHeroJob = (BattleHeroJob)LuaObject.checkSelf(l);
			int jobRelatedId;
			LuaObject.checkType(l, 2, out jobRelatedId);
			battleHeroJob.JobRelatedId = jobRelatedId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A60 RID: 96864 RVA: 0x0067E628 File Offset: 0x0067C828
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_JobLevel(IntPtr l)
	{
		int result;
		try
		{
			BattleHeroJob battleHeroJob = (BattleHeroJob)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleHeroJob.JobLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A61 RID: 96865 RVA: 0x0067E67C File Offset: 0x0067C87C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_JobLevel(IntPtr l)
	{
		int result;
		try
		{
			BattleHeroJob battleHeroJob = (BattleHeroJob)LuaObject.checkSelf(l);
			int jobLevel;
			LuaObject.checkType(l, 2, out jobLevel);
			battleHeroJob.JobLevel = jobLevel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A62 RID: 96866 RVA: 0x0067E6D4 File Offset: 0x0067C8D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_JobConnectionInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleHeroJob battleHeroJob = (BattleHeroJob)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleHeroJob.JobConnectionInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A63 RID: 96867 RVA: 0x0067E728 File Offset: 0x0067C928
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_JobConnectionInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleHeroJob battleHeroJob = (BattleHeroJob)LuaObject.checkSelf(l);
			ConfigDataJobConnectionInfo jobConnectionInfo;
			LuaObject.checkType<ConfigDataJobConnectionInfo>(l, 2, out jobConnectionInfo);
			battleHeroJob.m_luaExportHelper.JobConnectionInfo = jobConnectionInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017A64 RID: 96868 RVA: 0x0067E784 File Offset: 0x0067C984
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.BattleHeroJob");
		if (Lua_BlackJack_ProjectL_Common_BattleHeroJob.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleHeroJob.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleHeroJob.IsLevelMax);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleHeroJob.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_BattleHeroJob.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleHeroJob.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleHeroJob.BattleHeroJobToHeroJob_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleHeroJob.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_BattleHeroJob.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleHeroJob.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleHeroJob.HeroJobToBattleHeroJob_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleHeroJob.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_BattleHeroJob.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleHeroJob.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleHeroJob.PBBattleHeroJobToBattleHeroJob_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleHeroJob.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Common_BattleHeroJob.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleHeroJob.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleHeroJob.BattleHeroJobToPBBattleHeroJob_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleHeroJob.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Common_BattleHeroJob.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleHeroJob.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleHeroJob.UpdateJobConnectionInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleHeroJob.<>f__mg$cache5);
		string name = "m_jobRelatedId";
		if (Lua_BlackJack_ProjectL_Common_BattleHeroJob.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleHeroJob.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleHeroJob.get_m_jobRelatedId);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_BattleHeroJob.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_Common_BattleHeroJob.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleHeroJob.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleHeroJob.set_m_jobRelatedId);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_BattleHeroJob.<>f__mg$cache7, true);
		string name2 = "JobRelatedId";
		if (Lua_BlackJack_ProjectL_Common_BattleHeroJob.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleHeroJob.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleHeroJob.get_JobRelatedId);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_BattleHeroJob.<>f__mg$cache8;
		if (Lua_BlackJack_ProjectL_Common_BattleHeroJob.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleHeroJob.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleHeroJob.set_JobRelatedId);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_BattleHeroJob.<>f__mg$cache9, true);
		string name3 = "JobLevel";
		if (Lua_BlackJack_ProjectL_Common_BattleHeroJob.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleHeroJob.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleHeroJob.get_JobLevel);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_BattleHeroJob.<>f__mg$cacheA;
		if (Lua_BlackJack_ProjectL_Common_BattleHeroJob.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleHeroJob.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleHeroJob.set_JobLevel);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_BattleHeroJob.<>f__mg$cacheB, true);
		string name4 = "JobConnectionInfo";
		if (Lua_BlackJack_ProjectL_Common_BattleHeroJob.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleHeroJob.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleHeroJob.get_JobConnectionInfo);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Common_BattleHeroJob.<>f__mg$cacheC;
		if (Lua_BlackJack_ProjectL_Common_BattleHeroJob.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleHeroJob.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleHeroJob.set_JobConnectionInfo);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Common_BattleHeroJob.<>f__mg$cacheD, true);
		if (Lua_BlackJack_ProjectL_Common_BattleHeroJob.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleHeroJob.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleHeroJob.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_BattleHeroJob.<>f__mg$cacheE, typeof(BattleHeroJob));
	}

	// Token: 0x0400E09D RID: 57501
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E09E RID: 57502
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E09F RID: 57503
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400E0A0 RID: 57504
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400E0A1 RID: 57505
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400E0A2 RID: 57506
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400E0A3 RID: 57507
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400E0A4 RID: 57508
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400E0A5 RID: 57509
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400E0A6 RID: 57510
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400E0A7 RID: 57511
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400E0A8 RID: 57512
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400E0A9 RID: 57513
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400E0AA RID: 57514
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400E0AB RID: 57515
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;
}
