using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Battle;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020014DC RID: 5340
[Preserve]
public class Lua_BlackJack_ProjectL_UI_HeroPropertyComputer : LuaObject
{
	// Token: 0x0601F6E1 RID: 128737 RVA: 0x00A4E550 File Offset: 0x00A4C750
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			HeroPropertyComputer o = new HeroPropertyComputer();
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

	// Token: 0x0601F6E2 RID: 128738 RVA: 0x00A4E598 File Offset: 0x00A4C798
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Init(IntPtr l)
	{
		int result;
		try
		{
			HeroPropertyComputer heroPropertyComputer = (HeroPropertyComputer)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			heroPropertyComputer.Init(configDataLoader);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F6E3 RID: 128739 RVA: 0x00A4E5F0 File Offset: 0x00A4C7F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ComputeHeroProperties(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				HeroPropertyComputer heroPropertyComputer = (HeroPropertyComputer)LuaObject.checkSelf(l);
				BattleHero hero;
				LuaObject.checkType<BattleHero>(l, 2, out hero);
				heroPropertyComputer.ComputeHeroProperties(hero);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 9)
			{
				HeroPropertyComputer heroPropertyComputer2 = (HeroPropertyComputer)LuaObject.checkSelf(l);
				Hero hero2;
				LuaObject.checkType<Hero>(l, 2, out hero2);
				int jobConnectionId;
				LuaObject.checkType(l, 3, out jobConnectionId);
				int heroLevel;
				LuaObject.checkType(l, 4, out heroLevel);
				int heroLevel2;
				LuaObject.checkType(l, 5, out heroLevel2);
				int starLevel;
				LuaObject.checkType(l, 6, out starLevel);
				int starLevel2;
				LuaObject.checkType(l, 7, out starLevel2);
				int jobLevel;
				LuaObject.checkType(l, 8, out jobLevel);
				int jobLevel2;
				LuaObject.checkType(l, 9, out jobLevel2);
				heroPropertyComputer2.ComputeHeroProperties(hero2, jobConnectionId, heroLevel, heroLevel2, starLevel, starLevel2, jobLevel, jobLevel2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function ComputeHeroProperties to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F6E4 RID: 128740 RVA: 0x00A4E6FC File Offset: 0x00A4C8FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ComputeHeroJobLevelUpProperties(IntPtr l)
	{
		int result;
		try
		{
			HeroPropertyComputer heroPropertyComputer = (HeroPropertyComputer)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			int jobConnectionId;
			LuaObject.checkType(l, 3, out jobConnectionId);
			heroPropertyComputer.ComputeHeroJobLevelUpProperties(hero, jobConnectionId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F6E5 RID: 128741 RVA: 0x00A4E760 File Offset: 0x00A4C960
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ComputeHeroEquipmentProperties(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(Hero)))
			{
				HeroPropertyComputer heroPropertyComputer = (HeroPropertyComputer)LuaObject.checkSelf(l);
				Hero hero;
				LuaObject.checkType<Hero>(l, 2, out hero);
				heroPropertyComputer.ComputeHeroEquipmentProperties(hero);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(BattleHero)))
			{
				HeroPropertyComputer heroPropertyComputer2 = (HeroPropertyComputer)LuaObject.checkSelf(l);
				BattleHero hero2;
				LuaObject.checkType<BattleHero>(l, 2, out hero2);
				heroPropertyComputer2.ComputeHeroEquipmentProperties(hero2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function ComputeHeroEquipmentProperties to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F6E6 RID: 128742 RVA: 0x00A4E838 File Offset: 0x00A4CA38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ComputeSoldierCommandProperties(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 3)
			{
				HeroPropertyComputer heroPropertyComputer = (HeroPropertyComputer)LuaObject.checkSelf(l);
				Hero hero;
				LuaObject.checkType<Hero>(l, 2, out hero);
				ConfigDataSoldierInfo soldierInfo;
				LuaObject.checkType<ConfigDataSoldierInfo>(l, 3, out soldierInfo);
				heroPropertyComputer.ComputeSoldierCommandProperties(hero, soldierInfo);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 5)
			{
				HeroPropertyComputer heroPropertyComputer2 = (HeroPropertyComputer)LuaObject.checkSelf(l);
				BattleHero hero2;
				LuaObject.checkType<BattleHero>(l, 2, out hero2);
				ConfigDataSoldierInfo soldierInfo2;
				LuaObject.checkType<ConfigDataSoldierInfo>(l, 3, out soldierInfo2);
				List<TrainingTech> techs;
				LuaObject.checkType<List<TrainingTech>>(l, 4, out techs);
				ConfigDataModelSkinResourceInfo soldierSkinResInfo;
				LuaObject.checkType<ConfigDataModelSkinResourceInfo>(l, 5, out soldierSkinResInfo);
				heroPropertyComputer2.ComputeSoldierCommandProperties(hero2, soldierInfo2, techs, soldierSkinResInfo);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function ComputeSoldierCommandProperties to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F6E7 RID: 128743 RVA: 0x00A4E924 File Offset: 0x00A4CB24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ComputeHeroBuffProperties(IntPtr l)
	{
		int result;
		try
		{
			HeroPropertyComputer heroPropertyComputer = (HeroPropertyComputer)LuaObject.checkSelf(l);
			BattleActor a;
			LuaObject.checkType<BattleActor>(l, 2, out a);
			heroPropertyComputer.ComputeHeroBuffProperties(a);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F6E8 RID: 128744 RVA: 0x00A4E97C File Offset: 0x00A4CB7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ComputeSoldierBuffCommandProperties(IntPtr l)
	{
		int result;
		try
		{
			HeroPropertyComputer heroPropertyComputer = (HeroPropertyComputer)LuaObject.checkSelf(l);
			BattleActor a;
			LuaObject.checkType<BattleActor>(l, 2, out a);
			heroPropertyComputer.ComputeSoldierBuffCommandProperties(a);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F6E9 RID: 128745 RVA: 0x00A4E9D4 File Offset: 0x00A4CBD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetEquipmentResonanceSkillInfos(IntPtr l)
	{
		int result;
		try
		{
			HeroPropertyComputer heroPropertyComputer = (HeroPropertyComputer)LuaObject.checkSelf(l);
			ulong[] equipmentIds;
			LuaObject.checkArray<ulong>(l, 2, out equipmentIds);
			List<ConfigDataSkillInfo> equipmentResonanceSkillInfos = heroPropertyComputer.GetEquipmentResonanceSkillInfos(equipmentIds);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, equipmentResonanceSkillInfos);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F6EA RID: 128746 RVA: 0x00A4EA38 File Offset: 0x00A4CC38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CollectJobMasterPropertyModifier(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 4)
			{
				HeroPropertyComputer heroPropertyComputer = (HeroPropertyComputer)LuaObject.checkSelf(l);
				Hero hero;
				LuaObject.checkType<Hero>(l, 2, out hero);
				int jobConnectionId;
				LuaObject.checkType(l, 3, out jobConnectionId);
				int jobLevel;
				LuaObject.checkType(l, 4, out jobLevel);
				heroPropertyComputer.m_luaExportHelper.CollectJobMasterPropertyModifier(hero, jobConnectionId, jobLevel);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(BattleActor)))
			{
				HeroPropertyComputer heroPropertyComputer2 = (HeroPropertyComputer)LuaObject.checkSelf(l);
				BattleActor a;
				LuaObject.checkType<BattleActor>(l, 2, out a);
				heroPropertyComputer2.m_luaExportHelper.CollectJobMasterPropertyModifier(a);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(BattleHero)))
			{
				HeroPropertyComputer heroPropertyComputer3 = (HeroPropertyComputer)LuaObject.checkSelf(l);
				BattleHero hero2;
				LuaObject.checkType<BattleHero>(l, 2, out hero2);
				heroPropertyComputer3.m_luaExportHelper.CollectJobMasterPropertyModifier(hero2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function CollectJobMasterPropertyModifier to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F6EB RID: 128747 RVA: 0x00A4EB7C File Offset: 0x00A4CD7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CollectFetterPropertyModidier(IntPtr l)
	{
		int result;
		try
		{
			HeroPropertyComputer heroPropertyComputer = (HeroPropertyComputer)LuaObject.checkSelf(l);
			Dictionary<int, int> fetters;
			LuaObject.checkType<Dictionary<int, int>>(l, 2, out fetters);
			heroPropertyComputer.m_luaExportHelper.CollectFetterPropertyModidier(fetters);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F6EC RID: 128748 RVA: 0x00A4EBD8 File Offset: 0x00A4CDD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CollectEquipmentPropertyModifier(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(Hero)))
			{
				HeroPropertyComputer heroPropertyComputer = (HeroPropertyComputer)LuaObject.checkSelf(l);
				Hero hero;
				LuaObject.checkType<Hero>(l, 2, out hero);
				heroPropertyComputer.m_luaExportHelper.CollectEquipmentPropertyModifier(hero);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(BattleActor)))
			{
				HeroPropertyComputer heroPropertyComputer2 = (HeroPropertyComputer)LuaObject.checkSelf(l);
				BattleActor a;
				LuaObject.checkType<BattleActor>(l, 2, out a);
				heroPropertyComputer2.m_luaExportHelper.CollectEquipmentPropertyModifier(a);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(BattleHero)))
			{
				HeroPropertyComputer heroPropertyComputer3 = (HeroPropertyComputer)LuaObject.checkSelf(l);
				BattleHero hero2;
				LuaObject.checkType<BattleHero>(l, 2, out hero2);
				heroPropertyComputer3.m_luaExportHelper.CollectEquipmentPropertyModifier(hero2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function CollectEquipmentPropertyModifier to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F6ED RID: 128749 RVA: 0x00A4ED04 File Offset: 0x00A4CF04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CollectSoldierPassiveSkillPropertyModifier(IntPtr l)
	{
		int result;
		try
		{
			HeroPropertyComputer heroPropertyComputer = (HeroPropertyComputer)LuaObject.checkSelf(l);
			ConfigDataSoldierInfo soldierInfo;
			LuaObject.checkType<ConfigDataSoldierInfo>(l, 2, out soldierInfo);
			List<TrainingTech> techs;
			LuaObject.checkType<List<TrainingTech>>(l, 3, out techs);
			heroPropertyComputer.m_luaExportHelper.CollectSoldierPassiveSkillPropertyModifier(soldierInfo, techs);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F6EE RID: 128750 RVA: 0x00A4ED70 File Offset: 0x00A4CF70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CollectSkinPropertyModifier(IntPtr l)
	{
		int result;
		try
		{
			HeroPropertyComputer heroPropertyComputer = (HeroPropertyComputer)LuaObject.checkSelf(l);
			ConfigDataModelSkinResourceInfo skinResInfo;
			LuaObject.checkType<ConfigDataModelSkinResourceInfo>(l, 2, out skinResInfo);
			heroPropertyComputer.m_luaExportHelper.CollectSkinPropertyModifier(skinResInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F6EF RID: 128751 RVA: 0x00A4EDCC File Offset: 0x00A4CFCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CollectBuffPropertyModifier(IntPtr l)
	{
		int result;
		try
		{
			HeroPropertyComputer heroPropertyComputer = (HeroPropertyComputer)LuaObject.checkSelf(l);
			BattleActor a;
			LuaObject.checkType<BattleActor>(l, 2, out a);
			bool isDynamic;
			LuaObject.checkType(l, 3, out isDynamic);
			heroPropertyComputer.m_luaExportHelper.CollectBuffPropertyModifier(a, isDynamic);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F6F0 RID: 128752 RVA: 0x00A4EE38 File Offset: 0x00A4D038
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CollectBuffPropertyExchange(IntPtr l)
	{
		int result;
		try
		{
			HeroPropertyComputer heroPropertyComputer = (HeroPropertyComputer)LuaObject.checkSelf(l);
			BattleActor a;
			LuaObject.checkType<BattleActor>(l, 2, out a);
			BattleProperty property;
			LuaObject.checkType<BattleProperty>(l, 3, out property);
			heroPropertyComputer.m_luaExportHelper.CollectBuffPropertyExchange(a, property);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F6F1 RID: 128753 RVA: 0x00A4EEA4 File Offset: 0x00A4D0A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CollectJobPropertyModifier(IntPtr l)
	{
		int result;
		try
		{
			HeroPropertyComputer heroPropertyComputer = (HeroPropertyComputer)LuaObject.checkSelf(l);
			ConfigDataJobInfo jobInfo;
			LuaObject.checkType<ConfigDataJobInfo>(l, 2, out jobInfo);
			heroPropertyComputer.m_luaExportHelper.CollectJobPropertyModifier(jobInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F6F2 RID: 128754 RVA: 0x00A4EF00 File Offset: 0x00A4D100
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CollectPassiveSkillStaticPropertyModifier(IntPtr l)
	{
		int result;
		try
		{
			HeroPropertyComputer heroPropertyComputer = (HeroPropertyComputer)LuaObject.checkSelf(l);
			ConfigDataSkillInfo skillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 2, out skillInfo);
			heroPropertyComputer.m_luaExportHelper.CollectPassiveSkillStaticPropertyModifier(skillInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F6F3 RID: 128755 RVA: 0x00A4EF5C File Offset: 0x00A4D15C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CollectStaticPropertyModifier(IntPtr l)
	{
		int result;
		try
		{
			HeroPropertyComputer heroPropertyComputer = (HeroPropertyComputer)LuaObject.checkSelf(l);
			PropertyModifyType modifyType;
			LuaObject.checkEnum<PropertyModifyType>(l, 2, out modifyType);
			int value;
			LuaObject.checkType(l, 3, out value);
			heroPropertyComputer.m_luaExportHelper.CollectStaticPropertyModifier(modifyType, value);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F6F4 RID: 128756 RVA: 0x00A4EFC8 File Offset: 0x00A4D1C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			HeroPropertyComputer heroPropertyComputer = (HeroPropertyComputer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroPropertyComputer.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F6F5 RID: 128757 RVA: 0x00A4F020 File Offset: 0x00A4D220
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			HeroPropertyComputer heroPropertyComputer = (HeroPropertyComputer)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			heroPropertyComputer.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F6F6 RID: 128758 RVA: 0x00A4F07C File Offset: 0x00A4D27C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_property0(IntPtr l)
	{
		int result;
		try
		{
			HeroPropertyComputer heroPropertyComputer = (HeroPropertyComputer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroPropertyComputer.m_luaExportHelper.m_property0);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F6F7 RID: 128759 RVA: 0x00A4F0D4 File Offset: 0x00A4D2D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_property0(IntPtr l)
	{
		int result;
		try
		{
			HeroPropertyComputer heroPropertyComputer = (HeroPropertyComputer)LuaObject.checkSelf(l);
			BattleProperty property;
			LuaObject.checkType<BattleProperty>(l, 2, out property);
			heroPropertyComputer.m_luaExportHelper.m_property0 = property;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F6F8 RID: 128760 RVA: 0x00A4F130 File Offset: 0x00A4D330
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_property1(IntPtr l)
	{
		int result;
		try
		{
			HeroPropertyComputer heroPropertyComputer = (HeroPropertyComputer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroPropertyComputer.m_luaExportHelper.m_property1);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F6F9 RID: 128761 RVA: 0x00A4F188 File Offset: 0x00A4D388
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_property1(IntPtr l)
	{
		int result;
		try
		{
			HeroPropertyComputer heroPropertyComputer = (HeroPropertyComputer)LuaObject.checkSelf(l);
			BattleProperty property;
			LuaObject.checkType<BattleProperty>(l, 2, out property);
			heroPropertyComputer.m_luaExportHelper.m_property1 = property;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F6FA RID: 128762 RVA: 0x00A4F1E4 File Offset: 0x00A4D3E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_property2(IntPtr l)
	{
		int result;
		try
		{
			HeroPropertyComputer heroPropertyComputer = (HeroPropertyComputer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroPropertyComputer.m_luaExportHelper.m_property2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F6FB RID: 128763 RVA: 0x00A4F23C File Offset: 0x00A4D43C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_property2(IntPtr l)
	{
		int result;
		try
		{
			HeroPropertyComputer heroPropertyComputer = (HeroPropertyComputer)LuaObject.checkSelf(l);
			BattleProperty property;
			LuaObject.checkType<BattleProperty>(l, 2, out property);
			heroPropertyComputer.m_luaExportHelper.m_property2 = property;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F6FC RID: 128764 RVA: 0x00A4F298 File Offset: 0x00A4D498
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_propertyModifier(IntPtr l)
	{
		int result;
		try
		{
			HeroPropertyComputer heroPropertyComputer = (HeroPropertyComputer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroPropertyComputer.m_luaExportHelper.m_propertyModifier);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F6FD RID: 128765 RVA: 0x00A4F2F0 File Offset: 0x00A4D4F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_propertyModifier(IntPtr l)
	{
		int result;
		try
		{
			HeroPropertyComputer heroPropertyComputer = (HeroPropertyComputer)LuaObject.checkSelf(l);
			BattlePropertyModifier propertyModifier;
			LuaObject.checkType<BattlePropertyModifier>(l, 2, out propertyModifier);
			heroPropertyComputer.m_luaExportHelper.m_propertyModifier = propertyModifier;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F6FE RID: 128766 RVA: 0x00A4F34C File Offset: 0x00A4D54C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Property0(IntPtr l)
	{
		int result;
		try
		{
			HeroPropertyComputer heroPropertyComputer = (HeroPropertyComputer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroPropertyComputer.Property0);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F6FF RID: 128767 RVA: 0x00A4F3A0 File Offset: 0x00A4D5A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Property1(IntPtr l)
	{
		int result;
		try
		{
			HeroPropertyComputer heroPropertyComputer = (HeroPropertyComputer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroPropertyComputer.Property1);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F700 RID: 128768 RVA: 0x00A4F3F4 File Offset: 0x00A4D5F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Property2(IntPtr l)
	{
		int result;
		try
		{
			HeroPropertyComputer heroPropertyComputer = (HeroPropertyComputer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroPropertyComputer.Property2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F701 RID: 128769 RVA: 0x00A4F448 File Offset: 0x00A4D648
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.HeroPropertyComputer");
		if (Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.ComputeHeroProperties);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.ComputeHeroJobLevelUpProperties);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.ComputeHeroEquipmentProperties);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.ComputeSoldierCommandProperties);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.ComputeHeroBuffProperties);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.ComputeSoldierBuffCommandProperties);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.GetEquipmentResonanceSkillInfos);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.CollectJobMasterPropertyModifier);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.CollectFetterPropertyModidier);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.CollectEquipmentPropertyModifier);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.CollectSoldierPassiveSkillPropertyModifier);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.CollectSkinPropertyModifier);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.CollectBuffPropertyModifier);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.CollectBuffPropertyExchange);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.CollectJobPropertyModifier);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.CollectPassiveSkillStaticPropertyModifier);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.CollectStaticPropertyModifier);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.<>f__mg$cache11);
		string name = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.get_m_configDataLoader);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.<>f__mg$cache12;
		if (Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.<>f__mg$cache13, true);
		string name2 = "m_property0";
		if (Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.get_m_property0);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.<>f__mg$cache14;
		if (Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.set_m_property0);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.<>f__mg$cache15, true);
		string name3 = "m_property1";
		if (Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.get_m_property1);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.<>f__mg$cache16;
		if (Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.set_m_property1);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.<>f__mg$cache17, true);
		string name4 = "m_property2";
		if (Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.get_m_property2);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.<>f__mg$cache18;
		if (Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.set_m_property2);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.<>f__mg$cache19, true);
		string name5 = "m_propertyModifier";
		if (Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.get_m_propertyModifier);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.<>f__mg$cache1A;
		if (Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.set_m_propertyModifier);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.<>f__mg$cache1B, true);
		string name6 = "Property0";
		if (Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.get_Property0);
		}
		LuaObject.addMember(l, name6, Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.<>f__mg$cache1C, null, true);
		string name7 = "Property1";
		if (Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.get_Property1);
		}
		LuaObject.addMember(l, name7, Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.<>f__mg$cache1D, null, true);
		string name8 = "Property2";
		if (Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.get_Property2);
		}
		LuaObject.addMember(l, name8, Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.<>f__mg$cache1E, null, true);
		if (Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_HeroPropertyComputer.<>f__mg$cache1F, typeof(HeroPropertyComputer));
	}

	// Token: 0x0401570B RID: 87819
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401570C RID: 87820
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401570D RID: 87821
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0401570E RID: 87822
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0401570F RID: 87823
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04015710 RID: 87824
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04015711 RID: 87825
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04015712 RID: 87826
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04015713 RID: 87827
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04015714 RID: 87828
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04015715 RID: 87829
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04015716 RID: 87830
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04015717 RID: 87831
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04015718 RID: 87832
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04015719 RID: 87833
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0401571A RID: 87834
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0401571B RID: 87835
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0401571C RID: 87836
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0401571D RID: 87837
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0401571E RID: 87838
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0401571F RID: 87839
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04015720 RID: 87840
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04015721 RID: 87841
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04015722 RID: 87842
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04015723 RID: 87843
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04015724 RID: 87844
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04015725 RID: 87845
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04015726 RID: 87846
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04015727 RID: 87847
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04015728 RID: 87848
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04015729 RID: 87849
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0401572A RID: 87850
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;
}
