using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001319 RID: 4889
[Preserve]
public class Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorDie : LuaObject
{
	// Token: 0x0601A460 RID: 107616 RVA: 0x007BFF90 File Offset: 0x007BE190
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle.LogDataActorDie o = new ClientBattle.LogDataActorDie();
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

	// Token: 0x0601A461 RID: 107617 RVA: 0x007BFFD8 File Offset: 0x007BE1D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Type(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle.LogDataActorDie logDataActorDie = (ClientBattle.LogDataActorDie)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, logDataActorDie.Type);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A462 RID: 107618 RVA: 0x007C002C File Offset: 0x007BE22C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Type(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle.LogDataActorDie logDataActorDie = (ClientBattle.LogDataActorDie)LuaObject.checkSelf(l);
			string type;
			LuaObject.checkType(l, 2, out type);
			logDataActorDie.Type = type;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A463 RID: 107619 RVA: 0x007C0084 File Offset: 0x007BE284
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Turn(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle.LogDataActorDie logDataActorDie = (ClientBattle.LogDataActorDie)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, logDataActorDie.Turn);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A464 RID: 107620 RVA: 0x007C00D8 File Offset: 0x007BE2D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Turn(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle.LogDataActorDie logDataActorDie = (ClientBattle.LogDataActorDie)LuaObject.checkSelf(l);
			int turn;
			LuaObject.checkType(l, 2, out turn);
			logDataActorDie.Turn = turn;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A465 RID: 107621 RVA: 0x007C0130 File Offset: 0x007BE330
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_HeroId(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle.LogDataActorDie logDataActorDie = (ClientBattle.LogDataActorDie)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, logDataActorDie.HeroId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A466 RID: 107622 RVA: 0x007C0184 File Offset: 0x007BE384
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_HeroId(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle.LogDataActorDie logDataActorDie = (ClientBattle.LogDataActorDie)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			logDataActorDie.HeroId = heroId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A467 RID: 107623 RVA: 0x007C01DC File Offset: 0x007BE3DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_KillerHeroId(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle.LogDataActorDie logDataActorDie = (ClientBattle.LogDataActorDie)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, logDataActorDie.KillerHeroId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A468 RID: 107624 RVA: 0x007C0230 File Offset: 0x007BE430
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_KillerHeroId(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle.LogDataActorDie logDataActorDie = (ClientBattle.LogDataActorDie)LuaObject.checkSelf(l);
			int killerHeroId;
			LuaObject.checkType(l, 2, out killerHeroId);
			logDataActorDie.KillerHeroId = killerHeroId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A469 RID: 107625 RVA: 0x007C0288 File Offset: 0x007BE488
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Scene.ClientBattle.LogDataActorDie");
		string name = "Type";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorDie.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorDie.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorDie.get_Type);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorDie.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorDie.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorDie.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorDie.set_Type);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorDie.<>f__mg$cache1, true);
		string name2 = "Turn";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorDie.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorDie.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorDie.get_Turn);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorDie.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorDie.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorDie.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorDie.set_Turn);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorDie.<>f__mg$cache3, true);
		string name3 = "HeroId";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorDie.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorDie.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorDie.get_HeroId);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorDie.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorDie.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorDie.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorDie.set_HeroId);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorDie.<>f__mg$cache5, true);
		string name4 = "KillerHeroId";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorDie.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorDie.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorDie.get_KillerHeroId);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorDie.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorDie.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorDie.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorDie.set_KillerHeroId);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorDie.<>f__mg$cache7, true);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorDie.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorDie.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorDie.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorDie.<>f__mg$cache8, typeof(ClientBattle.LogDataActorDie));
	}

	// Token: 0x04010810 RID: 67600
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04010811 RID: 67601
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04010812 RID: 67602
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04010813 RID: 67603
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04010814 RID: 67604
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04010815 RID: 67605
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04010816 RID: 67606
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04010817 RID: 67607
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04010818 RID: 67608
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;
}
