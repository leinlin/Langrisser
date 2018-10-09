using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001325 RID: 4901
[Preserve]
public class Lua_BlackJack_ProjectL_Scene_ClientBattleConst : LuaObject
{
	// Token: 0x0601A545 RID: 107845 RVA: 0x007C77D4 File Offset: 0x007C59D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ClientBattleConst o = new ClientBattleConst();
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

	// Token: 0x0601A546 RID: 107846 RVA: 0x007C781C File Offset: 0x007C5A1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_TickRate(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 30);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A547 RID: 107847 RVA: 0x007C7860 File Offset: 0x007C5A60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_TickTime(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 0.0333333351f);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A548 RID: 107848 RVA: 0x007C78A8 File Offset: 0x007C5AA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_GridWidth(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 2f);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A549 RID: 107849 RVA: 0x007C78F0 File Offset: 0x007C5AF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_GridHeight(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 2f);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A54A RID: 107850 RVA: 0x007C7938 File Offset: 0x007C5B38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_FootHeightScale(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 0.25f);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A54B RID: 107851 RVA: 0x007C7980 File Offset: 0x007C5B80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_StartCombatEffectTime(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 500);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A54C RID: 107852 RVA: 0x007C79C8 File Offset: 0x007C5BC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_StopCombatEffectTime(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 500);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A54D RID: 107853 RVA: 0x007C7A10 File Offset: 0x007C5C10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SkillFadeTime(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 300);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A54E RID: 107854 RVA: 0x007C7A58 File Offset: 0x007C5C58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SkillFadeZOffset(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 30f);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A54F RID: 107855 RVA: 0x007C7AA0 File Offset: 0x007C5CA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_GuardZOffset(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -1f);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A550 RID: 107856 RVA: 0x007C7AE8 File Offset: 0x007C5CE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ActorFxZOffset(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -20f);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A551 RID: 107857 RVA: 0x007C7B30 File Offset: 0x007C5D30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_TreasureIdleZOffset(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 1f);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A552 RID: 107858 RVA: 0x007C7B78 File Offset: 0x007C5D78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_TreasureOpenZOffset(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, -1f);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A553 RID: 107859 RVA: 0x007C7BC0 File Offset: 0x007C5DC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ActorActStartCombatTime(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 700);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A554 RID: 107860 RVA: 0x007C7C08 File Offset: 0x007C5E08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ActorActStopCombatTime(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 300);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A555 RID: 107861 RVA: 0x007C7C50 File Offset: 0x007C5E50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ActorActImmuneTime(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 500);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A556 RID: 107862 RVA: 0x007C7C98 File Offset: 0x007C5E98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ActorActStartGuardDelay(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 800);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A557 RID: 107863 RVA: 0x007C7CE0 File Offset: 0x007C5EE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ActorActStopGuardDelay(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 300);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A558 RID: 107864 RVA: 0x007C7D28 File Offset: 0x007C5F28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ActorActPassiveSkillTime(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 1200);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A559 RID: 107865 RVA: 0x007C7D70 File Offset: 0x007C5F70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ActorActPassiveSkillHitTime(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 400);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A55A RID: 107866 RVA: 0x007C7DB8 File Offset: 0x007C5FB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ActorActAppearTime(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 500);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A55B RID: 107867 RVA: 0x007C7E00 File Offset: 0x007C6000
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ActorActDisappearTime(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 500);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A55C RID: 107868 RVA: 0x007C7E48 File Offset: 0x007C6048
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ActorActTelelportDisappearDelayTime(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 500);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A55D RID: 107869 RVA: 0x007C7E90 File Offset: 0x007C6090
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ActorActTelelportAppearDelayTime(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 500);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A55E RID: 107870 RVA: 0x007C7ED8 File Offset: 0x007C60D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ActorActSummonDelayTime(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 500);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A55F RID: 107871 RVA: 0x007C7F20 File Offset: 0x007C6120
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ActorActChangeTeamTime(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 500);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A560 RID: 107872 RVA: 0x007C7F68 File Offset: 0x007C6168
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ActorActPunchMoveTime(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 400);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A561 RID: 107873 RVA: 0x007C7FB0 File Offset: 0x007C61B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ActorActExchangeMoveTime(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 300);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A562 RID: 107874 RVA: 0x007C7FF8 File Offset: 0x007C61F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ActorActReplaceTime(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 500);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A563 RID: 107875 RVA: 0x007C8040 File Offset: 0x007C6240
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ActorActDieTime(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 300);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A564 RID: 107876 RVA: 0x007C8088 File Offset: 0x007C6288
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ActorActDieHideTime(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 200);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A565 RID: 107877 RVA: 0x007C80D0 File Offset: 0x007C62D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_TargetIconTime(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 500);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A566 RID: 107878 RVA: 0x007C8118 File Offset: 0x007C6318
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_HpBarBuffCountMax(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 3);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A567 RID: 107879 RVA: 0x007C815C File Offset: 0x007C635C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BattleResultHeroCountMax(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 5);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A568 RID: 107880 RVA: 0x007C81A0 File Offset: 0x007C63A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_FastBattleTimeScale(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 1.3f);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A569 RID: 107881 RVA: 0x007C81E8 File Offset: 0x007C63E8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Scene.ClientBattleConst");
		string name = "TickRate";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleConst.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleConst.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleConst.get_TickRate);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_ProjectL_Scene_ClientBattleConst.<>f__mg$cache0, null, false);
		string name2 = "TickTime";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleConst.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleConst.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleConst.get_TickTime);
		}
		LuaObject.addMember(l, name2, Lua_BlackJack_ProjectL_Scene_ClientBattleConst.<>f__mg$cache1, null, false);
		string name3 = "GridWidth";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleConst.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleConst.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleConst.get_GridWidth);
		}
		LuaObject.addMember(l, name3, Lua_BlackJack_ProjectL_Scene_ClientBattleConst.<>f__mg$cache2, null, false);
		string name4 = "GridHeight";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleConst.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleConst.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleConst.get_GridHeight);
		}
		LuaObject.addMember(l, name4, Lua_BlackJack_ProjectL_Scene_ClientBattleConst.<>f__mg$cache3, null, false);
		string name5 = "FootHeightScale";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleConst.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleConst.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleConst.get_FootHeightScale);
		}
		LuaObject.addMember(l, name5, Lua_BlackJack_ProjectL_Scene_ClientBattleConst.<>f__mg$cache4, null, false);
		string name6 = "StartCombatEffectTime";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleConst.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleConst.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleConst.get_StartCombatEffectTime);
		}
		LuaObject.addMember(l, name6, Lua_BlackJack_ProjectL_Scene_ClientBattleConst.<>f__mg$cache5, null, false);
		string name7 = "StopCombatEffectTime";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleConst.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleConst.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleConst.get_StopCombatEffectTime);
		}
		LuaObject.addMember(l, name7, Lua_BlackJack_ProjectL_Scene_ClientBattleConst.<>f__mg$cache6, null, false);
		string name8 = "SkillFadeTime";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleConst.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleConst.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleConst.get_SkillFadeTime);
		}
		LuaObject.addMember(l, name8, Lua_BlackJack_ProjectL_Scene_ClientBattleConst.<>f__mg$cache7, null, false);
		string name9 = "SkillFadeZOffset";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleConst.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleConst.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleConst.get_SkillFadeZOffset);
		}
		LuaObject.addMember(l, name9, Lua_BlackJack_ProjectL_Scene_ClientBattleConst.<>f__mg$cache8, null, false);
		string name10 = "GuardZOffset";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleConst.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleConst.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleConst.get_GuardZOffset);
		}
		LuaObject.addMember(l, name10, Lua_BlackJack_ProjectL_Scene_ClientBattleConst.<>f__mg$cache9, null, false);
		string name11 = "ActorFxZOffset";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleConst.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleConst.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleConst.get_ActorFxZOffset);
		}
		LuaObject.addMember(l, name11, Lua_BlackJack_ProjectL_Scene_ClientBattleConst.<>f__mg$cacheA, null, false);
		string name12 = "TreasureIdleZOffset";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleConst.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleConst.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleConst.get_TreasureIdleZOffset);
		}
		LuaObject.addMember(l, name12, Lua_BlackJack_ProjectL_Scene_ClientBattleConst.<>f__mg$cacheB, null, false);
		string name13 = "TreasureOpenZOffset";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleConst.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleConst.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleConst.get_TreasureOpenZOffset);
		}
		LuaObject.addMember(l, name13, Lua_BlackJack_ProjectL_Scene_ClientBattleConst.<>f__mg$cacheC, null, false);
		string name14 = "ActorActStartCombatTime";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleConst.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleConst.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleConst.get_ActorActStartCombatTime);
		}
		LuaObject.addMember(l, name14, Lua_BlackJack_ProjectL_Scene_ClientBattleConst.<>f__mg$cacheD, null, false);
		string name15 = "ActorActStopCombatTime";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleConst.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleConst.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleConst.get_ActorActStopCombatTime);
		}
		LuaObject.addMember(l, name15, Lua_BlackJack_ProjectL_Scene_ClientBattleConst.<>f__mg$cacheE, null, false);
		string name16 = "ActorActImmuneTime";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleConst.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleConst.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleConst.get_ActorActImmuneTime);
		}
		LuaObject.addMember(l, name16, Lua_BlackJack_ProjectL_Scene_ClientBattleConst.<>f__mg$cacheF, null, false);
		string name17 = "ActorActStartGuardDelay";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleConst.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleConst.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleConst.get_ActorActStartGuardDelay);
		}
		LuaObject.addMember(l, name17, Lua_BlackJack_ProjectL_Scene_ClientBattleConst.<>f__mg$cache10, null, false);
		string name18 = "ActorActStopGuardDelay";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleConst.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleConst.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleConst.get_ActorActStopGuardDelay);
		}
		LuaObject.addMember(l, name18, Lua_BlackJack_ProjectL_Scene_ClientBattleConst.<>f__mg$cache11, null, false);
		string name19 = "ActorActPassiveSkillTime";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleConst.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleConst.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleConst.get_ActorActPassiveSkillTime);
		}
		LuaObject.addMember(l, name19, Lua_BlackJack_ProjectL_Scene_ClientBattleConst.<>f__mg$cache12, null, false);
		string name20 = "ActorActPassiveSkillHitTime";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleConst.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleConst.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleConst.get_ActorActPassiveSkillHitTime);
		}
		LuaObject.addMember(l, name20, Lua_BlackJack_ProjectL_Scene_ClientBattleConst.<>f__mg$cache13, null, false);
		string name21 = "ActorActAppearTime";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleConst.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleConst.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleConst.get_ActorActAppearTime);
		}
		LuaObject.addMember(l, name21, Lua_BlackJack_ProjectL_Scene_ClientBattleConst.<>f__mg$cache14, null, false);
		string name22 = "ActorActDisappearTime";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleConst.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleConst.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleConst.get_ActorActDisappearTime);
		}
		LuaObject.addMember(l, name22, Lua_BlackJack_ProjectL_Scene_ClientBattleConst.<>f__mg$cache15, null, false);
		string name23 = "ActorActTelelportDisappearDelayTime";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleConst.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleConst.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleConst.get_ActorActTelelportDisappearDelayTime);
		}
		LuaObject.addMember(l, name23, Lua_BlackJack_ProjectL_Scene_ClientBattleConst.<>f__mg$cache16, null, false);
		string name24 = "ActorActTelelportAppearDelayTime";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleConst.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleConst.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleConst.get_ActorActTelelportAppearDelayTime);
		}
		LuaObject.addMember(l, name24, Lua_BlackJack_ProjectL_Scene_ClientBattleConst.<>f__mg$cache17, null, false);
		string name25 = "ActorActSummonDelayTime";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleConst.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleConst.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleConst.get_ActorActSummonDelayTime);
		}
		LuaObject.addMember(l, name25, Lua_BlackJack_ProjectL_Scene_ClientBattleConst.<>f__mg$cache18, null, false);
		string name26 = "ActorActChangeTeamTime";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleConst.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleConst.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleConst.get_ActorActChangeTeamTime);
		}
		LuaObject.addMember(l, name26, Lua_BlackJack_ProjectL_Scene_ClientBattleConst.<>f__mg$cache19, null, false);
		string name27 = "ActorActPunchMoveTime";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleConst.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleConst.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleConst.get_ActorActPunchMoveTime);
		}
		LuaObject.addMember(l, name27, Lua_BlackJack_ProjectL_Scene_ClientBattleConst.<>f__mg$cache1A, null, false);
		string name28 = "ActorActExchangeMoveTime";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleConst.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleConst.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleConst.get_ActorActExchangeMoveTime);
		}
		LuaObject.addMember(l, name28, Lua_BlackJack_ProjectL_Scene_ClientBattleConst.<>f__mg$cache1B, null, false);
		string name29 = "ActorActReplaceTime";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleConst.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleConst.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleConst.get_ActorActReplaceTime);
		}
		LuaObject.addMember(l, name29, Lua_BlackJack_ProjectL_Scene_ClientBattleConst.<>f__mg$cache1C, null, false);
		string name30 = "ActorActDieTime";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleConst.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleConst.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleConst.get_ActorActDieTime);
		}
		LuaObject.addMember(l, name30, Lua_BlackJack_ProjectL_Scene_ClientBattleConst.<>f__mg$cache1D, null, false);
		string name31 = "ActorActDieHideTime";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleConst.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleConst.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleConst.get_ActorActDieHideTime);
		}
		LuaObject.addMember(l, name31, Lua_BlackJack_ProjectL_Scene_ClientBattleConst.<>f__mg$cache1E, null, false);
		string name32 = "TargetIconTime";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleConst.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleConst.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleConst.get_TargetIconTime);
		}
		LuaObject.addMember(l, name32, Lua_BlackJack_ProjectL_Scene_ClientBattleConst.<>f__mg$cache1F, null, false);
		string name33 = "HpBarBuffCountMax";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleConst.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleConst.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleConst.get_HpBarBuffCountMax);
		}
		LuaObject.addMember(l, name33, Lua_BlackJack_ProjectL_Scene_ClientBattleConst.<>f__mg$cache20, null, false);
		string name34 = "BattleResultHeroCountMax";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleConst.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleConst.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleConst.get_BattleResultHeroCountMax);
		}
		LuaObject.addMember(l, name34, Lua_BlackJack_ProjectL_Scene_ClientBattleConst.<>f__mg$cache21, null, false);
		string name35 = "FastBattleTimeScale";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleConst.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleConst.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleConst.get_FastBattleTimeScale);
		}
		LuaObject.addMember(l, name35, Lua_BlackJack_ProjectL_Scene_ClientBattleConst.<>f__mg$cache22, null, false);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattleConst.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattleConst.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattleConst.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Scene_ClientBattleConst.<>f__mg$cache23, typeof(ClientBattleConst));
	}

	// Token: 0x040108DD RID: 67805
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040108DE RID: 67806
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040108DF RID: 67807
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040108E0 RID: 67808
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040108E1 RID: 67809
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040108E2 RID: 67810
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040108E3 RID: 67811
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040108E4 RID: 67812
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040108E5 RID: 67813
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040108E6 RID: 67814
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040108E7 RID: 67815
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040108E8 RID: 67816
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040108E9 RID: 67817
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040108EA RID: 67818
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040108EB RID: 67819
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040108EC RID: 67820
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040108ED RID: 67821
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040108EE RID: 67822
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040108EF RID: 67823
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x040108F0 RID: 67824
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x040108F1 RID: 67825
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x040108F2 RID: 67826
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x040108F3 RID: 67827
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x040108F4 RID: 67828
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x040108F5 RID: 67829
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x040108F6 RID: 67830
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x040108F7 RID: 67831
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x040108F8 RID: 67832
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x040108F9 RID: 67833
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x040108FA RID: 67834
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x040108FB RID: 67835
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x040108FC RID: 67836
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x040108FD RID: 67837
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x040108FE RID: 67838
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x040108FF RID: 67839
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04010900 RID: 67840
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;
}
