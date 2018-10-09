using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001237 RID: 4663
[Preserve]
public class Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon : LuaObject
{
	// Token: 0x060182F4 RID: 99060 RVA: 0x006BBCB8 File Offset: 0x006B9EB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistantsCompomentCommon o = new HeroAssistantsCompomentCommon();
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

	// Token: 0x060182F5 RID: 99061 RVA: 0x006BBD00 File Offset: 0x006B9F00
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetName(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistantsCompomentCommon heroAssistantsCompomentCommon = (HeroAssistantsCompomentCommon)LuaObject.checkSelf(l);
			string name = heroAssistantsCompomentCommon.GetName();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, name);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060182F6 RID: 99062 RVA: 0x006BBD54 File Offset: 0x006B9F54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Init(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistantsCompomentCommon heroAssistantsCompomentCommon = (HeroAssistantsCompomentCommon)LuaObject.checkSelf(l);
			heroAssistantsCompomentCommon.Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060182F7 RID: 99063 RVA: 0x006BBDA0 File Offset: 0x006B9FA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PostInit(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistantsCompomentCommon heroAssistantsCompomentCommon = (HeroAssistantsCompomentCommon)LuaObject.checkSelf(l);
			heroAssistantsCompomentCommon.PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060182F8 RID: 99064 RVA: 0x006BBDEC File Offset: 0x006B9FEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DeInit(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistantsCompomentCommon heroAssistantsCompomentCommon = (HeroAssistantsCompomentCommon)LuaObject.checkSelf(l);
			heroAssistantsCompomentCommon.DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060182F9 RID: 99065 RVA: 0x006BBE38 File Offset: 0x006BA038
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Tick(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistantsCompomentCommon heroAssistantsCompomentCommon = (HeroAssistantsCompomentCommon)LuaObject.checkSelf(l);
			uint deltaMillisecond;
			LuaObject.checkType(l, 2, out deltaMillisecond);
			heroAssistantsCompomentCommon.Tick(deltaMillisecond);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060182FA RID: 99066 RVA: 0x006BBE90 File Offset: 0x006BA090
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PostDeSerialize(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistantsCompomentCommon heroAssistantsCompomentCommon = (HeroAssistantsCompomentCommon)LuaObject.checkSelf(l);
			heroAssistantsCompomentCommon.PostDeSerialize();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060182FB RID: 99067 RVA: 0x006BBEDC File Offset: 0x006BA0DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsHeroAssigned(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistantsCompomentCommon heroAssistantsCompomentCommon = (HeroAssistantsCompomentCommon)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			bool b = heroAssistantsCompomentCommon.IsHeroAssigned(heroId);
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

	// Token: 0x060182FC RID: 99068 RVA: 0x006BBF40 File Offset: 0x006BA140
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanAssignHero(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistantsCompomentCommon heroAssistantsCompomentCommon = (HeroAssistantsCompomentCommon)LuaObject.checkSelf(l);
			List<int> heroIds;
			LuaObject.checkType<List<int>>(l, 2, out heroIds);
			int taskId;
			LuaObject.checkType(l, 3, out taskId);
			int slot;
			LuaObject.checkType(l, 4, out slot);
			int workSeconds;
			LuaObject.checkType(l, 5, out workSeconds);
			int i = heroAssistantsCompomentCommon.CanAssignHero(heroIds, taskId, slot, workSeconds);
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

	// Token: 0x060182FD RID: 99069 RVA: 0x006BBFC8 File Offset: 0x006BA1C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AssignHero(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistantsCompomentCommon heroAssistantsCompomentCommon = (HeroAssistantsCompomentCommon)LuaObject.checkSelf(l);
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
			int i = heroAssistantsCompomentCommon.AssignHero(heroIds, taskId, slot, workSeconds, noCheck);
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

	// Token: 0x060182FE RID: 99070 RVA: 0x006BC05C File Offset: 0x006BA25C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CanCancelTask(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistantsCompomentCommon heroAssistantsCompomentCommon = (HeroAssistantsCompomentCommon)LuaObject.checkSelf(l);
			int taskId;
			LuaObject.checkType(l, 2, out taskId);
			int slot;
			LuaObject.checkType(l, 3, out slot);
			int i = heroAssistantsCompomentCommon.CanCancelTask(taskId, slot);
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

	// Token: 0x060182FF RID: 99071 RVA: 0x006BC0CC File Offset: 0x006BA2CC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CancelTask(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistantsCompomentCommon heroAssistantsCompomentCommon = (HeroAssistantsCompomentCommon)LuaObject.checkSelf(l);
			int taskId;
			LuaObject.checkType(l, 2, out taskId);
			int slot;
			LuaObject.checkType(l, 3, out slot);
			bool noCheck;
			LuaObject.checkType(l, 4, out noCheck);
			int i = heroAssistantsCompomentCommon.CancelTask(taskId, slot, noCheck);
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

	// Token: 0x06018300 RID: 99072 RVA: 0x006BC148 File Offset: 0x006BA348
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanClaimRewards(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistantsCompomentCommon heroAssistantsCompomentCommon = (HeroAssistantsCompomentCommon)LuaObject.checkSelf(l);
			int taskId;
			LuaObject.checkType(l, 2, out taskId);
			int slot;
			LuaObject.checkType(l, 3, out slot);
			int i = heroAssistantsCompomentCommon.CanClaimRewards(taskId, slot);
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

	// Token: 0x06018301 RID: 99073 RVA: 0x006BC1B8 File Offset: 0x006BA3B8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ClaimRewards(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistantsCompomentCommon heroAssistantsCompomentCommon = (HeroAssistantsCompomentCommon)LuaObject.checkSelf(l);
			int taskId;
			LuaObject.checkType(l, 2, out taskId);
			int slot;
			LuaObject.checkType(l, 3, out slot);
			bool noCheck;
			LuaObject.checkType(l, 4, out noCheck);
			int i = heroAssistantsCompomentCommon.ClaimRewards(taskId, slot, noCheck);
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

	// Token: 0x06018302 RID: 99074 RVA: 0x006BC234 File Offset: 0x006BA434
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetTaskRemainingTime(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistantsCompomentCommon heroAssistantsCompomentCommon = (HeroAssistantsCompomentCommon)LuaObject.checkSelf(l);
			int taskId;
			LuaObject.checkType(l, 2, out taskId);
			int slot;
			LuaObject.checkType(l, 3, out slot);
			TimeSpan taskRemainingTime = heroAssistantsCompomentCommon.GetTaskRemainingTime(taskId, slot);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, taskRemainingTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018303 RID: 99075 RVA: 0x006BC2A8 File Offset: 0x006BA4A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetDropIdByTaskCompleteRate(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistantsCompomentCommon heroAssistantsCompomentCommon = (HeroAssistantsCompomentCommon)LuaObject.checkSelf(l);
			int taskId;
			LuaObject.checkType(l, 2, out taskId);
			int completeRate;
			LuaObject.checkType(l, 3, out completeRate);
			int dropIdByTaskCompleteRate = heroAssistantsCompomentCommon.GetDropIdByTaskCompleteRate(taskId, completeRate);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dropIdByTaskCompleteRate);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018304 RID: 99076 RVA: 0x006BC318 File Offset: 0x006BA518
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetDropCountByTaskWorkSeconds(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistantsCompomentCommon heroAssistantsCompomentCommon = (HeroAssistantsCompomentCommon)LuaObject.checkSelf(l);
			int taskId;
			LuaObject.checkType(l, 2, out taskId);
			int workSeconds;
			LuaObject.checkType(l, 3, out workSeconds);
			int dropCountByTaskWorkSeconds = heroAssistantsCompomentCommon.GetDropCountByTaskWorkSeconds(taskId, workSeconds);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dropCountByTaskWorkSeconds);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018305 RID: 99077 RVA: 0x006BC388 File Offset: 0x006BA588
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_AssignHeroToTaskMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistantsCompomentCommon heroAssistantsCompomentCommon = (HeroAssistantsCompomentCommon)LuaObject.checkSelf(l);
			heroAssistantsCompomentCommon.m_luaExportHelper.__callDele_AssignHeroToTaskMissionEvent();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018306 RID: 99078 RVA: 0x006BC3DC File Offset: 0x006BA5DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_AssignHeroToTaskMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistantsCompomentCommon heroAssistantsCompomentCommon = (HeroAssistantsCompomentCommon)LuaObject.checkSelf(l);
			heroAssistantsCompomentCommon.m_luaExportHelper.__clearDele_AssignHeroToTaskMissionEvent();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018307 RID: 99079 RVA: 0x006BC430 File Offset: 0x006BA630
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get__configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistantsCompomentCommon heroAssistantsCompomentCommon = (HeroAssistantsCompomentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroAssistantsCompomentCommon.m_luaExportHelper._configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018308 RID: 99080 RVA: 0x006BC488 File Offset: 0x006BA688
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set__configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistantsCompomentCommon heroAssistantsCompomentCommon = (HeroAssistantsCompomentCommon)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			heroAssistantsCompomentCommon.m_luaExportHelper._configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018309 RID: 99081 RVA: 0x006BC4E4 File Offset: 0x006BA6E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_changedGoods(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistantsCompomentCommon heroAssistantsCompomentCommon = (HeroAssistantsCompomentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroAssistantsCompomentCommon.m_luaExportHelper.m_changedGoods);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601830A RID: 99082 RVA: 0x006BC53C File Offset: 0x006BA73C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_changedGoods(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistantsCompomentCommon heroAssistantsCompomentCommon = (HeroAssistantsCompomentCommon)LuaObject.checkSelf(l);
			List<BagItemBase> changedGoods;
			LuaObject.checkType<List<BagItemBase>>(l, 2, out changedGoods);
			heroAssistantsCompomentCommon.m_luaExportHelper.m_changedGoods = changedGoods;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601830B RID: 99083 RVA: 0x006BC598 File Offset: 0x006BA798
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroAssistantsDS(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistantsCompomentCommon heroAssistantsCompomentCommon = (HeroAssistantsCompomentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroAssistantsCompomentCommon.m_luaExportHelper.m_heroAssistantsDS);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601830C RID: 99084 RVA: 0x006BC5F0 File Offset: 0x006BA7F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroAssistantsDS(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistantsCompomentCommon heroAssistantsCompomentCommon = (HeroAssistantsCompomentCommon)LuaObject.checkSelf(l);
			DataSectionHeroAssistants heroAssistantsDS;
			LuaObject.checkType<DataSectionHeroAssistants>(l, 2, out heroAssistantsDS);
			heroAssistantsCompomentCommon.m_luaExportHelper.m_heroAssistantsDS = heroAssistantsDS;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601830D RID: 99085 RVA: 0x006BC64C File Offset: 0x006BA84C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_basicInfo(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistantsCompomentCommon heroAssistantsCompomentCommon = (HeroAssistantsCompomentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroAssistantsCompomentCommon.m_luaExportHelper.m_basicInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601830E RID: 99086 RVA: 0x006BC6A4 File Offset: 0x006BA8A4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_basicInfo(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistantsCompomentCommon heroAssistantsCompomentCommon = (HeroAssistantsCompomentCommon)LuaObject.checkSelf(l);
			PlayerBasicInfoComponentCommon basicInfo;
			LuaObject.checkType<PlayerBasicInfoComponentCommon>(l, 2, out basicInfo);
			heroAssistantsCompomentCommon.m_luaExportHelper.m_basicInfo = basicInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601830F RID: 99087 RVA: 0x006BC700 File Offset: 0x006BA900
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battle(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistantsCompomentCommon heroAssistantsCompomentCommon = (HeroAssistantsCompomentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroAssistantsCompomentCommon.m_luaExportHelper.m_battle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018310 RID: 99088 RVA: 0x006BC758 File Offset: 0x006BA958
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battle(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistantsCompomentCommon heroAssistantsCompomentCommon = (HeroAssistantsCompomentCommon)LuaObject.checkSelf(l);
			BattleComponentCommon battle;
			LuaObject.checkType<BattleComponentCommon>(l, 2, out battle);
			heroAssistantsCompomentCommon.m_luaExportHelper.m_battle = battle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018311 RID: 99089 RVA: 0x006BC7B4 File Offset: 0x006BA9B4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_bag(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistantsCompomentCommon heroAssistantsCompomentCommon = (HeroAssistantsCompomentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroAssistantsCompomentCommon.m_luaExportHelper.m_bag);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018312 RID: 99090 RVA: 0x006BC80C File Offset: 0x006BAA0C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_bag(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistantsCompomentCommon heroAssistantsCompomentCommon = (HeroAssistantsCompomentCommon)LuaObject.checkSelf(l);
			BagComponentCommon bag;
			LuaObject.checkType<BagComponentCommon>(l, 2, out bag);
			heroAssistantsCompomentCommon.m_luaExportHelper.m_bag = bag;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018313 RID: 99091 RVA: 0x006BC868 File Offset: 0x006BAA68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_hero(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistantsCompomentCommon heroAssistantsCompomentCommon = (HeroAssistantsCompomentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroAssistantsCompomentCommon.m_luaExportHelper.m_hero);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018314 RID: 99092 RVA: 0x006BC8C0 File Offset: 0x006BAAC0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_hero(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistantsCompomentCommon heroAssistantsCompomentCommon = (HeroAssistantsCompomentCommon)LuaObject.checkSelf(l);
			HeroComponentCommon hero;
			LuaObject.checkType<HeroComponentCommon>(l, 2, out hero);
			heroAssistantsCompomentCommon.m_luaExportHelper.m_hero = hero;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018315 RID: 99093 RVA: 0x006BC91C File Offset: 0x006BAB1C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_rift(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistantsCompomentCommon heroAssistantsCompomentCommon = (HeroAssistantsCompomentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroAssistantsCompomentCommon.m_luaExportHelper.m_rift);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018316 RID: 99094 RVA: 0x006BC974 File Offset: 0x006BAB74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_rift(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistantsCompomentCommon heroAssistantsCompomentCommon = (HeroAssistantsCompomentCommon)LuaObject.checkSelf(l);
			RiftComponentCommon rift;
			LuaObject.checkType<RiftComponentCommon>(l, 2, out rift);
			heroAssistantsCompomentCommon.m_luaExportHelper.m_rift = rift;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018317 RID: 99095 RVA: 0x006BC9D0 File Offset: 0x006BABD0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_AssignHeroToTaskMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistantsCompomentCommon heroAssistantsCompomentCommon = (HeroAssistantsCompomentCommon)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroAssistantsCompomentCommon.AssignHeroToTaskMissionEvent += value;
				}
				else if (num == 2)
				{
					heroAssistantsCompomentCommon.AssignHeroToTaskMissionEvent -= value;
				}
			}
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018318 RID: 99096 RVA: 0x006BCA50 File Offset: 0x006BAC50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Owner(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistantsCompomentCommon heroAssistantsCompomentCommon = (HeroAssistantsCompomentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroAssistantsCompomentCommon.Owner);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018319 RID: 99097 RVA: 0x006BCAA4 File Offset: 0x006BACA4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Owner(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistantsCompomentCommon heroAssistantsCompomentCommon = (HeroAssistantsCompomentCommon)LuaObject.checkSelf(l);
			IComponentOwner owner;
			LuaObject.checkType<IComponentOwner>(l, 2, out owner);
			heroAssistantsCompomentCommon.Owner = owner;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601831A RID: 99098 RVA: 0x006BCAFC File Offset: 0x006BACFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistantsCompomentCommon heroAssistantsCompomentCommon = (HeroAssistantsCompomentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroAssistantsCompomentCommon.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601831B RID: 99099 RVA: 0x006BCB54 File Offset: 0x006BAD54
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			HeroAssistantsCompomentCommon heroAssistantsCompomentCommon = (HeroAssistantsCompomentCommon)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			heroAssistantsCompomentCommon.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601831C RID: 99100 RVA: 0x006BCBB0 File Offset: 0x006BADB0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.HeroAssistantsCompomentCommon");
		if (Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.GetName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.PostDeSerialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.IsHeroAssigned);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.CanAssignHero);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.AssignHero);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.CanCancelTask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.CancelTask);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.CanClaimRewards);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.ClaimRewards);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.GetTaskRemainingTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.GetDropIdByTaskCompleteRate);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.GetDropCountByTaskWorkSeconds);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.__callDele_AssignHeroToTaskMissionEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.__clearDele_AssignHeroToTaskMissionEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cache11);
		string name = "_configDataLoader";
		if (Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.get__configDataLoader);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cache12;
		if (Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.set__configDataLoader);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cache13, true);
		string name2 = "m_changedGoods";
		if (Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.get_m_changedGoods);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cache14;
		if (Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.set_m_changedGoods);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cache15, true);
		string name3 = "m_heroAssistantsDS";
		if (Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.get_m_heroAssistantsDS);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cache16;
		if (Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.set_m_heroAssistantsDS);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cache17, true);
		string name4 = "m_basicInfo";
		if (Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.get_m_basicInfo);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cache18;
		if (Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.set_m_basicInfo);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cache19, true);
		string name5 = "m_battle";
		if (Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.get_m_battle);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cache1A;
		if (Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.set_m_battle);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cache1B, true);
		string name6 = "m_bag";
		if (Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.get_m_bag);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cache1C;
		if (Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.set_m_bag);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cache1D, true);
		string name7 = "m_hero";
		if (Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.get_m_hero);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cache1E;
		if (Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.set_m_hero);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cache1F, true);
		string name8 = "m_rift";
		if (Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.get_m_rift);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cache20;
		if (Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.set_m_rift);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cache21, true);
		string name9 = "AssignHeroToTaskMissionEvent";
		LuaCSFunction get9 = null;
		if (Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.set_AssignHeroToTaskMissionEvent);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cache22, true);
		string name10 = "Owner";
		if (Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.get_Owner);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cache23;
		if (Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.set_Owner);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cache24, true);
		string name11 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.get_m_configDataLoader);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cache25;
		if (Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cache26, true);
		if (Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_HeroAssistantsCompomentCommon.<>f__mg$cache27, typeof(HeroAssistantsCompomentCommon));
	}

	// Token: 0x0400E868 RID: 59496
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E869 RID: 59497
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E86A RID: 59498
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400E86B RID: 59499
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400E86C RID: 59500
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400E86D RID: 59501
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400E86E RID: 59502
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400E86F RID: 59503
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400E870 RID: 59504
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400E871 RID: 59505
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400E872 RID: 59506
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400E873 RID: 59507
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400E874 RID: 59508
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400E875 RID: 59509
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400E876 RID: 59510
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400E877 RID: 59511
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400E878 RID: 59512
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400E879 RID: 59513
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400E87A RID: 59514
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400E87B RID: 59515
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400E87C RID: 59516
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400E87D RID: 59517
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400E87E RID: 59518
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400E87F RID: 59519
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400E880 RID: 59520
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400E881 RID: 59521
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400E882 RID: 59522
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400E883 RID: 59523
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400E884 RID: 59524
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400E885 RID: 59525
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400E886 RID: 59526
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400E887 RID: 59527
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400E888 RID: 59528
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400E889 RID: 59529
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400E88A RID: 59530
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400E88B RID: 59531
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0400E88C RID: 59532
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0400E88D RID: 59533
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0400E88E RID: 59534
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0400E88F RID: 59535
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;
}
