using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001146 RID: 4422
[Preserve]
public class Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo : LuaObject
{
	// Token: 0x0601668F RID: 91791 RVA: 0x005EA89C File Offset: 0x005E8A9C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataChallengeLevelInfo o = new ConfigDataChallengeLevelInfo();
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

	// Token: 0x06016690 RID: 91792 RVA: 0x005EA8E4 File Offset: 0x005E8AE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_dialogInfoBefore(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataChallengeLevelInfo configDataChallengeLevelInfo = (ConfigDataChallengeLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataChallengeLevelInfo.m_dialogInfoBefore);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016691 RID: 91793 RVA: 0x005EA938 File Offset: 0x005E8B38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_dialogInfoBefore(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataChallengeLevelInfo configDataChallengeLevelInfo = (ConfigDataChallengeLevelInfo)LuaObject.checkSelf(l);
			ConfigDataDialogInfo dialogInfoBefore;
			LuaObject.checkType<ConfigDataDialogInfo>(l, 2, out dialogInfoBefore);
			configDataChallengeLevelInfo.m_dialogInfoBefore = dialogInfoBefore;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016692 RID: 91794 RVA: 0x005EA990 File Offset: 0x005E8B90
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_dialogInfoAfter(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataChallengeLevelInfo configDataChallengeLevelInfo = (ConfigDataChallengeLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataChallengeLevelInfo.m_dialogInfoAfter);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016693 RID: 91795 RVA: 0x005EA9E4 File Offset: 0x005E8BE4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_dialogInfoAfter(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataChallengeLevelInfo configDataChallengeLevelInfo = (ConfigDataChallengeLevelInfo)LuaObject.checkSelf(l);
			ConfigDataDialogInfo dialogInfoAfter;
			LuaObject.checkType<ConfigDataDialogInfo>(l, 2, out dialogInfoAfter);
			configDataChallengeLevelInfo.m_dialogInfoAfter = dialogInfoAfter;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016694 RID: 91796 RVA: 0x005EAA3C File Offset: 0x005E8C3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataChallengeLevelInfo configDataChallengeLevelInfo = (ConfigDataChallengeLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataChallengeLevelInfo.ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016695 RID: 91797 RVA: 0x005EAA90 File Offset: 0x005E8C90
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataChallengeLevelInfo configDataChallengeLevelInfo = (ConfigDataChallengeLevelInfo)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			configDataChallengeLevelInfo.ID = id;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016696 RID: 91798 RVA: 0x005EAAE8 File Offset: 0x005E8CE8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Name(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataChallengeLevelInfo configDataChallengeLevelInfo = (ConfigDataChallengeLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataChallengeLevelInfo.Name);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016697 RID: 91799 RVA: 0x005EAB3C File Offset: 0x005E8D3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Name(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataChallengeLevelInfo configDataChallengeLevelInfo = (ConfigDataChallengeLevelInfo)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			configDataChallengeLevelInfo.Name = name;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016698 RID: 91800 RVA: 0x005EAB94 File Offset: 0x005E8D94
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_PrevLevelId(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataChallengeLevelInfo configDataChallengeLevelInfo = (ConfigDataChallengeLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataChallengeLevelInfo.PrevLevelId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016699 RID: 91801 RVA: 0x005EABE8 File Offset: 0x005E8DE8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_PrevLevelId(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataChallengeLevelInfo configDataChallengeLevelInfo = (ConfigDataChallengeLevelInfo)LuaObject.checkSelf(l);
			int prevLevelId;
			LuaObject.checkType(l, 2, out prevLevelId);
			configDataChallengeLevelInfo.PrevLevelId = prevLevelId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601669A RID: 91802 RVA: 0x005EAC40 File Offset: 0x005E8E40
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_UnlockDaysDelay(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataChallengeLevelInfo configDataChallengeLevelInfo = (ConfigDataChallengeLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataChallengeLevelInfo.UnlockDaysDelay);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601669B RID: 91803 RVA: 0x005EAC94 File Offset: 0x005E8E94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_UnlockDaysDelay(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataChallengeLevelInfo configDataChallengeLevelInfo = (ConfigDataChallengeLevelInfo)LuaObject.checkSelf(l);
			int unlockDaysDelay;
			LuaObject.checkType(l, 2, out unlockDaysDelay);
			configDataChallengeLevelInfo.UnlockDaysDelay = unlockDaysDelay;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601669C RID: 91804 RVA: 0x005EACEC File Offset: 0x005E8EEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_EnergySuccess(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataChallengeLevelInfo configDataChallengeLevelInfo = (ConfigDataChallengeLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataChallengeLevelInfo.EnergySuccess);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601669D RID: 91805 RVA: 0x005EAD40 File Offset: 0x005E8F40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EnergySuccess(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataChallengeLevelInfo configDataChallengeLevelInfo = (ConfigDataChallengeLevelInfo)LuaObject.checkSelf(l);
			int energySuccess;
			LuaObject.checkType(l, 2, out energySuccess);
			configDataChallengeLevelInfo.EnergySuccess = energySuccess;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601669E RID: 91806 RVA: 0x005EAD98 File Offset: 0x005E8F98
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_EnergyFail(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataChallengeLevelInfo configDataChallengeLevelInfo = (ConfigDataChallengeLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataChallengeLevelInfo.EnergyFail);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601669F RID: 91807 RVA: 0x005EADEC File Offset: 0x005E8FEC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_EnergyFail(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataChallengeLevelInfo configDataChallengeLevelInfo = (ConfigDataChallengeLevelInfo)LuaObject.checkSelf(l);
			int energyFail;
			LuaObject.checkType(l, 2, out energyFail);
			configDataChallengeLevelInfo.EnergyFail = energyFail;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060166A0 RID: 91808 RVA: 0x005EAE44 File Offset: 0x005E9044
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_MonsterLevel(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataChallengeLevelInfo configDataChallengeLevelInfo = (ConfigDataChallengeLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataChallengeLevelInfo.MonsterLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060166A1 RID: 91809 RVA: 0x005EAE98 File Offset: 0x005E9098
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_MonsterLevel(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataChallengeLevelInfo configDataChallengeLevelInfo = (ConfigDataChallengeLevelInfo)LuaObject.checkSelf(l);
			int monsterLevel;
			LuaObject.checkType(l, 2, out monsterLevel);
			configDataChallengeLevelInfo.MonsterLevel = monsterLevel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060166A2 RID: 91810 RVA: 0x005EAEF0 File Offset: 0x005E90F0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Battle_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataChallengeLevelInfo configDataChallengeLevelInfo = (ConfigDataChallengeLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataChallengeLevelInfo.Battle_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060166A3 RID: 91811 RVA: 0x005EAF44 File Offset: 0x005E9144
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Battle_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataChallengeLevelInfo configDataChallengeLevelInfo = (ConfigDataChallengeLevelInfo)LuaObject.checkSelf(l);
			int battle_ID;
			LuaObject.checkType(l, 2, out battle_ID);
			configDataChallengeLevelInfo.Battle_ID = battle_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060166A4 RID: 91812 RVA: 0x005EAF9C File Offset: 0x005E919C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_DialogBefore_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataChallengeLevelInfo configDataChallengeLevelInfo = (ConfigDataChallengeLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataChallengeLevelInfo.DialogBefore_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060166A5 RID: 91813 RVA: 0x005EAFF0 File Offset: 0x005E91F0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_DialogBefore_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataChallengeLevelInfo configDataChallengeLevelInfo = (ConfigDataChallengeLevelInfo)LuaObject.checkSelf(l);
			int dialogBefore_ID;
			LuaObject.checkType(l, 2, out dialogBefore_ID);
			configDataChallengeLevelInfo.DialogBefore_ID = dialogBefore_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060166A6 RID: 91814 RVA: 0x005EB048 File Offset: 0x005E9248
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_DialogAfter_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataChallengeLevelInfo configDataChallengeLevelInfo = (ConfigDataChallengeLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataChallengeLevelInfo.DialogAfter_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060166A7 RID: 91815 RVA: 0x005EB09C File Offset: 0x005E929C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_DialogAfter_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataChallengeLevelInfo configDataChallengeLevelInfo = (ConfigDataChallengeLevelInfo)LuaObject.checkSelf(l);
			int dialogAfter_ID;
			LuaObject.checkType(l, 2, out dialogAfter_ID);
			configDataChallengeLevelInfo.DialogAfter_ID = dialogAfter_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060166A8 RID: 91816 RVA: 0x005EB0F4 File Offset: 0x005E92F4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_PlayerExp(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataChallengeLevelInfo configDataChallengeLevelInfo = (ConfigDataChallengeLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataChallengeLevelInfo.PlayerExp);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060166A9 RID: 91817 RVA: 0x005EB148 File Offset: 0x005E9348
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_PlayerExp(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataChallengeLevelInfo configDataChallengeLevelInfo = (ConfigDataChallengeLevelInfo)LuaObject.checkSelf(l);
			int playerExp;
			LuaObject.checkType(l, 2, out playerExp);
			configDataChallengeLevelInfo.PlayerExp = playerExp;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060166AA RID: 91818 RVA: 0x005EB1A0 File Offset: 0x005E93A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_HeroExp(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataChallengeLevelInfo configDataChallengeLevelInfo = (ConfigDataChallengeLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataChallengeLevelInfo.HeroExp);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060166AB RID: 91819 RVA: 0x005EB1F4 File Offset: 0x005E93F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_HeroExp(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataChallengeLevelInfo configDataChallengeLevelInfo = (ConfigDataChallengeLevelInfo)LuaObject.checkSelf(l);
			int heroExp;
			LuaObject.checkType(l, 2, out heroExp);
			configDataChallengeLevelInfo.HeroExp = heroExp;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060166AC RID: 91820 RVA: 0x005EB24C File Offset: 0x005E944C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Gold(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataChallengeLevelInfo configDataChallengeLevelInfo = (ConfigDataChallengeLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataChallengeLevelInfo.Gold);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060166AD RID: 91821 RVA: 0x005EB2A0 File Offset: 0x005E94A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Gold(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataChallengeLevelInfo configDataChallengeLevelInfo = (ConfigDataChallengeLevelInfo)LuaObject.checkSelf(l);
			int gold;
			LuaObject.checkType(l, 2, out gold);
			configDataChallengeLevelInfo.Gold = gold;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060166AE RID: 91822 RVA: 0x005EB2F8 File Offset: 0x005E94F8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ScoreBase(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataChallengeLevelInfo configDataChallengeLevelInfo = (ConfigDataChallengeLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataChallengeLevelInfo.ScoreBase);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060166AF RID: 91823 RVA: 0x005EB34C File Offset: 0x005E954C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_ScoreBase(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataChallengeLevelInfo configDataChallengeLevelInfo = (ConfigDataChallengeLevelInfo)LuaObject.checkSelf(l);
			int scoreBase;
			LuaObject.checkType(l, 2, out scoreBase);
			configDataChallengeLevelInfo.ScoreBase = scoreBase;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060166B0 RID: 91824 RVA: 0x005EB3A4 File Offset: 0x005E95A4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_CommonRewardList(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataChallengeLevelInfo configDataChallengeLevelInfo = (ConfigDataChallengeLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataChallengeLevelInfo.CommonRewardList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060166B1 RID: 91825 RVA: 0x005EB3F8 File Offset: 0x005E95F8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ItemDropCountDisplay(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataChallengeLevelInfo configDataChallengeLevelInfo = (ConfigDataChallengeLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataChallengeLevelInfo.ItemDropCountDisplay);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060166B2 RID: 91826 RVA: 0x005EB44C File Offset: 0x005E964C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ItemDropCountDisplay(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataChallengeLevelInfo configDataChallengeLevelInfo = (ConfigDataChallengeLevelInfo)LuaObject.checkSelf(l);
			int itemDropCountDisplay;
			LuaObject.checkType(l, 2, out itemDropCountDisplay);
			configDataChallengeLevelInfo.ItemDropCountDisplay = itemDropCountDisplay;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060166B3 RID: 91827 RVA: 0x005EB4A4 File Offset: 0x005E96A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BattleInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataChallengeLevelInfo configDataChallengeLevelInfo = (ConfigDataChallengeLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataChallengeLevelInfo.BattleInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060166B4 RID: 91828 RVA: 0x005EB4F8 File Offset: 0x005E96F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_BattleInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataChallengeLevelInfo configDataChallengeLevelInfo = (ConfigDataChallengeLevelInfo)LuaObject.checkSelf(l);
			ConfigDataBattleInfo battleInfo;
			LuaObject.checkType<ConfigDataBattleInfo>(l, 2, out battleInfo);
			configDataChallengeLevelInfo.BattleInfo = battleInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060166B5 RID: 91829 RVA: 0x005EB550 File Offset: 0x005E9750
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_UnchartedScoreInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataChallengeLevelInfo configDataChallengeLevelInfo = (ConfigDataChallengeLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataChallengeLevelInfo.UnchartedScoreInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060166B6 RID: 91830 RVA: 0x005EB5A4 File Offset: 0x005E97A4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_UnchartedScoreInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataChallengeLevelInfo configDataChallengeLevelInfo = (ConfigDataChallengeLevelInfo)LuaObject.checkSelf(l);
			ConfigDataUnchartedScoreInfo unchartedScoreInfo;
			LuaObject.checkType<ConfigDataUnchartedScoreInfo>(l, 2, out unchartedScoreInfo);
			configDataChallengeLevelInfo.UnchartedScoreInfo = unchartedScoreInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060166B7 RID: 91831 RVA: 0x005EB5FC File Offset: 0x005E97FC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ConfigData.ConfigDataChallengeLevelInfo");
		string name = "m_dialogInfoBefore";
		if (Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.get_m_dialogInfoBefore);
		}
		LuaCSFunction get = Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cache0;
		if (Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.set_m_dialogInfoBefore);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cache1, true);
		string name2 = "m_dialogInfoAfter";
		if (Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.get_m_dialogInfoAfter);
		}
		LuaCSFunction get2 = Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cache2;
		if (Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.set_m_dialogInfoAfter);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cache3, true);
		string name3 = "ID";
		if (Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.get_ID);
		}
		LuaCSFunction get3 = Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cache4;
		if (Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.set_ID);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cache5, true);
		string name4 = "Name";
		if (Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.get_Name);
		}
		LuaCSFunction get4 = Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cache6;
		if (Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.set_Name);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cache7, true);
		string name5 = "PrevLevelId";
		if (Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.get_PrevLevelId);
		}
		LuaCSFunction get5 = Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cache8;
		if (Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.set_PrevLevelId);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cache9, true);
		string name6 = "UnlockDaysDelay";
		if (Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.get_UnlockDaysDelay);
		}
		LuaCSFunction get6 = Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cacheA;
		if (Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.set_UnlockDaysDelay);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cacheB, true);
		string name7 = "EnergySuccess";
		if (Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.get_EnergySuccess);
		}
		LuaCSFunction get7 = Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cacheC;
		if (Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.set_EnergySuccess);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cacheD, true);
		string name8 = "EnergyFail";
		if (Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.get_EnergyFail);
		}
		LuaCSFunction get8 = Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cacheE;
		if (Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.set_EnergyFail);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cacheF, true);
		string name9 = "MonsterLevel";
		if (Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.get_MonsterLevel);
		}
		LuaCSFunction get9 = Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cache10;
		if (Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.set_MonsterLevel);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cache11, true);
		string name10 = "Battle_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.get_Battle_ID);
		}
		LuaCSFunction get10 = Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cache12;
		if (Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.set_Battle_ID);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cache13, true);
		string name11 = "DialogBefore_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.get_DialogBefore_ID);
		}
		LuaCSFunction get11 = Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cache14;
		if (Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.set_DialogBefore_ID);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cache15, true);
		string name12 = "DialogAfter_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.get_DialogAfter_ID);
		}
		LuaCSFunction get12 = Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cache16;
		if (Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.set_DialogAfter_ID);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cache17, true);
		string name13 = "PlayerExp";
		if (Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.get_PlayerExp);
		}
		LuaCSFunction get13 = Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cache18;
		if (Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.set_PlayerExp);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cache19, true);
		string name14 = "HeroExp";
		if (Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.get_HeroExp);
		}
		LuaCSFunction get14 = Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cache1A;
		if (Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.set_HeroExp);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cache1B, true);
		string name15 = "Gold";
		if (Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.get_Gold);
		}
		LuaCSFunction get15 = Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cache1C;
		if (Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.set_Gold);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cache1D, true);
		string name16 = "ScoreBase";
		if (Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.get_ScoreBase);
		}
		LuaCSFunction get16 = Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cache1E;
		if (Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.set_ScoreBase);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cache1F, true);
		string name17 = "CommonRewardList";
		if (Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.get_CommonRewardList);
		}
		LuaObject.addMember(l, name17, Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cache20, null, true);
		string name18 = "ItemDropCountDisplay";
		if (Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.get_ItemDropCountDisplay);
		}
		LuaCSFunction get17 = Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cache21;
		if (Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.set_ItemDropCountDisplay);
		}
		LuaObject.addMember(l, name18, get17, Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cache22, true);
		string name19 = "BattleInfo";
		if (Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.get_BattleInfo);
		}
		LuaCSFunction get18 = Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cache23;
		if (Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.set_BattleInfo);
		}
		LuaObject.addMember(l, name19, get18, Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cache24, true);
		string name20 = "UnchartedScoreInfo";
		if (Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.get_UnchartedScoreInfo);
		}
		LuaCSFunction get19 = Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cache25;
		if (Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.set_UnchartedScoreInfo);
		}
		LuaObject.addMember(l, name20, get19, Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cache26, true);
		if (Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ConfigData_ConfigDataChallengeLevelInfo.<>f__mg$cache27, typeof(ConfigDataChallengeLevelInfo));
	}

	// Token: 0x0400CDE5 RID: 52709
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400CDE6 RID: 52710
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400CDE7 RID: 52711
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400CDE8 RID: 52712
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400CDE9 RID: 52713
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400CDEA RID: 52714
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400CDEB RID: 52715
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400CDEC RID: 52716
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400CDED RID: 52717
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400CDEE RID: 52718
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400CDEF RID: 52719
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400CDF0 RID: 52720
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400CDF1 RID: 52721
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400CDF2 RID: 52722
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400CDF3 RID: 52723
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400CDF4 RID: 52724
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400CDF5 RID: 52725
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400CDF6 RID: 52726
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400CDF7 RID: 52727
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400CDF8 RID: 52728
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400CDF9 RID: 52729
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400CDFA RID: 52730
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400CDFB RID: 52731
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400CDFC RID: 52732
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400CDFD RID: 52733
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400CDFE RID: 52734
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400CDFF RID: 52735
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400CE00 RID: 52736
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400CE01 RID: 52737
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400CE02 RID: 52738
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400CE03 RID: 52739
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400CE04 RID: 52740
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400CE05 RID: 52741
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400CE06 RID: 52742
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400CE07 RID: 52743
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400CE08 RID: 52744
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0400CE09 RID: 52745
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0400CE0A RID: 52746
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0400CE0B RID: 52747
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0400CE0C RID: 52748
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;
}
