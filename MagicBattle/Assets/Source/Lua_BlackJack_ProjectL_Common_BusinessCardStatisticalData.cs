using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020011D8 RID: 4568
[Preserve]
public class Lua_BlackJack_ProjectL_Common_BusinessCardStatisticalData : LuaObject
{
	// Token: 0x06017B2E RID: 97070 RVA: 0x006843D4 File Offset: 0x006825D4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardStatisticalData o = new BusinessCardStatisticalData();
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

	// Token: 0x06017B2F RID: 97071 RVA: 0x0068441C File Offset: 0x0068261C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ToProtocol_s(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardStatisticalData data;
			LuaObject.checkType<BusinessCardStatisticalData>(l, 1, out data);
			ProBusinessCardStatisticalData o = BusinessCardStatisticalData.ToProtocol(data);
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

	// Token: 0x06017B30 RID: 97072 RVA: 0x00684470 File Offset: 0x00682670
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FromProtocol_s(IntPtr l)
	{
		int result;
		try
		{
			ProBusinessCardStatisticalData pbData;
			LuaObject.checkType<ProBusinessCardStatisticalData>(l, 1, out pbData);
			BusinessCardStatisticalData o = BusinessCardStatisticalData.FromProtocol(pbData);
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

	// Token: 0x06017B31 RID: 97073 RVA: 0x006844C4 File Offset: 0x006826C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_MostSkilledHeroId(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardStatisticalData businessCardStatisticalData = (BusinessCardStatisticalData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardStatisticalData.MostSkilledHeroId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017B32 RID: 97074 RVA: 0x00684518 File Offset: 0x00682718
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_MostSkilledHeroId(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardStatisticalData businessCardStatisticalData = (BusinessCardStatisticalData)LuaObject.checkSelf(l);
			int mostSkilledHeroId;
			LuaObject.checkType(l, 2, out mostSkilledHeroId);
			businessCardStatisticalData.MostSkilledHeroId = mostSkilledHeroId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017B33 RID: 97075 RVA: 0x00684570 File Offset: 0x00682770
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_HeroTotalPower(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardStatisticalData businessCardStatisticalData = (BusinessCardStatisticalData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardStatisticalData.HeroTotalPower);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017B34 RID: 97076 RVA: 0x006845C4 File Offset: 0x006827C4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_HeroTotalPower(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardStatisticalData businessCardStatisticalData = (BusinessCardStatisticalData)LuaObject.checkSelf(l);
			int heroTotalPower;
			LuaObject.checkType(l, 2, out heroTotalPower);
			businessCardStatisticalData.HeroTotalPower = heroTotalPower;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017B35 RID: 97077 RVA: 0x0068461C File Offset: 0x0068281C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_AchievementMissionNums(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardStatisticalData businessCardStatisticalData = (BusinessCardStatisticalData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardStatisticalData.AchievementMissionNums);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017B36 RID: 97078 RVA: 0x00684670 File Offset: 0x00682870
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_AchievementMissionNums(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardStatisticalData businessCardStatisticalData = (BusinessCardStatisticalData)LuaObject.checkSelf(l);
			int achievementMissionNums;
			LuaObject.checkType(l, 2, out achievementMissionNums);
			businessCardStatisticalData.AchievementMissionNums = achievementMissionNums;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017B37 RID: 97079 RVA: 0x006846C8 File Offset: 0x006828C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_MasterJobNums(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardStatisticalData businessCardStatisticalData = (BusinessCardStatisticalData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardStatisticalData.MasterJobNums);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017B38 RID: 97080 RVA: 0x0068471C File Offset: 0x0068291C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_MasterJobNums(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardStatisticalData businessCardStatisticalData = (BusinessCardStatisticalData)LuaObject.checkSelf(l);
			int masterJobNums;
			LuaObject.checkType(l, 2, out masterJobNums);
			businessCardStatisticalData.MasterJobNums = masterJobNums;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017B39 RID: 97081 RVA: 0x00684774 File Offset: 0x00682974
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_RiftAchievementNums(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardStatisticalData businessCardStatisticalData = (BusinessCardStatisticalData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardStatisticalData.RiftAchievementNums);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017B3A RID: 97082 RVA: 0x006847C8 File Offset: 0x006829C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_RiftAchievementNums(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardStatisticalData businessCardStatisticalData = (BusinessCardStatisticalData)LuaObject.checkSelf(l);
			int riftAchievementNums;
			LuaObject.checkType(l, 2, out riftAchievementNums);
			businessCardStatisticalData.RiftAchievementNums = riftAchievementNums;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017B3B RID: 97083 RVA: 0x00684820 File Offset: 0x00682A20
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ChooseLevelAchievementNums(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardStatisticalData businessCardStatisticalData = (BusinessCardStatisticalData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCardStatisticalData.ChooseLevelAchievementNums);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017B3C RID: 97084 RVA: 0x00684874 File Offset: 0x00682A74
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_ChooseLevelAchievementNums(IntPtr l)
	{
		int result;
		try
		{
			BusinessCardStatisticalData businessCardStatisticalData = (BusinessCardStatisticalData)LuaObject.checkSelf(l);
			int chooseLevelAchievementNums;
			LuaObject.checkType(l, 2, out chooseLevelAchievementNums);
			businessCardStatisticalData.ChooseLevelAchievementNums = chooseLevelAchievementNums;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017B3D RID: 97085 RVA: 0x006848CC File Offset: 0x00682ACC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.BusinessCardStatisticalData");
		if (Lua_BlackJack_ProjectL_Common_BusinessCardStatisticalData.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_BusinessCardStatisticalData.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BusinessCardStatisticalData.ToProtocol_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BusinessCardStatisticalData.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_BusinessCardStatisticalData.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_BusinessCardStatisticalData.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BusinessCardStatisticalData.FromProtocol_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BusinessCardStatisticalData.<>f__mg$cache1);
		string name = "MostSkilledHeroId";
		if (Lua_BlackJack_ProjectL_Common_BusinessCardStatisticalData.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_BusinessCardStatisticalData.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BusinessCardStatisticalData.get_MostSkilledHeroId);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_BusinessCardStatisticalData.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Common_BusinessCardStatisticalData.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_BusinessCardStatisticalData.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BusinessCardStatisticalData.set_MostSkilledHeroId);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_BusinessCardStatisticalData.<>f__mg$cache3, true);
		string name2 = "HeroTotalPower";
		if (Lua_BlackJack_ProjectL_Common_BusinessCardStatisticalData.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_BusinessCardStatisticalData.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BusinessCardStatisticalData.get_HeroTotalPower);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_BusinessCardStatisticalData.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Common_BusinessCardStatisticalData.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_BusinessCardStatisticalData.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BusinessCardStatisticalData.set_HeroTotalPower);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_BusinessCardStatisticalData.<>f__mg$cache5, true);
		string name3 = "AchievementMissionNums";
		if (Lua_BlackJack_ProjectL_Common_BusinessCardStatisticalData.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_BusinessCardStatisticalData.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BusinessCardStatisticalData.get_AchievementMissionNums);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_BusinessCardStatisticalData.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_Common_BusinessCardStatisticalData.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_BusinessCardStatisticalData.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BusinessCardStatisticalData.set_AchievementMissionNums);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_BusinessCardStatisticalData.<>f__mg$cache7, true);
		string name4 = "MasterJobNums";
		if (Lua_BlackJack_ProjectL_Common_BusinessCardStatisticalData.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_BusinessCardStatisticalData.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BusinessCardStatisticalData.get_MasterJobNums);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Common_BusinessCardStatisticalData.<>f__mg$cache8;
		if (Lua_BlackJack_ProjectL_Common_BusinessCardStatisticalData.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_BusinessCardStatisticalData.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BusinessCardStatisticalData.set_MasterJobNums);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Common_BusinessCardStatisticalData.<>f__mg$cache9, true);
		string name5 = "RiftAchievementNums";
		if (Lua_BlackJack_ProjectL_Common_BusinessCardStatisticalData.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_BusinessCardStatisticalData.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BusinessCardStatisticalData.get_RiftAchievementNums);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Common_BusinessCardStatisticalData.<>f__mg$cacheA;
		if (Lua_BlackJack_ProjectL_Common_BusinessCardStatisticalData.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_BusinessCardStatisticalData.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BusinessCardStatisticalData.set_RiftAchievementNums);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Common_BusinessCardStatisticalData.<>f__mg$cacheB, true);
		string name6 = "ChooseLevelAchievementNums";
		if (Lua_BlackJack_ProjectL_Common_BusinessCardStatisticalData.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_BusinessCardStatisticalData.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BusinessCardStatisticalData.get_ChooseLevelAchievementNums);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Common_BusinessCardStatisticalData.<>f__mg$cacheC;
		if (Lua_BlackJack_ProjectL_Common_BusinessCardStatisticalData.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Common_BusinessCardStatisticalData.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BusinessCardStatisticalData.set_ChooseLevelAchievementNums);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Common_BusinessCardStatisticalData.<>f__mg$cacheD, true);
		if (Lua_BlackJack_ProjectL_Common_BusinessCardStatisticalData.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Common_BusinessCardStatisticalData.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BusinessCardStatisticalData.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_BusinessCardStatisticalData.<>f__mg$cacheE, typeof(BusinessCardStatisticalData));
	}

	// Token: 0x0400E160 RID: 57696
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E161 RID: 57697
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E162 RID: 57698
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400E163 RID: 57699
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400E164 RID: 57700
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400E165 RID: 57701
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400E166 RID: 57702
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400E167 RID: 57703
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400E168 RID: 57704
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400E169 RID: 57705
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400E16A RID: 57706
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400E16B RID: 57707
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400E16C RID: 57708
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400E16D RID: 57709
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400E16E RID: 57710
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;
}
