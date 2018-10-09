using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Battle;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001191 RID: 4497
[Preserve]
public class Lua_BlackJack_ProjectL_Battle_BattleActorSetup : LuaObject
{
	// Token: 0x060171F6 RID: 94710 RVA: 0x0063E68C File Offset: 0x0063C88C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			BattleActorSetup o = new BattleActorSetup();
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

	// Token: 0x060171F7 RID: 94711 RVA: 0x0063E6D4 File Offset: 0x0063C8D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_HeroInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleActorSetup battleActorSetup = (BattleActorSetup)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorSetup.HeroInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060171F8 RID: 94712 RVA: 0x0063E728 File Offset: 0x0063C928
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_HeroInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleActorSetup battleActorSetup = (BattleActorSetup)LuaObject.checkSelf(l);
			ConfigDataHeroInfo heroInfo;
			LuaObject.checkType<ConfigDataHeroInfo>(l, 2, out heroInfo);
			battleActorSetup.HeroInfo = heroInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060171F9 RID: 94713 RVA: 0x0063E780 File Offset: 0x0063C980
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_JobConnectionInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleActorSetup battleActorSetup = (BattleActorSetup)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorSetup.JobConnectionInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060171FA RID: 94714 RVA: 0x0063E7D4 File Offset: 0x0063C9D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_JobConnectionInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleActorSetup battleActorSetup = (BattleActorSetup)LuaObject.checkSelf(l);
			ConfigDataJobConnectionInfo jobConnectionInfo;
			LuaObject.checkType<ConfigDataJobConnectionInfo>(l, 2, out jobConnectionInfo);
			battleActorSetup.JobConnectionInfo = jobConnectionInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060171FB RID: 94715 RVA: 0x0063E82C File Offset: 0x0063CA2C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_SoldierInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleActorSetup battleActorSetup = (BattleActorSetup)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorSetup.SoldierInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060171FC RID: 94716 RVA: 0x0063E880 File Offset: 0x0063CA80
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_SoldierInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleActorSetup battleActorSetup = (BattleActorSetup)LuaObject.checkSelf(l);
			ConfigDataSoldierInfo soldierInfo;
			LuaObject.checkType<ConfigDataSoldierInfo>(l, 2, out soldierInfo);
			battleActorSetup.SoldierInfo = soldierInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060171FD RID: 94717 RVA: 0x0063E8D8 File Offset: 0x0063CAD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SkillInfos(IntPtr l)
	{
		int result;
		try
		{
			BattleActorSetup battleActorSetup = (BattleActorSetup)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorSetup.SkillInfos);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060171FE RID: 94718 RVA: 0x0063E92C File Offset: 0x0063CB2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_SkillInfos(IntPtr l)
	{
		int result;
		try
		{
			BattleActorSetup battleActorSetup = (BattleActorSetup)LuaObject.checkSelf(l);
			ConfigDataSkillInfo[] skillInfos;
			LuaObject.checkArray<ConfigDataSkillInfo>(l, 2, out skillInfos);
			battleActorSetup.SkillInfos = skillInfos;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060171FF RID: 94719 RVA: 0x0063E984 File Offset: 0x0063CB84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_MasterJobInfos(IntPtr l)
	{
		int result;
		try
		{
			BattleActorSetup battleActorSetup = (BattleActorSetup)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorSetup.MasterJobInfos);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017200 RID: 94720 RVA: 0x0063E9D8 File Offset: 0x0063CBD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_MasterJobInfos(IntPtr l)
	{
		int result;
		try
		{
			BattleActorSetup battleActorSetup = (BattleActorSetup)LuaObject.checkSelf(l);
			ConfigDataJobInfo[] masterJobInfos;
			LuaObject.checkArray<ConfigDataJobInfo>(l, 2, out masterJobInfos);
			battleActorSetup.MasterJobInfos = masterJobInfos;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017201 RID: 94721 RVA: 0x0063EA30 File Offset: 0x0063CC30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Equipments(IntPtr l)
	{
		int result;
		try
		{
			BattleActorSetup battleActorSetup = (BattleActorSetup)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorSetup.Equipments);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017202 RID: 94722 RVA: 0x0063EA84 File Offset: 0x0063CC84
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Equipments(IntPtr l)
	{
		int result;
		try
		{
			BattleActorSetup battleActorSetup = (BattleActorSetup)LuaObject.checkSelf(l);
			BattleActorEquipment[] equipments;
			LuaObject.checkArray<BattleActorEquipment>(l, 2, out equipments);
			battleActorSetup.Equipments = equipments;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017203 RID: 94723 RVA: 0x0063EADC File Offset: 0x0063CCDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ResonanceSkillInfos(IntPtr l)
	{
		int result;
		try
		{
			BattleActorSetup battleActorSetup = (BattleActorSetup)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorSetup.ResonanceSkillInfos);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017204 RID: 94724 RVA: 0x0063EB30 File Offset: 0x0063CD30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ResonanceSkillInfos(IntPtr l)
	{
		int result;
		try
		{
			BattleActorSetup battleActorSetup = (BattleActorSetup)LuaObject.checkSelf(l);
			ConfigDataSkillInfo[] resonanceSkillInfos;
			LuaObject.checkArray<ConfigDataSkillInfo>(l, 2, out resonanceSkillInfos);
			battleActorSetup.ResonanceSkillInfos = resonanceSkillInfos;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017205 RID: 94725 RVA: 0x0063EB88 File Offset: 0x0063CD88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_FetterSkillInfos(IntPtr l)
	{
		int result;
		try
		{
			BattleActorSetup battleActorSetup = (BattleActorSetup)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorSetup.FetterSkillInfos);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017206 RID: 94726 RVA: 0x0063EBDC File Offset: 0x0063CDDC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_FetterSkillInfos(IntPtr l)
	{
		int result;
		try
		{
			BattleActorSetup battleActorSetup = (BattleActorSetup)LuaObject.checkSelf(l);
			ConfigDataSkillInfo[] fetterSkillInfos;
			LuaObject.checkArray<ConfigDataSkillInfo>(l, 2, out fetterSkillInfos);
			battleActorSetup.FetterSkillInfos = fetterSkillInfos;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017207 RID: 94727 RVA: 0x0063EC34 File Offset: 0x0063CE34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_HeroLevel(IntPtr l)
	{
		int result;
		try
		{
			BattleActorSetup battleActorSetup = (BattleActorSetup)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorSetup.HeroLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017208 RID: 94728 RVA: 0x0063EC88 File Offset: 0x0063CE88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_HeroLevel(IntPtr l)
	{
		int result;
		try
		{
			BattleActorSetup battleActorSetup = (BattleActorSetup)LuaObject.checkSelf(l);
			int heroLevel;
			LuaObject.checkType(l, 2, out heroLevel);
			battleActorSetup.HeroLevel = heroLevel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017209 RID: 94729 RVA: 0x0063ECE0 File Offset: 0x0063CEE0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_HeroStar(IntPtr l)
	{
		int result;
		try
		{
			BattleActorSetup battleActorSetup = (BattleActorSetup)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorSetup.HeroStar);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601720A RID: 94730 RVA: 0x0063ED34 File Offset: 0x0063CF34
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_HeroStar(IntPtr l)
	{
		int result;
		try
		{
			BattleActorSetup battleActorSetup = (BattleActorSetup)LuaObject.checkSelf(l);
			int heroStar;
			LuaObject.checkType(l, 2, out heroStar);
			battleActorSetup.HeroStar = heroStar;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601720B RID: 94731 RVA: 0x0063ED8C File Offset: 0x0063CF8C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_JobLevel(IntPtr l)
	{
		int result;
		try
		{
			BattleActorSetup battleActorSetup = (BattleActorSetup)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorSetup.JobLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601720C RID: 94732 RVA: 0x0063EDE0 File Offset: 0x0063CFE0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_JobLevel(IntPtr l)
	{
		int result;
		try
		{
			BattleActorSetup battleActorSetup = (BattleActorSetup)LuaObject.checkSelf(l);
			int jobLevel;
			LuaObject.checkType(l, 2, out jobLevel);
			battleActorSetup.JobLevel = jobLevel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601720D RID: 94733 RVA: 0x0063EE38 File Offset: 0x0063D038
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_SoldierCount(IntPtr l)
	{
		int result;
		try
		{
			BattleActorSetup battleActorSetup = (BattleActorSetup)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorSetup.SoldierCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601720E RID: 94734 RVA: 0x0063EE8C File Offset: 0x0063D08C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_SoldierCount(IntPtr l)
	{
		int result;
		try
		{
			BattleActorSetup battleActorSetup = (BattleActorSetup)LuaObject.checkSelf(l);
			int soldierCount;
			LuaObject.checkType(l, 2, out soldierCount);
			battleActorSetup.SoldierCount = soldierCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601720F RID: 94735 RVA: 0x0063EEE4 File Offset: 0x0063D0E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Position(IntPtr l)
	{
		int result;
		try
		{
			BattleActorSetup battleActorSetup = (BattleActorSetup)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorSetup.Position);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017210 RID: 94736 RVA: 0x0063EF3C File Offset: 0x0063D13C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Position(IntPtr l)
	{
		int result;
		try
		{
			BattleActorSetup battleActorSetup = (BattleActorSetup)LuaObject.checkSelf(l);
			GridPosition position;
			LuaObject.checkValueType<GridPosition>(l, 2, out position);
			battleActorSetup.Position = position;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017211 RID: 94737 RVA: 0x0063EF94 File Offset: 0x0063D194
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Direction(IntPtr l)
	{
		int result;
		try
		{
			BattleActorSetup battleActorSetup = (BattleActorSetup)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorSetup.Direction);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017212 RID: 94738 RVA: 0x0063EFE8 File Offset: 0x0063D1E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Direction(IntPtr l)
	{
		int result;
		try
		{
			BattleActorSetup battleActorSetup = (BattleActorSetup)LuaObject.checkSelf(l);
			int direction;
			LuaObject.checkType(l, 2, out direction);
			battleActorSetup.Direction = direction;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017213 RID: 94739 RVA: 0x0063F040 File Offset: 0x0063D240
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_IsNpc(IntPtr l)
	{
		int result;
		try
		{
			BattleActorSetup battleActorSetup = (BattleActorSetup)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorSetup.IsNpc);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017214 RID: 94740 RVA: 0x0063F094 File Offset: 0x0063D294
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_IsNpc(IntPtr l)
	{
		int result;
		try
		{
			BattleActorSetup battleActorSetup = (BattleActorSetup)LuaObject.checkSelf(l);
			bool isNpc;
			LuaObject.checkType(l, 2, out isNpc);
			battleActorSetup.IsNpc = isNpc;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017215 RID: 94741 RVA: 0x0063F0EC File Offset: 0x0063D2EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BehaviorId(IntPtr l)
	{
		int result;
		try
		{
			BattleActorSetup battleActorSetup = (BattleActorSetup)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorSetup.BehaviorId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017216 RID: 94742 RVA: 0x0063F140 File Offset: 0x0063D340
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_BehaviorId(IntPtr l)
	{
		int result;
		try
		{
			BattleActorSetup battleActorSetup = (BattleActorSetup)LuaObject.checkSelf(l);
			int behaviorId;
			LuaObject.checkType(l, 2, out behaviorId);
			battleActorSetup.BehaviorId = behaviorId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017217 RID: 94743 RVA: 0x0063F198 File Offset: 0x0063D398
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_GroupId(IntPtr l)
	{
		int result;
		try
		{
			BattleActorSetup battleActorSetup = (BattleActorSetup)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorSetup.GroupId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017218 RID: 94744 RVA: 0x0063F1EC File Offset: 0x0063D3EC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_GroupId(IntPtr l)
	{
		int result;
		try
		{
			BattleActorSetup battleActorSetup = (BattleActorSetup)LuaObject.checkSelf(l);
			int groupId;
			LuaObject.checkType(l, 2, out groupId);
			battleActorSetup.GroupId = groupId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017219 RID: 94745 RVA: 0x0063F244 File Offset: 0x0063D444
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ActionValue(IntPtr l)
	{
		int result;
		try
		{
			BattleActorSetup battleActorSetup = (BattleActorSetup)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorSetup.ActionValue);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601721A RID: 94746 RVA: 0x0063F298 File Offset: 0x0063D498
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ActionValue(IntPtr l)
	{
		int result;
		try
		{
			BattleActorSetup battleActorSetup = (BattleActorSetup)LuaObject.checkSelf(l);
			int actionValue;
			LuaObject.checkType(l, 2, out actionValue);
			battleActorSetup.ActionValue = actionValue;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601721B RID: 94747 RVA: 0x0063F2F0 File Offset: 0x0063D4F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_HeroCharImageSkinResourceInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleActorSetup battleActorSetup = (BattleActorSetup)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorSetup.HeroCharImageSkinResourceInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601721C RID: 94748 RVA: 0x0063F344 File Offset: 0x0063D544
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_HeroCharImageSkinResourceInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleActorSetup battleActorSetup = (BattleActorSetup)LuaObject.checkSelf(l);
			ConfigDataCharImageSkinResourceInfo heroCharImageSkinResourceInfo;
			LuaObject.checkType<ConfigDataCharImageSkinResourceInfo>(l, 2, out heroCharImageSkinResourceInfo);
			battleActorSetup.HeroCharImageSkinResourceInfo = heroCharImageSkinResourceInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601721D RID: 94749 RVA: 0x0063F39C File Offset: 0x0063D59C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_HeroModelSkinResourceInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleActorSetup battleActorSetup = (BattleActorSetup)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorSetup.HeroModelSkinResourceInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601721E RID: 94750 RVA: 0x0063F3F0 File Offset: 0x0063D5F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_HeroModelSkinResourceInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleActorSetup battleActorSetup = (BattleActorSetup)LuaObject.checkSelf(l);
			ConfigDataModelSkinResourceInfo heroModelSkinResourceInfo;
			LuaObject.checkType<ConfigDataModelSkinResourceInfo>(l, 2, out heroModelSkinResourceInfo);
			battleActorSetup.HeroModelSkinResourceInfo = heroModelSkinResourceInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601721F RID: 94751 RVA: 0x0063F448 File Offset: 0x0063D648
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SoldierModelSkinResourceInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleActorSetup battleActorSetup = (BattleActorSetup)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorSetup.SoldierModelSkinResourceInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017220 RID: 94752 RVA: 0x0063F49C File Offset: 0x0063D69C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_SoldierModelSkinResourceInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleActorSetup battleActorSetup = (BattleActorSetup)LuaObject.checkSelf(l);
			ConfigDataModelSkinResourceInfo soldierModelSkinResourceInfo;
			LuaObject.checkType<ConfigDataModelSkinResourceInfo>(l, 2, out soldierModelSkinResourceInfo);
			battleActorSetup.SoldierModelSkinResourceInfo = soldierModelSkinResourceInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017221 RID: 94753 RVA: 0x0063F4F4 File Offset: 0x0063D6F4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ExtraPassiveSkillInfos(IntPtr l)
	{
		int result;
		try
		{
			BattleActorSetup battleActorSetup = (BattleActorSetup)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorSetup.ExtraPassiveSkillInfos);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017222 RID: 94754 RVA: 0x0063F548 File Offset: 0x0063D748
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ExtraPassiveSkillInfos(IntPtr l)
	{
		int result;
		try
		{
			BattleActorSetup battleActorSetup = (BattleActorSetup)LuaObject.checkSelf(l);
			List<ConfigDataSkillInfo> extraPassiveSkillInfos;
			LuaObject.checkType<List<ConfigDataSkillInfo>>(l, 2, out extraPassiveSkillInfos);
			battleActorSetup.ExtraPassiveSkillInfos = extraPassiveSkillInfos;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017223 RID: 94755 RVA: 0x0063F5A0 File Offset: 0x0063D7A0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ExtraTalentSkillInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleActorSetup battleActorSetup = (BattleActorSetup)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorSetup.ExtraTalentSkillInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017224 RID: 94756 RVA: 0x0063F5F4 File Offset: 0x0063D7F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ExtraTalentSkillInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleActorSetup battleActorSetup = (BattleActorSetup)LuaObject.checkSelf(l);
			ConfigDataSkillInfo extraTalentSkillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 2, out extraTalentSkillInfo);
			battleActorSetup.ExtraTalentSkillInfo = extraTalentSkillInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017225 RID: 94757 RVA: 0x0063F64C File Offset: 0x0063D84C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_HeroHealthPoint(IntPtr l)
	{
		int result;
		try
		{
			BattleActorSetup battleActorSetup = (BattleActorSetup)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorSetup.HeroHealthPoint);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017226 RID: 94758 RVA: 0x0063F6A0 File Offset: 0x0063D8A0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_HeroHealthPoint(IntPtr l)
	{
		int result;
		try
		{
			BattleActorSetup battleActorSetup = (BattleActorSetup)LuaObject.checkSelf(l);
			int heroHealthPoint;
			LuaObject.checkType(l, 2, out heroHealthPoint);
			battleActorSetup.HeroHealthPoint = heroHealthPoint;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017227 RID: 94759 RVA: 0x0063F6F8 File Offset: 0x0063D8F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SoldierHealthPoint(IntPtr l)
	{
		int result;
		try
		{
			BattleActorSetup battleActorSetup = (BattleActorSetup)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorSetup.SoldierHealthPoint);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017228 RID: 94760 RVA: 0x0063F74C File Offset: 0x0063D94C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_SoldierHealthPoint(IntPtr l)
	{
		int result;
		try
		{
			BattleActorSetup battleActorSetup = (BattleActorSetup)LuaObject.checkSelf(l);
			int soldierHealthPoint;
			LuaObject.checkType(l, 2, out soldierHealthPoint);
			battleActorSetup.SoldierHealthPoint = soldierHealthPoint;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017229 RID: 94761 RVA: 0x0063F7A4 File Offset: 0x0063D9A4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ActorId(IntPtr l)
	{
		int result;
		try
		{
			BattleActorSetup battleActorSetup = (BattleActorSetup)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorSetup.ActorId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601722A RID: 94762 RVA: 0x0063F7F8 File Offset: 0x0063D9F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ActorId(IntPtr l)
	{
		int result;
		try
		{
			BattleActorSetup battleActorSetup = (BattleActorSetup)LuaObject.checkSelf(l);
			int actorId;
			LuaObject.checkType(l, 2, out actorId);
			battleActorSetup.ActorId = actorId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601722B RID: 94763 RVA: 0x0063F850 File Offset: 0x0063DA50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PlayerIndex(IntPtr l)
	{
		int result;
		try
		{
			BattleActorSetup battleActorSetup = (BattleActorSetup)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleActorSetup.PlayerIndex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601722C RID: 94764 RVA: 0x0063F8A4 File Offset: 0x0063DAA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_PlayerIndex(IntPtr l)
	{
		int result;
		try
		{
			BattleActorSetup battleActorSetup = (BattleActorSetup)LuaObject.checkSelf(l);
			int playerIndex;
			LuaObject.checkType(l, 2, out playerIndex);
			battleActorSetup.PlayerIndex = playerIndex;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601722D RID: 94765 RVA: 0x0063F8FC File Offset: 0x0063DAFC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Battle.BattleActorSetup");
		string name = "HeroInfo";
		if (Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActorSetup.get_HeroInfo);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActorSetup.set_HeroInfo);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache1, true);
		string name2 = "JobConnectionInfo";
		if (Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActorSetup.get_JobConnectionInfo);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActorSetup.set_JobConnectionInfo);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache3, true);
		string name3 = "SoldierInfo";
		if (Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActorSetup.get_SoldierInfo);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActorSetup.set_SoldierInfo);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache5, true);
		string name4 = "SkillInfos";
		if (Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActorSetup.get_SkillInfos);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActorSetup.set_SkillInfos);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache7, true);
		string name5 = "MasterJobInfos";
		if (Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActorSetup.get_MasterJobInfos);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache8;
		if (Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActorSetup.set_MasterJobInfos);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache9, true);
		string name6 = "Equipments";
		if (Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActorSetup.get_Equipments);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cacheA;
		if (Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActorSetup.set_Equipments);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cacheB, true);
		string name7 = "ResonanceSkillInfos";
		if (Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActorSetup.get_ResonanceSkillInfos);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cacheC;
		if (Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActorSetup.set_ResonanceSkillInfos);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cacheD, true);
		string name8 = "FetterSkillInfos";
		if (Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActorSetup.get_FetterSkillInfos);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cacheE;
		if (Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActorSetup.set_FetterSkillInfos);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cacheF, true);
		string name9 = "HeroLevel";
		if (Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActorSetup.get_HeroLevel);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache10;
		if (Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActorSetup.set_HeroLevel);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache11, true);
		string name10 = "HeroStar";
		if (Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActorSetup.get_HeroStar);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache12;
		if (Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActorSetup.set_HeroStar);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache13, true);
		string name11 = "JobLevel";
		if (Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActorSetup.get_JobLevel);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache14;
		if (Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActorSetup.set_JobLevel);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache15, true);
		string name12 = "SoldierCount";
		if (Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActorSetup.get_SoldierCount);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache16;
		if (Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActorSetup.set_SoldierCount);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache17, true);
		string name13 = "Position";
		if (Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActorSetup.get_Position);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache18;
		if (Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActorSetup.set_Position);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache19, true);
		string name14 = "Direction";
		if (Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActorSetup.get_Direction);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache1A;
		if (Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActorSetup.set_Direction);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache1B, true);
		string name15 = "IsNpc";
		if (Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActorSetup.get_IsNpc);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache1C;
		if (Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActorSetup.set_IsNpc);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache1D, true);
		string name16 = "BehaviorId";
		if (Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActorSetup.get_BehaviorId);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache1E;
		if (Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActorSetup.set_BehaviorId);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache1F, true);
		string name17 = "GroupId";
		if (Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActorSetup.get_GroupId);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache20;
		if (Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActorSetup.set_GroupId);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache21, true);
		string name18 = "ActionValue";
		if (Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActorSetup.get_ActionValue);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActorSetup.set_ActionValue);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache23, true);
		string name19 = "HeroCharImageSkinResourceInfo";
		if (Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActorSetup.get_HeroCharImageSkinResourceInfo);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache24;
		if (Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActorSetup.set_HeroCharImageSkinResourceInfo);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache25, true);
		string name20 = "HeroModelSkinResourceInfo";
		if (Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActorSetup.get_HeroModelSkinResourceInfo);
		}
		LuaCSFunction get20 = Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache26;
		if (Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActorSetup.set_HeroModelSkinResourceInfo);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache27, true);
		string name21 = "SoldierModelSkinResourceInfo";
		if (Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActorSetup.get_SoldierModelSkinResourceInfo);
		}
		LuaCSFunction get21 = Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache28;
		if (Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActorSetup.set_SoldierModelSkinResourceInfo);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache29, true);
		string name22 = "ExtraPassiveSkillInfos";
		if (Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActorSetup.get_ExtraPassiveSkillInfos);
		}
		LuaCSFunction get22 = Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache2A;
		if (Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActorSetup.set_ExtraPassiveSkillInfos);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache2B, true);
		string name23 = "ExtraTalentSkillInfo";
		if (Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActorSetup.get_ExtraTalentSkillInfo);
		}
		LuaCSFunction get23 = Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache2C;
		if (Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActorSetup.set_ExtraTalentSkillInfo);
		}
		LuaObject.addMember(l, name23, get23, Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache2D, true);
		string name24 = "HeroHealthPoint";
		if (Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActorSetup.get_HeroHealthPoint);
		}
		LuaCSFunction get24 = Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache2E;
		if (Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActorSetup.set_HeroHealthPoint);
		}
		LuaObject.addMember(l, name24, get24, Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache2F, true);
		string name25 = "SoldierHealthPoint";
		if (Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActorSetup.get_SoldierHealthPoint);
		}
		LuaCSFunction get25 = Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache30;
		if (Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActorSetup.set_SoldierHealthPoint);
		}
		LuaObject.addMember(l, name25, get25, Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache31, true);
		string name26 = "ActorId";
		if (Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActorSetup.get_ActorId);
		}
		LuaCSFunction get26 = Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache32;
		if (Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActorSetup.set_ActorId);
		}
		LuaObject.addMember(l, name26, get26, Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache33, true);
		string name27 = "PlayerIndex";
		if (Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActorSetup.get_PlayerIndex);
		}
		LuaCSFunction get27 = Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache34;
		if (Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActorSetup.set_PlayerIndex);
		}
		LuaObject.addMember(l, name27, get27, Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache35, true);
		if (Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_Battle_BattleActorSetup.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Battle_BattleActorSetup.<>f__mg$cache36, typeof(BattleActorSetup));
	}

	// Token: 0x0400D8B6 RID: 55478
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400D8B7 RID: 55479
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400D8B8 RID: 55480
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400D8B9 RID: 55481
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400D8BA RID: 55482
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400D8BB RID: 55483
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400D8BC RID: 55484
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400D8BD RID: 55485
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400D8BE RID: 55486
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400D8BF RID: 55487
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400D8C0 RID: 55488
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400D8C1 RID: 55489
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400D8C2 RID: 55490
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400D8C3 RID: 55491
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400D8C4 RID: 55492
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400D8C5 RID: 55493
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400D8C6 RID: 55494
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400D8C7 RID: 55495
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400D8C8 RID: 55496
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400D8C9 RID: 55497
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400D8CA RID: 55498
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400D8CB RID: 55499
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400D8CC RID: 55500
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400D8CD RID: 55501
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400D8CE RID: 55502
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400D8CF RID: 55503
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400D8D0 RID: 55504
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400D8D1 RID: 55505
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400D8D2 RID: 55506
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400D8D3 RID: 55507
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400D8D4 RID: 55508
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400D8D5 RID: 55509
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400D8D6 RID: 55510
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400D8D7 RID: 55511
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400D8D8 RID: 55512
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400D8D9 RID: 55513
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0400D8DA RID: 55514
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0400D8DB RID: 55515
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0400D8DC RID: 55516
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0400D8DD RID: 55517
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0400D8DE RID: 55518
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0400D8DF RID: 55519
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0400D8E0 RID: 55520
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0400D8E1 RID: 55521
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0400D8E2 RID: 55522
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0400D8E3 RID: 55523
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0400D8E4 RID: 55524
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x0400D8E5 RID: 55525
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x0400D8E6 RID: 55526
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x0400D8E7 RID: 55527
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x0400D8E8 RID: 55528
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x0400D8E9 RID: 55529
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x0400D8EA RID: 55530
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x0400D8EB RID: 55531
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x0400D8EC RID: 55532
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;
}
