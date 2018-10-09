using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200116B RID: 4459
[Preserve]
public class Lua_BlackJack_ConfigData_ConfigDataSoldierInfo : LuaObject
{
	// Token: 0x06016D6F RID: 93551 RVA: 0x0061CCB8 File Offset: 0x0061AEB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo o = new ConfigDataSoldierInfo();
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

	// Token: 0x06016D70 RID: 93552 RVA: 0x0061CD00 File Offset: 0x0061AF00
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetLevelUpSkillInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			int skillLevelUp;
			LuaObject.checkType(l, 2, out skillLevelUp);
			ConfigDataSkillInfo levelUpSkillInfo = configDataSoldierInfo.GetLevelUpSkillInfo(skillLevelUp);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, levelUpSkillInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D71 RID: 93553 RVA: 0x0061CD64 File Offset: 0x0061AF64
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_armyInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSoldierInfo.m_armyInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D72 RID: 93554 RVA: 0x0061CDB8 File Offset: 0x0061AFB8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_armyInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			ConfigDataArmyInfo armyInfo;
			LuaObject.checkType<ConfigDataArmyInfo>(l, 2, out armyInfo);
			configDataSoldierInfo.m_armyInfo = armyInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D73 RID: 93555 RVA: 0x0061CE10 File Offset: 0x0061B010
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_meleeSkillInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSoldierInfo.m_meleeSkillInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D74 RID: 93556 RVA: 0x0061CE64 File Offset: 0x0061B064
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_meleeSkillInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			ConfigDataSkillInfo meleeSkillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 2, out meleeSkillInfo);
			configDataSoldierInfo.m_meleeSkillInfo = meleeSkillInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D75 RID: 93557 RVA: 0x0061CEBC File Offset: 0x0061B0BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_rangeSkillInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSoldierInfo.m_rangeSkillInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D76 RID: 93558 RVA: 0x0061CF10 File Offset: 0x0061B110
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_rangeSkillInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			ConfigDataSkillInfo rangeSkillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 2, out rangeSkillInfo);
			configDataSoldierInfo.m_rangeSkillInfo = rangeSkillInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D77 RID: 93559 RVA: 0x0061CF68 File Offset: 0x0061B168
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_skillInfos(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSoldierInfo.m_skillInfos);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D78 RID: 93560 RVA: 0x0061CFBC File Offset: 0x0061B1BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillInfos(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			ConfigDataSkillInfo[] skillInfos;
			LuaObject.checkArray<ConfigDataSkillInfo>(l, 2, out skillInfos);
			configDataSoldierInfo.m_skillInfos = skillInfos;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D79 RID: 93561 RVA: 0x0061D014 File Offset: 0x0061B214
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSoldierInfo.ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D7A RID: 93562 RVA: 0x0061D068 File Offset: 0x0061B268
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			configDataSoldierInfo.ID = id;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D7B RID: 93563 RVA: 0x0061D0C0 File Offset: 0x0061B2C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Name(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSoldierInfo.Name);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D7C RID: 93564 RVA: 0x0061D114 File Offset: 0x0061B314
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Name(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			configDataSoldierInfo.Name = name;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D7D RID: 93565 RVA: 0x0061D16C File Offset: 0x0061B36C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_NameStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSoldierInfo.NameStrKey);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D7E RID: 93566 RVA: 0x0061D1C0 File Offset: 0x0061B3C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_NameStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			string nameStrKey;
			LuaObject.checkType(l, 2, out nameStrKey);
			configDataSoldierInfo.NameStrKey = nameStrKey;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D7F RID: 93567 RVA: 0x0061D218 File Offset: 0x0061B418
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Desc(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSoldierInfo.Desc);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D80 RID: 93568 RVA: 0x0061D26C File Offset: 0x0061B46C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Desc(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			string desc;
			LuaObject.checkType(l, 2, out desc);
			configDataSoldierInfo.Desc = desc;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D81 RID: 93569 RVA: 0x0061D2C4 File Offset: 0x0061B4C4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_DescStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSoldierInfo.DescStrKey);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D82 RID: 93570 RVA: 0x0061D318 File Offset: 0x0061B518
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_DescStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			string descStrKey;
			LuaObject.checkType(l, 2, out descStrKey);
			configDataSoldierInfo.DescStrKey = descStrKey;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D83 RID: 93571 RVA: 0x0061D370 File Offset: 0x0061B570
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Strong(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSoldierInfo.Strong);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D84 RID: 93572 RVA: 0x0061D3C4 File Offset: 0x0061B5C4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Strong(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			string strong;
			LuaObject.checkType(l, 2, out strong);
			configDataSoldierInfo.Strong = strong;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D85 RID: 93573 RVA: 0x0061D41C File Offset: 0x0061B61C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_StrongStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSoldierInfo.StrongStrKey);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D86 RID: 93574 RVA: 0x0061D470 File Offset: 0x0061B670
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_StrongStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			string strongStrKey;
			LuaObject.checkType(l, 2, out strongStrKey);
			configDataSoldierInfo.StrongStrKey = strongStrKey;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D87 RID: 93575 RVA: 0x0061D4C8 File Offset: 0x0061B6C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Weak(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSoldierInfo.Weak);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D88 RID: 93576 RVA: 0x0061D51C File Offset: 0x0061B71C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Weak(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			string weak;
			LuaObject.checkType(l, 2, out weak);
			configDataSoldierInfo.Weak = weak;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D89 RID: 93577 RVA: 0x0061D574 File Offset: 0x0061B774
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_WeakStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSoldierInfo.WeakStrKey);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D8A RID: 93578 RVA: 0x0061D5C8 File Offset: 0x0061B7C8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_WeakStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			string weakStrKey;
			LuaObject.checkType(l, 2, out weakStrKey);
			configDataSoldierInfo.WeakStrKey = weakStrKey;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D8B RID: 93579 RVA: 0x0061D620 File Offset: 0x0061B820
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Radius(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSoldierInfo.Radius);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D8C RID: 93580 RVA: 0x0061D674 File Offset: 0x0061B874
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Radius(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			int radius;
			LuaObject.checkType(l, 2, out radius);
			configDataSoldierInfo.Radius = radius;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D8D RID: 93581 RVA: 0x0061D6CC File Offset: 0x0061B8CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Height(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSoldierInfo.Height);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D8E RID: 93582 RVA: 0x0061D720 File Offset: 0x0061B920
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Height(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			int height;
			LuaObject.checkType(l, 2, out height);
			configDataSoldierInfo.Height = height;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D8F RID: 93583 RVA: 0x0061D778 File Offset: 0x0061B978
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_FootHeight(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSoldierInfo.FootHeight);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D90 RID: 93584 RVA: 0x0061D7CC File Offset: 0x0061B9CC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_FootHeight(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			int footHeight;
			LuaObject.checkType(l, 2, out footHeight);
			configDataSoldierInfo.FootHeight = footHeight;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D91 RID: 93585 RVA: 0x0061D824 File Offset: 0x0061BA24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Skills_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSoldierInfo.Skills_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D92 RID: 93586 RVA: 0x0061D878 File Offset: 0x0061BA78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Old_Buffs_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSoldierInfo.Old_Buffs_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D93 RID: 93587 RVA: 0x0061D8CC File Offset: 0x0061BACC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Army_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSoldierInfo.Army_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D94 RID: 93588 RVA: 0x0061D920 File Offset: 0x0061BB20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Army_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			int army_ID;
			LuaObject.checkType(l, 2, out army_ID);
			configDataSoldierInfo.Army_ID = army_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D95 RID: 93589 RVA: 0x0061D978 File Offset: 0x0061BB78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_IsMelee(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSoldierInfo.IsMelee);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D96 RID: 93590 RVA: 0x0061D9CC File Offset: 0x0061BBCC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_IsMelee(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			bool isMelee;
			LuaObject.checkType(l, 2, out isMelee);
			configDataSoldierInfo.IsMelee = isMelee;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D97 RID: 93591 RVA: 0x0061DA24 File Offset: 0x0061BC24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_MoveType(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)configDataSoldierInfo.MoveType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D98 RID: 93592 RVA: 0x0061DA78 File Offset: 0x0061BC78
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_MoveType(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			MoveType moveType;
			LuaObject.checkEnum<MoveType>(l, 2, out moveType);
			configDataSoldierInfo.MoveType = moveType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D99 RID: 93593 RVA: 0x0061DAD0 File Offset: 0x0061BCD0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_BF_AttackDistance(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSoldierInfo.BF_AttackDistance);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D9A RID: 93594 RVA: 0x0061DB24 File Offset: 0x0061BD24
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_BF_AttackDistance(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			int bf_AttackDistance;
			LuaObject.checkType(l, 2, out bf_AttackDistance);
			configDataSoldierInfo.BF_AttackDistance = bf_AttackDistance;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D9B RID: 93595 RVA: 0x0061DB7C File Offset: 0x0061BD7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_MeleeATK_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSoldierInfo.MeleeATK_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D9C RID: 93596 RVA: 0x0061DBD0 File Offset: 0x0061BDD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_MeleeATK_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			int meleeATK_ID;
			LuaObject.checkType(l, 2, out meleeATK_ID);
			configDataSoldierInfo.MeleeATK_ID = meleeATK_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D9D RID: 93597 RVA: 0x0061DC28 File Offset: 0x0061BE28
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_RangeATK_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSoldierInfo.RangeATK_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D9E RID: 93598 RVA: 0x0061DC7C File Offset: 0x0061BE7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_RangeATK_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			int rangeATK_ID;
			LuaObject.checkType(l, 2, out rangeATK_ID);
			configDataSoldierInfo.RangeATK_ID = rangeATK_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016D9F RID: 93599 RVA: 0x0061DCD4 File Offset: 0x0061BED4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_AttackSPD_INI(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSoldierInfo.AttackSPD_INI);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016DA0 RID: 93600 RVA: 0x0061DD28 File Offset: 0x0061BF28
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_AttackSPD_INI(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			int attackSPD_INI;
			LuaObject.checkType(l, 2, out attackSPD_INI);
			configDataSoldierInfo.AttackSPD_INI = attackSPD_INI;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016DA1 RID: 93601 RVA: 0x0061DD80 File Offset: 0x0061BF80
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_MoveSPD_INI(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSoldierInfo.MoveSPD_INI);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016DA2 RID: 93602 RVA: 0x0061DDD4 File Offset: 0x0061BFD4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_MoveSPD_INI(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			int moveSPD_INI;
			LuaObject.checkType(l, 2, out moveSPD_INI);
			configDataSoldierInfo.MoveSPD_INI = moveSPD_INI;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016DA3 RID: 93603 RVA: 0x0061DE2C File Offset: 0x0061C02C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_HP_INI(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSoldierInfo.HP_INI);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016DA4 RID: 93604 RVA: 0x0061DE80 File Offset: 0x0061C080
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_HP_INI(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			int hp_INI;
			LuaObject.checkType(l, 2, out hp_INI);
			configDataSoldierInfo.HP_INI = hp_INI;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016DA5 RID: 93605 RVA: 0x0061DED8 File Offset: 0x0061C0D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_AT_INI(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSoldierInfo.AT_INI);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016DA6 RID: 93606 RVA: 0x0061DF2C File Offset: 0x0061C12C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_AT_INI(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			int at_INI;
			LuaObject.checkType(l, 2, out at_INI);
			configDataSoldierInfo.AT_INI = at_INI;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016DA7 RID: 93607 RVA: 0x0061DF84 File Offset: 0x0061C184
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_DF_INI(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSoldierInfo.DF_INI);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016DA8 RID: 93608 RVA: 0x0061DFD8 File Offset: 0x0061C1D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_DF_INI(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			int df_INI;
			LuaObject.checkType(l, 2, out df_INI);
			configDataSoldierInfo.DF_INI = df_INI;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016DA9 RID: 93609 RVA: 0x0061E030 File Offset: 0x0061C230
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_MagicDF_INI(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSoldierInfo.MagicDF_INI);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016DAA RID: 93610 RVA: 0x0061E084 File Offset: 0x0061C284
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_MagicDF_INI(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			int magicDF_INI;
			LuaObject.checkType(l, 2, out magicDF_INI);
			configDataSoldierInfo.MagicDF_INI = magicDF_INI;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016DAB RID: 93611 RVA: 0x0061E0DC File Offset: 0x0061C2DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_HP_UP(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSoldierInfo.HP_UP);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016DAC RID: 93612 RVA: 0x0061E130 File Offset: 0x0061C330
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_HP_UP(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			int hp_UP;
			LuaObject.checkType(l, 2, out hp_UP);
			configDataSoldierInfo.HP_UP = hp_UP;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016DAD RID: 93613 RVA: 0x0061E188 File Offset: 0x0061C388
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_AT_UP(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSoldierInfo.AT_UP);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016DAE RID: 93614 RVA: 0x0061E1DC File Offset: 0x0061C3DC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_AT_UP(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			int at_UP;
			LuaObject.checkType(l, 2, out at_UP);
			configDataSoldierInfo.AT_UP = at_UP;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016DAF RID: 93615 RVA: 0x0061E234 File Offset: 0x0061C434
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_DF_UP(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSoldierInfo.DF_UP);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016DB0 RID: 93616 RVA: 0x0061E288 File Offset: 0x0061C488
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_DF_UP(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			int df_UP;
			LuaObject.checkType(l, 2, out df_UP);
			configDataSoldierInfo.DF_UP = df_UP;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016DB1 RID: 93617 RVA: 0x0061E2E0 File Offset: 0x0061C4E0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_MagicDF_UP(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSoldierInfo.MagicDF_UP);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016DB2 RID: 93618 RVA: 0x0061E334 File Offset: 0x0061C534
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_MagicDF_UP(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			int magicDF_UP;
			LuaObject.checkType(l, 2, out magicDF_UP);
			configDataSoldierInfo.MagicDF_UP = magicDF_UP;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016DB3 RID: 93619 RVA: 0x0061E38C File Offset: 0x0061C58C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_CriticalDamage(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSoldierInfo.CriticalDamage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016DB4 RID: 93620 RVA: 0x0061E3E0 File Offset: 0x0061C5E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_CriticalDamage(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			int criticalDamage;
			LuaObject.checkType(l, 2, out criticalDamage);
			configDataSoldierInfo.CriticalDamage = criticalDamage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016DB5 RID: 93621 RVA: 0x0061E438 File Offset: 0x0061C638
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_CriticalRate(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSoldierInfo.CriticalRate);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016DB6 RID: 93622 RVA: 0x0061E48C File Offset: 0x0061C68C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_CriticalRate(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			int criticalRate;
			LuaObject.checkType(l, 2, out criticalRate);
			configDataSoldierInfo.CriticalRate = criticalRate;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016DB7 RID: 93623 RVA: 0x0061E4E4 File Offset: 0x0061C6E4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_BF_MovePoint(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSoldierInfo.BF_MovePoint);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016DB8 RID: 93624 RVA: 0x0061E538 File Offset: 0x0061C738
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_BF_MovePoint(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			int bf_MovePoint;
			LuaObject.checkType(l, 2, out bf_MovePoint);
			configDataSoldierInfo.BF_MovePoint = bf_MovePoint;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016DB9 RID: 93625 RVA: 0x0061E590 File Offset: 0x0061C790
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BattlePowerHP(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSoldierInfo.BattlePowerHP);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016DBA RID: 93626 RVA: 0x0061E5E4 File Offset: 0x0061C7E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_BattlePowerHP(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			int battlePowerHP;
			LuaObject.checkType(l, 2, out battlePowerHP);
			configDataSoldierInfo.BattlePowerHP = battlePowerHP;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016DBB RID: 93627 RVA: 0x0061E63C File Offset: 0x0061C83C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_BattlePowerAT(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSoldierInfo.BattlePowerAT);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016DBC RID: 93628 RVA: 0x0061E690 File Offset: 0x0061C890
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_BattlePowerAT(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			int battlePowerAT;
			LuaObject.checkType(l, 2, out battlePowerAT);
			configDataSoldierInfo.BattlePowerAT = battlePowerAT;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016DBD RID: 93629 RVA: 0x0061E6E8 File Offset: 0x0061C8E8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_BattlePowerDF(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSoldierInfo.BattlePowerDF);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016DBE RID: 93630 RVA: 0x0061E73C File Offset: 0x0061C93C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_BattlePowerDF(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			int battlePowerDF;
			LuaObject.checkType(l, 2, out battlePowerDF);
			configDataSoldierInfo.BattlePowerDF = battlePowerDF;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016DBF RID: 93631 RVA: 0x0061E794 File Offset: 0x0061C994
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BattlePowerMagicDF(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSoldierInfo.BattlePowerMagicDF);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016DC0 RID: 93632 RVA: 0x0061E7E8 File Offset: 0x0061C9E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_BattlePowerMagicDF(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			int battlePowerMagicDF;
			LuaObject.checkType(l, 2, out battlePowerMagicDF);
			configDataSoldierInfo.BattlePowerMagicDF = battlePowerMagicDF;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016DC1 RID: 93633 RVA: 0x0061E840 File Offset: 0x0061CA40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_DieFlyDistanceMin(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSoldierInfo.DieFlyDistanceMin);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016DC2 RID: 93634 RVA: 0x0061E894 File Offset: 0x0061CA94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_DieFlyDistanceMin(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			int dieFlyDistanceMin;
			LuaObject.checkType(l, 2, out dieFlyDistanceMin);
			configDataSoldierInfo.DieFlyDistanceMin = dieFlyDistanceMin;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016DC3 RID: 93635 RVA: 0x0061E8EC File Offset: 0x0061CAEC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_DieFlyDistanceMax(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSoldierInfo.DieFlyDistanceMax);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016DC4 RID: 93636 RVA: 0x0061E940 File Offset: 0x0061CB40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_DieFlyDistanceMax(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			int dieFlyDistanceMax;
			LuaObject.checkType(l, 2, out dieFlyDistanceMax);
			configDataSoldierInfo.DieFlyDistanceMax = dieFlyDistanceMax;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016DC5 RID: 93637 RVA: 0x0061E998 File Offset: 0x0061CB98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Model(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSoldierInfo.Model);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016DC6 RID: 93638 RVA: 0x0061E9EC File Offset: 0x0061CBEC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Model(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			string model;
			LuaObject.checkType(l, 2, out model);
			configDataSoldierInfo.Model = model;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016DC7 RID: 93639 RVA: 0x0061EA44 File Offset: 0x0061CC44
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Model2(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSoldierInfo.Model2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016DC8 RID: 93640 RVA: 0x0061EA98 File Offset: 0x0061CC98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Model2(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			string model;
			LuaObject.checkType(l, 2, out model);
			configDataSoldierInfo.Model2 = model;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016DC9 RID: 93641 RVA: 0x0061EAF0 File Offset: 0x0061CCF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_CombatModel(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSoldierInfo.CombatModel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016DCA RID: 93642 RVA: 0x0061EB44 File Offset: 0x0061CD44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_CombatModel(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			string combatModel;
			LuaObject.checkType(l, 2, out combatModel);
			configDataSoldierInfo.CombatModel = combatModel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016DCB RID: 93643 RVA: 0x0061EB9C File Offset: 0x0061CD9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_CombatModel2(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSoldierInfo.CombatModel2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016DCC RID: 93644 RVA: 0x0061EBF0 File Offset: 0x0061CDF0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_CombatModel2(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			string combatModel;
			LuaObject.checkType(l, 2, out combatModel);
			configDataSoldierInfo.CombatModel2 = combatModel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016DCD RID: 93645 RVA: 0x0061EC48 File Offset: 0x0061CE48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ReplaceAnims(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSoldierInfo.ReplaceAnims);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016DCE RID: 93646 RVA: 0x0061EC9C File Offset: 0x0061CE9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ModelScale(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSoldierInfo.ModelScale);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016DCF RID: 93647 RVA: 0x0061ECF0 File Offset: 0x0061CEF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ModelScale(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			int modelScale;
			LuaObject.checkType(l, 2, out modelScale);
			configDataSoldierInfo.ModelScale = modelScale;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016DD0 RID: 93648 RVA: 0x0061ED48 File Offset: 0x0061CF48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BF_ModelScale(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSoldierInfo.BF_ModelScale);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016DD1 RID: 93649 RVA: 0x0061ED9C File Offset: 0x0061CF9C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_BF_ModelScale(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			int bf_ModelScale;
			LuaObject.checkType(l, 2, out bf_ModelScale);
			configDataSoldierInfo.BF_ModelScale = bf_ModelScale;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016DD2 RID: 93650 RVA: 0x0061EDF4 File Offset: 0x0061CFF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UI_ModelScale(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSoldierInfo.UI_ModelScale);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016DD3 RID: 93651 RVA: 0x0061EE48 File Offset: 0x0061D048
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_UI_ModelScale(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			int ui_ModelScale;
			LuaObject.checkType(l, 2, out ui_ModelScale);
			configDataSoldierInfo.UI_ModelScale = ui_ModelScale;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016DD4 RID: 93652 RVA: 0x0061EEA0 File Offset: 0x0061D0A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UI_ModelOffsetX(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSoldierInfo.UI_ModelOffsetX);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016DD5 RID: 93653 RVA: 0x0061EEF4 File Offset: 0x0061D0F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_UI_ModelOffsetX(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			int ui_ModelOffsetX;
			LuaObject.checkType(l, 2, out ui_ModelOffsetX);
			configDataSoldierInfo.UI_ModelOffsetX = ui_ModelOffsetX;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016DD6 RID: 93654 RVA: 0x0061EF4C File Offset: 0x0061D14C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_UI_ModelOffsetY(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSoldierInfo.UI_ModelOffsetY);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016DD7 RID: 93655 RVA: 0x0061EFA0 File Offset: 0x0061D1A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_UI_ModelOffsetY(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			int ui_ModelOffsetY;
			LuaObject.checkType(l, 2, out ui_ModelOffsetY);
			configDataSoldierInfo.UI_ModelOffsetY = ui_ModelOffsetY;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016DD8 RID: 93656 RVA: 0x0061EFF8 File Offset: 0x0061D1F8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Sound_Enter(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSoldierInfo.Sound_Enter);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016DD9 RID: 93657 RVA: 0x0061F04C File Offset: 0x0061D24C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Sound_Enter(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			string sound_Enter;
			LuaObject.checkType(l, 2, out sound_Enter);
			configDataSoldierInfo.Sound_Enter = sound_Enter;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016DDA RID: 93658 RVA: 0x0061F0A4 File Offset: 0x0061D2A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Sound_Die(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSoldierInfo.Sound_Die);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016DDB RID: 93659 RVA: 0x0061F0F8 File Offset: 0x0061D2F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Sound_Die(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			string sound_Die;
			LuaObject.checkType(l, 2, out sound_Die);
			configDataSoldierInfo.Sound_Die = sound_Die;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016DDC RID: 93660 RVA: 0x0061F150 File Offset: 0x0061D350
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Rank(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSoldierInfo.Rank);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016DDD RID: 93661 RVA: 0x0061F1A4 File Offset: 0x0061D3A4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Rank(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			int rank;
			LuaObject.checkType(l, 2, out rank);
			configDataSoldierInfo.Rank = rank;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016DDE RID: 93662 RVA: 0x0061F1FC File Offset: 0x0061D3FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_IsEnemy(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSoldierInfo.IsEnemy);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016DDF RID: 93663 RVA: 0x0061F250 File Offset: 0x0061D450
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_IsEnemy(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			bool isEnemy;
			LuaObject.checkType(l, 2, out isEnemy);
			configDataSoldierInfo.IsEnemy = isEnemy;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016DE0 RID: 93664 RVA: 0x0061F2A8 File Offset: 0x0061D4A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_GetSoldierDesc(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSoldierInfo.GetSoldierDesc);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016DE1 RID: 93665 RVA: 0x0061F2FC File Offset: 0x0061D4FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_GetSoldierDesc(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			string getSoldierDesc;
			LuaObject.checkType(l, 2, out getSoldierDesc);
			configDataSoldierInfo.GetSoldierDesc = getSoldierDesc;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016DE2 RID: 93666 RVA: 0x0061F354 File Offset: 0x0061D554
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_GetSoldierHeros_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSoldierInfo.GetSoldierHeros_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016DE3 RID: 93667 RVA: 0x0061F3A8 File Offset: 0x0061D5A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_GetSoldierTechId(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSoldierInfo.GetSoldierTechId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016DE4 RID: 93668 RVA: 0x0061F3FC File Offset: 0x0061D5FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_GetSoldierTechId(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			int getSoldierTechId;
			LuaObject.checkType(l, 2, out getSoldierTechId);
			configDataSoldierInfo.GetSoldierTechId = getSoldierTechId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016DE5 RID: 93669 RVA: 0x0061F454 File Offset: 0x0061D654
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_SoldierSkins_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataSoldierInfo configDataSoldierInfo = (ConfigDataSoldierInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataSoldierInfo.SoldierSkins_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016DE6 RID: 93670 RVA: 0x0061F4A8 File Offset: 0x0061D6A8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ConfigData.ConfigDataSoldierInfo");
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.GetLevelUpSkillInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache0);
		string name = "m_armyInfo";
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.get_m_armyInfo);
		}
		LuaCSFunction get = Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache1;
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.set_m_armyInfo);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache2, true);
		string name2 = "m_meleeSkillInfo";
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.get_m_meleeSkillInfo);
		}
		LuaCSFunction get2 = Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache3;
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.set_m_meleeSkillInfo);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache4, true);
		string name3 = "m_rangeSkillInfo";
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.get_m_rangeSkillInfo);
		}
		LuaCSFunction get3 = Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache5;
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.set_m_rangeSkillInfo);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache6, true);
		string name4 = "m_skillInfos";
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.get_m_skillInfos);
		}
		LuaCSFunction get4 = Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache7;
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.set_m_skillInfos);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache8, true);
		string name5 = "ID";
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.get_ID);
		}
		LuaCSFunction get5 = Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache9;
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.set_ID);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cacheA, true);
		string name6 = "Name";
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.get_Name);
		}
		LuaCSFunction get6 = Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cacheB;
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.set_Name);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cacheC, true);
		string name7 = "NameStrKey";
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.get_NameStrKey);
		}
		LuaCSFunction get7 = Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cacheD;
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.set_NameStrKey);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cacheE, true);
		string name8 = "Desc";
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.get_Desc);
		}
		LuaCSFunction get8 = Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cacheF;
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.set_Desc);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache10, true);
		string name9 = "DescStrKey";
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.get_DescStrKey);
		}
		LuaCSFunction get9 = Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache11;
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.set_DescStrKey);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache12, true);
		string name10 = "Strong";
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.get_Strong);
		}
		LuaCSFunction get10 = Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache13;
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.set_Strong);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache14, true);
		string name11 = "StrongStrKey";
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.get_StrongStrKey);
		}
		LuaCSFunction get11 = Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache15;
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.set_StrongStrKey);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache16, true);
		string name12 = "Weak";
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.get_Weak);
		}
		LuaCSFunction get12 = Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache17;
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.set_Weak);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache18, true);
		string name13 = "WeakStrKey";
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.get_WeakStrKey);
		}
		LuaCSFunction get13 = Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache19;
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.set_WeakStrKey);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache1A, true);
		string name14 = "Radius";
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.get_Radius);
		}
		LuaCSFunction get14 = Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache1B;
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.set_Radius);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache1C, true);
		string name15 = "Height";
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.get_Height);
		}
		LuaCSFunction get15 = Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache1D;
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.set_Height);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache1E, true);
		string name16 = "FootHeight";
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.get_FootHeight);
		}
		LuaCSFunction get16 = Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache1F;
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.set_FootHeight);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache20, true);
		string name17 = "Skills_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.get_Skills_ID);
		}
		LuaObject.addMember(l, name17, Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache21, null, true);
		string name18 = "Old_Buffs_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.get_Old_Buffs_ID);
		}
		LuaObject.addMember(l, name18, Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache22, null, true);
		string name19 = "Army_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.get_Army_ID);
		}
		LuaCSFunction get17 = Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache23;
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.set_Army_ID);
		}
		LuaObject.addMember(l, name19, get17, Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache24, true);
		string name20 = "IsMelee";
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.get_IsMelee);
		}
		LuaCSFunction get18 = Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache25;
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.set_IsMelee);
		}
		LuaObject.addMember(l, name20, get18, Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache26, true);
		string name21 = "MoveType";
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.get_MoveType);
		}
		LuaCSFunction get19 = Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache27;
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.set_MoveType);
		}
		LuaObject.addMember(l, name21, get19, Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache28, true);
		string name22 = "BF_AttackDistance";
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.get_BF_AttackDistance);
		}
		LuaCSFunction get20 = Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache29;
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.set_BF_AttackDistance);
		}
		LuaObject.addMember(l, name22, get20, Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache2A, true);
		string name23 = "MeleeATK_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.get_MeleeATK_ID);
		}
		LuaCSFunction get21 = Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache2B;
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.set_MeleeATK_ID);
		}
		LuaObject.addMember(l, name23, get21, Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache2C, true);
		string name24 = "RangeATK_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.get_RangeATK_ID);
		}
		LuaCSFunction get22 = Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache2D;
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.set_RangeATK_ID);
		}
		LuaObject.addMember(l, name24, get22, Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache2E, true);
		string name25 = "AttackSPD_INI";
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.get_AttackSPD_INI);
		}
		LuaCSFunction get23 = Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache2F;
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.set_AttackSPD_INI);
		}
		LuaObject.addMember(l, name25, get23, Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache30, true);
		string name26 = "MoveSPD_INI";
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.get_MoveSPD_INI);
		}
		LuaCSFunction get24 = Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache31;
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.set_MoveSPD_INI);
		}
		LuaObject.addMember(l, name26, get24, Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache32, true);
		string name27 = "HP_INI";
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.get_HP_INI);
		}
		LuaCSFunction get25 = Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache33;
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.set_HP_INI);
		}
		LuaObject.addMember(l, name27, get25, Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache34, true);
		string name28 = "AT_INI";
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.get_AT_INI);
		}
		LuaCSFunction get26 = Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache35;
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.set_AT_INI);
		}
		LuaObject.addMember(l, name28, get26, Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache36, true);
		string name29 = "DF_INI";
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.get_DF_INI);
		}
		LuaCSFunction get27 = Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache37;
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.set_DF_INI);
		}
		LuaObject.addMember(l, name29, get27, Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache38, true);
		string name30 = "MagicDF_INI";
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.get_MagicDF_INI);
		}
		LuaCSFunction get28 = Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache39;
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.set_MagicDF_INI);
		}
		LuaObject.addMember(l, name30, get28, Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache3A, true);
		string name31 = "HP_UP";
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.get_HP_UP);
		}
		LuaCSFunction get29 = Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache3B;
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.set_HP_UP);
		}
		LuaObject.addMember(l, name31, get29, Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache3C, true);
		string name32 = "AT_UP";
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.get_AT_UP);
		}
		LuaCSFunction get30 = Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache3D;
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.set_AT_UP);
		}
		LuaObject.addMember(l, name32, get30, Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache3E, true);
		string name33 = "DF_UP";
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.get_DF_UP);
		}
		LuaCSFunction get31 = Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache3F;
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.set_DF_UP);
		}
		LuaObject.addMember(l, name33, get31, Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache40, true);
		string name34 = "MagicDF_UP";
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.get_MagicDF_UP);
		}
		LuaCSFunction get32 = Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache41;
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.set_MagicDF_UP);
		}
		LuaObject.addMember(l, name34, get32, Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache42, true);
		string name35 = "CriticalDamage";
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.get_CriticalDamage);
		}
		LuaCSFunction get33 = Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache43;
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.set_CriticalDamage);
		}
		LuaObject.addMember(l, name35, get33, Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache44, true);
		string name36 = "CriticalRate";
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.get_CriticalRate);
		}
		LuaCSFunction get34 = Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache45;
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.set_CriticalRate);
		}
		LuaObject.addMember(l, name36, get34, Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache46, true);
		string name37 = "BF_MovePoint";
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.get_BF_MovePoint);
		}
		LuaCSFunction get35 = Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache47;
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.set_BF_MovePoint);
		}
		LuaObject.addMember(l, name37, get35, Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache48, true);
		string name38 = "BattlePowerHP";
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.get_BattlePowerHP);
		}
		LuaCSFunction get36 = Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache49;
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.set_BattlePowerHP);
		}
		LuaObject.addMember(l, name38, get36, Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache4A, true);
		string name39 = "BattlePowerAT";
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.get_BattlePowerAT);
		}
		LuaCSFunction get37 = Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache4B;
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.set_BattlePowerAT);
		}
		LuaObject.addMember(l, name39, get37, Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache4C, true);
		string name40 = "BattlePowerDF";
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.get_BattlePowerDF);
		}
		LuaCSFunction get38 = Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache4D;
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.set_BattlePowerDF);
		}
		LuaObject.addMember(l, name40, get38, Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache4E, true);
		string name41 = "BattlePowerMagicDF";
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.get_BattlePowerMagicDF);
		}
		LuaCSFunction get39 = Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache4F;
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.set_BattlePowerMagicDF);
		}
		LuaObject.addMember(l, name41, get39, Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache50, true);
		string name42 = "DieFlyDistanceMin";
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.get_DieFlyDistanceMin);
		}
		LuaCSFunction get40 = Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache51;
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache52 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache52 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.set_DieFlyDistanceMin);
		}
		LuaObject.addMember(l, name42, get40, Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache52, true);
		string name43 = "DieFlyDistanceMax";
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache53 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache53 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.get_DieFlyDistanceMax);
		}
		LuaCSFunction get41 = Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache53;
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache54 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache54 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.set_DieFlyDistanceMax);
		}
		LuaObject.addMember(l, name43, get41, Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache54, true);
		string name44 = "Model";
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache55 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache55 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.get_Model);
		}
		LuaCSFunction get42 = Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache55;
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache56 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache56 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.set_Model);
		}
		LuaObject.addMember(l, name44, get42, Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache56, true);
		string name45 = "Model2";
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache57 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache57 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.get_Model2);
		}
		LuaCSFunction get43 = Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache57;
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache58 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache58 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.set_Model2);
		}
		LuaObject.addMember(l, name45, get43, Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache58, true);
		string name46 = "CombatModel";
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache59 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache59 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.get_CombatModel);
		}
		LuaCSFunction get44 = Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache59;
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache5A == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache5A = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.set_CombatModel);
		}
		LuaObject.addMember(l, name46, get44, Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache5A, true);
		string name47 = "CombatModel2";
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache5B == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache5B = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.get_CombatModel2);
		}
		LuaCSFunction get45 = Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache5B;
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache5C == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache5C = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.set_CombatModel2);
		}
		LuaObject.addMember(l, name47, get45, Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache5C, true);
		string name48 = "ReplaceAnims";
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache5D == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache5D = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.get_ReplaceAnims);
		}
		LuaObject.addMember(l, name48, Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache5D, null, true);
		string name49 = "ModelScale";
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache5E == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache5E = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.get_ModelScale);
		}
		LuaCSFunction get46 = Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache5E;
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache5F == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache5F = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.set_ModelScale);
		}
		LuaObject.addMember(l, name49, get46, Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache5F, true);
		string name50 = "BF_ModelScale";
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache60 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache60 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.get_BF_ModelScale);
		}
		LuaCSFunction get47 = Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache60;
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache61 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache61 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.set_BF_ModelScale);
		}
		LuaObject.addMember(l, name50, get47, Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache61, true);
		string name51 = "UI_ModelScale";
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache62 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache62 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.get_UI_ModelScale);
		}
		LuaCSFunction get48 = Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache62;
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache63 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache63 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.set_UI_ModelScale);
		}
		LuaObject.addMember(l, name51, get48, Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache63, true);
		string name52 = "UI_ModelOffsetX";
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache64 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache64 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.get_UI_ModelOffsetX);
		}
		LuaCSFunction get49 = Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache64;
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache65 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache65 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.set_UI_ModelOffsetX);
		}
		LuaObject.addMember(l, name52, get49, Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache65, true);
		string name53 = "UI_ModelOffsetY";
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache66 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache66 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.get_UI_ModelOffsetY);
		}
		LuaCSFunction get50 = Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache66;
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache67 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache67 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.set_UI_ModelOffsetY);
		}
		LuaObject.addMember(l, name53, get50, Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache67, true);
		string name54 = "Sound_Enter";
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache68 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache68 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.get_Sound_Enter);
		}
		LuaCSFunction get51 = Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache68;
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache69 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache69 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.set_Sound_Enter);
		}
		LuaObject.addMember(l, name54, get51, Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache69, true);
		string name55 = "Sound_Die";
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache6A == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache6A = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.get_Sound_Die);
		}
		LuaCSFunction get52 = Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache6A;
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache6B == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache6B = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.set_Sound_Die);
		}
		LuaObject.addMember(l, name55, get52, Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache6B, true);
		string name56 = "Rank";
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache6C == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache6C = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.get_Rank);
		}
		LuaCSFunction get53 = Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache6C;
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache6D == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache6D = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.set_Rank);
		}
		LuaObject.addMember(l, name56, get53, Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache6D, true);
		string name57 = "IsEnemy";
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache6E == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache6E = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.get_IsEnemy);
		}
		LuaCSFunction get54 = Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache6E;
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache6F == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache6F = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.set_IsEnemy);
		}
		LuaObject.addMember(l, name57, get54, Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache6F, true);
		string name58 = "GetSoldierDesc";
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache70 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache70 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.get_GetSoldierDesc);
		}
		LuaCSFunction get55 = Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache70;
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache71 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache71 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.set_GetSoldierDesc);
		}
		LuaObject.addMember(l, name58, get55, Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache71, true);
		string name59 = "GetSoldierHeros_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache72 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache72 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.get_GetSoldierHeros_ID);
		}
		LuaObject.addMember(l, name59, Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache72, null, true);
		string name60 = "GetSoldierTechId";
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache73 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache73 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.get_GetSoldierTechId);
		}
		LuaCSFunction get56 = Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache73;
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache74 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache74 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.set_GetSoldierTechId);
		}
		LuaObject.addMember(l, name60, get56, Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache74, true);
		string name61 = "SoldierSkins_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache75 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache75 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.get_SoldierSkins_ID);
		}
		LuaObject.addMember(l, name61, Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache75, null, true);
		if (Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache76 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache76 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ConfigData_ConfigDataSoldierInfo.<>f__mg$cache76, typeof(ConfigDataSoldierInfo));
	}

	// Token: 0x0400D47B RID: 54395
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400D47C RID: 54396
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400D47D RID: 54397
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400D47E RID: 54398
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400D47F RID: 54399
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400D480 RID: 54400
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400D481 RID: 54401
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400D482 RID: 54402
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400D483 RID: 54403
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400D484 RID: 54404
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400D485 RID: 54405
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400D486 RID: 54406
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400D487 RID: 54407
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400D488 RID: 54408
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400D489 RID: 54409
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400D48A RID: 54410
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400D48B RID: 54411
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400D48C RID: 54412
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400D48D RID: 54413
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400D48E RID: 54414
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400D48F RID: 54415
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400D490 RID: 54416
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400D491 RID: 54417
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400D492 RID: 54418
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400D493 RID: 54419
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400D494 RID: 54420
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400D495 RID: 54421
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400D496 RID: 54422
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400D497 RID: 54423
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400D498 RID: 54424
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400D499 RID: 54425
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400D49A RID: 54426
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400D49B RID: 54427
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400D49C RID: 54428
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400D49D RID: 54429
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400D49E RID: 54430
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0400D49F RID: 54431
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0400D4A0 RID: 54432
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0400D4A1 RID: 54433
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0400D4A2 RID: 54434
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0400D4A3 RID: 54435
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0400D4A4 RID: 54436
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0400D4A5 RID: 54437
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0400D4A6 RID: 54438
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0400D4A7 RID: 54439
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0400D4A8 RID: 54440
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0400D4A9 RID: 54441
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x0400D4AA RID: 54442
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x0400D4AB RID: 54443
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x0400D4AC RID: 54444
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x0400D4AD RID: 54445
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x0400D4AE RID: 54446
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x0400D4AF RID: 54447
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x0400D4B0 RID: 54448
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x0400D4B1 RID: 54449
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x0400D4B2 RID: 54450
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x0400D4B3 RID: 54451
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x0400D4B4 RID: 54452
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x0400D4B5 RID: 54453
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x0400D4B6 RID: 54454
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x0400D4B7 RID: 54455
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x0400D4B8 RID: 54456
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x0400D4B9 RID: 54457
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x0400D4BA RID: 54458
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x0400D4BB RID: 54459
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x0400D4BC RID: 54460
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x0400D4BD RID: 54461
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x0400D4BE RID: 54462
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x0400D4BF RID: 54463
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x0400D4C0 RID: 54464
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x0400D4C1 RID: 54465
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x0400D4C2 RID: 54466
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x0400D4C3 RID: 54467
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x0400D4C4 RID: 54468
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x0400D4C5 RID: 54469
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x0400D4C6 RID: 54470
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x0400D4C7 RID: 54471
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x0400D4C8 RID: 54472
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x0400D4C9 RID: 54473
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x0400D4CA RID: 54474
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x0400D4CB RID: 54475
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x0400D4CC RID: 54476
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x0400D4CD RID: 54477
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x0400D4CE RID: 54478
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x0400D4CF RID: 54479
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x0400D4D0 RID: 54480
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x0400D4D1 RID: 54481
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x0400D4D2 RID: 54482
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;

	// Token: 0x0400D4D3 RID: 54483
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache58;

	// Token: 0x0400D4D4 RID: 54484
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache59;

	// Token: 0x0400D4D5 RID: 54485
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5A;

	// Token: 0x0400D4D6 RID: 54486
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5B;

	// Token: 0x0400D4D7 RID: 54487
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5C;

	// Token: 0x0400D4D8 RID: 54488
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5D;

	// Token: 0x0400D4D9 RID: 54489
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5E;

	// Token: 0x0400D4DA RID: 54490
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5F;

	// Token: 0x0400D4DB RID: 54491
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache60;

	// Token: 0x0400D4DC RID: 54492
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache61;

	// Token: 0x0400D4DD RID: 54493
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache62;

	// Token: 0x0400D4DE RID: 54494
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache63;

	// Token: 0x0400D4DF RID: 54495
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache64;

	// Token: 0x0400D4E0 RID: 54496
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache65;

	// Token: 0x0400D4E1 RID: 54497
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache66;

	// Token: 0x0400D4E2 RID: 54498
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache67;

	// Token: 0x0400D4E3 RID: 54499
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache68;

	// Token: 0x0400D4E4 RID: 54500
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache69;

	// Token: 0x0400D4E5 RID: 54501
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6A;

	// Token: 0x0400D4E6 RID: 54502
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6B;

	// Token: 0x0400D4E7 RID: 54503
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6C;

	// Token: 0x0400D4E8 RID: 54504
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6D;

	// Token: 0x0400D4E9 RID: 54505
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6E;

	// Token: 0x0400D4EA RID: 54506
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6F;

	// Token: 0x0400D4EB RID: 54507
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache70;

	// Token: 0x0400D4EC RID: 54508
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache71;

	// Token: 0x0400D4ED RID: 54509
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache72;

	// Token: 0x0400D4EE RID: 54510
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache73;

	// Token: 0x0400D4EF RID: 54511
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache74;

	// Token: 0x0400D4F0 RID: 54512
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache75;

	// Token: 0x0400D4F1 RID: 54513
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache76;
}
