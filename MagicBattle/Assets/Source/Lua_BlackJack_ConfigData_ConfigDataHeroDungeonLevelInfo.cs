using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001154 RID: 4436
[Preserve]
public class Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo : LuaObject
{
	// Token: 0x060168B2 RID: 92338 RVA: 0x005FA0A0 File Offset: 0x005F82A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroDungeonLevelInfo o = new ConfigDataHeroDungeonLevelInfo();
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

	// Token: 0x060168B3 RID: 92339 RVA: 0x005FA0E8 File Offset: 0x005F82E8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_chapterId(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroDungeonLevelInfo configDataHeroDungeonLevelInfo = (ConfigDataHeroDungeonLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroDungeonLevelInfo.m_chapterId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060168B4 RID: 92340 RVA: 0x005FA13C File Offset: 0x005F833C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_chapterId(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroDungeonLevelInfo configDataHeroDungeonLevelInfo = (ConfigDataHeroDungeonLevelInfo)LuaObject.checkSelf(l);
			int chapterId;
			LuaObject.checkType(l, 2, out chapterId);
			configDataHeroDungeonLevelInfo.m_chapterId = chapterId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060168B5 RID: 92341 RVA: 0x005FA194 File Offset: 0x005F8394
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battleInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroDungeonLevelInfo configDataHeroDungeonLevelInfo = (ConfigDataHeroDungeonLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroDungeonLevelInfo.m_battleInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060168B6 RID: 92342 RVA: 0x005FA1E8 File Offset: 0x005F83E8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_battleInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroDungeonLevelInfo configDataHeroDungeonLevelInfo = (ConfigDataHeroDungeonLevelInfo)LuaObject.checkSelf(l);
			ConfigDataBattleInfo battleInfo;
			LuaObject.checkType<ConfigDataBattleInfo>(l, 2, out battleInfo);
			configDataHeroDungeonLevelInfo.m_battleInfo = battleInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060168B7 RID: 92343 RVA: 0x005FA240 File Offset: 0x005F8440
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_achievements(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroDungeonLevelInfo configDataHeroDungeonLevelInfo = (ConfigDataHeroDungeonLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroDungeonLevelInfo.m_achievements);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060168B8 RID: 92344 RVA: 0x005FA294 File Offset: 0x005F8494
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_achievements(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroDungeonLevelInfo configDataHeroDungeonLevelInfo = (ConfigDataHeroDungeonLevelInfo)LuaObject.checkSelf(l);
			BattleLevelAchievement[] achievements;
			LuaObject.checkArray<BattleLevelAchievement>(l, 2, out achievements);
			configDataHeroDungeonLevelInfo.m_achievements = achievements;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060168B9 RID: 92345 RVA: 0x005FA2EC File Offset: 0x005F84EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_dialogInfoBefore(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroDungeonLevelInfo configDataHeroDungeonLevelInfo = (ConfigDataHeroDungeonLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroDungeonLevelInfo.m_dialogInfoBefore);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060168BA RID: 92346 RVA: 0x005FA340 File Offset: 0x005F8540
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_dialogInfoBefore(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroDungeonLevelInfo configDataHeroDungeonLevelInfo = (ConfigDataHeroDungeonLevelInfo)LuaObject.checkSelf(l);
			ConfigDataDialogInfo dialogInfoBefore;
			LuaObject.checkType<ConfigDataDialogInfo>(l, 2, out dialogInfoBefore);
			configDataHeroDungeonLevelInfo.m_dialogInfoBefore = dialogInfoBefore;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060168BB RID: 92347 RVA: 0x005FA398 File Offset: 0x005F8598
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_dialogInfoAfter(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroDungeonLevelInfo configDataHeroDungeonLevelInfo = (ConfigDataHeroDungeonLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroDungeonLevelInfo.m_dialogInfoAfter);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060168BC RID: 92348 RVA: 0x005FA3EC File Offset: 0x005F85EC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_dialogInfoAfter(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroDungeonLevelInfo configDataHeroDungeonLevelInfo = (ConfigDataHeroDungeonLevelInfo)LuaObject.checkSelf(l);
			ConfigDataDialogInfo dialogInfoAfter;
			LuaObject.checkType<ConfigDataDialogInfo>(l, 2, out dialogInfoAfter);
			configDataHeroDungeonLevelInfo.m_dialogInfoAfter = dialogInfoAfter;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060168BD RID: 92349 RVA: 0x005FA444 File Offset: 0x005F8644
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroDungeonLevelInfo configDataHeroDungeonLevelInfo = (ConfigDataHeroDungeonLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroDungeonLevelInfo.ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060168BE RID: 92350 RVA: 0x005FA498 File Offset: 0x005F8698
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroDungeonLevelInfo configDataHeroDungeonLevelInfo = (ConfigDataHeroDungeonLevelInfo)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			configDataHeroDungeonLevelInfo.ID = id;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060168BF RID: 92351 RVA: 0x005FA4F0 File Offset: 0x005F86F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Name(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroDungeonLevelInfo configDataHeroDungeonLevelInfo = (ConfigDataHeroDungeonLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroDungeonLevelInfo.Name);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060168C0 RID: 92352 RVA: 0x005FA544 File Offset: 0x005F8744
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Name(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroDungeonLevelInfo configDataHeroDungeonLevelInfo = (ConfigDataHeroDungeonLevelInfo)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			configDataHeroDungeonLevelInfo.Name = name;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060168C1 RID: 92353 RVA: 0x005FA59C File Offset: 0x005F879C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Desc(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroDungeonLevelInfo configDataHeroDungeonLevelInfo = (ConfigDataHeroDungeonLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroDungeonLevelInfo.Desc);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060168C2 RID: 92354 RVA: 0x005FA5F0 File Offset: 0x005F87F0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Desc(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroDungeonLevelInfo configDataHeroDungeonLevelInfo = (ConfigDataHeroDungeonLevelInfo)LuaObject.checkSelf(l);
			string desc;
			LuaObject.checkType(l, 2, out desc);
			configDataHeroDungeonLevelInfo.Desc = desc;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060168C3 RID: 92355 RVA: 0x005FA648 File Offset: 0x005F8848
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_NameNum(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroDungeonLevelInfo configDataHeroDungeonLevelInfo = (ConfigDataHeroDungeonLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroDungeonLevelInfo.NameNum);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060168C4 RID: 92356 RVA: 0x005FA69C File Offset: 0x005F889C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_NameNum(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroDungeonLevelInfo configDataHeroDungeonLevelInfo = (ConfigDataHeroDungeonLevelInfo)LuaObject.checkSelf(l);
			string nameNum;
			LuaObject.checkType(l, 2, out nameNum);
			configDataHeroDungeonLevelInfo.NameNum = nameNum;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060168C5 RID: 92357 RVA: 0x005FA6F4 File Offset: 0x005F88F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Resource(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroDungeonLevelInfo configDataHeroDungeonLevelInfo = (ConfigDataHeroDungeonLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroDungeonLevelInfo.Resource);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060168C6 RID: 92358 RVA: 0x005FA748 File Offset: 0x005F8948
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Resource(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroDungeonLevelInfo configDataHeroDungeonLevelInfo = (ConfigDataHeroDungeonLevelInfo)LuaObject.checkSelf(l);
			string resource;
			LuaObject.checkType(l, 2, out resource);
			configDataHeroDungeonLevelInfo.Resource = resource;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060168C7 RID: 92359 RVA: 0x005FA7A0 File Offset: 0x005F89A0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ChallengeCount(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroDungeonLevelInfo configDataHeroDungeonLevelInfo = (ConfigDataHeroDungeonLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroDungeonLevelInfo.ChallengeCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060168C8 RID: 92360 RVA: 0x005FA7F4 File Offset: 0x005F89F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ChallengeCount(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroDungeonLevelInfo configDataHeroDungeonLevelInfo = (ConfigDataHeroDungeonLevelInfo)LuaObject.checkSelf(l);
			int challengeCount;
			LuaObject.checkType(l, 2, out challengeCount);
			configDataHeroDungeonLevelInfo.ChallengeCount = challengeCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060168C9 RID: 92361 RVA: 0x005FA84C File Offset: 0x005F8A4C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_EnergySuccess(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroDungeonLevelInfo configDataHeroDungeonLevelInfo = (ConfigDataHeroDungeonLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroDungeonLevelInfo.EnergySuccess);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060168CA RID: 92362 RVA: 0x005FA8A0 File Offset: 0x005F8AA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EnergySuccess(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroDungeonLevelInfo configDataHeroDungeonLevelInfo = (ConfigDataHeroDungeonLevelInfo)LuaObject.checkSelf(l);
			int energySuccess;
			LuaObject.checkType(l, 2, out energySuccess);
			configDataHeroDungeonLevelInfo.EnergySuccess = energySuccess;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060168CB RID: 92363 RVA: 0x005FA8F8 File Offset: 0x005F8AF8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_EnergyFail(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroDungeonLevelInfo configDataHeroDungeonLevelInfo = (ConfigDataHeroDungeonLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroDungeonLevelInfo.EnergyFail);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060168CC RID: 92364 RVA: 0x005FA94C File Offset: 0x005F8B4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EnergyFail(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroDungeonLevelInfo configDataHeroDungeonLevelInfo = (ConfigDataHeroDungeonLevelInfo)LuaObject.checkSelf(l);
			int energyFail;
			LuaObject.checkType(l, 2, out energyFail);
			configDataHeroDungeonLevelInfo.EnergyFail = energyFail;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060168CD RID: 92365 RVA: 0x005FA9A4 File Offset: 0x005F8BA4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_MonsterLevel(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroDungeonLevelInfo configDataHeroDungeonLevelInfo = (ConfigDataHeroDungeonLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroDungeonLevelInfo.MonsterLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060168CE RID: 92366 RVA: 0x005FA9F8 File Offset: 0x005F8BF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_MonsterLevel(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroDungeonLevelInfo configDataHeroDungeonLevelInfo = (ConfigDataHeroDungeonLevelInfo)LuaObject.checkSelf(l);
			int monsterLevel;
			LuaObject.checkType(l, 2, out monsterLevel);
			configDataHeroDungeonLevelInfo.MonsterLevel = monsterLevel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060168CF RID: 92367 RVA: 0x005FAA50 File Offset: 0x005F8C50
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Battle_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroDungeonLevelInfo configDataHeroDungeonLevelInfo = (ConfigDataHeroDungeonLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroDungeonLevelInfo.Battle_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060168D0 RID: 92368 RVA: 0x005FAAA4 File Offset: 0x005F8CA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Battle_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroDungeonLevelInfo configDataHeroDungeonLevelInfo = (ConfigDataHeroDungeonLevelInfo)LuaObject.checkSelf(l);
			int battle_ID;
			LuaObject.checkType(l, 2, out battle_ID);
			configDataHeroDungeonLevelInfo.Battle_ID = battle_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060168D1 RID: 92369 RVA: 0x005FAAFC File Offset: 0x005F8CFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_DialogBefore_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroDungeonLevelInfo configDataHeroDungeonLevelInfo = (ConfigDataHeroDungeonLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroDungeonLevelInfo.DialogBefore_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060168D2 RID: 92370 RVA: 0x005FAB50 File Offset: 0x005F8D50
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_DialogBefore_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroDungeonLevelInfo configDataHeroDungeonLevelInfo = (ConfigDataHeroDungeonLevelInfo)LuaObject.checkSelf(l);
			int dialogBefore_ID;
			LuaObject.checkType(l, 2, out dialogBefore_ID);
			configDataHeroDungeonLevelInfo.DialogBefore_ID = dialogBefore_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060168D3 RID: 92371 RVA: 0x005FABA8 File Offset: 0x005F8DA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_DialogAfter_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroDungeonLevelInfo configDataHeroDungeonLevelInfo = (ConfigDataHeroDungeonLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroDungeonLevelInfo.DialogAfter_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060168D4 RID: 92372 RVA: 0x005FABFC File Offset: 0x005F8DFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_DialogAfter_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroDungeonLevelInfo configDataHeroDungeonLevelInfo = (ConfigDataHeroDungeonLevelInfo)LuaObject.checkSelf(l);
			int dialogAfter_ID;
			LuaObject.checkType(l, 2, out dialogAfter_ID);
			configDataHeroDungeonLevelInfo.DialogAfter_ID = dialogAfter_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060168D5 RID: 92373 RVA: 0x005FAC54 File Offset: 0x005F8E54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PreLevel_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroDungeonLevelInfo configDataHeroDungeonLevelInfo = (ConfigDataHeroDungeonLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroDungeonLevelInfo.PreLevel_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060168D6 RID: 92374 RVA: 0x005FACA8 File Offset: 0x005F8EA8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_PreLevel_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroDungeonLevelInfo configDataHeroDungeonLevelInfo = (ConfigDataHeroDungeonLevelInfo)LuaObject.checkSelf(l);
			int preLevel_ID;
			LuaObject.checkType(l, 2, out preLevel_ID);
			configDataHeroDungeonLevelInfo.PreLevel_ID = preLevel_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060168D7 RID: 92375 RVA: 0x005FAD00 File Offset: 0x005F8F00
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_PlayerLevel(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroDungeonLevelInfo configDataHeroDungeonLevelInfo = (ConfigDataHeroDungeonLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroDungeonLevelInfo.PlayerLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060168D8 RID: 92376 RVA: 0x005FAD54 File Offset: 0x005F8F54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_PlayerLevel(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroDungeonLevelInfo configDataHeroDungeonLevelInfo = (ConfigDataHeroDungeonLevelInfo)LuaObject.checkSelf(l);
			int playerLevel;
			LuaObject.checkType(l, 2, out playerLevel);
			configDataHeroDungeonLevelInfo.PlayerLevel = playerLevel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060168D9 RID: 92377 RVA: 0x005FADAC File Offset: 0x005F8FAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UnlockConditions(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroDungeonLevelInfo configDataHeroDungeonLevelInfo = (ConfigDataHeroDungeonLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroDungeonLevelInfo.UnlockConditions);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060168DA RID: 92378 RVA: 0x005FAE00 File Offset: 0x005F9000
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_StarTurnMax(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroDungeonLevelInfo configDataHeroDungeonLevelInfo = (ConfigDataHeroDungeonLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroDungeonLevelInfo.StarTurnMax);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060168DB RID: 92379 RVA: 0x005FAE54 File Offset: 0x005F9054
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_StarTurnMax(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroDungeonLevelInfo configDataHeroDungeonLevelInfo = (ConfigDataHeroDungeonLevelInfo)LuaObject.checkSelf(l);
			int starTurnMax;
			LuaObject.checkType(l, 2, out starTurnMax);
			configDataHeroDungeonLevelInfo.StarTurnMax = starTurnMax;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060168DC RID: 92380 RVA: 0x005FAEAC File Offset: 0x005F90AC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_StarDeadMax(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroDungeonLevelInfo configDataHeroDungeonLevelInfo = (ConfigDataHeroDungeonLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroDungeonLevelInfo.StarDeadMax);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060168DD RID: 92381 RVA: 0x005FAF00 File Offset: 0x005F9100
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_StarDeadMax(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroDungeonLevelInfo configDataHeroDungeonLevelInfo = (ConfigDataHeroDungeonLevelInfo)LuaObject.checkSelf(l);
			int starDeadMax;
			LuaObject.checkType(l, 2, out starDeadMax);
			configDataHeroDungeonLevelInfo.StarDeadMax = starDeadMax;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060168DE RID: 92382 RVA: 0x005FAF58 File Offset: 0x005F9158
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Achievement1_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroDungeonLevelInfo configDataHeroDungeonLevelInfo = (ConfigDataHeroDungeonLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroDungeonLevelInfo.Achievement1_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060168DF RID: 92383 RVA: 0x005FAFAC File Offset: 0x005F91AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Achievement1_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroDungeonLevelInfo configDataHeroDungeonLevelInfo = (ConfigDataHeroDungeonLevelInfo)LuaObject.checkSelf(l);
			int achievement1_ID;
			LuaObject.checkType(l, 2, out achievement1_ID);
			configDataHeroDungeonLevelInfo.Achievement1_ID = achievement1_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060168E0 RID: 92384 RVA: 0x005FB004 File Offset: 0x005F9204
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_AchievementReward1(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroDungeonLevelInfo configDataHeroDungeonLevelInfo = (ConfigDataHeroDungeonLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroDungeonLevelInfo.AchievementReward1);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060168E1 RID: 92385 RVA: 0x005FB058 File Offset: 0x005F9258
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Achievement2_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroDungeonLevelInfo configDataHeroDungeonLevelInfo = (ConfigDataHeroDungeonLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroDungeonLevelInfo.Achievement2_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060168E2 RID: 92386 RVA: 0x005FB0AC File Offset: 0x005F92AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Achievement2_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroDungeonLevelInfo configDataHeroDungeonLevelInfo = (ConfigDataHeroDungeonLevelInfo)LuaObject.checkSelf(l);
			int achievement2_ID;
			LuaObject.checkType(l, 2, out achievement2_ID);
			configDataHeroDungeonLevelInfo.Achievement2_ID = achievement2_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060168E3 RID: 92387 RVA: 0x005FB104 File Offset: 0x005F9304
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_AchievementReward2(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroDungeonLevelInfo configDataHeroDungeonLevelInfo = (ConfigDataHeroDungeonLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroDungeonLevelInfo.AchievementReward2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060168E4 RID: 92388 RVA: 0x005FB158 File Offset: 0x005F9358
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Achievement3_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroDungeonLevelInfo configDataHeroDungeonLevelInfo = (ConfigDataHeroDungeonLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroDungeonLevelInfo.Achievement3_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060168E5 RID: 92389 RVA: 0x005FB1AC File Offset: 0x005F93AC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Achievement3_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroDungeonLevelInfo configDataHeroDungeonLevelInfo = (ConfigDataHeroDungeonLevelInfo)LuaObject.checkSelf(l);
			int achievement3_ID;
			LuaObject.checkType(l, 2, out achievement3_ID);
			configDataHeroDungeonLevelInfo.Achievement3_ID = achievement3_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060168E6 RID: 92390 RVA: 0x005FB204 File Offset: 0x005F9404
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_AchievementReward3(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroDungeonLevelInfo configDataHeroDungeonLevelInfo = (ConfigDataHeroDungeonLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroDungeonLevelInfo.AchievementReward3);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060168E7 RID: 92391 RVA: 0x005FB258 File Offset: 0x005F9458
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PlayerExpReward(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroDungeonLevelInfo configDataHeroDungeonLevelInfo = (ConfigDataHeroDungeonLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroDungeonLevelInfo.PlayerExpReward);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060168E8 RID: 92392 RVA: 0x005FB2AC File Offset: 0x005F94AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_PlayerExpReward(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroDungeonLevelInfo configDataHeroDungeonLevelInfo = (ConfigDataHeroDungeonLevelInfo)LuaObject.checkSelf(l);
			int playerExpReward;
			LuaObject.checkType(l, 2, out playerExpReward);
			configDataHeroDungeonLevelInfo.PlayerExpReward = playerExpReward;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060168E9 RID: 92393 RVA: 0x005FB304 File Offset: 0x005F9504
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_HeroExpReward(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroDungeonLevelInfo configDataHeroDungeonLevelInfo = (ConfigDataHeroDungeonLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroDungeonLevelInfo.HeroExpReward);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060168EA RID: 92394 RVA: 0x005FB358 File Offset: 0x005F9558
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_HeroExpReward(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroDungeonLevelInfo configDataHeroDungeonLevelInfo = (ConfigDataHeroDungeonLevelInfo)LuaObject.checkSelf(l);
			int heroExpReward;
			LuaObject.checkType(l, 2, out heroExpReward);
			configDataHeroDungeonLevelInfo.HeroExpReward = heroExpReward;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060168EB RID: 92395 RVA: 0x005FB3B0 File Offset: 0x005F95B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_GoldReward(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroDungeonLevelInfo configDataHeroDungeonLevelInfo = (ConfigDataHeroDungeonLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroDungeonLevelInfo.GoldReward);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060168EC RID: 92396 RVA: 0x005FB404 File Offset: 0x005F9604
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_GoldReward(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroDungeonLevelInfo configDataHeroDungeonLevelInfo = (ConfigDataHeroDungeonLevelInfo)LuaObject.checkSelf(l);
			int goldReward;
			LuaObject.checkType(l, 2, out goldReward);
			configDataHeroDungeonLevelInfo.GoldReward = goldReward;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060168ED RID: 92397 RVA: 0x005FB45C File Offset: 0x005F965C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_FirstReward(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroDungeonLevelInfo configDataHeroDungeonLevelInfo = (ConfigDataHeroDungeonLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroDungeonLevelInfo.FirstReward);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060168EE RID: 92398 RVA: 0x005FB4B0 File Offset: 0x005F96B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_RaidReward(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroDungeonLevelInfo configDataHeroDungeonLevelInfo = (ConfigDataHeroDungeonLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroDungeonLevelInfo.RaidReward);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060168EF RID: 92399 RVA: 0x005FB504 File Offset: 0x005F9704
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Drop_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroDungeonLevelInfo configDataHeroDungeonLevelInfo = (ConfigDataHeroDungeonLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroDungeonLevelInfo.Drop_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060168F0 RID: 92400 RVA: 0x005FB558 File Offset: 0x005F9758
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Drop_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroDungeonLevelInfo configDataHeroDungeonLevelInfo = (ConfigDataHeroDungeonLevelInfo)LuaObject.checkSelf(l);
			int drop_ID;
			LuaObject.checkType(l, 2, out drop_ID);
			configDataHeroDungeonLevelInfo.Drop_ID = drop_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060168F1 RID: 92401 RVA: 0x005FB5B0 File Offset: 0x005F97B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_OperationalActivityDrop_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroDungeonLevelInfo configDataHeroDungeonLevelInfo = (ConfigDataHeroDungeonLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroDungeonLevelInfo.OperationalActivityDrop_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060168F2 RID: 92402 RVA: 0x005FB604 File Offset: 0x005F9804
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_OperationalActivityDrop_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroDungeonLevelInfo configDataHeroDungeonLevelInfo = (ConfigDataHeroDungeonLevelInfo)LuaObject.checkSelf(l);
			int operationalActivityDrop_ID;
			LuaObject.checkType(l, 2, out operationalActivityDrop_ID);
			configDataHeroDungeonLevelInfo.OperationalActivityDrop_ID = operationalActivityDrop_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060168F3 RID: 92403 RVA: 0x005FB65C File Offset: 0x005F985C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_DisplayRewardCount(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroDungeonLevelInfo configDataHeroDungeonLevelInfo = (ConfigDataHeroDungeonLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroDungeonLevelInfo.DisplayRewardCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060168F4 RID: 92404 RVA: 0x005FB6B0 File Offset: 0x005F98B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_DisplayRewardCount(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroDungeonLevelInfo configDataHeroDungeonLevelInfo = (ConfigDataHeroDungeonLevelInfo)LuaObject.checkSelf(l);
			int displayRewardCount;
			LuaObject.checkType(l, 2, out displayRewardCount);
			configDataHeroDungeonLevelInfo.DisplayRewardCount = displayRewardCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060168F5 RID: 92405 RVA: 0x005FB708 File Offset: 0x005F9908
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Strategy(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroDungeonLevelInfo configDataHeroDungeonLevelInfo = (ConfigDataHeroDungeonLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroDungeonLevelInfo.Strategy);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060168F6 RID: 92406 RVA: 0x005FB75C File Offset: 0x005F995C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Strategy(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroDungeonLevelInfo configDataHeroDungeonLevelInfo = (ConfigDataHeroDungeonLevelInfo)LuaObject.checkSelf(l);
			string strategy;
			LuaObject.checkType(l, 2, out strategy);
			configDataHeroDungeonLevelInfo.Strategy = strategy;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060168F7 RID: 92407 RVA: 0x005FB7B4 File Offset: 0x005F99B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_HeroFragment_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroDungeonLevelInfo configDataHeroDungeonLevelInfo = (ConfigDataHeroDungeonLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroDungeonLevelInfo.HeroFragment_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060168F8 RID: 92408 RVA: 0x005FB808 File Offset: 0x005F9A08
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_HeroFragment_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroDungeonLevelInfo configDataHeroDungeonLevelInfo = (ConfigDataHeroDungeonLevelInfo)LuaObject.checkSelf(l);
			int heroFragment_ID;
			LuaObject.checkType(l, 2, out heroFragment_ID);
			configDataHeroDungeonLevelInfo.HeroFragment_ID = heroFragment_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060168F9 RID: 92409 RVA: 0x005FB860 File Offset: 0x005F9A60
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ConfigData.ConfigDataHeroDungeonLevelInfo");
		string name = "m_chapterId";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.get_m_chapterId);
		}
		LuaCSFunction get = Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache0;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.set_m_chapterId);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache1, true);
		string name2 = "m_battleInfo";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.get_m_battleInfo);
		}
		LuaCSFunction get2 = Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache2;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.set_m_battleInfo);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache3, true);
		string name3 = "m_achievements";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.get_m_achievements);
		}
		LuaCSFunction get3 = Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache4;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.set_m_achievements);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache5, true);
		string name4 = "m_dialogInfoBefore";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.get_m_dialogInfoBefore);
		}
		LuaCSFunction get4 = Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache6;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.set_m_dialogInfoBefore);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache7, true);
		string name5 = "m_dialogInfoAfter";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.get_m_dialogInfoAfter);
		}
		LuaCSFunction get5 = Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache8;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.set_m_dialogInfoAfter);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache9, true);
		string name6 = "ID";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.get_ID);
		}
		LuaCSFunction get6 = Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cacheA;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.set_ID);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cacheB, true);
		string name7 = "Name";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.get_Name);
		}
		LuaCSFunction get7 = Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cacheC;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.set_Name);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cacheD, true);
		string name8 = "Desc";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.get_Desc);
		}
		LuaCSFunction get8 = Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cacheE;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.set_Desc);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cacheF, true);
		string name9 = "NameNum";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.get_NameNum);
		}
		LuaCSFunction get9 = Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache10;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.set_NameNum);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache11, true);
		string name10 = "Resource";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.get_Resource);
		}
		LuaCSFunction get10 = Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache12;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.set_Resource);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache13, true);
		string name11 = "ChallengeCount";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.get_ChallengeCount);
		}
		LuaCSFunction get11 = Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache14;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.set_ChallengeCount);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache15, true);
		string name12 = "EnergySuccess";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.get_EnergySuccess);
		}
		LuaCSFunction get12 = Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache16;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.set_EnergySuccess);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache17, true);
		string name13 = "EnergyFail";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.get_EnergyFail);
		}
		LuaCSFunction get13 = Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache18;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.set_EnergyFail);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache19, true);
		string name14 = "MonsterLevel";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.get_MonsterLevel);
		}
		LuaCSFunction get14 = Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache1A;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.set_MonsterLevel);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache1B, true);
		string name15 = "Battle_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.get_Battle_ID);
		}
		LuaCSFunction get15 = Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache1C;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.set_Battle_ID);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache1D, true);
		string name16 = "DialogBefore_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.get_DialogBefore_ID);
		}
		LuaCSFunction get16 = Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache1E;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.set_DialogBefore_ID);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache1F, true);
		string name17 = "DialogAfter_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.get_DialogAfter_ID);
		}
		LuaCSFunction get17 = Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache20;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.set_DialogAfter_ID);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache21, true);
		string name18 = "PreLevel_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.get_PreLevel_ID);
		}
		LuaCSFunction get18 = Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache22;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.set_PreLevel_ID);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache23, true);
		string name19 = "PlayerLevel";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.get_PlayerLevel);
		}
		LuaCSFunction get19 = Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache24;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.set_PlayerLevel);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache25, true);
		string name20 = "UnlockConditions";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.get_UnlockConditions);
		}
		LuaObject.addMember(l, name20, Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache26, null, true);
		string name21 = "StarTurnMax";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.get_StarTurnMax);
		}
		LuaCSFunction get20 = Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache27;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.set_StarTurnMax);
		}
		LuaObject.addMember(l, name21, get20, Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache28, true);
		string name22 = "StarDeadMax";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.get_StarDeadMax);
		}
		LuaCSFunction get21 = Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache29;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.set_StarDeadMax);
		}
		LuaObject.addMember(l, name22, get21, Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache2A, true);
		string name23 = "Achievement1_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.get_Achievement1_ID);
		}
		LuaCSFunction get22 = Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache2B;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.set_Achievement1_ID);
		}
		LuaObject.addMember(l, name23, get22, Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache2C, true);
		string name24 = "AchievementReward1";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.get_AchievementReward1);
		}
		LuaObject.addMember(l, name24, Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache2D, null, true);
		string name25 = "Achievement2_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.get_Achievement2_ID);
		}
		LuaCSFunction get23 = Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache2E;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.set_Achievement2_ID);
		}
		LuaObject.addMember(l, name25, get23, Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache2F, true);
		string name26 = "AchievementReward2";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.get_AchievementReward2);
		}
		LuaObject.addMember(l, name26, Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache30, null, true);
		string name27 = "Achievement3_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.get_Achievement3_ID);
		}
		LuaCSFunction get24 = Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache31;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.set_Achievement3_ID);
		}
		LuaObject.addMember(l, name27, get24, Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache32, true);
		string name28 = "AchievementReward3";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.get_AchievementReward3);
		}
		LuaObject.addMember(l, name28, Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache33, null, true);
		string name29 = "PlayerExpReward";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.get_PlayerExpReward);
		}
		LuaCSFunction get25 = Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache34;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.set_PlayerExpReward);
		}
		LuaObject.addMember(l, name29, get25, Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache35, true);
		string name30 = "HeroExpReward";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.get_HeroExpReward);
		}
		LuaCSFunction get26 = Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache36;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.set_HeroExpReward);
		}
		LuaObject.addMember(l, name30, get26, Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache37, true);
		string name31 = "GoldReward";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.get_GoldReward);
		}
		LuaCSFunction get27 = Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache38;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.set_GoldReward);
		}
		LuaObject.addMember(l, name31, get27, Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache39, true);
		string name32 = "FirstReward";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.get_FirstReward);
		}
		LuaObject.addMember(l, name32, Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache3A, null, true);
		string name33 = "RaidReward";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.get_RaidReward);
		}
		LuaObject.addMember(l, name33, Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache3B, null, true);
		string name34 = "Drop_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.get_Drop_ID);
		}
		LuaCSFunction get28 = Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache3C;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.set_Drop_ID);
		}
		LuaObject.addMember(l, name34, get28, Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache3D, true);
		string name35 = "OperationalActivityDrop_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.get_OperationalActivityDrop_ID);
		}
		LuaCSFunction get29 = Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache3E;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.set_OperationalActivityDrop_ID);
		}
		LuaObject.addMember(l, name35, get29, Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache3F, true);
		string name36 = "DisplayRewardCount";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.get_DisplayRewardCount);
		}
		LuaCSFunction get30 = Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache40;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.set_DisplayRewardCount);
		}
		LuaObject.addMember(l, name36, get30, Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache41, true);
		string name37 = "Strategy";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.get_Strategy);
		}
		LuaCSFunction get31 = Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache42;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.set_Strategy);
		}
		LuaObject.addMember(l, name37, get31, Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache43, true);
		string name38 = "HeroFragment_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.get_HeroFragment_ID);
		}
		LuaCSFunction get32 = Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache44;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.set_HeroFragment_ID);
		}
		LuaObject.addMember(l, name38, get32, Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache45, true);
		if (Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ConfigData_ConfigDataHeroDungeonLevelInfo.<>f__mg$cache46, typeof(ConfigDataHeroDungeonLevelInfo));
	}

	// Token: 0x0400CFEC RID: 53228
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400CFED RID: 53229
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400CFEE RID: 53230
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400CFEF RID: 53231
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400CFF0 RID: 53232
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400CFF1 RID: 53233
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400CFF2 RID: 53234
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400CFF3 RID: 53235
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400CFF4 RID: 53236
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400CFF5 RID: 53237
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400CFF6 RID: 53238
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400CFF7 RID: 53239
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400CFF8 RID: 53240
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400CFF9 RID: 53241
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400CFFA RID: 53242
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400CFFB RID: 53243
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400CFFC RID: 53244
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400CFFD RID: 53245
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400CFFE RID: 53246
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400CFFF RID: 53247
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400D000 RID: 53248
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400D001 RID: 53249
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400D002 RID: 53250
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400D003 RID: 53251
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400D004 RID: 53252
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400D005 RID: 53253
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400D006 RID: 53254
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400D007 RID: 53255
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400D008 RID: 53256
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400D009 RID: 53257
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400D00A RID: 53258
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400D00B RID: 53259
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400D00C RID: 53260
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400D00D RID: 53261
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400D00E RID: 53262
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400D00F RID: 53263
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0400D010 RID: 53264
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0400D011 RID: 53265
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0400D012 RID: 53266
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0400D013 RID: 53267
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0400D014 RID: 53268
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0400D015 RID: 53269
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0400D016 RID: 53270
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0400D017 RID: 53271
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0400D018 RID: 53272
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0400D019 RID: 53273
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0400D01A RID: 53274
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x0400D01B RID: 53275
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x0400D01C RID: 53276
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x0400D01D RID: 53277
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x0400D01E RID: 53278
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x0400D01F RID: 53279
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x0400D020 RID: 53280
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x0400D021 RID: 53281
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x0400D022 RID: 53282
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x0400D023 RID: 53283
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x0400D024 RID: 53284
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x0400D025 RID: 53285
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x0400D026 RID: 53286
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x0400D027 RID: 53287
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x0400D028 RID: 53288
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x0400D029 RID: 53289
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x0400D02A RID: 53290
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x0400D02B RID: 53291
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x0400D02C RID: 53292
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x0400D02D RID: 53293
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x0400D02E RID: 53294
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x0400D02F RID: 53295
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x0400D030 RID: 53296
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x0400D031 RID: 53297
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x0400D032 RID: 53298
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;
}
