using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200131B RID: 4891
[Preserve]
public class Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorSkill : LuaObject
{
	// Token: 0x0601A478 RID: 107640 RVA: 0x007C0948 File Offset: 0x007BEB48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle.LogDataActorSkill o = new ClientBattle.LogDataActorSkill();
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

	// Token: 0x0601A479 RID: 107641 RVA: 0x007C0990 File Offset: 0x007BEB90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Type(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle.LogDataActorSkill logDataActorSkill = (ClientBattle.LogDataActorSkill)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, logDataActorSkill.Type);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A47A RID: 107642 RVA: 0x007C09E4 File Offset: 0x007BEBE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Type(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle.LogDataActorSkill logDataActorSkill = (ClientBattle.LogDataActorSkill)LuaObject.checkSelf(l);
			string type;
			LuaObject.checkType(l, 2, out type);
			logDataActorSkill.Type = type;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A47B RID: 107643 RVA: 0x007C0A3C File Offset: 0x007BEC3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Turn(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle.LogDataActorSkill logDataActorSkill = (ClientBattle.LogDataActorSkill)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, logDataActorSkill.Turn);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A47C RID: 107644 RVA: 0x007C0A90 File Offset: 0x007BEC90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Turn(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle.LogDataActorSkill logDataActorSkill = (ClientBattle.LogDataActorSkill)LuaObject.checkSelf(l);
			int turn;
			LuaObject.checkType(l, 2, out turn);
			logDataActorSkill.Turn = turn;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A47D RID: 107645 RVA: 0x007C0AE8 File Offset: 0x007BECE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_HeroId(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle.LogDataActorSkill logDataActorSkill = (ClientBattle.LogDataActorSkill)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, logDataActorSkill.HeroId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A47E RID: 107646 RVA: 0x007C0B3C File Offset: 0x007BED3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_HeroId(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle.LogDataActorSkill logDataActorSkill = (ClientBattle.LogDataActorSkill)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			logDataActorSkill.HeroId = heroId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A47F RID: 107647 RVA: 0x007C0B94 File Offset: 0x007BED94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_TargetHeroId(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle.LogDataActorSkill logDataActorSkill = (ClientBattle.LogDataActorSkill)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, logDataActorSkill.TargetHeroId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A480 RID: 107648 RVA: 0x007C0BE8 File Offset: 0x007BEDE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_TargetHeroId(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle.LogDataActorSkill logDataActorSkill = (ClientBattle.LogDataActorSkill)LuaObject.checkSelf(l);
			int targetHeroId;
			LuaObject.checkType(l, 2, out targetHeroId);
			logDataActorSkill.TargetHeroId = targetHeroId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A481 RID: 107649 RVA: 0x007C0C40 File Offset: 0x007BEE40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_TargetPos(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle.LogDataActorSkill logDataActorSkill = (ClientBattle.LogDataActorSkill)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, logDataActorSkill.TargetPos);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A482 RID: 107650 RVA: 0x007C0C98 File Offset: 0x007BEE98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_TargetPos(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle.LogDataActorSkill logDataActorSkill = (ClientBattle.LogDataActorSkill)LuaObject.checkSelf(l);
			GridPosition targetPos;
			LuaObject.checkValueType<GridPosition>(l, 2, out targetPos);
			logDataActorSkill.TargetPos = targetPos;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A483 RID: 107651 RVA: 0x007C0CF0 File Offset: 0x007BEEF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SkillId(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle.LogDataActorSkill logDataActorSkill = (ClientBattle.LogDataActorSkill)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, logDataActorSkill.SkillId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A484 RID: 107652 RVA: 0x007C0D44 File Offset: 0x007BEF44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_SkillId(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle.LogDataActorSkill logDataActorSkill = (ClientBattle.LogDataActorSkill)LuaObject.checkSelf(l);
			int skillId;
			LuaObject.checkType(l, 2, out skillId);
			logDataActorSkill.SkillId = skillId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A485 RID: 107653 RVA: 0x007C0D9C File Offset: 0x007BEF9C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Scene.ClientBattle.LogDataActorSkill");
		string name = "Type";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorSkill.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorSkill.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorSkill.get_Type);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorSkill.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorSkill.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorSkill.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorSkill.set_Type);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorSkill.<>f__mg$cache1, true);
		string name2 = "Turn";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorSkill.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorSkill.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorSkill.get_Turn);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorSkill.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorSkill.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorSkill.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorSkill.set_Turn);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorSkill.<>f__mg$cache3, true);
		string name3 = "HeroId";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorSkill.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorSkill.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorSkill.get_HeroId);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorSkill.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorSkill.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorSkill.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorSkill.set_HeroId);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorSkill.<>f__mg$cache5, true);
		string name4 = "TargetHeroId";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorSkill.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorSkill.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorSkill.get_TargetHeroId);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorSkill.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorSkill.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorSkill.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorSkill.set_TargetHeroId);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorSkill.<>f__mg$cache7, true);
		string name5 = "TargetPos";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorSkill.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorSkill.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorSkill.get_TargetPos);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorSkill.<>f__mg$cache8;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorSkill.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorSkill.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorSkill.set_TargetPos);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorSkill.<>f__mg$cache9, true);
		string name6 = "SkillId";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorSkill.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorSkill.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorSkill.get_SkillId);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorSkill.<>f__mg$cacheA;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorSkill.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorSkill.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorSkill.set_SkillId);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorSkill.<>f__mg$cacheB, true);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorSkill.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorSkill.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorSkill.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorSkill.<>f__mg$cacheC, typeof(ClientBattle.LogDataActorSkill));
	}

	// Token: 0x04010824 RID: 67620
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04010825 RID: 67621
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04010826 RID: 67622
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04010827 RID: 67623
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04010828 RID: 67624
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04010829 RID: 67625
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0401082A RID: 67626
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0401082B RID: 67627
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0401082C RID: 67628
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0401082D RID: 67629
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0401082E RID: 67630
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0401082F RID: 67631
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04010830 RID: 67632
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;
}
