using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001320 RID: 4896
[Preserve]
public class Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataBattleTeam : LuaObject
{
	// Token: 0x0601A4A7 RID: 107687 RVA: 0x007C1B68 File Offset: 0x007BFD68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle.LogDataBattleTeam o = new ClientBattle.LogDataBattleTeam();
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

	// Token: 0x0601A4A8 RID: 107688 RVA: 0x007C1BB0 File Offset: 0x007BFDB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Type(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle.LogDataBattleTeam logDataBattleTeam = (ClientBattle.LogDataBattleTeam)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, logDataBattleTeam.Type);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A4A9 RID: 107689 RVA: 0x007C1C04 File Offset: 0x007BFE04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Type(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle.LogDataBattleTeam logDataBattleTeam = (ClientBattle.LogDataBattleTeam)LuaObject.checkSelf(l);
			string type;
			LuaObject.checkType(l, 2, out type);
			logDataBattleTeam.Type = type;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A4AA RID: 107690 RVA: 0x007C1C5C File Offset: 0x007BFE5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_HeroId(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle.LogDataBattleTeam logDataBattleTeam = (ClientBattle.LogDataBattleTeam)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, logDataBattleTeam.HeroId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A4AB RID: 107691 RVA: 0x007C1CB0 File Offset: 0x007BFEB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_HeroId(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle.LogDataBattleTeam logDataBattleTeam = (ClientBattle.LogDataBattleTeam)LuaObject.checkSelf(l);
			List<int> heroId;
			LuaObject.checkType<List<int>>(l, 2, out heroId);
			logDataBattleTeam.HeroId = heroId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A4AC RID: 107692 RVA: 0x007C1D08 File Offset: 0x007BFF08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Pos(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle.LogDataBattleTeam logDataBattleTeam = (ClientBattle.LogDataBattleTeam)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, logDataBattleTeam.Pos);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A4AD RID: 107693 RVA: 0x007C1D5C File Offset: 0x007BFF5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Pos(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle.LogDataBattleTeam logDataBattleTeam = (ClientBattle.LogDataBattleTeam)LuaObject.checkSelf(l);
			List<GridPosition> pos;
			LuaObject.checkType<List<GridPosition>>(l, 2, out pos);
			logDataBattleTeam.Pos = pos;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A4AE RID: 107694 RVA: 0x007C1DB4 File Offset: 0x007BFFB4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Scene.ClientBattle.LogDataBattleTeam");
		string name = "Type";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataBattleTeam.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataBattleTeam.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataBattleTeam.get_Type);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataBattleTeam.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataBattleTeam.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataBattleTeam.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataBattleTeam.set_Type);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataBattleTeam.<>f__mg$cache1, true);
		string name2 = "HeroId";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataBattleTeam.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataBattleTeam.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataBattleTeam.get_HeroId);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataBattleTeam.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataBattleTeam.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataBattleTeam.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataBattleTeam.set_HeroId);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataBattleTeam.<>f__mg$cache3, true);
		string name3 = "Pos";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataBattleTeam.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataBattleTeam.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataBattleTeam.get_Pos);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataBattleTeam.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataBattleTeam.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataBattleTeam.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataBattleTeam.set_Pos);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataBattleTeam.<>f__mg$cache5, true);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataBattleTeam.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataBattleTeam.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataBattleTeam.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataBattleTeam.<>f__mg$cache6, typeof(ClientBattle.LogDataBattleTeam));
	}

	// Token: 0x04010849 RID: 67657
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401084A RID: 67658
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401084B RID: 67659
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0401084C RID: 67660
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0401084D RID: 67661
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0401084E RID: 67662
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0401084F RID: 67663
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;
}
