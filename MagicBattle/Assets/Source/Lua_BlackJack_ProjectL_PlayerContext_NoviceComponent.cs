using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020012D4 RID: 4820
[Preserve]
public class Lua_BlackJack_ProjectL_PlayerContext_NoviceComponent : LuaObject
{
	// Token: 0x06019704 RID: 104196 RVA: 0x00753970 File Offset: 0x00751B70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			NoviceComponent o = new NoviceComponent();
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

	// Token: 0x06019705 RID: 104197 RVA: 0x007539B8 File Offset: 0x00751BB8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Init(IntPtr l)
	{
		int result;
		try
		{
			NoviceComponent noviceComponent = (NoviceComponent)LuaObject.checkSelf(l);
			noviceComponent.Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019706 RID: 104198 RVA: 0x00753A04 File Offset: 0x00751C04
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PostInit(IntPtr l)
	{
		int result;
		try
		{
			NoviceComponent noviceComponent = (NoviceComponent)LuaObject.checkSelf(l);
			noviceComponent.PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019707 RID: 104199 RVA: 0x00753A50 File Offset: 0x00751C50
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int DeInit(IntPtr l)
	{
		int result;
		try
		{
			NoviceComponent noviceComponent = (NoviceComponent)LuaObject.checkSelf(l);
			noviceComponent.DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019708 RID: 104200 RVA: 0x00753A9C File Offset: 0x00751C9C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int DeSerialize(IntPtr l)
	{
		int result;
		try
		{
			NoviceComponent noviceComponent = (NoviceComponent)LuaObject.checkSelf(l);
			DSNoviceNtf ntf;
			LuaObject.checkType<DSNoviceNtf>(l, 2, out ntf);
			noviceComponent.DeSerialize(ntf);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019709 RID: 104201 RVA: 0x00753AF4 File Offset: 0x00751CF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetDSVersion(IntPtr l)
	{
		int result;
		try
		{
			NoviceComponent noviceComponent = (NoviceComponent)LuaObject.checkSelf(l);
			ushort dsversion = noviceComponent.GetDSVersion();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dsversion);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601970A RID: 104202 RVA: 0x00753B48 File Offset: 0x00751D48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetName(IntPtr l)
	{
		int result;
		try
		{
			NoviceComponent noviceComponent = (NoviceComponent)LuaObject.checkSelf(l);
			string s = noviceComponent.m_luaExportHelper.__callBase_GetName();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, s);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601970B RID: 104203 RVA: 0x00753BA4 File Offset: 0x00751DA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Init(IntPtr l)
	{
		int result;
		try
		{
			NoviceComponent noviceComponent = (NoviceComponent)LuaObject.checkSelf(l);
			noviceComponent.m_luaExportHelper.__callBase_Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601970C RID: 104204 RVA: 0x00753BF8 File Offset: 0x00751DF8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_PostInit(IntPtr l)
	{
		int result;
		try
		{
			NoviceComponent noviceComponent = (NoviceComponent)LuaObject.checkSelf(l);
			noviceComponent.m_luaExportHelper.__callBase_PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601970D RID: 104205 RVA: 0x00753C4C File Offset: 0x00751E4C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_DeInit(IntPtr l)
	{
		int result;
		try
		{
			NoviceComponent noviceComponent = (NoviceComponent)LuaObject.checkSelf(l);
			noviceComponent.m_luaExportHelper.__callBase_DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601970E RID: 104206 RVA: 0x00753CA0 File Offset: 0x00751EA0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_Tick(IntPtr l)
	{
		int result;
		try
		{
			NoviceComponent noviceComponent = (NoviceComponent)LuaObject.checkSelf(l);
			uint deltaMillisecond;
			LuaObject.checkType(l, 2, out deltaMillisecond);
			noviceComponent.m_luaExportHelper.__callBase_Tick(deltaMillisecond);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601970F RID: 104207 RVA: 0x00753CFC File Offset: 0x00751EFC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_PostDeSerialize(IntPtr l)
	{
		int result;
		try
		{
			NoviceComponent noviceComponent = (NoviceComponent)LuaObject.checkSelf(l);
			noviceComponent.m_luaExportHelper.__callBase_PostDeSerialize();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019710 RID: 104208 RVA: 0x00753D50 File Offset: 0x00751F50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetMissionPoints(IntPtr l)
	{
		int result;
		try
		{
			NoviceComponent noviceComponent = (NoviceComponent)LuaObject.checkSelf(l);
			int i = noviceComponent.m_luaExportHelper.__callBase_GetMissionPoints();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019711 RID: 104209 RVA: 0x00753DAC File Offset: 0x00751FAC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_AddMissionPoints(IntPtr l)
	{
		int result;
		try
		{
			NoviceComponent noviceComponent = (NoviceComponent)LuaObject.checkSelf(l);
			int delta;
			LuaObject.checkType(l, 2, out delta);
			noviceComponent.m_luaExportHelper.__callBase_AddMissionPoints(delta);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019712 RID: 104210 RVA: 0x00753E08 File Offset: 0x00752008
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetRewardClaimedSlots(IntPtr l)
	{
		int result;
		try
		{
			NoviceComponent noviceComponent = (NoviceComponent)LuaObject.checkSelf(l);
			List<int> o = noviceComponent.m_luaExportHelper.__callBase_GetRewardClaimedSlots();
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

	// Token: 0x06019713 RID: 104211 RVA: 0x00753E64 File Offset: 0x00752064
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsRewardClaimed(IntPtr l)
	{
		int result;
		try
		{
			NoviceComponent noviceComponent = (NoviceComponent)LuaObject.checkSelf(l);
			int slot;
			LuaObject.checkType(l, 2, out slot);
			bool b = noviceComponent.m_luaExportHelper.__callBase_IsRewardClaimed(slot);
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

	// Token: 0x06019714 RID: 104212 RVA: 0x00753ECC File Offset: 0x007520CC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_CanClaimReward(IntPtr l)
	{
		int result;
		try
		{
			NoviceComponent noviceComponent = (NoviceComponent)LuaObject.checkSelf(l);
			int slot;
			LuaObject.checkType(l, 2, out slot);
			int i = noviceComponent.m_luaExportHelper.__callBase_CanClaimReward(slot);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019715 RID: 104213 RVA: 0x00753F34 File Offset: 0x00752134
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClaimReward(IntPtr l)
	{
		int result;
		try
		{
			NoviceComponent noviceComponent = (NoviceComponent)LuaObject.checkSelf(l);
			int slot;
			LuaObject.checkType(l, 2, out slot);
			bool noCheck;
			LuaObject.checkType(l, 3, out noCheck);
			int i = noviceComponent.m_luaExportHelper.__callBase_ClaimReward(slot, noCheck);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019716 RID: 104214 RVA: 0x00753FA8 File Offset: 0x007521A8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_GetNovicePointsRewardsConfig(IntPtr l)
	{
		int result;
		try
		{
			NoviceComponent noviceComponent = (NoviceComponent)LuaObject.checkSelf(l);
			List<ConfigDataNoviceRewardInfo> o = noviceComponent.m_luaExportHelper.__callBase_GetNovicePointsRewardsConfig();
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

	// Token: 0x06019717 RID: 104215 RVA: 0x00754004 File Offset: 0x00752204
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetDaysAfterCreation(IntPtr l)
	{
		int result;
		try
		{
			NoviceComponent noviceComponent = (NoviceComponent)LuaObject.checkSelf(l);
			int i = noviceComponent.m_luaExportHelper.__callBase_GetDaysAfterCreation();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019718 RID: 104216 RVA: 0x00754060 File Offset: 0x00752260
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_GetProcessingMissions(IntPtr l)
	{
		int result;
		try
		{
			NoviceComponent noviceComponent = (NoviceComponent)LuaObject.checkSelf(l);
			List<Mission> o = noviceComponent.m_luaExportHelper.__callBase_GetProcessingMissions();
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

	// Token: 0x06019719 RID: 104217 RVA: 0x007540BC File Offset: 0x007522BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetFinishedMissions(IntPtr l)
	{
		int result;
		try
		{
			NoviceComponent noviceComponent = (NoviceComponent)LuaObject.checkSelf(l);
			List<Mission> o = noviceComponent.m_luaExportHelper.__callBase_GetFinishedMissions();
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

	// Token: 0x0601971A RID: 104218 RVA: 0x00754118 File Offset: 0x00752318
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_GetMissionDay(IntPtr l)
	{
		int result;
		try
		{
			NoviceComponent noviceComponent = (NoviceComponent)LuaObject.checkSelf(l);
			ConfigDataMissionInfo mission;
			LuaObject.checkType<ConfigDataMissionInfo>(l, 2, out mission);
			int i = noviceComponent.m_luaExportHelper.__callBase_GetMissionDay(mission);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601971B RID: 104219 RVA: 0x00754180 File Offset: 0x00752380
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetMissions(IntPtr l)
	{
		int result;
		try
		{
			NoviceComponent noviceComponent = (NoviceComponent)LuaObject.checkSelf(l);
			Dictionary<int, List<int>> o = noviceComponent.m_luaExportHelper.__callBase_GetMissions();
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

	// Token: 0x0601971C RID: 104220 RVA: 0x007541DC File Offset: 0x007523DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetMissionsEndTime(IntPtr l)
	{
		int result;
		try
		{
			NoviceComponent noviceComponent = (NoviceComponent)LuaObject.checkSelf(l);
			TimeSpan timeSpan = noviceComponent.m_luaExportHelper.__callBase_GetMissionsEndTime();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, timeSpan);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601971D RID: 104221 RVA: 0x0075423C File Offset: 0x0075243C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.PlayerContext.NoviceComponent");
		if (Lua_BlackJack_ProjectL_PlayerContext_NoviceComponent.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_NoviceComponent.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_NoviceComponent.Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_NoviceComponent.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_PlayerContext_NoviceComponent.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_NoviceComponent.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_NoviceComponent.PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_NoviceComponent.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_PlayerContext_NoviceComponent.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_NoviceComponent.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_NoviceComponent.DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_NoviceComponent.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_PlayerContext_NoviceComponent.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_NoviceComponent.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_NoviceComponent.DeSerialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_NoviceComponent.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_PlayerContext_NoviceComponent.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_NoviceComponent.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_NoviceComponent.GetDSVersion);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_NoviceComponent.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_PlayerContext_NoviceComponent.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_NoviceComponent.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_NoviceComponent.__callBase_GetName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_NoviceComponent.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_PlayerContext_NoviceComponent.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_NoviceComponent.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_NoviceComponent.__callBase_Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_NoviceComponent.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_PlayerContext_NoviceComponent.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_NoviceComponent.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_NoviceComponent.__callBase_PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_NoviceComponent.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_PlayerContext_NoviceComponent.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_NoviceComponent.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_NoviceComponent.__callBase_DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_NoviceComponent.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_PlayerContext_NoviceComponent.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_NoviceComponent.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_NoviceComponent.__callBase_Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_NoviceComponent.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_PlayerContext_NoviceComponent.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_NoviceComponent.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_NoviceComponent.__callBase_PostDeSerialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_NoviceComponent.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_PlayerContext_NoviceComponent.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_NoviceComponent.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_NoviceComponent.__callBase_GetMissionPoints);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_NoviceComponent.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_PlayerContext_NoviceComponent.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_NoviceComponent.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_NoviceComponent.__callBase_AddMissionPoints);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_NoviceComponent.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_PlayerContext_NoviceComponent.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_NoviceComponent.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_NoviceComponent.__callBase_GetRewardClaimedSlots);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_NoviceComponent.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_PlayerContext_NoviceComponent.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_NoviceComponent.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_NoviceComponent.__callBase_IsRewardClaimed);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_NoviceComponent.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_PlayerContext_NoviceComponent.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_NoviceComponent.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_NoviceComponent.__callBase_CanClaimReward);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_NoviceComponent.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_PlayerContext_NoviceComponent.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_NoviceComponent.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_NoviceComponent.__callBase_ClaimReward);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_NoviceComponent.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_PlayerContext_NoviceComponent.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_NoviceComponent.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_NoviceComponent.__callBase_GetNovicePointsRewardsConfig);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_NoviceComponent.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_PlayerContext_NoviceComponent.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_NoviceComponent.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_NoviceComponent.__callBase_GetDaysAfterCreation);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_NoviceComponent.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_PlayerContext_NoviceComponent.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_NoviceComponent.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_NoviceComponent.__callBase_GetProcessingMissions);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_NoviceComponent.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_PlayerContext_NoviceComponent.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_NoviceComponent.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_NoviceComponent.__callBase_GetFinishedMissions);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_NoviceComponent.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_PlayerContext_NoviceComponent.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_NoviceComponent.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_NoviceComponent.__callBase_GetMissionDay);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_NoviceComponent.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_PlayerContext_NoviceComponent.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_NoviceComponent.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_NoviceComponent.__callBase_GetMissions);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_NoviceComponent.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_PlayerContext_NoviceComponent.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_NoviceComponent.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_NoviceComponent.__callBase_GetMissionsEndTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_NoviceComponent.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_PlayerContext_NoviceComponent.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_NoviceComponent.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_NoviceComponent.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_PlayerContext_NoviceComponent.<>f__mg$cache18, typeof(NoviceComponent), typeof(NoviceComponentCommon));
	}

	// Token: 0x0400FB3E RID: 64318
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400FB3F RID: 64319
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400FB40 RID: 64320
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400FB41 RID: 64321
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400FB42 RID: 64322
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400FB43 RID: 64323
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400FB44 RID: 64324
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400FB45 RID: 64325
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400FB46 RID: 64326
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400FB47 RID: 64327
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400FB48 RID: 64328
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400FB49 RID: 64329
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400FB4A RID: 64330
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400FB4B RID: 64331
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400FB4C RID: 64332
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400FB4D RID: 64333
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400FB4E RID: 64334
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400FB4F RID: 64335
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400FB50 RID: 64336
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400FB51 RID: 64337
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400FB52 RID: 64338
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400FB53 RID: 64339
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400FB54 RID: 64340
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400FB55 RID: 64341
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400FB56 RID: 64342
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;
}
