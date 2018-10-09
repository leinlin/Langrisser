using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001242 RID: 4674
[Preserve]
public class Lua_BlackJack_ProjectL_Common_HeroJob : LuaObject
{
	// Token: 0x06018495 RID: 99477 RVA: 0x006C8F1C File Offset: 0x006C711C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 1)
			{
				HeroJob o = new HeroJob();
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (num == 2)
			{
				HeroJob other;
				LuaObject.checkType<HeroJob>(l, 2, out other);
				HeroJob o = new HeroJob(other);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else
			{
				result = LuaObject.error(l, "New object failed.");
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018496 RID: 99478 RVA: 0x006C8FB4 File Offset: 0x006C71B4
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
				HeroJob heroJob = (HeroJob)LuaObject.checkSelf(l);
				bool b = heroJob.IsLevelMax();
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b);
				result = 2;
			}
			else if (num == 2)
			{
				HeroJob heroJob2 = (HeroJob)LuaObject.checkSelf(l);
				int jobLevel;
				LuaObject.checkType(l, 2, out jobLevel);
				bool b2 = heroJob2.IsLevelMax(jobLevel);
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

	// Token: 0x06018497 RID: 99479 RVA: 0x006C9070 File Offset: 0x006C7270
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetModelSkinResourceInfo(IntPtr l)
	{
		int result;
		try
		{
			HeroJob heroJob = (HeroJob)LuaObject.checkSelf(l);
			ConfigDataModelSkinResourceInfo modelSkinResourceInfo = heroJob.GetModelSkinResourceInfo();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, modelSkinResourceInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018498 RID: 99480 RVA: 0x006C90C4 File Offset: 0x006C72C4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int HeroJobToPBHeroJob_s(IntPtr l)
	{
		int result;
		try
		{
			HeroJob heroJob;
			LuaObject.checkType<HeroJob>(l, 1, out heroJob);
			ProHeroJob o = HeroJob.HeroJobToPBHeroJob(heroJob);
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

	// Token: 0x06018499 RID: 99481 RVA: 0x006C9118 File Offset: 0x006C7318
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PbHeroJobToHeroJob_s(IntPtr l)
	{
		int result;
		try
		{
			ProHeroJob pbHeroJob;
			LuaObject.checkType<ProHeroJob>(l, 1, out pbHeroJob);
			HeroJob o = HeroJob.PbHeroJobToHeroJob(pbHeroJob);
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

	// Token: 0x0601849A RID: 99482 RVA: 0x006C916C File Offset: 0x006C736C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Achievements(IntPtr l)
	{
		int result;
		try
		{
			HeroJob heroJob = (HeroJob)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJob.Achievements);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601849B RID: 99483 RVA: 0x006C91C0 File Offset: 0x006C73C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Achievements(IntPtr l)
	{
		int result;
		try
		{
			HeroJob heroJob = (HeroJob)LuaObject.checkSelf(l);
			HashSet<int> achievements;
			LuaObject.checkType<HashSet<int>>(l, 2, out achievements);
			heroJob.Achievements = achievements;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601849C RID: 99484 RVA: 0x006C9218 File Offset: 0x006C7418
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_JobRelatedId(IntPtr l)
	{
		int result;
		try
		{
			HeroJob heroJob = (HeroJob)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJob.JobRelatedId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601849D RID: 99485 RVA: 0x006C926C File Offset: 0x006C746C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_JobRelatedId(IntPtr l)
	{
		int result;
		try
		{
			HeroJob heroJob = (HeroJob)LuaObject.checkSelf(l);
			int jobRelatedId;
			LuaObject.checkType(l, 2, out jobRelatedId);
			heroJob.JobRelatedId = jobRelatedId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601849E RID: 99486 RVA: 0x006C92C4 File Offset: 0x006C74C4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_JobLevel(IntPtr l)
	{
		int result;
		try
		{
			HeroJob heroJob = (HeroJob)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJob.JobLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601849F RID: 99487 RVA: 0x006C9318 File Offset: 0x006C7518
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_JobLevel(IntPtr l)
	{
		int result;
		try
		{
			HeroJob heroJob = (HeroJob)LuaObject.checkSelf(l);
			int jobLevel;
			LuaObject.checkType(l, 2, out jobLevel);
			heroJob.JobLevel = jobLevel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060184A0 RID: 99488 RVA: 0x006C9370 File Offset: 0x006C7570
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ModelSkinId(IntPtr l)
	{
		int result;
		try
		{
			HeroJob heroJob = (HeroJob)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJob.ModelSkinId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060184A1 RID: 99489 RVA: 0x006C93C4 File Offset: 0x006C75C4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_ModelSkinId(IntPtr l)
	{
		int result;
		try
		{
			HeroJob heroJob = (HeroJob)LuaObject.checkSelf(l);
			int modelSkinId;
			LuaObject.checkType(l, 2, out modelSkinId);
			heroJob.ModelSkinId = modelSkinId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060184A2 RID: 99490 RVA: 0x006C941C File Offset: 0x006C761C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_JobConnectionInfo(IntPtr l)
	{
		int result;
		try
		{
			HeroJob heroJob = (HeroJob)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroJob.JobConnectionInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060184A3 RID: 99491 RVA: 0x006C9470 File Offset: 0x006C7670
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.HeroJob");
		if (Lua_BlackJack_ProjectL_Common_HeroJob.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroJob.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroJob.IsLevelMax);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroJob.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_HeroJob.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroJob.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroJob.GetModelSkinResourceInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroJob.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_HeroJob.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroJob.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroJob.HeroJobToPBHeroJob_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroJob.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_HeroJob.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroJob.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroJob.PbHeroJobToHeroJob_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroJob.<>f__mg$cache3);
		string name = "Achievements";
		if (Lua_BlackJack_ProjectL_Common_HeroJob.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroJob.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroJob.get_Achievements);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_HeroJob.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Common_HeroJob.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroJob.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroJob.set_Achievements);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_HeroJob.<>f__mg$cache5, true);
		string name2 = "JobRelatedId";
		if (Lua_BlackJack_ProjectL_Common_HeroJob.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroJob.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroJob.get_JobRelatedId);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_HeroJob.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_Common_HeroJob.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroJob.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroJob.set_JobRelatedId);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_HeroJob.<>f__mg$cache7, true);
		string name3 = "JobLevel";
		if (Lua_BlackJack_ProjectL_Common_HeroJob.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroJob.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroJob.get_JobLevel);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_HeroJob.<>f__mg$cache8;
		if (Lua_BlackJack_ProjectL_Common_HeroJob.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroJob.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroJob.set_JobLevel);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_HeroJob.<>f__mg$cache9, true);
		string name4 = "ModelSkinId";
		if (Lua_BlackJack_ProjectL_Common_HeroJob.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroJob.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroJob.get_ModelSkinId);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Common_HeroJob.<>f__mg$cacheA;
		if (Lua_BlackJack_ProjectL_Common_HeroJob.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroJob.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroJob.set_ModelSkinId);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Common_HeroJob.<>f__mg$cacheB, true);
		string name5 = "JobConnectionInfo";
		if (Lua_BlackJack_ProjectL_Common_HeroJob.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroJob.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroJob.get_JobConnectionInfo);
		}
		LuaObject.addMember(l, name5, Lua_BlackJack_ProjectL_Common_HeroJob.<>f__mg$cacheC, null, true);
		if (Lua_BlackJack_ProjectL_Common_HeroJob.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroJob.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroJob.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_HeroJob.<>f__mg$cacheD, typeof(HeroJob));
	}

	// Token: 0x0400E9F3 RID: 59891
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E9F4 RID: 59892
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E9F5 RID: 59893
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400E9F6 RID: 59894
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400E9F7 RID: 59895
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400E9F8 RID: 59896
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400E9F9 RID: 59897
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400E9FA RID: 59898
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400E9FB RID: 59899
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400E9FC RID: 59900
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400E9FD RID: 59901
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400E9FE RID: 59902
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400E9FF RID: 59903
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400EA00 RID: 59904
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;
}
