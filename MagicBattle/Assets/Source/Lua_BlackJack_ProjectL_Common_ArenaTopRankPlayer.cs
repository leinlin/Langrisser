using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020011C2 RID: 4546
[Preserve]
public class Lua_BlackJack_ProjectL_Common_ArenaTopRankPlayer : LuaObject
{
	// Token: 0x060178CB RID: 96459 RVA: 0x006722F0 File Offset: 0x006704F0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ArenaTopRankPlayer o = new ArenaTopRankPlayer();
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

	// Token: 0x060178CC RID: 96460 RVA: 0x00672338 File Offset: 0x00670538
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ArenaTopRankPlayerToPBArenaTopRankPlayer_s(IntPtr l)
	{
		int result;
		try
		{
			ArenaTopRankPlayer topRankPlayer;
			LuaObject.checkType<ArenaTopRankPlayer>(l, 1, out topRankPlayer);
			ProArenaTopRankPlayer o = ArenaTopRankPlayer.ArenaTopRankPlayerToPBArenaTopRankPlayer(topRankPlayer);
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

	// Token: 0x060178CD RID: 96461 RVA: 0x0067238C File Offset: 0x0067058C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PBArenaTopRankPlayerToArenaTopRankPlayer_s(IntPtr l)
	{
		int result;
		try
		{
			ProArenaTopRankPlayer pbTopRankPlayer;
			LuaObject.checkType<ProArenaTopRankPlayer>(l, 1, out pbTopRankPlayer);
			ArenaTopRankPlayer o = ArenaTopRankPlayer.PBArenaTopRankPlayerToArenaTopRankPlayer(pbTopRankPlayer);
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

	// Token: 0x060178CE RID: 96462 RVA: 0x006723E0 File Offset: 0x006705E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Name(IntPtr l)
	{
		int result;
		try
		{
			ArenaTopRankPlayer arenaTopRankPlayer = (ArenaTopRankPlayer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaTopRankPlayer.Name);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060178CF RID: 96463 RVA: 0x00672434 File Offset: 0x00670634
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Name(IntPtr l)
	{
		int result;
		try
		{
			ArenaTopRankPlayer arenaTopRankPlayer = (ArenaTopRankPlayer)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			arenaTopRankPlayer.Name = name;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060178D0 RID: 96464 RVA: 0x0067248C File Offset: 0x0067068C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ArenaPoints(IntPtr l)
	{
		int result;
		try
		{
			ArenaTopRankPlayer arenaTopRankPlayer = (ArenaTopRankPlayer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaTopRankPlayer.ArenaPoints);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060178D1 RID: 96465 RVA: 0x006724E0 File Offset: 0x006706E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ArenaPoints(IntPtr l)
	{
		int result;
		try
		{
			ArenaTopRankPlayer arenaTopRankPlayer = (ArenaTopRankPlayer)LuaObject.checkSelf(l);
			ushort arenaPoints;
			LuaObject.checkType(l, 2, out arenaPoints);
			arenaTopRankPlayer.ArenaPoints = arenaPoints;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060178D2 RID: 96466 RVA: 0x00672538 File Offset: 0x00670738
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LevelId(IntPtr l)
	{
		int result;
		try
		{
			ArenaTopRankPlayer arenaTopRankPlayer = (ArenaTopRankPlayer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaTopRankPlayer.LevelId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060178D3 RID: 96467 RVA: 0x0067258C File Offset: 0x0067078C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_LevelId(IntPtr l)
	{
		int result;
		try
		{
			ArenaTopRankPlayer arenaTopRankPlayer = (ArenaTopRankPlayer)LuaObject.checkSelf(l);
			byte levelId;
			LuaObject.checkType(l, 2, out levelId);
			arenaTopRankPlayer.LevelId = levelId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060178D4 RID: 96468 RVA: 0x006725E4 File Offset: 0x006707E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_HeadIcon(IntPtr l)
	{
		int result;
		try
		{
			ArenaTopRankPlayer arenaTopRankPlayer = (ArenaTopRankPlayer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaTopRankPlayer.HeadIcon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060178D5 RID: 96469 RVA: 0x00672638 File Offset: 0x00670838
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_HeadIcon(IntPtr l)
	{
		int result;
		try
		{
			ArenaTopRankPlayer arenaTopRankPlayer = (ArenaTopRankPlayer)LuaObject.checkSelf(l);
			int headIcon;
			LuaObject.checkType(l, 2, out headIcon);
			arenaTopRankPlayer.HeadIcon = headIcon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060178D6 RID: 96470 RVA: 0x00672690 File Offset: 0x00670890
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Level(IntPtr l)
	{
		int result;
		try
		{
			ArenaTopRankPlayer arenaTopRankPlayer = (ArenaTopRankPlayer)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaTopRankPlayer.Level);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060178D7 RID: 96471 RVA: 0x006726E4 File Offset: 0x006708E4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Level(IntPtr l)
	{
		int result;
		try
		{
			ArenaTopRankPlayer arenaTopRankPlayer = (ArenaTopRankPlayer)LuaObject.checkSelf(l);
			int level;
			LuaObject.checkType(l, 2, out level);
			arenaTopRankPlayer.Level = level;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060178D8 RID: 96472 RVA: 0x0067273C File Offset: 0x0067093C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.ArenaTopRankPlayer");
		if (Lua_BlackJack_ProjectL_Common_ArenaTopRankPlayer.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaTopRankPlayer.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaTopRankPlayer.ArenaTopRankPlayerToPBArenaTopRankPlayer_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ArenaTopRankPlayer.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_ArenaTopRankPlayer.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaTopRankPlayer.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaTopRankPlayer.PBArenaTopRankPlayerToArenaTopRankPlayer_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ArenaTopRankPlayer.<>f__mg$cache1);
		string name = "Name";
		if (Lua_BlackJack_ProjectL_Common_ArenaTopRankPlayer.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaTopRankPlayer.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaTopRankPlayer.get_Name);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_ArenaTopRankPlayer.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Common_ArenaTopRankPlayer.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaTopRankPlayer.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaTopRankPlayer.set_Name);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_ArenaTopRankPlayer.<>f__mg$cache3, true);
		string name2 = "ArenaPoints";
		if (Lua_BlackJack_ProjectL_Common_ArenaTopRankPlayer.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaTopRankPlayer.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaTopRankPlayer.get_ArenaPoints);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_ArenaTopRankPlayer.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Common_ArenaTopRankPlayer.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaTopRankPlayer.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaTopRankPlayer.set_ArenaPoints);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_ArenaTopRankPlayer.<>f__mg$cache5, true);
		string name3 = "LevelId";
		if (Lua_BlackJack_ProjectL_Common_ArenaTopRankPlayer.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaTopRankPlayer.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaTopRankPlayer.get_LevelId);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_ArenaTopRankPlayer.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_Common_ArenaTopRankPlayer.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaTopRankPlayer.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaTopRankPlayer.set_LevelId);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_ArenaTopRankPlayer.<>f__mg$cache7, true);
		string name4 = "HeadIcon";
		if (Lua_BlackJack_ProjectL_Common_ArenaTopRankPlayer.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaTopRankPlayer.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaTopRankPlayer.get_HeadIcon);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Common_ArenaTopRankPlayer.<>f__mg$cache8;
		if (Lua_BlackJack_ProjectL_Common_ArenaTopRankPlayer.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaTopRankPlayer.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaTopRankPlayer.set_HeadIcon);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Common_ArenaTopRankPlayer.<>f__mg$cache9, true);
		string name5 = "Level";
		if (Lua_BlackJack_ProjectL_Common_ArenaTopRankPlayer.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaTopRankPlayer.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaTopRankPlayer.get_Level);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Common_ArenaTopRankPlayer.<>f__mg$cacheA;
		if (Lua_BlackJack_ProjectL_Common_ArenaTopRankPlayer.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaTopRankPlayer.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaTopRankPlayer.set_Level);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Common_ArenaTopRankPlayer.<>f__mg$cacheB, true);
		if (Lua_BlackJack_ProjectL_Common_ArenaTopRankPlayer.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaTopRankPlayer.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaTopRankPlayer.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_ArenaTopRankPlayer.<>f__mg$cacheC, typeof(ArenaTopRankPlayer));
	}

	// Token: 0x0400DF29 RID: 57129
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400DF2A RID: 57130
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400DF2B RID: 57131
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400DF2C RID: 57132
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400DF2D RID: 57133
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400DF2E RID: 57134
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400DF2F RID: 57135
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400DF30 RID: 57136
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400DF31 RID: 57137
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400DF32 RID: 57138
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400DF33 RID: 57139
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400DF34 RID: 57140
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400DF35 RID: 57141
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;
}
