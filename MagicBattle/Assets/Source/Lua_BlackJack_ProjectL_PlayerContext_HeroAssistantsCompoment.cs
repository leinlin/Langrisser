using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020012CA RID: 4810
[Preserve]
public class Lua_BlackJack_ProjectL_PlayerContext_HeroAssistantsCompoment : LuaObject
{
	// Token: 0x06019528 RID: 103720 RVA: 0x007441D0 File Offset: 0x007423D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistantsCompoment o = new HeroAssistantsCompoment();
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

	// Token: 0x06019529 RID: 103721 RVA: 0x00744218 File Offset: 0x00742418
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Init(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistantsCompoment heroAssistantsCompoment = (HeroAssistantsCompoment)LuaObject.checkSelf(l);
			heroAssistantsCompoment.Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601952A RID: 103722 RVA: 0x00744264 File Offset: 0x00742464
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PostInit(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistantsCompoment heroAssistantsCompoment = (HeroAssistantsCompoment)LuaObject.checkSelf(l);
			heroAssistantsCompoment.PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601952B RID: 103723 RVA: 0x007442B0 File Offset: 0x007424B0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int DeInit(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistantsCompoment heroAssistantsCompoment = (HeroAssistantsCompoment)LuaObject.checkSelf(l);
			heroAssistantsCompoment.DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601952C RID: 103724 RVA: 0x007442FC File Offset: 0x007424FC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int DeSerialize(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistantsCompoment heroAssistantsCompoment = (HeroAssistantsCompoment)LuaObject.checkSelf(l);
			DSHeroAssistantNtf ntf;
			LuaObject.checkType<DSHeroAssistantNtf>(l, 2, out ntf);
			heroAssistantsCompoment.DeSerialize(ntf);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601952D RID: 103725 RVA: 0x00744354 File Offset: 0x00742554
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetDSVersion(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistantsCompoment heroAssistantsCompoment = (HeroAssistantsCompoment)LuaObject.checkSelf(l);
			ushort dsversion = heroAssistantsCompoment.GetDSVersion();
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

	// Token: 0x0601952E RID: 103726 RVA: 0x007443A8 File Offset: 0x007425A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetTodayHeroAssistantsTask(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistantsCompoment heroAssistantsCompoment = (HeroAssistantsCompoment)LuaObject.checkSelf(l);
			List<HeroAssistantsTask> todayHeroAssistantsTask = heroAssistantsCompoment.GetTodayHeroAssistantsTask();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, todayHeroAssistantsTask);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601952F RID: 103727 RVA: 0x007443FC File Offset: 0x007425FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetHeroAssistantsTaskByWeekDay(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistantsCompoment heroAssistantsCompoment = (HeroAssistantsCompoment)LuaObject.checkSelf(l);
			int weekDay;
			LuaObject.checkType(l, 2, out weekDay);
			List<HeroAssistantsTask> heroAssistantsTaskByWeekDay = heroAssistantsCompoment.GetHeroAssistantsTaskByWeekDay(weekDay);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroAssistantsTaskByWeekDay);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019530 RID: 103728 RVA: 0x00744460 File Offset: 0x00742660
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetAssignedHeroAssistantsTask(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistantsCompoment heroAssistantsCompoment = (HeroAssistantsCompoment)LuaObject.checkSelf(l);
			List<HeroAssistantsTaskAssignment> assignedHeroAssistantsTask = heroAssistantsCompoment.GetAssignedHeroAssistantsTask();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, assignedHeroAssistantsTask);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019531 RID: 103729 RVA: 0x007444B4 File Offset: 0x007426B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetName(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistantsCompoment heroAssistantsCompoment = (HeroAssistantsCompoment)LuaObject.checkSelf(l);
			string s = heroAssistantsCompoment.m_luaExportHelper.__callBase_GetName();
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

	// Token: 0x06019532 RID: 103730 RVA: 0x00744510 File Offset: 0x00742710
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Init(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistantsCompoment heroAssistantsCompoment = (HeroAssistantsCompoment)LuaObject.checkSelf(l);
			heroAssistantsCompoment.m_luaExportHelper.__callBase_Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019533 RID: 103731 RVA: 0x00744564 File Offset: 0x00742764
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostInit(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistantsCompoment heroAssistantsCompoment = (HeroAssistantsCompoment)LuaObject.checkSelf(l);
			heroAssistantsCompoment.m_luaExportHelper.__callBase_PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019534 RID: 103732 RVA: 0x007445B8 File Offset: 0x007427B8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_DeInit(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistantsCompoment heroAssistantsCompoment = (HeroAssistantsCompoment)LuaObject.checkSelf(l);
			heroAssistantsCompoment.m_luaExportHelper.__callBase_DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019535 RID: 103733 RVA: 0x0074460C File Offset: 0x0074280C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Tick(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistantsCompoment heroAssistantsCompoment = (HeroAssistantsCompoment)LuaObject.checkSelf(l);
			uint deltaMillisecond;
			LuaObject.checkType(l, 2, out deltaMillisecond);
			heroAssistantsCompoment.m_luaExportHelper.__callBase_Tick(deltaMillisecond);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019536 RID: 103734 RVA: 0x00744668 File Offset: 0x00742868
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostDeSerialize(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistantsCompoment heroAssistantsCompoment = (HeroAssistantsCompoment)LuaObject.checkSelf(l);
			heroAssistantsCompoment.m_luaExportHelper.__callBase_PostDeSerialize();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019537 RID: 103735 RVA: 0x007446BC File Offset: 0x007428BC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_IsHeroAssigned(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistantsCompoment heroAssistantsCompoment = (HeroAssistantsCompoment)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			bool b = heroAssistantsCompoment.m_luaExportHelper.__callBase_IsHeroAssigned(heroId);
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

	// Token: 0x06019538 RID: 103736 RVA: 0x00744724 File Offset: 0x00742924
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CanAssignHero(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistantsCompoment heroAssistantsCompoment = (HeroAssistantsCompoment)LuaObject.checkSelf(l);
			List<int> heroIds;
			LuaObject.checkType<List<int>>(l, 2, out heroIds);
			int taskId;
			LuaObject.checkType(l, 3, out taskId);
			int slot;
			LuaObject.checkType(l, 4, out slot);
			int workSeconds;
			LuaObject.checkType(l, 5, out workSeconds);
			int i = heroAssistantsCompoment.m_luaExportHelper.__callBase_CanAssignHero(heroIds, taskId, slot, workSeconds);
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

	// Token: 0x06019539 RID: 103737 RVA: 0x007447B4 File Offset: 0x007429B4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_AssignHero(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistantsCompoment heroAssistantsCompoment = (HeroAssistantsCompoment)LuaObject.checkSelf(l);
			List<int> heroIds;
			LuaObject.checkType<List<int>>(l, 2, out heroIds);
			int taskId;
			LuaObject.checkType(l, 3, out taskId);
			int slot;
			LuaObject.checkType(l, 4, out slot);
			int workSeconds;
			LuaObject.checkType(l, 5, out workSeconds);
			bool noCheck;
			LuaObject.checkType(l, 6, out noCheck);
			int i = heroAssistantsCompoment.m_luaExportHelper.__callBase_AssignHero(heroIds, taskId, slot, workSeconds, noCheck);
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

	// Token: 0x0601953A RID: 103738 RVA: 0x00744850 File Offset: 0x00742A50
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_CanCancelTask(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistantsCompoment heroAssistantsCompoment = (HeroAssistantsCompoment)LuaObject.checkSelf(l);
			int taskId;
			LuaObject.checkType(l, 2, out taskId);
			int slot;
			LuaObject.checkType(l, 3, out slot);
			int i = heroAssistantsCompoment.m_luaExportHelper.__callBase_CanCancelTask(taskId, slot);
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

	// Token: 0x0601953B RID: 103739 RVA: 0x007448C4 File Offset: 0x00742AC4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_CancelTask(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistantsCompoment heroAssistantsCompoment = (HeroAssistantsCompoment)LuaObject.checkSelf(l);
			int taskId;
			LuaObject.checkType(l, 2, out taskId);
			int slot;
			LuaObject.checkType(l, 3, out slot);
			bool noCheck;
			LuaObject.checkType(l, 4, out noCheck);
			int i = heroAssistantsCompoment.m_luaExportHelper.__callBase_CancelTask(taskId, slot, noCheck);
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

	// Token: 0x0601953C RID: 103740 RVA: 0x00744948 File Offset: 0x00742B48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CanClaimRewards(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistantsCompoment heroAssistantsCompoment = (HeroAssistantsCompoment)LuaObject.checkSelf(l);
			int taskId;
			LuaObject.checkType(l, 2, out taskId);
			int slot;
			LuaObject.checkType(l, 3, out slot);
			int i = heroAssistantsCompoment.m_luaExportHelper.__callBase_CanClaimRewards(taskId, slot);
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

	// Token: 0x0601953D RID: 103741 RVA: 0x007449BC File Offset: 0x00742BBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClaimRewards(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistantsCompoment heroAssistantsCompoment = (HeroAssistantsCompoment)LuaObject.checkSelf(l);
			int taskId;
			LuaObject.checkType(l, 2, out taskId);
			int slot;
			LuaObject.checkType(l, 3, out slot);
			bool noCheck;
			LuaObject.checkType(l, 4, out noCheck);
			int i = heroAssistantsCompoment.m_luaExportHelper.__callBase_ClaimRewards(taskId, slot, noCheck);
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

	// Token: 0x0601953E RID: 103742 RVA: 0x00744A40 File Offset: 0x00742C40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetTaskRemainingTime(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistantsCompoment heroAssistantsCompoment = (HeroAssistantsCompoment)LuaObject.checkSelf(l);
			int taskId;
			LuaObject.checkType(l, 2, out taskId);
			int slot;
			LuaObject.checkType(l, 3, out slot);
			TimeSpan timeSpan = heroAssistantsCompoment.m_luaExportHelper.__callBase_GetTaskRemainingTime(taskId, slot);
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

	// Token: 0x0601953F RID: 103743 RVA: 0x00744ABC File Offset: 0x00742CBC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_GetDropIdByTaskCompleteRate(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistantsCompoment heroAssistantsCompoment = (HeroAssistantsCompoment)LuaObject.checkSelf(l);
			int taskId;
			LuaObject.checkType(l, 2, out taskId);
			int completeRate;
			LuaObject.checkType(l, 3, out completeRate);
			int i = heroAssistantsCompoment.m_luaExportHelper.__callBase_GetDropIdByTaskCompleteRate(taskId, completeRate);
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

	// Token: 0x06019540 RID: 103744 RVA: 0x00744B30 File Offset: 0x00742D30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetDropCountByTaskWorkSeconds(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistantsCompoment heroAssistantsCompoment = (HeroAssistantsCompoment)LuaObject.checkSelf(l);
			int taskId;
			LuaObject.checkType(l, 2, out taskId);
			int workSeconds;
			LuaObject.checkType(l, 3, out workSeconds);
			int i = heroAssistantsCompoment.m_luaExportHelper.__callBase_GetDropCountByTaskWorkSeconds(taskId, workSeconds);
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

	// Token: 0x06019541 RID: 103745 RVA: 0x00744BA4 File Offset: 0x00742DA4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.PlayerContext.HeroAssistantsCompoment");
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroAssistantsCompoment.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroAssistantsCompoment.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroAssistantsCompoment.Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroAssistantsCompoment.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroAssistantsCompoment.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroAssistantsCompoment.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroAssistantsCompoment.PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroAssistantsCompoment.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroAssistantsCompoment.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroAssistantsCompoment.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroAssistantsCompoment.DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroAssistantsCompoment.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroAssistantsCompoment.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroAssistantsCompoment.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroAssistantsCompoment.DeSerialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroAssistantsCompoment.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroAssistantsCompoment.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroAssistantsCompoment.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroAssistantsCompoment.GetDSVersion);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroAssistantsCompoment.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroAssistantsCompoment.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroAssistantsCompoment.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroAssistantsCompoment.GetTodayHeroAssistantsTask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroAssistantsCompoment.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroAssistantsCompoment.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroAssistantsCompoment.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroAssistantsCompoment.GetHeroAssistantsTaskByWeekDay);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroAssistantsCompoment.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroAssistantsCompoment.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroAssistantsCompoment.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroAssistantsCompoment.GetAssignedHeroAssistantsTask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroAssistantsCompoment.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroAssistantsCompoment.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroAssistantsCompoment.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroAssistantsCompoment.__callBase_GetName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroAssistantsCompoment.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroAssistantsCompoment.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroAssistantsCompoment.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroAssistantsCompoment.__callBase_Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroAssistantsCompoment.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroAssistantsCompoment.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroAssistantsCompoment.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroAssistantsCompoment.__callBase_PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroAssistantsCompoment.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroAssistantsCompoment.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroAssistantsCompoment.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroAssistantsCompoment.__callBase_DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroAssistantsCompoment.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroAssistantsCompoment.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroAssistantsCompoment.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroAssistantsCompoment.__callBase_Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroAssistantsCompoment.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroAssistantsCompoment.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroAssistantsCompoment.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroAssistantsCompoment.__callBase_PostDeSerialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroAssistantsCompoment.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroAssistantsCompoment.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroAssistantsCompoment.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroAssistantsCompoment.__callBase_IsHeroAssigned);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroAssistantsCompoment.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroAssistantsCompoment.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroAssistantsCompoment.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroAssistantsCompoment.__callBase_CanAssignHero);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroAssistantsCompoment.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroAssistantsCompoment.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroAssistantsCompoment.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroAssistantsCompoment.__callBase_AssignHero);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroAssistantsCompoment.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroAssistantsCompoment.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroAssistantsCompoment.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroAssistantsCompoment.__callBase_CanCancelTask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroAssistantsCompoment.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroAssistantsCompoment.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroAssistantsCompoment.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroAssistantsCompoment.__callBase_CancelTask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroAssistantsCompoment.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroAssistantsCompoment.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroAssistantsCompoment.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroAssistantsCompoment.__callBase_CanClaimRewards);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroAssistantsCompoment.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroAssistantsCompoment.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroAssistantsCompoment.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroAssistantsCompoment.__callBase_ClaimRewards);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroAssistantsCompoment.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroAssistantsCompoment.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroAssistantsCompoment.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroAssistantsCompoment.__callBase_GetTaskRemainingTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroAssistantsCompoment.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroAssistantsCompoment.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroAssistantsCompoment.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroAssistantsCompoment.__callBase_GetDropIdByTaskCompleteRate);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroAssistantsCompoment.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroAssistantsCompoment.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroAssistantsCompoment.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroAssistantsCompoment.__callBase_GetDropCountByTaskWorkSeconds);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_HeroAssistantsCompoment.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_PlayerContext_HeroAssistantsCompoment.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_HeroAssistantsCompoment.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_HeroAssistantsCompoment.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_PlayerContext_HeroAssistantsCompoment.<>f__mg$cache18, typeof(HeroAssistantsCompoment), typeof(HeroAssistantsCompomentCommon));
	}

	// Token: 0x0400F976 RID: 63862
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400F977 RID: 63863
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400F978 RID: 63864
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400F979 RID: 63865
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400F97A RID: 63866
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400F97B RID: 63867
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400F97C RID: 63868
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400F97D RID: 63869
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400F97E RID: 63870
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400F97F RID: 63871
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400F980 RID: 63872
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400F981 RID: 63873
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400F982 RID: 63874
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400F983 RID: 63875
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400F984 RID: 63876
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400F985 RID: 63877
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400F986 RID: 63878
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400F987 RID: 63879
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400F988 RID: 63880
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400F989 RID: 63881
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400F98A RID: 63882
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400F98B RID: 63883
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400F98C RID: 63884
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400F98D RID: 63885
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400F98E RID: 63886
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;
}
