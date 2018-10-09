using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200131C RID: 4892
[Preserve]
public class Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorStandby : LuaObject
{
	// Token: 0x0601A487 RID: 107655 RVA: 0x007C0F90 File Offset: 0x007BF190
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle.LogDataActorStandby o = new ClientBattle.LogDataActorStandby();
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

	// Token: 0x0601A488 RID: 107656 RVA: 0x007C0FD8 File Offset: 0x007BF1D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Type(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle.LogDataActorStandby logDataActorStandby = (ClientBattle.LogDataActorStandby)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, logDataActorStandby.Type);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A489 RID: 107657 RVA: 0x007C102C File Offset: 0x007BF22C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Type(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle.LogDataActorStandby logDataActorStandby = (ClientBattle.LogDataActorStandby)LuaObject.checkSelf(l);
			string type;
			LuaObject.checkType(l, 2, out type);
			logDataActorStandby.Type = type;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A48A RID: 107658 RVA: 0x007C1084 File Offset: 0x007BF284
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Turn(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle.LogDataActorStandby logDataActorStandby = (ClientBattle.LogDataActorStandby)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, logDataActorStandby.Turn);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A48B RID: 107659 RVA: 0x007C10D8 File Offset: 0x007BF2D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Turn(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle.LogDataActorStandby logDataActorStandby = (ClientBattle.LogDataActorStandby)LuaObject.checkSelf(l);
			int turn;
			LuaObject.checkType(l, 2, out turn);
			logDataActorStandby.Turn = turn;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A48C RID: 107660 RVA: 0x007C1130 File Offset: 0x007BF330
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_HeroId(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle.LogDataActorStandby logDataActorStandby = (ClientBattle.LogDataActorStandby)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, logDataActorStandby.HeroId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A48D RID: 107661 RVA: 0x007C1184 File Offset: 0x007BF384
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_HeroId(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle.LogDataActorStandby logDataActorStandby = (ClientBattle.LogDataActorStandby)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			logDataActorStandby.HeroId = heroId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A48E RID: 107662 RVA: 0x007C11DC File Offset: 0x007BF3DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Pos(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle.LogDataActorStandby logDataActorStandby = (ClientBattle.LogDataActorStandby)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, logDataActorStandby.Pos);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A48F RID: 107663 RVA: 0x007C1234 File Offset: 0x007BF434
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Pos(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle.LogDataActorStandby logDataActorStandby = (ClientBattle.LogDataActorStandby)LuaObject.checkSelf(l);
			GridPosition pos;
			LuaObject.checkValueType<GridPosition>(l, 2, out pos);
			logDataActorStandby.Pos = pos;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A490 RID: 107664 RVA: 0x007C128C File Offset: 0x007BF48C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Scene.ClientBattle.LogDataActorStandby");
		string name = "Type";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorStandby.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorStandby.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorStandby.get_Type);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorStandby.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorStandby.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorStandby.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorStandby.set_Type);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorStandby.<>f__mg$cache1, true);
		string name2 = "Turn";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorStandby.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorStandby.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorStandby.get_Turn);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorStandby.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorStandby.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorStandby.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorStandby.set_Turn);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorStandby.<>f__mg$cache3, true);
		string name3 = "HeroId";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorStandby.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorStandby.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorStandby.get_HeroId);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorStandby.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorStandby.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorStandby.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorStandby.set_HeroId);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorStandby.<>f__mg$cache5, true);
		string name4 = "Pos";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorStandby.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorStandby.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorStandby.get_Pos);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorStandby.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorStandby.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorStandby.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorStandby.set_Pos);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorStandby.<>f__mg$cache7, true);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorStandby.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorStandby.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorStandby.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataActorStandby.<>f__mg$cache8, typeof(ClientBattle.LogDataActorStandby));
	}

	// Token: 0x04010831 RID: 67633
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04010832 RID: 67634
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04010833 RID: 67635
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04010834 RID: 67636
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04010835 RID: 67637
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04010836 RID: 67638
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04010837 RID: 67639
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04010838 RID: 67640
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04010839 RID: 67641
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;
}
