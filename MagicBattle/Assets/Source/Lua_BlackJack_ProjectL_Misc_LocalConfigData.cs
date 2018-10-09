using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Misc;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020012A9 RID: 4777
[Preserve]
public class Lua_BlackJack_ProjectL_Misc_LocalConfigData : LuaObject
{
	// Token: 0x060190BB RID: 102587 RVA: 0x00722830 File Offset: 0x00720A30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			LocalConfigData o = new LocalConfigData();
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

	// Token: 0x060190BC RID: 102588 RVA: 0x00722878 File Offset: 0x00720A78
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_MusicOn(IntPtr l)
	{
		int result;
		try
		{
			LocalConfigData localConfigData = (LocalConfigData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, localConfigData.MusicOn);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060190BD RID: 102589 RVA: 0x007228CC File Offset: 0x00720ACC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_MusicOn(IntPtr l)
	{
		int result;
		try
		{
			LocalConfigData localConfigData = (LocalConfigData)LuaObject.checkSelf(l);
			bool musicOn;
			LuaObject.checkType(l, 2, out musicOn);
			localConfigData.MusicOn = musicOn;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060190BE RID: 102590 RVA: 0x00722924 File Offset: 0x00720B24
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_SoundOn(IntPtr l)
	{
		int result;
		try
		{
			LocalConfigData localConfigData = (LocalConfigData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, localConfigData.SoundOn);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060190BF RID: 102591 RVA: 0x00722978 File Offset: 0x00720B78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_SoundOn(IntPtr l)
	{
		int result;
		try
		{
			LocalConfigData localConfigData = (LocalConfigData)LuaObject.checkSelf(l);
			bool soundOn;
			LuaObject.checkType(l, 2, out soundOn);
			localConfigData.SoundOn = soundOn;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060190C0 RID: 102592 RVA: 0x007229D0 File Offset: 0x00720BD0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_VoiceOn(IntPtr l)
	{
		int result;
		try
		{
			LocalConfigData localConfigData = (LocalConfigData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, localConfigData.VoiceOn);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060190C1 RID: 102593 RVA: 0x00722A24 File Offset: 0x00720C24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_VoiceOn(IntPtr l)
	{
		int result;
		try
		{
			LocalConfigData localConfigData = (LocalConfigData)LuaObject.checkSelf(l);
			bool voiceOn;
			LuaObject.checkType(l, 2, out voiceOn);
			localConfigData.VoiceOn = voiceOn;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060190C2 RID: 102594 RVA: 0x00722A7C File Offset: 0x00720C7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_IsFasBattle(IntPtr l)
	{
		int result;
		try
		{
			LocalConfigData localConfigData = (LocalConfigData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, localConfigData.IsFasBattle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060190C3 RID: 102595 RVA: 0x00722AD0 File Offset: 0x00720CD0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_IsFasBattle(IntPtr l)
	{
		int result;
		try
		{
			LocalConfigData localConfigData = (LocalConfigData)LuaObject.checkSelf(l);
			bool isFasBattle;
			LuaObject.checkType(l, 2, out isFasBattle);
			localConfigData.IsFasBattle = isFasBattle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060190C4 RID: 102596 RVA: 0x00722B28 File Offset: 0x00720D28
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_SkipCombatMode(IntPtr l)
	{
		int result;
		try
		{
			LocalConfigData localConfigData = (LocalConfigData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, localConfigData.SkipCombatMode);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060190C5 RID: 102597 RVA: 0x00722B7C File Offset: 0x00720D7C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_SkipCombatMode(IntPtr l)
	{
		int result;
		try
		{
			LocalConfigData localConfigData = (LocalConfigData)LuaObject.checkSelf(l);
			int skipCombatMode;
			LuaObject.checkType(l, 2, out skipCombatMode);
			localConfigData.SkipCombatMode = skipCombatMode;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060190C6 RID: 102598 RVA: 0x00722BD4 File Offset: 0x00720DD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ClickActorEndAction(IntPtr l)
	{
		int result;
		try
		{
			LocalConfigData localConfigData = (LocalConfigData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, localConfigData.ClickActorEndAction);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060190C7 RID: 102599 RVA: 0x00722C28 File Offset: 0x00720E28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ClickActorEndAction(IntPtr l)
	{
		int result;
		try
		{
			LocalConfigData localConfigData = (LocalConfigData)LuaObject.checkSelf(l);
			bool clickActorEndAction;
			LuaObject.checkType(l, 2, out clickActorEndAction);
			localConfigData.ClickActorEndAction = clickActorEndAction;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060190C8 RID: 102600 RVA: 0x00722C80 File Offset: 0x00720E80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ShowBattleDanmaku(IntPtr l)
	{
		int result;
		try
		{
			LocalConfigData localConfigData = (LocalConfigData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, localConfigData.ShowBattleDanmaku);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060190C9 RID: 102601 RVA: 0x00722CD4 File Offset: 0x00720ED4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ShowBattleDanmaku(IntPtr l)
	{
		int result;
		try
		{
			LocalConfigData localConfigData = (LocalConfigData)LuaObject.checkSelf(l);
			bool showBattleDanmaku;
			LuaObject.checkType(l, 2, out showBattleDanmaku);
			localConfigData.ShowBattleDanmaku = showBattleDanmaku;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060190CA RID: 102602 RVA: 0x00722D2C File Offset: 0x00720F2C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_AutoBattleBits(IntPtr l)
	{
		int result;
		try
		{
			LocalConfigData localConfigData = (LocalConfigData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, localConfigData.AutoBattleBits);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060190CB RID: 102603 RVA: 0x00722D80 File Offset: 0x00720F80
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_AutoBattleBits(IntPtr l)
	{
		int result;
		try
		{
			LocalConfigData localConfigData = (LocalConfigData)LuaObject.checkSelf(l);
			int autoBattleBits;
			LuaObject.checkType(l, 2, out autoBattleBits);
			localConfigData.AutoBattleBits = autoBattleBits;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060190CC RID: 102604 RVA: 0x00722DD8 File Offset: 0x00720FD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_OnlyShowCurJobSkin(IntPtr l)
	{
		int result;
		try
		{
			LocalConfigData localConfigData = (LocalConfigData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, localConfigData.OnlyShowCurJobSkin);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060190CD RID: 102605 RVA: 0x00722E2C File Offset: 0x0072102C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_OnlyShowCurJobSkin(IntPtr l)
	{
		int result;
		try
		{
			LocalConfigData localConfigData = (LocalConfigData)LuaObject.checkSelf(l);
			bool onlyShowCurJobSkin;
			LuaObject.checkType(l, 2, out onlyShowCurJobSkin);
			localConfigData.OnlyShowCurJobSkin = onlyShowCurJobSkin;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060190CE RID: 102606 RVA: 0x00722E84 File Offset: 0x00721084
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SetSkinToAllSoldier(IntPtr l)
	{
		int result;
		try
		{
			LocalConfigData localConfigData = (LocalConfigData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, localConfigData.SetSkinToAllSoldier);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060190CF RID: 102607 RVA: 0x00722ED8 File Offset: 0x007210D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_SetSkinToAllSoldier(IntPtr l)
	{
		int result;
		try
		{
			LocalConfigData localConfigData = (LocalConfigData)LuaObject.checkSelf(l);
			bool setSkinToAllSoldier;
			LuaObject.checkType(l, 2, out setSkinToAllSoldier);
			localConfigData.SetSkinToAllSoldier = setSkinToAllSoldier;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060190D0 RID: 102608 RVA: 0x00722F30 File Offset: 0x00721130
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_HeroListSortType(IntPtr l)
	{
		int result;
		try
		{
			LocalConfigData localConfigData = (LocalConfigData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, localConfigData.HeroListSortType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060190D1 RID: 102609 RVA: 0x00722F84 File Offset: 0x00721184
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_HeroListSortType(IntPtr l)
	{
		int result;
		try
		{
			LocalConfigData localConfigData = (LocalConfigData)LuaObject.checkSelf(l);
			int heroListSortType;
			LuaObject.checkType(l, 2, out heroListSortType);
			localConfigData.HeroListSortType = heroListSortType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060190D2 RID: 102610 RVA: 0x00722FDC File Offset: 0x007211DC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_NotifyEnergyRecover(IntPtr l)
	{
		int result;
		try
		{
			LocalConfigData localConfigData = (LocalConfigData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, localConfigData.NotifyEnergyRecover);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060190D3 RID: 102611 RVA: 0x00723030 File Offset: 0x00721230
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_NotifyEnergyRecover(IntPtr l)
	{
		int result;
		try
		{
			LocalConfigData localConfigData = (LocalConfigData)LuaObject.checkSelf(l);
			bool notifyEnergyRecover;
			LuaObject.checkType(l, 2, out notifyEnergyRecover);
			localConfigData.NotifyEnergyRecover = notifyEnergyRecover;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060190D4 RID: 102612 RVA: 0x00723088 File Offset: 0x00721288
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_NotifyRandomEvent(IntPtr l)
	{
		int result;
		try
		{
			LocalConfigData localConfigData = (LocalConfigData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, localConfigData.NotifyRandomEvent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060190D5 RID: 102613 RVA: 0x007230DC File Offset: 0x007212DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_NotifyRandomEvent(IntPtr l)
	{
		int result;
		try
		{
			LocalConfigData localConfigData = (LocalConfigData)LuaObject.checkSelf(l);
			bool notifyRandomEvent;
			LuaObject.checkType(l, 2, out notifyRandomEvent);
			localConfigData.NotifyRandomEvent = notifyRandomEvent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060190D6 RID: 102614 RVA: 0x00723134 File Offset: 0x00721334
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_NotifyArenaTicket(IntPtr l)
	{
		int result;
		try
		{
			LocalConfigData localConfigData = (LocalConfigData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, localConfigData.NotifyArenaTicket);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060190D7 RID: 102615 RVA: 0x00723188 File Offset: 0x00721388
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_NotifyArenaTicket(IntPtr l)
	{
		int result;
		try
		{
			LocalConfigData localConfigData = (LocalConfigData)LuaObject.checkSelf(l);
			bool notifyArenaTicket;
			LuaObject.checkType(l, 2, out notifyArenaTicket);
			localConfigData.NotifyArenaTicket = notifyArenaTicket;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060190D8 RID: 102616 RVA: 0x007231E0 File Offset: 0x007213E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_NotifyStoreRefresh(IntPtr l)
	{
		int result;
		try
		{
			LocalConfigData localConfigData = (LocalConfigData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, localConfigData.NotifyStoreRefresh);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060190D9 RID: 102617 RVA: 0x00723234 File Offset: 0x00721434
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_NotifyStoreRefresh(IntPtr l)
	{
		int result;
		try
		{
			LocalConfigData localConfigData = (LocalConfigData)LuaObject.checkSelf(l);
			bool notifyStoreRefresh;
			LuaObject.checkType(l, 2, out notifyStoreRefresh);
			localConfigData.NotifyStoreRefresh = notifyStoreRefresh;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060190DA RID: 102618 RVA: 0x0072328C File Offset: 0x0072148C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_PowerSaveModeOn(IntPtr l)
	{
		int result;
		try
		{
			LocalConfigData localConfigData = (LocalConfigData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, localConfigData.PowerSaveModeOn);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060190DB RID: 102619 RVA: 0x007232E0 File Offset: 0x007214E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_PowerSaveModeOn(IntPtr l)
	{
		int result;
		try
		{
			LocalConfigData localConfigData = (LocalConfigData)LuaObject.checkSelf(l);
			bool powerSaveModeOn;
			LuaObject.checkType(l, 2, out powerSaveModeOn);
			localConfigData.PowerSaveModeOn = powerSaveModeOn;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060190DC RID: 102620 RVA: 0x00723338 File Offset: 0x00721538
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ScreenRecordOn(IntPtr l)
	{
		int result;
		try
		{
			LocalConfigData localConfigData = (LocalConfigData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, localConfigData.ScreenRecordOn);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060190DD RID: 102621 RVA: 0x0072338C File Offset: 0x0072158C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ScreenRecordOn(IntPtr l)
	{
		int result;
		try
		{
			LocalConfigData localConfigData = (LocalConfigData)LuaObject.checkSelf(l);
			bool screenRecordOn;
			LuaObject.checkType(l, 2, out screenRecordOn);
			localConfigData.ScreenRecordOn = screenRecordOn;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060190DE RID: 102622 RVA: 0x007233E4 File Offset: 0x007215E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_RecentLoginServerIDs(IntPtr l)
	{
		int result;
		try
		{
			LocalConfigData localConfigData = (LocalConfigData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, localConfigData.RecentLoginServerIDs);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060190DF RID: 102623 RVA: 0x00723438 File Offset: 0x00721638
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_RecentLoginServerIDs(IntPtr l)
	{
		int result;
		try
		{
			LocalConfigData localConfigData = (LocalConfigData)LuaObject.checkSelf(l);
			int[] recentLoginServerIDs;
			LuaObject.checkArray<int>(l, 2, out recentLoginServerIDs);
			localConfigData.RecentLoginServerIDs = recentLoginServerIDs;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060190E0 RID: 102624 RVA: 0x00723490 File Offset: 0x00721690
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_AccountName(IntPtr l)
	{
		int result;
		try
		{
			LocalConfigData localConfigData = (LocalConfigData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, localConfigData.AccountName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060190E1 RID: 102625 RVA: 0x007234E4 File Offset: 0x007216E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_AccountName(IntPtr l)
	{
		int result;
		try
		{
			LocalConfigData localConfigData = (LocalConfigData)LuaObject.checkSelf(l);
			string accountName;
			LuaObject.checkType(l, 2, out accountName);
			localConfigData.AccountName = accountName;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060190E2 RID: 102626 RVA: 0x0072353C File Offset: 0x0072173C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Password(IntPtr l)
	{
		int result;
		try
		{
			LocalConfigData localConfigData = (LocalConfigData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, localConfigData.Password);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060190E3 RID: 102627 RVA: 0x00723590 File Offset: 0x00721790
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Password(IntPtr l)
	{
		int result;
		try
		{
			LocalConfigData localConfigData = (LocalConfigData)LuaObject.checkSelf(l);
			string password;
			LuaObject.checkType(l, 2, out password);
			localConfigData.Password = password;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060190E4 RID: 102628 RVA: 0x007235E8 File Offset: 0x007217E8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_IsDeveloper(IntPtr l)
	{
		int result;
		try
		{
			LocalConfigData localConfigData = (LocalConfigData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, localConfigData.IsDeveloper);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060190E5 RID: 102629 RVA: 0x0072363C File Offset: 0x0072183C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_IsDeveloper(IntPtr l)
	{
		int result;
		try
		{
			LocalConfigData localConfigData = (LocalConfigData)LuaObject.checkSelf(l);
			bool isDeveloper;
			LuaObject.checkType(l, 2, out isDeveloper);
			localConfigData.IsDeveloper = isDeveloper;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060190E6 RID: 102630 RVA: 0x00723694 File Offset: 0x00721894
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_IsFastEnterGame(IntPtr l)
	{
		int result;
		try
		{
			LocalConfigData localConfigData = (LocalConfigData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, localConfigData.IsFastEnterGame);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060190E7 RID: 102631 RVA: 0x007236E8 File Offset: 0x007218E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_IsFastEnterGame(IntPtr l)
	{
		int result;
		try
		{
			LocalConfigData localConfigData = (LocalConfigData)LuaObject.checkSelf(l);
			bool isFastEnterGame;
			LuaObject.checkType(l, 2, out isFastEnterGame);
			localConfigData.IsFastEnterGame = isFastEnterGame;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060190E8 RID: 102632 RVA: 0x00723740 File Offset: 0x00721940
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_EnableUserGuide(IntPtr l)
	{
		int result;
		try
		{
			LocalConfigData localConfigData = (LocalConfigData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, localConfigData.EnableUserGuide);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060190E9 RID: 102633 RVA: 0x00723794 File Offset: 0x00721994
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EnableUserGuide(IntPtr l)
	{
		int result;
		try
		{
			LocalConfigData localConfigData = (LocalConfigData)LuaObject.checkSelf(l);
			bool enableUserGuide;
			LuaObject.checkType(l, 2, out enableUserGuide);
			localConfigData.EnableUserGuide = enableUserGuide;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060190EA RID: 102634 RVA: 0x007237EC File Offset: 0x007219EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_TestListType(IntPtr l)
	{
		int result;
		try
		{
			LocalConfigData localConfigData = (LocalConfigData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, localConfigData.TestListType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060190EB RID: 102635 RVA: 0x00723840 File Offset: 0x00721A40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_TestListType(IntPtr l)
	{
		int result;
		try
		{
			LocalConfigData localConfigData = (LocalConfigData)LuaObject.checkSelf(l);
			int testListType;
			LuaObject.checkType(l, 2, out testListType);
			localConfigData.TestListType = testListType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060190EC RID: 102636 RVA: 0x00723898 File Offset: 0x00721A98
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_TestListItemIds(IntPtr l)
	{
		int result;
		try
		{
			LocalConfigData localConfigData = (LocalConfigData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, localConfigData.TestListItemIds);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060190ED RID: 102637 RVA: 0x007238EC File Offset: 0x00721AEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_TestListItemIds(IntPtr l)
	{
		int result;
		try
		{
			LocalConfigData localConfigData = (LocalConfigData)LuaObject.checkSelf(l);
			int[] testListItemIds;
			LuaObject.checkArray<int>(l, 2, out testListItemIds);
			localConfigData.TestListItemIds = testListItemIds;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060190EE RID: 102638 RVA: 0x00723944 File Offset: 0x00721B44
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_TestMonsterLevel(IntPtr l)
	{
		int result;
		try
		{
			LocalConfigData localConfigData = (LocalConfigData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, localConfigData.TestMonsterLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060190EF RID: 102639 RVA: 0x00723998 File Offset: 0x00721B98
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_TestMonsterLevel(IntPtr l)
	{
		int result;
		try
		{
			LocalConfigData localConfigData = (LocalConfigData)LuaObject.checkSelf(l);
			int testMonsterLevel;
			LuaObject.checkType(l, 2, out testMonsterLevel);
			localConfigData.TestMonsterLevel = testMonsterLevel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060190F0 RID: 102640 RVA: 0x007239F0 File Offset: 0x00721BF0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_TestMarginFix(IntPtr l)
	{
		int result;
		try
		{
			LocalConfigData localConfigData = (LocalConfigData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, localConfigData.TestMarginFix);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060190F1 RID: 102641 RVA: 0x00723A44 File Offset: 0x00721C44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_TestMarginFix(IntPtr l)
	{
		int result;
		try
		{
			LocalConfigData localConfigData = (LocalConfigData)LuaObject.checkSelf(l);
			bool testMarginFix;
			LuaObject.checkType(l, 2, out testMarginFix);
			localConfigData.TestMarginFix = testMarginFix;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060190F2 RID: 102642 RVA: 0x00723A9C File Offset: 0x00721C9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LastBecomeStrongHeroStarLevel(IntPtr l)
	{
		int result;
		try
		{
			LocalConfigData localConfigData = (LocalConfigData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, localConfigData.LastBecomeStrongHeroStarLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060190F3 RID: 102643 RVA: 0x00723AF0 File Offset: 0x00721CF0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_LastBecomeStrongHeroStarLevel(IntPtr l)
	{
		int result;
		try
		{
			LocalConfigData localConfigData = (LocalConfigData)LuaObject.checkSelf(l);
			string lastBecomeStrongHeroStarLevel;
			LuaObject.checkType(l, 2, out lastBecomeStrongHeroStarLevel);
			localConfigData.LastBecomeStrongHeroStarLevel = lastBecomeStrongHeroStarLevel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060190F4 RID: 102644 RVA: 0x00723B48 File Offset: 0x00721D48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LastBecomeStrongPlayerLevel(IntPtr l)
	{
		int result;
		try
		{
			LocalConfigData localConfigData = (LocalConfigData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, localConfigData.LastBecomeStrongPlayerLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060190F5 RID: 102645 RVA: 0x00723B9C File Offset: 0x00721D9C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_LastBecomeStrongPlayerLevel(IntPtr l)
	{
		int result;
		try
		{
			LocalConfigData localConfigData = (LocalConfigData)LuaObject.checkSelf(l);
			string lastBecomeStrongPlayerLevel;
			LuaObject.checkType(l, 2, out lastBecomeStrongPlayerLevel);
			localConfigData.LastBecomeStrongPlayerLevel = lastBecomeStrongPlayerLevel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060190F6 RID: 102646 RVA: 0x00723BF4 File Offset: 0x00721DF4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_LastBecomeStrongEquipmentLevel(IntPtr l)
	{
		int result;
		try
		{
			LocalConfigData localConfigData = (LocalConfigData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, localConfigData.LastBecomeStrongEquipmentLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060190F7 RID: 102647 RVA: 0x00723C48 File Offset: 0x00721E48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_LastBecomeStrongEquipmentLevel(IntPtr l)
	{
		int result;
		try
		{
			LocalConfigData localConfigData = (LocalConfigData)LuaObject.checkSelf(l);
			string lastBecomeStrongEquipmentLevel;
			LuaObject.checkType(l, 2, out lastBecomeStrongEquipmentLevel);
			localConfigData.LastBecomeStrongEquipmentLevel = lastBecomeStrongEquipmentLevel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060190F8 RID: 102648 RVA: 0x00723CA0 File Offset: 0x00721EA0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_MusicVolume(IntPtr l)
	{
		int result;
		try
		{
			LocalConfigData localConfigData = (LocalConfigData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, localConfigData.MusicVolume);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060190F9 RID: 102649 RVA: 0x00723CF4 File Offset: 0x00721EF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_MusicVolume(IntPtr l)
	{
		int result;
		try
		{
			LocalConfigData localConfigData = (LocalConfigData)LuaObject.checkSelf(l);
			float musicVolume;
			LuaObject.checkType(l, 2, out musicVolume);
			localConfigData.MusicVolume = musicVolume;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060190FA RID: 102650 RVA: 0x00723D4C File Offset: 0x00721F4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SoundVolumn(IntPtr l)
	{
		int result;
		try
		{
			LocalConfigData localConfigData = (LocalConfigData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, localConfigData.SoundVolumn);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060190FB RID: 102651 RVA: 0x00723DA0 File Offset: 0x00721FA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_SoundVolumn(IntPtr l)
	{
		int result;
		try
		{
			LocalConfigData localConfigData = (LocalConfigData)LuaObject.checkSelf(l);
			float soundVolumn;
			LuaObject.checkType(l, 2, out soundVolumn);
			localConfigData.SoundVolumn = soundVolumn;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060190FC RID: 102652 RVA: 0x00723DF8 File Offset: 0x00721FF8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_VoiceVolume(IntPtr l)
	{
		int result;
		try
		{
			LocalConfigData localConfigData = (LocalConfigData)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, localConfigData.VoiceVolume);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060190FD RID: 102653 RVA: 0x00723E4C File Offset: 0x0072204C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_VoiceVolume(IntPtr l)
	{
		int result;
		try
		{
			LocalConfigData localConfigData = (LocalConfigData)LuaObject.checkSelf(l);
			float voiceVolume;
			LuaObject.checkType(l, 2, out voiceVolume);
			localConfigData.VoiceVolume = voiceVolume;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060190FE RID: 102654 RVA: 0x00723EA4 File Offset: 0x007220A4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Misc.LocalConfigData");
		string name = "MusicOn";
		if (Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalConfigData.get_MusicOn);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalConfigData.set_MusicOn);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache1, true);
		string name2 = "SoundOn";
		if (Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalConfigData.get_SoundOn);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalConfigData.set_SoundOn);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache3, true);
		string name3 = "VoiceOn";
		if (Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalConfigData.get_VoiceOn);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalConfigData.set_VoiceOn);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache5, true);
		string name4 = "IsFasBattle";
		if (Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalConfigData.get_IsFasBattle);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalConfigData.set_IsFasBattle);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache7, true);
		string name5 = "SkipCombatMode";
		if (Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalConfigData.get_SkipCombatMode);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache8;
		if (Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalConfigData.set_SkipCombatMode);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache9, true);
		string name6 = "ClickActorEndAction";
		if (Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalConfigData.get_ClickActorEndAction);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cacheA;
		if (Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalConfigData.set_ClickActorEndAction);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cacheB, true);
		string name7 = "ShowBattleDanmaku";
		if (Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalConfigData.get_ShowBattleDanmaku);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cacheC;
		if (Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalConfigData.set_ShowBattleDanmaku);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cacheD, true);
		string name8 = "AutoBattleBits";
		if (Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalConfigData.get_AutoBattleBits);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cacheE;
		if (Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalConfigData.set_AutoBattleBits);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cacheF, true);
		string name9 = "OnlyShowCurJobSkin";
		if (Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalConfigData.get_OnlyShowCurJobSkin);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache10;
		if (Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalConfigData.set_OnlyShowCurJobSkin);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache11, true);
		string name10 = "SetSkinToAllSoldier";
		if (Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalConfigData.get_SetSkinToAllSoldier);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache12;
		if (Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalConfigData.set_SetSkinToAllSoldier);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache13, true);
		string name11 = "HeroListSortType";
		if (Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalConfigData.get_HeroListSortType);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache14;
		if (Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalConfigData.set_HeroListSortType);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache15, true);
		string name12 = "NotifyEnergyRecover";
		if (Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalConfigData.get_NotifyEnergyRecover);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache16;
		if (Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalConfigData.set_NotifyEnergyRecover);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache17, true);
		string name13 = "NotifyRandomEvent";
		if (Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalConfigData.get_NotifyRandomEvent);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache18;
		if (Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalConfigData.set_NotifyRandomEvent);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache19, true);
		string name14 = "NotifyArenaTicket";
		if (Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalConfigData.get_NotifyArenaTicket);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache1A;
		if (Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalConfigData.set_NotifyArenaTicket);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache1B, true);
		string name15 = "NotifyStoreRefresh";
		if (Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalConfigData.get_NotifyStoreRefresh);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache1C;
		if (Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalConfigData.set_NotifyStoreRefresh);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache1D, true);
		string name16 = "PowerSaveModeOn";
		if (Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalConfigData.get_PowerSaveModeOn);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache1E;
		if (Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalConfigData.set_PowerSaveModeOn);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache1F, true);
		string name17 = "ScreenRecordOn";
		if (Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalConfigData.get_ScreenRecordOn);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache20;
		if (Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalConfigData.set_ScreenRecordOn);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache21, true);
		string name18 = "RecentLoginServerIDs";
		if (Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalConfigData.get_RecentLoginServerIDs);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalConfigData.set_RecentLoginServerIDs);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache23, true);
		string name19 = "AccountName";
		if (Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalConfigData.get_AccountName);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache24;
		if (Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalConfigData.set_AccountName);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache25, true);
		string name20 = "Password";
		if (Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalConfigData.get_Password);
		}
		LuaCSFunction get20 = Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache26;
		if (Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalConfigData.set_Password);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache27, true);
		string name21 = "IsDeveloper";
		if (Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalConfigData.get_IsDeveloper);
		}
		LuaCSFunction get21 = Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache28;
		if (Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalConfigData.set_IsDeveloper);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache29, true);
		string name22 = "IsFastEnterGame";
		if (Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalConfigData.get_IsFastEnterGame);
		}
		LuaCSFunction get22 = Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache2A;
		if (Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalConfigData.set_IsFastEnterGame);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache2B, true);
		string name23 = "EnableUserGuide";
		if (Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalConfigData.get_EnableUserGuide);
		}
		LuaCSFunction get23 = Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache2C;
		if (Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalConfigData.set_EnableUserGuide);
		}
		LuaObject.addMember(l, name23, get23, Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache2D, true);
		string name24 = "TestListType";
		if (Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalConfigData.get_TestListType);
		}
		LuaCSFunction get24 = Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache2E;
		if (Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalConfigData.set_TestListType);
		}
		LuaObject.addMember(l, name24, get24, Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache2F, true);
		string name25 = "TestListItemIds";
		if (Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalConfigData.get_TestListItemIds);
		}
		LuaCSFunction get25 = Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache30;
		if (Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalConfigData.set_TestListItemIds);
		}
		LuaObject.addMember(l, name25, get25, Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache31, true);
		string name26 = "TestMonsterLevel";
		if (Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalConfigData.get_TestMonsterLevel);
		}
		LuaCSFunction get26 = Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache32;
		if (Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalConfigData.set_TestMonsterLevel);
		}
		LuaObject.addMember(l, name26, get26, Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache33, true);
		string name27 = "TestMarginFix";
		if (Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalConfigData.get_TestMarginFix);
		}
		LuaCSFunction get27 = Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache34;
		if (Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalConfigData.set_TestMarginFix);
		}
		LuaObject.addMember(l, name27, get27, Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache35, true);
		string name28 = "LastBecomeStrongHeroStarLevel";
		if (Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalConfigData.get_LastBecomeStrongHeroStarLevel);
		}
		LuaCSFunction get28 = Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache36;
		if (Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalConfigData.set_LastBecomeStrongHeroStarLevel);
		}
		LuaObject.addMember(l, name28, get28, Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache37, true);
		string name29 = "LastBecomeStrongPlayerLevel";
		if (Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalConfigData.get_LastBecomeStrongPlayerLevel);
		}
		LuaCSFunction get29 = Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache38;
		if (Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalConfigData.set_LastBecomeStrongPlayerLevel);
		}
		LuaObject.addMember(l, name29, get29, Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache39, true);
		string name30 = "LastBecomeStrongEquipmentLevel";
		if (Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalConfigData.get_LastBecomeStrongEquipmentLevel);
		}
		LuaCSFunction get30 = Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache3A;
		if (Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalConfigData.set_LastBecomeStrongEquipmentLevel);
		}
		LuaObject.addMember(l, name30, get30, Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache3B, true);
		string name31 = "MusicVolume";
		if (Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalConfigData.get_MusicVolume);
		}
		LuaCSFunction get31 = Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache3C;
		if (Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalConfigData.set_MusicVolume);
		}
		LuaObject.addMember(l, name31, get31, Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache3D, true);
		string name32 = "SoundVolumn";
		if (Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalConfigData.get_SoundVolumn);
		}
		LuaCSFunction get32 = Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache3E;
		if (Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalConfigData.set_SoundVolumn);
		}
		LuaObject.addMember(l, name32, get32, Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache3F, true);
		string name33 = "VoiceVolume";
		if (Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalConfigData.get_VoiceVolume);
		}
		LuaCSFunction get33 = Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache40;
		if (Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalConfigData.set_VoiceVolume);
		}
		LuaObject.addMember(l, name33, get33, Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache41, true);
		if (Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalConfigData.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Misc_LocalConfigData.<>f__mg$cache42, typeof(LocalConfigData));
	}

	// Token: 0x0400F54B RID: 62795
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400F54C RID: 62796
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400F54D RID: 62797
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400F54E RID: 62798
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400F54F RID: 62799
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400F550 RID: 62800
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400F551 RID: 62801
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400F552 RID: 62802
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400F553 RID: 62803
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400F554 RID: 62804
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400F555 RID: 62805
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400F556 RID: 62806
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400F557 RID: 62807
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400F558 RID: 62808
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400F559 RID: 62809
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400F55A RID: 62810
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400F55B RID: 62811
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400F55C RID: 62812
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400F55D RID: 62813
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400F55E RID: 62814
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400F55F RID: 62815
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400F560 RID: 62816
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400F561 RID: 62817
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400F562 RID: 62818
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400F563 RID: 62819
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400F564 RID: 62820
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400F565 RID: 62821
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400F566 RID: 62822
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400F567 RID: 62823
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400F568 RID: 62824
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400F569 RID: 62825
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400F56A RID: 62826
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400F56B RID: 62827
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400F56C RID: 62828
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400F56D RID: 62829
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400F56E RID: 62830
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0400F56F RID: 62831
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0400F570 RID: 62832
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0400F571 RID: 62833
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0400F572 RID: 62834
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0400F573 RID: 62835
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0400F574 RID: 62836
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0400F575 RID: 62837
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0400F576 RID: 62838
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0400F577 RID: 62839
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0400F578 RID: 62840
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0400F579 RID: 62841
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x0400F57A RID: 62842
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x0400F57B RID: 62843
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x0400F57C RID: 62844
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x0400F57D RID: 62845
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x0400F57E RID: 62846
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x0400F57F RID: 62847
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x0400F580 RID: 62848
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x0400F581 RID: 62849
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x0400F582 RID: 62850
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x0400F583 RID: 62851
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x0400F584 RID: 62852
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x0400F585 RID: 62853
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x0400F586 RID: 62854
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x0400F587 RID: 62855
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x0400F588 RID: 62856
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x0400F589 RID: 62857
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x0400F58A RID: 62858
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x0400F58B RID: 62859
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x0400F58C RID: 62860
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x0400F58D RID: 62861
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;
}
