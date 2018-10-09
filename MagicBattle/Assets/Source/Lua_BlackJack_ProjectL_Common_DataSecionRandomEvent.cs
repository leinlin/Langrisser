using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020011F0 RID: 4592
[Preserve]
public class Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent : LuaObject
{
	// Token: 0x06017CF9 RID: 97529 RVA: 0x00690D38 File Offset: 0x0068EF38
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			DataSecionRandomEvent o = new DataSecionRandomEvent();
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

	// Token: 0x06017CFA RID: 97530 RVA: 0x00690D80 File Offset: 0x0068EF80
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ClearInitedData(IntPtr l)
	{
		int result;
		try
		{
			DataSecionRandomEvent dataSecionRandomEvent = (DataSecionRandomEvent)LuaObject.checkSelf(l);
			dataSecionRandomEvent.ClearInitedData();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017CFB RID: 97531 RVA: 0x00690DCC File Offset: 0x0068EFCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitDefiniteLevelZone(IntPtr l)
	{
		int result;
		try
		{
			DataSecionRandomEvent dataSecionRandomEvent = (DataSecionRandomEvent)LuaObject.checkSelf(l);
			RandomEventLevelZone zone;
			LuaObject.checkType<RandomEventLevelZone>(l, 2, out zone);
			dataSecionRandomEvent.InitDefiniteLevelZone(zone);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017CFC RID: 97532 RVA: 0x00690E24 File Offset: 0x0068F024
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int InitRandomLevelZone(IntPtr l)
	{
		int result;
		try
		{
			DataSecionRandomEvent dataSecionRandomEvent = (DataSecionRandomEvent)LuaObject.checkSelf(l);
			List<RandomEventLevelZone> zones;
			LuaObject.checkType<List<RandomEventLevelZone>>(l, 2, out zones);
			dataSecionRandomEvent.InitRandomLevelZone(zones);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017CFD RID: 97533 RVA: 0x00690E7C File Offset: 0x0068F07C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int InitGenerateEventTime(IntPtr l)
	{
		int result;
		try
		{
			DataSecionRandomEvent dataSecionRandomEvent = (DataSecionRandomEvent)LuaObject.checkSelf(l);
			List<int> timeList;
			LuaObject.checkType<List<int>>(l, 2, out timeList);
			dataSecionRandomEvent.InitGenerateEventTime(timeList);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017CFE RID: 97534 RVA: 0x00690ED4 File Offset: 0x0068F0D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitGenerateRandomEventTotalCount(IntPtr l)
	{
		int result;
		try
		{
			DataSecionRandomEvent dataSecionRandomEvent = (DataSecionRandomEvent)LuaObject.checkSelf(l);
			int count;
			LuaObject.checkType(l, 2, out count);
			dataSecionRandomEvent.InitGenerateRandomEventTotalCount(count);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017CFF RID: 97535 RVA: 0x00690F2C File Offset: 0x0068F12C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitRandomEventTotalCount(IntPtr l)
	{
		int result;
		try
		{
			DataSecionRandomEvent dataSecionRandomEvent = (DataSecionRandomEvent)LuaObject.checkSelf(l);
			int count;
			LuaObject.checkType(l, 2, out count);
			dataSecionRandomEvent.InitRandomEventTotalCount(count);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D00 RID: 97536 RVA: 0x00690F84 File Offset: 0x0068F184
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetDefiniteEventLevelZone(IntPtr l)
	{
		int result;
		try
		{
			DataSecionRandomEvent dataSecionRandomEvent = (DataSecionRandomEvent)LuaObject.checkSelf(l);
			RandomEventLevelZone definiteEventLevelZone;
			LuaObject.checkType<RandomEventLevelZone>(l, 2, out definiteEventLevelZone);
			dataSecionRandomEvent.SetDefiniteEventLevelZone(definiteEventLevelZone);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D01 RID: 97537 RVA: 0x00690FDC File Offset: 0x0068F1DC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int DefiniteGroupGenerateRandomEvent(IntPtr l)
	{
		int result;
		try
		{
			DataSecionRandomEvent dataSecionRandomEvent = (DataSecionRandomEvent)LuaObject.checkSelf(l);
			int groupId;
			LuaObject.checkType(l, 2, out groupId);
			dataSecionRandomEvent.DefiniteGroupGenerateRandomEvent(groupId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D02 RID: 97538 RVA: 0x00691034 File Offset: 0x0068F234
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RandomGroupGenerateRandomEvent(IntPtr l)
	{
		int result;
		try
		{
			DataSecionRandomEvent dataSecionRandomEvent = (DataSecionRandomEvent)LuaObject.checkSelf(l);
			int levelZoneId;
			LuaObject.checkType(l, 2, out levelZoneId);
			int groupId;
			LuaObject.checkType(l, 3, out groupId);
			int maxCount;
			LuaObject.checkType(l, 4, out maxCount);
			dataSecionRandomEvent.RandomGroupGenerateRandomEvent(levelZoneId, groupId, maxCount);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D03 RID: 97539 RVA: 0x006910A8 File Offset: 0x0068F2A8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AddRandomEventLevelZone(IntPtr l)
	{
		int result;
		try
		{
			DataSecionRandomEvent dataSecionRandomEvent = (DataSecionRandomEvent)LuaObject.checkSelf(l);
			int index;
			LuaObject.checkType(l, 2, out index);
			RandomEventLevelZone zone;
			LuaObject.checkType<RandomEventLevelZone>(l, 3, out zone);
			dataSecionRandomEvent.AddRandomEventLevelZone(index, zone);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D04 RID: 97540 RVA: 0x0069110C File Offset: 0x0068F30C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetRandomEventTotalCount(IntPtr l)
	{
		int result;
		try
		{
			DataSecionRandomEvent dataSecionRandomEvent = (DataSecionRandomEvent)LuaObject.checkSelf(l);
			int randomEventTotalCount;
			LuaObject.checkType(l, 2, out randomEventTotalCount);
			dataSecionRandomEvent.SetRandomEventTotalCount(randomEventTotalCount);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D05 RID: 97541 RVA: 0x00691164 File Offset: 0x0068F364
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetRandomEventTimes(IntPtr l)
	{
		int result;
		try
		{
			DataSecionRandomEvent dataSecionRandomEvent = (DataSecionRandomEvent)LuaObject.checkSelf(l);
			List<int> randomEventTimes;
			LuaObject.checkType<List<int>>(l, 2, out randomEventTimes);
			dataSecionRandomEvent.SetRandomEventTimes(randomEventTimes);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D06 RID: 97542 RVA: 0x006911BC File Offset: 0x0068F3BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetNextRandomEventFlushTime(IntPtr l)
	{
		int result;
		try
		{
			DataSecionRandomEvent dataSecionRandomEvent = (DataSecionRandomEvent)LuaObject.checkSelf(l);
			DateTime nextRandomEventFlushTime;
			LuaObject.checkValueType<DateTime>(l, 2, out nextRandomEventFlushTime);
			dataSecionRandomEvent.SetNextRandomEventFlushTime(nextRandomEventFlushTime);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D07 RID: 97543 RVA: 0x00691214 File Offset: 0x0068F414
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetDefiniteEventMaxCount(IntPtr l)
	{
		int result;
		try
		{
			DataSecionRandomEvent dataSecionRandomEvent = (DataSecionRandomEvent)LuaObject.checkSelf(l);
			int definiteEventMaxCount;
			LuaObject.checkType(l, 2, out definiteEventMaxCount);
			dataSecionRandomEvent.SetDefiniteEventMaxCount(definiteEventMaxCount);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D08 RID: 97544 RVA: 0x0069126C File Offset: 0x0068F46C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AddRandomEventCount(IntPtr l)
	{
		int result;
		try
		{
			DataSecionRandomEvent dataSecionRandomEvent = (DataSecionRandomEvent)LuaObject.checkSelf(l);
			int count;
			LuaObject.checkType(l, 2, out count);
			dataSecionRandomEvent.AddRandomEventCount(count);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D09 RID: 97545 RVA: 0x006912C4 File Offset: 0x0068F4C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetDefiniteGroupRandomEventGroups(IntPtr l)
	{
		int result;
		try
		{
			DataSecionRandomEvent dataSecionRandomEvent = (DataSecionRandomEvent)LuaObject.checkSelf(l);
			Dictionary<int, RandomEventGroup> definiteGroupRandomEventGroups = dataSecionRandomEvent.GetDefiniteGroupRandomEventGroups();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, definiteGroupRandomEventGroups);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D0A RID: 97546 RVA: 0x00691318 File Offset: 0x0068F518
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddDefiniteGroupRandomEventGroup(IntPtr l)
	{
		int result;
		try
		{
			DataSecionRandomEvent dataSecionRandomEvent = (DataSecionRandomEvent)LuaObject.checkSelf(l);
			RandomEventGroup newGroup;
			LuaObject.checkType<RandomEventGroup>(l, 2, out newGroup);
			dataSecionRandomEvent.AddDefiniteGroupRandomEventGroup(newGroup);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D0B RID: 97547 RVA: 0x00691370 File Offset: 0x0068F570
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetRandomGroupLevelZoneEventGroups(IntPtr l)
	{
		int result;
		try
		{
			DataSecionRandomEvent dataSecionRandomEvent = (DataSecionRandomEvent)LuaObject.checkSelf(l);
			int levelZoneId;
			LuaObject.checkType(l, 2, out levelZoneId);
			Dictionary<int, RandomEventGroup> randomGroupLevelZoneEventGroups = dataSecionRandomEvent.GetRandomGroupLevelZoneEventGroups(levelZoneId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, randomGroupLevelZoneEventGroups);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D0C RID: 97548 RVA: 0x006913D4 File Offset: 0x0068F5D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearRandomInfo(IntPtr l)
	{
		int result;
		try
		{
			DataSecionRandomEvent dataSecionRandomEvent = (DataSecionRandomEvent)LuaObject.checkSelf(l);
			dataSecionRandomEvent.ClearRandomInfo();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D0D RID: 97549 RVA: 0x00691420 File Offset: 0x0068F620
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RemoveRandomEventTime(IntPtr l)
	{
		int result;
		try
		{
			DataSecionRandomEvent dataSecionRandomEvent = (DataSecionRandomEvent)LuaObject.checkSelf(l);
			int time;
			LuaObject.checkType(l, 2, out time);
			dataSecionRandomEvent.RemoveRandomEventTime(time);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D0E RID: 97550 RVA: 0x00691478 File Offset: 0x0068F678
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsCompletedRandomEventGenerate(IntPtr l)
	{
		int result;
		try
		{
			DataSecionRandomEvent dataSecionRandomEvent = (DataSecionRandomEvent)LuaObject.checkSelf(l);
			bool b = dataSecionRandomEvent.IsCompletedRandomEventGenerate();
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

	// Token: 0x06017D0F RID: 97551 RVA: 0x006914CC File Offset: 0x0068F6CC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_RandomEventTotalCount(IntPtr l)
	{
		int result;
		try
		{
			DataSecionRandomEvent dataSecionRandomEvent = (DataSecionRandomEvent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSecionRandomEvent.RandomEventTotalCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D10 RID: 97552 RVA: 0x00691520 File Offset: 0x0068F720
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_RandomEventTotalCount(IntPtr l)
	{
		int result;
		try
		{
			DataSecionRandomEvent dataSecionRandomEvent = (DataSecionRandomEvent)LuaObject.checkSelf(l);
			int randomEventTotalCount;
			LuaObject.checkType(l, 2, out randomEventTotalCount);
			dataSecionRandomEvent.RandomEventTotalCount = randomEventTotalCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D11 RID: 97553 RVA: 0x00691578 File Offset: 0x0068F778
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_GenerateRandomEventTotalCount(IntPtr l)
	{
		int result;
		try
		{
			DataSecionRandomEvent dataSecionRandomEvent = (DataSecionRandomEvent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSecionRandomEvent.GenerateRandomEventTotalCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D12 RID: 97554 RVA: 0x006915CC File Offset: 0x0068F7CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_GenerateRandomEventTotalCount(IntPtr l)
	{
		int result;
		try
		{
			DataSecionRandomEvent dataSecionRandomEvent = (DataSecionRandomEvent)LuaObject.checkSelf(l);
			int generateRandomEventTotalCount;
			LuaObject.checkType(l, 2, out generateRandomEventTotalCount);
			dataSecionRandomEvent.GenerateRandomEventTotalCount = generateRandomEventTotalCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D13 RID: 97555 RVA: 0x00691624 File Offset: 0x0068F824
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_DefiniteEventMaxCount(IntPtr l)
	{
		int result;
		try
		{
			DataSecionRandomEvent dataSecionRandomEvent = (DataSecionRandomEvent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSecionRandomEvent.DefiniteEventMaxCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D14 RID: 97556 RVA: 0x00691678 File Offset: 0x0068F878
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_DefiniteEventMaxCount(IntPtr l)
	{
		int result;
		try
		{
			DataSecionRandomEvent dataSecionRandomEvent = (DataSecionRandomEvent)LuaObject.checkSelf(l);
			int definiteEventMaxCount;
			LuaObject.checkType(l, 2, out definiteEventMaxCount);
			dataSecionRandomEvent.DefiniteEventMaxCount = definiteEventMaxCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D15 RID: 97557 RVA: 0x006916D0 File Offset: 0x0068F8D0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_NextRandomEventFlushTime(IntPtr l)
	{
		int result;
		try
		{
			DataSecionRandomEvent dataSecionRandomEvent = (DataSecionRandomEvent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSecionRandomEvent.NextRandomEventFlushTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D16 RID: 97558 RVA: 0x00691728 File Offset: 0x0068F928
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_NextRandomEventFlushTime(IntPtr l)
	{
		int result;
		try
		{
			DataSecionRandomEvent dataSecionRandomEvent = (DataSecionRandomEvent)LuaObject.checkSelf(l);
			DateTime nextRandomEventFlushTime;
			LuaObject.checkValueType<DateTime>(l, 2, out nextRandomEventFlushTime);
			dataSecionRandomEvent.NextRandomEventFlushTime = nextRandomEventFlushTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D17 RID: 97559 RVA: 0x00691780 File Offset: 0x0068F980
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_DefiniteLevelZone(IntPtr l)
	{
		int result;
		try
		{
			DataSecionRandomEvent dataSecionRandomEvent = (DataSecionRandomEvent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSecionRandomEvent.DefiniteLevelZone);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D18 RID: 97560 RVA: 0x006917D4 File Offset: 0x0068F9D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_DefiniteLevelZone(IntPtr l)
	{
		int result;
		try
		{
			DataSecionRandomEvent dataSecionRandomEvent = (DataSecionRandomEvent)LuaObject.checkSelf(l);
			RandomEventLevelZone definiteLevelZone;
			LuaObject.checkType<RandomEventLevelZone>(l, 2, out definiteLevelZone);
			dataSecionRandomEvent.DefiniteLevelZone = definiteLevelZone;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D19 RID: 97561 RVA: 0x0069182C File Offset: 0x0068FA2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_RandomLevelZone(IntPtr l)
	{
		int result;
		try
		{
			DataSecionRandomEvent dataSecionRandomEvent = (DataSecionRandomEvent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSecionRandomEvent.RandomLevelZone);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D1A RID: 97562 RVA: 0x00691880 File Offset: 0x0068FA80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_RandomLevelZone(IntPtr l)
	{
		int result;
		try
		{
			DataSecionRandomEvent dataSecionRandomEvent = (DataSecionRandomEvent)LuaObject.checkSelf(l);
			Dictionary<int, RandomEventLevelZone> randomLevelZone;
			LuaObject.checkType<Dictionary<int, RandomEventLevelZone>>(l, 2, out randomLevelZone);
			dataSecionRandomEvent.RandomLevelZone = randomLevelZone;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D1B RID: 97563 RVA: 0x006918D8 File Offset: 0x0068FAD8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_RandomEventTimeList(IntPtr l)
	{
		int result;
		try
		{
			DataSecionRandomEvent dataSecionRandomEvent = (DataSecionRandomEvent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSecionRandomEvent.RandomEventTimeList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D1C RID: 97564 RVA: 0x0069192C File Offset: 0x0068FB2C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_RandomEventTimeList(IntPtr l)
	{
		int result;
		try
		{
			DataSecionRandomEvent dataSecionRandomEvent = (DataSecionRandomEvent)LuaObject.checkSelf(l);
			List<int> randomEventTimeList;
			LuaObject.checkType<List<int>>(l, 2, out randomEventTimeList);
			dataSecionRandomEvent.RandomEventTimeList = randomEventTimeList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D1D RID: 97565 RVA: 0x00691984 File Offset: 0x0068FB84
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.DataSecionRandomEvent");
		if (Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.ClearInitedData);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.InitDefiniteLevelZone);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.InitRandomLevelZone);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.InitGenerateEventTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.InitGenerateRandomEventTotalCount);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.InitRandomEventTotalCount);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.SetDefiniteEventLevelZone);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.DefiniteGroupGenerateRandomEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.RandomGroupGenerateRandomEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.AddRandomEventLevelZone);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.SetRandomEventTotalCount);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.SetRandomEventTimes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.SetNextRandomEventFlushTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.SetDefiniteEventMaxCount);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.AddRandomEventCount);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.GetDefiniteGroupRandomEventGroups);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.AddDefiniteGroupRandomEventGroup);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.GetRandomGroupLevelZoneEventGroups);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.ClearRandomInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.RemoveRandomEventTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.IsCompletedRandomEventGenerate);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.<>f__mg$cache14);
		string name = "RandomEventTotalCount";
		if (Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.get_RandomEventTotalCount);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.<>f__mg$cache15;
		if (Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.set_RandomEventTotalCount);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.<>f__mg$cache16, true);
		string name2 = "GenerateRandomEventTotalCount";
		if (Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.get_GenerateRandomEventTotalCount);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.<>f__mg$cache17;
		if (Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.set_GenerateRandomEventTotalCount);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.<>f__mg$cache18, true);
		string name3 = "DefiniteEventMaxCount";
		if (Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.get_DefiniteEventMaxCount);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.<>f__mg$cache19;
		if (Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.set_DefiniteEventMaxCount);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.<>f__mg$cache1A, true);
		string name4 = "NextRandomEventFlushTime";
		if (Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.get_NextRandomEventFlushTime);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.<>f__mg$cache1B;
		if (Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.set_NextRandomEventFlushTime);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.<>f__mg$cache1C, true);
		string name5 = "DefiniteLevelZone";
		if (Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.get_DefiniteLevelZone);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.<>f__mg$cache1D;
		if (Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.set_DefiniteLevelZone);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.<>f__mg$cache1E, true);
		string name6 = "RandomLevelZone";
		if (Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.get_RandomLevelZone);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.<>f__mg$cache1F;
		if (Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.set_RandomLevelZone);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.<>f__mg$cache20, true);
		string name7 = "RandomEventTimeList";
		if (Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.get_RandomEventTimeList);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.<>f__mg$cache21;
		if (Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.set_RandomEventTimeList);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.<>f__mg$cache22, true);
		if (Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_DataSecionRandomEvent.<>f__mg$cache23, typeof(DataSecionRandomEvent), typeof(DataSection));
	}

	// Token: 0x0400E2FB RID: 58107
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E2FC RID: 58108
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E2FD RID: 58109
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400E2FE RID: 58110
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400E2FF RID: 58111
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400E300 RID: 58112
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400E301 RID: 58113
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400E302 RID: 58114
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400E303 RID: 58115
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400E304 RID: 58116
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400E305 RID: 58117
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400E306 RID: 58118
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400E307 RID: 58119
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400E308 RID: 58120
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400E309 RID: 58121
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400E30A RID: 58122
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400E30B RID: 58123
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400E30C RID: 58124
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400E30D RID: 58125
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400E30E RID: 58126
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400E30F RID: 58127
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400E310 RID: 58128
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400E311 RID: 58129
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400E312 RID: 58130
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400E313 RID: 58131
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400E314 RID: 58132
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400E315 RID: 58133
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400E316 RID: 58134
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400E317 RID: 58135
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400E318 RID: 58136
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400E319 RID: 58137
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400E31A RID: 58138
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400E31B RID: 58139
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400E31C RID: 58140
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400E31D RID: 58141
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400E31E RID: 58142
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;
}
