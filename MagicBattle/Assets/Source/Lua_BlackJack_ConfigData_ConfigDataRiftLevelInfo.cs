using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001167 RID: 4455
[Preserve]
public class Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo : LuaObject
{
	// Token: 0x06016C1F RID: 93215 RVA: 0x00613104 File Offset: 0x00611304
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftLevelInfo o = new ConfigDataRiftLevelInfo();
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

	// Token: 0x06016C20 RID: 93216 RVA: 0x0061314C File Offset: 0x0061134C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battleInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftLevelInfo configDataRiftLevelInfo = (ConfigDataRiftLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataRiftLevelInfo.m_battleInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C21 RID: 93217 RVA: 0x006131A0 File Offset: 0x006113A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battleInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftLevelInfo configDataRiftLevelInfo = (ConfigDataRiftLevelInfo)LuaObject.checkSelf(l);
			ConfigDataBattleInfo battleInfo;
			LuaObject.checkType<ConfigDataBattleInfo>(l, 2, out battleInfo);
			configDataRiftLevelInfo.m_battleInfo = battleInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C22 RID: 93218 RVA: 0x006131F8 File Offset: 0x006113F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_chapterId(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftLevelInfo configDataRiftLevelInfo = (ConfigDataRiftLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataRiftLevelInfo.m_chapterId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C23 RID: 93219 RVA: 0x0061324C File Offset: 0x0061144C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_chapterId(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftLevelInfo configDataRiftLevelInfo = (ConfigDataRiftLevelInfo)LuaObject.checkSelf(l);
			int chapterId;
			LuaObject.checkType(l, 2, out chapterId);
			configDataRiftLevelInfo.m_chapterId = chapterId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C24 RID: 93220 RVA: 0x006132A4 File Offset: 0x006114A4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_chapterInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftLevelInfo configDataRiftLevelInfo = (ConfigDataRiftLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataRiftLevelInfo.m_chapterInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C25 RID: 93221 RVA: 0x006132F8 File Offset: 0x006114F8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_chapterInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftLevelInfo configDataRiftLevelInfo = (ConfigDataRiftLevelInfo)LuaObject.checkSelf(l);
			ConfigDataRiftChapterInfo chapterInfo;
			LuaObject.checkType<ConfigDataRiftChapterInfo>(l, 2, out chapterInfo);
			configDataRiftLevelInfo.m_chapterInfo = chapterInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C26 RID: 93222 RVA: 0x00613350 File Offset: 0x00611550
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_achievements(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftLevelInfo configDataRiftLevelInfo = (ConfigDataRiftLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataRiftLevelInfo.m_achievements);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C27 RID: 93223 RVA: 0x006133A4 File Offset: 0x006115A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_achievements(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftLevelInfo configDataRiftLevelInfo = (ConfigDataRiftLevelInfo)LuaObject.checkSelf(l);
			BattleLevelAchievement[] achievements;
			LuaObject.checkArray<BattleLevelAchievement>(l, 2, out achievements);
			configDataRiftLevelInfo.m_achievements = achievements;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C28 RID: 93224 RVA: 0x006133FC File Offset: 0x006115FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftLevelInfo configDataRiftLevelInfo = (ConfigDataRiftLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataRiftLevelInfo.ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C29 RID: 93225 RVA: 0x00613450 File Offset: 0x00611650
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftLevelInfo configDataRiftLevelInfo = (ConfigDataRiftLevelInfo)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			configDataRiftLevelInfo.ID = id;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C2A RID: 93226 RVA: 0x006134A8 File Offset: 0x006116A8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Name(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftLevelInfo configDataRiftLevelInfo = (ConfigDataRiftLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataRiftLevelInfo.Name);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C2B RID: 93227 RVA: 0x006134FC File Offset: 0x006116FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Name(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftLevelInfo configDataRiftLevelInfo = (ConfigDataRiftLevelInfo)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			configDataRiftLevelInfo.Name = name;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C2C RID: 93228 RVA: 0x00613554 File Offset: 0x00611754
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_NameStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftLevelInfo configDataRiftLevelInfo = (ConfigDataRiftLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataRiftLevelInfo.NameStrKey);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C2D RID: 93229 RVA: 0x006135A8 File Offset: 0x006117A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_NameStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftLevelInfo configDataRiftLevelInfo = (ConfigDataRiftLevelInfo)LuaObject.checkSelf(l);
			string nameStrKey;
			LuaObject.checkType(l, 2, out nameStrKey);
			configDataRiftLevelInfo.NameStrKey = nameStrKey;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C2E RID: 93230 RVA: 0x00613600 File Offset: 0x00611800
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Desc(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftLevelInfo configDataRiftLevelInfo = (ConfigDataRiftLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataRiftLevelInfo.Desc);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C2F RID: 93231 RVA: 0x00613654 File Offset: 0x00611854
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Desc(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftLevelInfo configDataRiftLevelInfo = (ConfigDataRiftLevelInfo)LuaObject.checkSelf(l);
			string desc;
			LuaObject.checkType(l, 2, out desc);
			configDataRiftLevelInfo.Desc = desc;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C30 RID: 93232 RVA: 0x006136AC File Offset: 0x006118AC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_DescStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftLevelInfo configDataRiftLevelInfo = (ConfigDataRiftLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataRiftLevelInfo.DescStrKey);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C31 RID: 93233 RVA: 0x00613700 File Offset: 0x00611900
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_DescStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftLevelInfo configDataRiftLevelInfo = (ConfigDataRiftLevelInfo)LuaObject.checkSelf(l);
			string descStrKey;
			LuaObject.checkType(l, 2, out descStrKey);
			configDataRiftLevelInfo.DescStrKey = descStrKey;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C32 RID: 93234 RVA: 0x00613758 File Offset: 0x00611958
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ChapterID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftLevelInfo configDataRiftLevelInfo = (ConfigDataRiftLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataRiftLevelInfo.ChapterID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C33 RID: 93235 RVA: 0x006137AC File Offset: 0x006119AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ChapterID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftLevelInfo configDataRiftLevelInfo = (ConfigDataRiftLevelInfo)LuaObject.checkSelf(l);
			int chapterID;
			LuaObject.checkType(l, 2, out chapterID);
			configDataRiftLevelInfo.ChapterID = chapterID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C34 RID: 93236 RVA: 0x00613804 File Offset: 0x00611A04
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_OwnNum(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftLevelInfo configDataRiftLevelInfo = (ConfigDataRiftLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataRiftLevelInfo.OwnNum);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C35 RID: 93237 RVA: 0x00613858 File Offset: 0x00611A58
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_OwnNum(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftLevelInfo configDataRiftLevelInfo = (ConfigDataRiftLevelInfo)LuaObject.checkSelf(l);
			int ownNum;
			LuaObject.checkType(l, 2, out ownNum);
			configDataRiftLevelInfo.OwnNum = ownNum;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C36 RID: 93238 RVA: 0x006138B0 File Offset: 0x00611AB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_NameNum(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftLevelInfo configDataRiftLevelInfo = (ConfigDataRiftLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataRiftLevelInfo.NameNum);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C37 RID: 93239 RVA: 0x00613904 File Offset: 0x00611B04
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_NameNum(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftLevelInfo configDataRiftLevelInfo = (ConfigDataRiftLevelInfo)LuaObject.checkSelf(l);
			string nameNum;
			LuaObject.checkType(l, 2, out nameNum);
			configDataRiftLevelInfo.NameNum = nameNum;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C38 RID: 93240 RVA: 0x0061395C File Offset: 0x00611B5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ChallengeCount(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftLevelInfo configDataRiftLevelInfo = (ConfigDataRiftLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataRiftLevelInfo.ChallengeCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C39 RID: 93241 RVA: 0x006139B0 File Offset: 0x00611BB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ChallengeCount(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftLevelInfo configDataRiftLevelInfo = (ConfigDataRiftLevelInfo)LuaObject.checkSelf(l);
			int challengeCount;
			LuaObject.checkType(l, 2, out challengeCount);
			configDataRiftLevelInfo.ChallengeCount = challengeCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C3A RID: 93242 RVA: 0x00613A08 File Offset: 0x00611C08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_EnergySuccess(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftLevelInfo configDataRiftLevelInfo = (ConfigDataRiftLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataRiftLevelInfo.EnergySuccess);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C3B RID: 93243 RVA: 0x00613A5C File Offset: 0x00611C5C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_EnergySuccess(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftLevelInfo configDataRiftLevelInfo = (ConfigDataRiftLevelInfo)LuaObject.checkSelf(l);
			int energySuccess;
			LuaObject.checkType(l, 2, out energySuccess);
			configDataRiftLevelInfo.EnergySuccess = energySuccess;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C3C RID: 93244 RVA: 0x00613AB4 File Offset: 0x00611CB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_EnergyFail(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftLevelInfo configDataRiftLevelInfo = (ConfigDataRiftLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataRiftLevelInfo.EnergyFail);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C3D RID: 93245 RVA: 0x00613B08 File Offset: 0x00611D08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EnergyFail(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftLevelInfo configDataRiftLevelInfo = (ConfigDataRiftLevelInfo)LuaObject.checkSelf(l);
			int energyFail;
			LuaObject.checkType(l, 2, out energyFail);
			configDataRiftLevelInfo.EnergyFail = energyFail;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C3E RID: 93246 RVA: 0x00613B60 File Offset: 0x00611D60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_MonsterLevel(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftLevelInfo configDataRiftLevelInfo = (ConfigDataRiftLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataRiftLevelInfo.MonsterLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C3F RID: 93247 RVA: 0x00613BB4 File Offset: 0x00611DB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_MonsterLevel(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftLevelInfo configDataRiftLevelInfo = (ConfigDataRiftLevelInfo)LuaObject.checkSelf(l);
			int monsterLevel;
			LuaObject.checkType(l, 2, out monsterLevel);
			configDataRiftLevelInfo.MonsterLevel = monsterLevel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C40 RID: 93248 RVA: 0x00613C0C File Offset: 0x00611E0C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Battle_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftLevelInfo configDataRiftLevelInfo = (ConfigDataRiftLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataRiftLevelInfo.Battle_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C41 RID: 93249 RVA: 0x00613C60 File Offset: 0x00611E60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Battle_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftLevelInfo configDataRiftLevelInfo = (ConfigDataRiftLevelInfo)LuaObject.checkSelf(l);
			int battle_ID;
			LuaObject.checkType(l, 2, out battle_ID);
			configDataRiftLevelInfo.Battle_ID = battle_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C42 RID: 93250 RVA: 0x00613CB8 File Offset: 0x00611EB8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_PreLevel_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftLevelInfo configDataRiftLevelInfo = (ConfigDataRiftLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataRiftLevelInfo.PreLevel_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C43 RID: 93251 RVA: 0x00613D0C File Offset: 0x00611F0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_PreLevel_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftLevelInfo configDataRiftLevelInfo = (ConfigDataRiftLevelInfo)LuaObject.checkSelf(l);
			int preLevel_ID;
			LuaObject.checkType(l, 2, out preLevel_ID);
			configDataRiftLevelInfo.PreLevel_ID = preLevel_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C44 RID: 93252 RVA: 0x00613D64 File Offset: 0x00611F64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PlayerLevel(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftLevelInfo configDataRiftLevelInfo = (ConfigDataRiftLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataRiftLevelInfo.PlayerLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C45 RID: 93253 RVA: 0x00613DB8 File Offset: 0x00611FB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_PlayerLevel(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftLevelInfo configDataRiftLevelInfo = (ConfigDataRiftLevelInfo)LuaObject.checkSelf(l);
			int playerLevel;
			LuaObject.checkType(l, 2, out playerLevel);
			configDataRiftLevelInfo.PlayerLevel = playerLevel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C46 RID: 93254 RVA: 0x00613E10 File Offset: 0x00612010
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UnlockConditions(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftLevelInfo configDataRiftLevelInfo = (ConfigDataRiftLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataRiftLevelInfo.UnlockConditions);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C47 RID: 93255 RVA: 0x00613E64 File Offset: 0x00612064
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_StarTurnMax(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftLevelInfo configDataRiftLevelInfo = (ConfigDataRiftLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataRiftLevelInfo.StarTurnMax);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C48 RID: 93256 RVA: 0x00613EB8 File Offset: 0x006120B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_StarTurnMax(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftLevelInfo configDataRiftLevelInfo = (ConfigDataRiftLevelInfo)LuaObject.checkSelf(l);
			int starTurnMax;
			LuaObject.checkType(l, 2, out starTurnMax);
			configDataRiftLevelInfo.StarTurnMax = starTurnMax;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C49 RID: 93257 RVA: 0x00613F10 File Offset: 0x00612110
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_StarDeadMax(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftLevelInfo configDataRiftLevelInfo = (ConfigDataRiftLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataRiftLevelInfo.StarDeadMax);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C4A RID: 93258 RVA: 0x00613F64 File Offset: 0x00612164
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_StarDeadMax(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftLevelInfo configDataRiftLevelInfo = (ConfigDataRiftLevelInfo)LuaObject.checkSelf(l);
			int starDeadMax;
			LuaObject.checkType(l, 2, out starDeadMax);
			configDataRiftLevelInfo.StarDeadMax = starDeadMax;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C4B RID: 93259 RVA: 0x00613FBC File Offset: 0x006121BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Achievement1_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftLevelInfo configDataRiftLevelInfo = (ConfigDataRiftLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataRiftLevelInfo.Achievement1_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C4C RID: 93260 RVA: 0x00614010 File Offset: 0x00612210
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Achievement1_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftLevelInfo configDataRiftLevelInfo = (ConfigDataRiftLevelInfo)LuaObject.checkSelf(l);
			int achievement1_ID;
			LuaObject.checkType(l, 2, out achievement1_ID);
			configDataRiftLevelInfo.Achievement1_ID = achievement1_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C4D RID: 93261 RVA: 0x00614068 File Offset: 0x00612268
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_AchievementReward1(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftLevelInfo configDataRiftLevelInfo = (ConfigDataRiftLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataRiftLevelInfo.AchievementReward1);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C4E RID: 93262 RVA: 0x006140BC File Offset: 0x006122BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Achievement2_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftLevelInfo configDataRiftLevelInfo = (ConfigDataRiftLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataRiftLevelInfo.Achievement2_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C4F RID: 93263 RVA: 0x00614110 File Offset: 0x00612310
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Achievement2_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftLevelInfo configDataRiftLevelInfo = (ConfigDataRiftLevelInfo)LuaObject.checkSelf(l);
			int achievement2_ID;
			LuaObject.checkType(l, 2, out achievement2_ID);
			configDataRiftLevelInfo.Achievement2_ID = achievement2_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C50 RID: 93264 RVA: 0x00614168 File Offset: 0x00612368
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_AchievementReward2(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftLevelInfo configDataRiftLevelInfo = (ConfigDataRiftLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataRiftLevelInfo.AchievementReward2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C51 RID: 93265 RVA: 0x006141BC File Offset: 0x006123BC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Achievement3_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftLevelInfo configDataRiftLevelInfo = (ConfigDataRiftLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataRiftLevelInfo.Achievement3_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C52 RID: 93266 RVA: 0x00614210 File Offset: 0x00612410
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Achievement3_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftLevelInfo configDataRiftLevelInfo = (ConfigDataRiftLevelInfo)LuaObject.checkSelf(l);
			int achievement3_ID;
			LuaObject.checkType(l, 2, out achievement3_ID);
			configDataRiftLevelInfo.Achievement3_ID = achievement3_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C53 RID: 93267 RVA: 0x00614268 File Offset: 0x00612468
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_AchievementReward3(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftLevelInfo configDataRiftLevelInfo = (ConfigDataRiftLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataRiftLevelInfo.AchievementReward3);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C54 RID: 93268 RVA: 0x006142BC File Offset: 0x006124BC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_PlayerExpReward(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftLevelInfo configDataRiftLevelInfo = (ConfigDataRiftLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataRiftLevelInfo.PlayerExpReward);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C55 RID: 93269 RVA: 0x00614310 File Offset: 0x00612510
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_PlayerExpReward(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftLevelInfo configDataRiftLevelInfo = (ConfigDataRiftLevelInfo)LuaObject.checkSelf(l);
			int playerExpReward;
			LuaObject.checkType(l, 2, out playerExpReward);
			configDataRiftLevelInfo.PlayerExpReward = playerExpReward;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C56 RID: 93270 RVA: 0x00614368 File Offset: 0x00612568
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_HeroExpReward(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftLevelInfo configDataRiftLevelInfo = (ConfigDataRiftLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataRiftLevelInfo.HeroExpReward);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C57 RID: 93271 RVA: 0x006143BC File Offset: 0x006125BC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_HeroExpReward(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftLevelInfo configDataRiftLevelInfo = (ConfigDataRiftLevelInfo)LuaObject.checkSelf(l);
			int heroExpReward;
			LuaObject.checkType(l, 2, out heroExpReward);
			configDataRiftLevelInfo.HeroExpReward = heroExpReward;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C58 RID: 93272 RVA: 0x00614414 File Offset: 0x00612614
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_GoldReward(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftLevelInfo configDataRiftLevelInfo = (ConfigDataRiftLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataRiftLevelInfo.GoldReward);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C59 RID: 93273 RVA: 0x00614468 File Offset: 0x00612668
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_GoldReward(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftLevelInfo configDataRiftLevelInfo = (ConfigDataRiftLevelInfo)LuaObject.checkSelf(l);
			int goldReward;
			LuaObject.checkType(l, 2, out goldReward);
			configDataRiftLevelInfo.GoldReward = goldReward;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C5A RID: 93274 RVA: 0x006144C0 File Offset: 0x006126C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_FirstReward(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftLevelInfo configDataRiftLevelInfo = (ConfigDataRiftLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataRiftLevelInfo.FirstReward);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C5B RID: 93275 RVA: 0x00614514 File Offset: 0x00612714
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_RaidReward(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftLevelInfo configDataRiftLevelInfo = (ConfigDataRiftLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataRiftLevelInfo.RaidReward);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C5C RID: 93276 RVA: 0x00614568 File Offset: 0x00612768
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Drop_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftLevelInfo configDataRiftLevelInfo = (ConfigDataRiftLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataRiftLevelInfo.Drop_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C5D RID: 93277 RVA: 0x006145BC File Offset: 0x006127BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Drop_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftLevelInfo configDataRiftLevelInfo = (ConfigDataRiftLevelInfo)LuaObject.checkSelf(l);
			int drop_ID;
			LuaObject.checkType(l, 2, out drop_ID);
			configDataRiftLevelInfo.Drop_ID = drop_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C5E RID: 93278 RVA: 0x00614614 File Offset: 0x00612814
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_OperationalActivityDrop_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftLevelInfo configDataRiftLevelInfo = (ConfigDataRiftLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataRiftLevelInfo.OperationalActivityDrop_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C5F RID: 93279 RVA: 0x00614668 File Offset: 0x00612868
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_OperationalActivityDrop_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftLevelInfo configDataRiftLevelInfo = (ConfigDataRiftLevelInfo)LuaObject.checkSelf(l);
			int operationalActivityDrop_ID;
			LuaObject.checkType(l, 2, out operationalActivityDrop_ID);
			configDataRiftLevelInfo.OperationalActivityDrop_ID = operationalActivityDrop_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C60 RID: 93280 RVA: 0x006146C0 File Offset: 0x006128C0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_DisplayRewardCount(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftLevelInfo configDataRiftLevelInfo = (ConfigDataRiftLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataRiftLevelInfo.DisplayRewardCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C61 RID: 93281 RVA: 0x00614714 File Offset: 0x00612914
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_DisplayRewardCount(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftLevelInfo configDataRiftLevelInfo = (ConfigDataRiftLevelInfo)LuaObject.checkSelf(l);
			int displayRewardCount;
			LuaObject.checkType(l, 2, out displayRewardCount);
			configDataRiftLevelInfo.DisplayRewardCount = displayRewardCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C62 RID: 93282 RVA: 0x0061476C File Offset: 0x0061296C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Image(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftLevelInfo configDataRiftLevelInfo = (ConfigDataRiftLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataRiftLevelInfo.Image);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C63 RID: 93283 RVA: 0x006147C0 File Offset: 0x006129C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Image(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftLevelInfo configDataRiftLevelInfo = (ConfigDataRiftLevelInfo)LuaObject.checkSelf(l);
			string image;
			LuaObject.checkType(l, 2, out image);
			configDataRiftLevelInfo.Image = image;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C64 RID: 93284 RVA: 0x00614818 File Offset: 0x00612A18
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Icon(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftLevelInfo configDataRiftLevelInfo = (ConfigDataRiftLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataRiftLevelInfo.Icon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C65 RID: 93285 RVA: 0x0061486C File Offset: 0x00612A6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Icon(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftLevelInfo configDataRiftLevelInfo = (ConfigDataRiftLevelInfo)LuaObject.checkSelf(l);
			string icon;
			LuaObject.checkType(l, 2, out icon);
			configDataRiftLevelInfo.Icon = icon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C66 RID: 93286 RVA: 0x006148C4 File Offset: 0x00612AC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_IconX(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftLevelInfo configDataRiftLevelInfo = (ConfigDataRiftLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataRiftLevelInfo.IconX);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C67 RID: 93287 RVA: 0x00614918 File Offset: 0x00612B18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_IconX(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftLevelInfo configDataRiftLevelInfo = (ConfigDataRiftLevelInfo)LuaObject.checkSelf(l);
			int iconX;
			LuaObject.checkType(l, 2, out iconX);
			configDataRiftLevelInfo.IconX = iconX;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C68 RID: 93288 RVA: 0x00614970 File Offset: 0x00612B70
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_IconY(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftLevelInfo configDataRiftLevelInfo = (ConfigDataRiftLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataRiftLevelInfo.IconY);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C69 RID: 93289 RVA: 0x006149C4 File Offset: 0x00612BC4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_IconY(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftLevelInfo configDataRiftLevelInfo = (ConfigDataRiftLevelInfo)LuaObject.checkSelf(l);
			int iconY;
			LuaObject.checkType(l, 2, out iconY);
			configDataRiftLevelInfo.IconY = iconY;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C6A RID: 93290 RVA: 0x00614A1C File Offset: 0x00612C1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Strategy(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftLevelInfo configDataRiftLevelInfo = (ConfigDataRiftLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataRiftLevelInfo.Strategy);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C6B RID: 93291 RVA: 0x00614A70 File Offset: 0x00612C70
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Strategy(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftLevelInfo configDataRiftLevelInfo = (ConfigDataRiftLevelInfo)LuaObject.checkSelf(l);
			string strategy;
			LuaObject.checkType(l, 2, out strategy);
			configDataRiftLevelInfo.Strategy = strategy;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C6C RID: 93292 RVA: 0x00614AC8 File Offset: 0x00612CC8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_LevelType(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftLevelInfo configDataRiftLevelInfo = (ConfigDataRiftLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)configDataRiftLevelInfo.LevelType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C6D RID: 93293 RVA: 0x00614B1C File Offset: 0x00612D1C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_LevelType(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataRiftLevelInfo configDataRiftLevelInfo = (ConfigDataRiftLevelInfo)LuaObject.checkSelf(l);
			RiftLevelType levelType;
			LuaObject.checkEnum<RiftLevelType>(l, 2, out levelType);
			configDataRiftLevelInfo.LevelType = levelType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016C6E RID: 93294 RVA: 0x00614B74 File Offset: 0x00612D74
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ConfigData.ConfigDataRiftLevelInfo");
		string name = "m_battleInfo";
		if (Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.get_m_battleInfo);
		}
		LuaCSFunction get = Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache0;
		if (Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.set_m_battleInfo);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache1, true);
		string name2 = "m_chapterId";
		if (Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.get_m_chapterId);
		}
		LuaCSFunction get2 = Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache2;
		if (Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.set_m_chapterId);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache3, true);
		string name3 = "m_chapterInfo";
		if (Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.get_m_chapterInfo);
		}
		LuaCSFunction get3 = Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache4;
		if (Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.set_m_chapterInfo);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache5, true);
		string name4 = "m_achievements";
		if (Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.get_m_achievements);
		}
		LuaCSFunction get4 = Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache6;
		if (Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.set_m_achievements);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache7, true);
		string name5 = "ID";
		if (Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.get_ID);
		}
		LuaCSFunction get5 = Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache8;
		if (Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.set_ID);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache9, true);
		string name6 = "Name";
		if (Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.get_Name);
		}
		LuaCSFunction get6 = Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cacheA;
		if (Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.set_Name);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cacheB, true);
		string name7 = "NameStrKey";
		if (Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.get_NameStrKey);
		}
		LuaCSFunction get7 = Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cacheC;
		if (Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.set_NameStrKey);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cacheD, true);
		string name8 = "Desc";
		if (Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.get_Desc);
		}
		LuaCSFunction get8 = Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cacheE;
		if (Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.set_Desc);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cacheF, true);
		string name9 = "DescStrKey";
		if (Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.get_DescStrKey);
		}
		LuaCSFunction get9 = Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache10;
		if (Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.set_DescStrKey);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache11, true);
		string name10 = "ChapterID";
		if (Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.get_ChapterID);
		}
		LuaCSFunction get10 = Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache12;
		if (Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.set_ChapterID);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache13, true);
		string name11 = "OwnNum";
		if (Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.get_OwnNum);
		}
		LuaCSFunction get11 = Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache14;
		if (Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.set_OwnNum);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache15, true);
		string name12 = "NameNum";
		if (Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.get_NameNum);
		}
		LuaCSFunction get12 = Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache16;
		if (Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.set_NameNum);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache17, true);
		string name13 = "ChallengeCount";
		if (Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.get_ChallengeCount);
		}
		LuaCSFunction get13 = Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache18;
		if (Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.set_ChallengeCount);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache19, true);
		string name14 = "EnergySuccess";
		if (Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.get_EnergySuccess);
		}
		LuaCSFunction get14 = Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache1A;
		if (Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.set_EnergySuccess);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache1B, true);
		string name15 = "EnergyFail";
		if (Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.get_EnergyFail);
		}
		LuaCSFunction get15 = Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache1C;
		if (Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.set_EnergyFail);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache1D, true);
		string name16 = "MonsterLevel";
		if (Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.get_MonsterLevel);
		}
		LuaCSFunction get16 = Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache1E;
		if (Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.set_MonsterLevel);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache1F, true);
		string name17 = "Battle_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.get_Battle_ID);
		}
		LuaCSFunction get17 = Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache20;
		if (Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.set_Battle_ID);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache21, true);
		string name18 = "PreLevel_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.get_PreLevel_ID);
		}
		LuaCSFunction get18 = Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache22;
		if (Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.set_PreLevel_ID);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache23, true);
		string name19 = "PlayerLevel";
		if (Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.get_PlayerLevel);
		}
		LuaCSFunction get19 = Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache24;
		if (Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.set_PlayerLevel);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache25, true);
		string name20 = "UnlockConditions";
		if (Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.get_UnlockConditions);
		}
		LuaObject.addMember(l, name20, Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache26, null, true);
		string name21 = "StarTurnMax";
		if (Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.get_StarTurnMax);
		}
		LuaCSFunction get20 = Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache27;
		if (Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.set_StarTurnMax);
		}
		LuaObject.addMember(l, name21, get20, Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache28, true);
		string name22 = "StarDeadMax";
		if (Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.get_StarDeadMax);
		}
		LuaCSFunction get21 = Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache29;
		if (Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.set_StarDeadMax);
		}
		LuaObject.addMember(l, name22, get21, Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache2A, true);
		string name23 = "Achievement1_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.get_Achievement1_ID);
		}
		LuaCSFunction get22 = Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache2B;
		if (Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.set_Achievement1_ID);
		}
		LuaObject.addMember(l, name23, get22, Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache2C, true);
		string name24 = "AchievementReward1";
		if (Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.get_AchievementReward1);
		}
		LuaObject.addMember(l, name24, Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache2D, null, true);
		string name25 = "Achievement2_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.get_Achievement2_ID);
		}
		LuaCSFunction get23 = Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache2E;
		if (Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.set_Achievement2_ID);
		}
		LuaObject.addMember(l, name25, get23, Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache2F, true);
		string name26 = "AchievementReward2";
		if (Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.get_AchievementReward2);
		}
		LuaObject.addMember(l, name26, Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache30, null, true);
		string name27 = "Achievement3_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.get_Achievement3_ID);
		}
		LuaCSFunction get24 = Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache31;
		if (Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.set_Achievement3_ID);
		}
		LuaObject.addMember(l, name27, get24, Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache32, true);
		string name28 = "AchievementReward3";
		if (Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.get_AchievementReward3);
		}
		LuaObject.addMember(l, name28, Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache33, null, true);
		string name29 = "PlayerExpReward";
		if (Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.get_PlayerExpReward);
		}
		LuaCSFunction get25 = Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache34;
		if (Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.set_PlayerExpReward);
		}
		LuaObject.addMember(l, name29, get25, Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache35, true);
		string name30 = "HeroExpReward";
		if (Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.get_HeroExpReward);
		}
		LuaCSFunction get26 = Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache36;
		if (Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.set_HeroExpReward);
		}
		LuaObject.addMember(l, name30, get26, Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache37, true);
		string name31 = "GoldReward";
		if (Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.get_GoldReward);
		}
		LuaCSFunction get27 = Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache38;
		if (Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.set_GoldReward);
		}
		LuaObject.addMember(l, name31, get27, Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache39, true);
		string name32 = "FirstReward";
		if (Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.get_FirstReward);
		}
		LuaObject.addMember(l, name32, Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache3A, null, true);
		string name33 = "RaidReward";
		if (Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.get_RaidReward);
		}
		LuaObject.addMember(l, name33, Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache3B, null, true);
		string name34 = "Drop_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.get_Drop_ID);
		}
		LuaCSFunction get28 = Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache3C;
		if (Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.set_Drop_ID);
		}
		LuaObject.addMember(l, name34, get28, Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache3D, true);
		string name35 = "OperationalActivityDrop_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.get_OperationalActivityDrop_ID);
		}
		LuaCSFunction get29 = Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache3E;
		if (Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.set_OperationalActivityDrop_ID);
		}
		LuaObject.addMember(l, name35, get29, Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache3F, true);
		string name36 = "DisplayRewardCount";
		if (Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.get_DisplayRewardCount);
		}
		LuaCSFunction get30 = Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache40;
		if (Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.set_DisplayRewardCount);
		}
		LuaObject.addMember(l, name36, get30, Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache41, true);
		string name37 = "Image";
		if (Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.get_Image);
		}
		LuaCSFunction get31 = Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache42;
		if (Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.set_Image);
		}
		LuaObject.addMember(l, name37, get31, Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache43, true);
		string name38 = "Icon";
		if (Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.get_Icon);
		}
		LuaCSFunction get32 = Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache44;
		if (Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.set_Icon);
		}
		LuaObject.addMember(l, name38, get32, Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache45, true);
		string name39 = "IconX";
		if (Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.get_IconX);
		}
		LuaCSFunction get33 = Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache46;
		if (Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.set_IconX);
		}
		LuaObject.addMember(l, name39, get33, Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache47, true);
		string name40 = "IconY";
		if (Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.get_IconY);
		}
		LuaCSFunction get34 = Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache48;
		if (Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.set_IconY);
		}
		LuaObject.addMember(l, name40, get34, Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache49, true);
		string name41 = "Strategy";
		if (Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.get_Strategy);
		}
		LuaCSFunction get35 = Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache4A;
		if (Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.set_Strategy);
		}
		LuaObject.addMember(l, name41, get35, Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache4B, true);
		string name42 = "LevelType";
		if (Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.get_LevelType);
		}
		LuaCSFunction get36 = Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache4C;
		if (Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.set_LevelType);
		}
		LuaObject.addMember(l, name42, get36, Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache4D, true);
		if (Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ConfigData_ConfigDataRiftLevelInfo.<>f__mg$cache4E, typeof(ConfigDataRiftLevelInfo));
	}

	// Token: 0x0400D333 RID: 54067
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400D334 RID: 54068
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400D335 RID: 54069
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400D336 RID: 54070
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400D337 RID: 54071
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400D338 RID: 54072
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400D339 RID: 54073
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400D33A RID: 54074
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400D33B RID: 54075
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400D33C RID: 54076
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400D33D RID: 54077
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400D33E RID: 54078
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400D33F RID: 54079
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400D340 RID: 54080
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400D341 RID: 54081
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400D342 RID: 54082
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400D343 RID: 54083
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400D344 RID: 54084
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400D345 RID: 54085
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400D346 RID: 54086
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400D347 RID: 54087
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400D348 RID: 54088
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400D349 RID: 54089
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400D34A RID: 54090
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400D34B RID: 54091
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400D34C RID: 54092
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400D34D RID: 54093
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400D34E RID: 54094
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400D34F RID: 54095
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400D350 RID: 54096
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400D351 RID: 54097
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400D352 RID: 54098
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400D353 RID: 54099
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400D354 RID: 54100
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400D355 RID: 54101
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400D356 RID: 54102
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0400D357 RID: 54103
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0400D358 RID: 54104
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0400D359 RID: 54105
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0400D35A RID: 54106
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0400D35B RID: 54107
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0400D35C RID: 54108
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0400D35D RID: 54109
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0400D35E RID: 54110
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0400D35F RID: 54111
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0400D360 RID: 54112
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0400D361 RID: 54113
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x0400D362 RID: 54114
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x0400D363 RID: 54115
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x0400D364 RID: 54116
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x0400D365 RID: 54117
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x0400D366 RID: 54118
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x0400D367 RID: 54119
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x0400D368 RID: 54120
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x0400D369 RID: 54121
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x0400D36A RID: 54122
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x0400D36B RID: 54123
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x0400D36C RID: 54124
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x0400D36D RID: 54125
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x0400D36E RID: 54126
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x0400D36F RID: 54127
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x0400D370 RID: 54128
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x0400D371 RID: 54129
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x0400D372 RID: 54130
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x0400D373 RID: 54131
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x0400D374 RID: 54132
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x0400D375 RID: 54133
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x0400D376 RID: 54134
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x0400D377 RID: 54135
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x0400D378 RID: 54136
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x0400D379 RID: 54137
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x0400D37A RID: 54138
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x0400D37B RID: 54139
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x0400D37C RID: 54140
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x0400D37D RID: 54141
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x0400D37E RID: 54142
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x0400D37F RID: 54143
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x0400D380 RID: 54144
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x0400D381 RID: 54145
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;
}
