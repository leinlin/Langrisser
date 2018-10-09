using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001318 RID: 4888
[Preserve]
public class Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorAttack : LuaObject
{
	// Token: 0x0601A453 RID: 107603 RVA: 0x007BFA3C File Offset: 0x007BDC3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle.LogDataActorAttack o = new ClientBattle.LogDataActorAttack();
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

	// Token: 0x0601A454 RID: 107604 RVA: 0x007BFA84 File Offset: 0x007BDC84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Type(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle.LogDataActorAttack logDataActorAttack = (ClientBattle.LogDataActorAttack)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, logDataActorAttack.Type);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A455 RID: 107605 RVA: 0x007BFAD8 File Offset: 0x007BDCD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Type(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle.LogDataActorAttack logDataActorAttack = (ClientBattle.LogDataActorAttack)LuaObject.checkSelf(l);
			string type;
			LuaObject.checkType(l, 2, out type);
			logDataActorAttack.Type = type;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A456 RID: 107606 RVA: 0x007BFB30 File Offset: 0x007BDD30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Turn(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle.LogDataActorAttack logDataActorAttack = (ClientBattle.LogDataActorAttack)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, logDataActorAttack.Turn);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A457 RID: 107607 RVA: 0x007BFB84 File Offset: 0x007BDD84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Turn(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle.LogDataActorAttack logDataActorAttack = (ClientBattle.LogDataActorAttack)LuaObject.checkSelf(l);
			int turn;
			LuaObject.checkType(l, 2, out turn);
			logDataActorAttack.Turn = turn;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A458 RID: 107608 RVA: 0x007BFBDC File Offset: 0x007BDDDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_HeroId(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle.LogDataActorAttack logDataActorAttack = (ClientBattle.LogDataActorAttack)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, logDataActorAttack.HeroId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A459 RID: 107609 RVA: 0x007BFC30 File Offset: 0x007BDE30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_HeroId(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle.LogDataActorAttack logDataActorAttack = (ClientBattle.LogDataActorAttack)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			logDataActorAttack.HeroId = heroId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A45A RID: 107610 RVA: 0x007BFC88 File Offset: 0x007BDE88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_TargetHeroId(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle.LogDataActorAttack logDataActorAttack = (ClientBattle.LogDataActorAttack)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, logDataActorAttack.TargetHeroId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A45B RID: 107611 RVA: 0x007BFCDC File Offset: 0x007BDEDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_TargetHeroId(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle.LogDataActorAttack logDataActorAttack = (ClientBattle.LogDataActorAttack)LuaObject.checkSelf(l);
			int targetHeroId;
			LuaObject.checkType(l, 2, out targetHeroId);
			logDataActorAttack.TargetHeroId = targetHeroId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A45C RID: 107612 RVA: 0x007BFD34 File Offset: 0x007BDF34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_TargetPos(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle.LogDataActorAttack logDataActorAttack = (ClientBattle.LogDataActorAttack)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, logDataActorAttack.TargetPos);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A45D RID: 107613 RVA: 0x007BFD8C File Offset: 0x007BDF8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_TargetPos(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle.LogDataActorAttack logDataActorAttack = (ClientBattle.LogDataActorAttack)LuaObject.checkSelf(l);
			GridPosition targetPos;
			LuaObject.checkValueType<GridPosition>(l, 2, out targetPos);
			logDataActorAttack.TargetPos = targetPos;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A45E RID: 107614 RVA: 0x007BFDE4 File Offset: 0x007BDFE4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Scene.ClientBattle.LogDataActorAttack");
		string name = "Type";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorAttack.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorAttack.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorAttack.get_Type);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorAttack.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorAttack.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorAttack.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorAttack.set_Type);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorAttack.<>f__mg$cache1, true);
		string name2 = "Turn";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorAttack.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorAttack.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorAttack.get_Turn);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorAttack.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorAttack.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorAttack.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorAttack.set_Turn);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorAttack.<>f__mg$cache3, true);
		string name3 = "HeroId";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorAttack.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorAttack.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorAttack.get_HeroId);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorAttack.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorAttack.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorAttack.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorAttack.set_HeroId);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorAttack.<>f__mg$cache5, true);
		string name4 = "TargetHeroId";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorAttack.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorAttack.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorAttack.get_TargetHeroId);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorAttack.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorAttack.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorAttack.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorAttack.set_TargetHeroId);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorAttack.<>f__mg$cache7, true);
		string name5 = "TargetPos";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorAttack.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorAttack.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorAttack.get_TargetPos);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorAttack.<>f__mg$cache8;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorAttack.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorAttack.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorAttack.set_TargetPos);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorAttack.<>f__mg$cache9, true);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorAttack.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorAttack.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorAttack.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorAttack.<>f__mg$cacheA, typeof(ClientBattle.LogDataActorAttack));
	}

	// Token: 0x04010805 RID: 67589
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04010806 RID: 67590
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04010807 RID: 67591
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04010808 RID: 67592
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04010809 RID: 67593
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0401080A RID: 67594
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0401080B RID: 67595
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0401080C RID: 67596
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0401080D RID: 67597
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0401080E RID: 67598
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0401080F RID: 67599
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;
}
