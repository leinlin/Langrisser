using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Protocol;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020014D8 RID: 5336
[Preserve]
public class Lua_BlackJack_ProjectL_UI_HeroPhantomLevelBattleFinishedNetTask : LuaObject
{
	// Token: 0x0601F632 RID: 128562 RVA: 0x00A48DD4 File Offset: 0x00A46FD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int levelID;
			LuaObject.checkType(l, 2, out levelID);
			ProBattleReport battleReport;
			LuaObject.checkType<ProBattleReport>(l, 3, out battleReport);
			HeroPhantomLevelBattleFinishedNetTask o = new HeroPhantomLevelBattleFinishedNetTask(levelID, battleReport);
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

	// Token: 0x0601F633 RID: 128563 RVA: 0x00A48E34 File Offset: 0x00A47034
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_IsWin(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomLevelBattleFinishedNetTask heroPhantomLevelBattleFinishedNetTask = (HeroPhantomLevelBattleFinishedNetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroPhantomLevelBattleFinishedNetTask.IsWin);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F634 RID: 128564 RVA: 0x00A48E88 File Offset: 0x00A47088
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_IsFirstWin(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomLevelBattleFinishedNetTask heroPhantomLevelBattleFinishedNetTask = (HeroPhantomLevelBattleFinishedNetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroPhantomLevelBattleFinishedNetTask.IsFirstWin);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F635 RID: 128565 RVA: 0x00A48EDC File Offset: 0x00A470DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Reward(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomLevelBattleFinishedNetTask heroPhantomLevelBattleFinishedNetTask = (HeroPhantomLevelBattleFinishedNetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroPhantomLevelBattleFinishedNetTask.Reward);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F636 RID: 128566 RVA: 0x00A48F30 File Offset: 0x00A47130
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Achievements(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomLevelBattleFinishedNetTask heroPhantomLevelBattleFinishedNetTask = (HeroPhantomLevelBattleFinishedNetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroPhantomLevelBattleFinishedNetTask.Achievements);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F637 RID: 128567 RVA: 0x00A48F84 File Offset: 0x00A47184
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.HeroPhantomLevelBattleFinishedNetTask");
		string name = "IsWin";
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomLevelBattleFinishedNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomLevelBattleFinishedNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomLevelBattleFinishedNetTask.get_IsWin);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_ProjectL_UI_HeroPhantomLevelBattleFinishedNetTask.<>f__mg$cache0, null, true);
		string name2 = "IsFirstWin";
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomLevelBattleFinishedNetTask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomLevelBattleFinishedNetTask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomLevelBattleFinishedNetTask.get_IsFirstWin);
		}
		LuaObject.addMember(l, name2, Lua_BlackJack_ProjectL_UI_HeroPhantomLevelBattleFinishedNetTask.<>f__mg$cache1, null, true);
		string name3 = "Reward";
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomLevelBattleFinishedNetTask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomLevelBattleFinishedNetTask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomLevelBattleFinishedNetTask.get_Reward);
		}
		LuaObject.addMember(l, name3, Lua_BlackJack_ProjectL_UI_HeroPhantomLevelBattleFinishedNetTask.<>f__mg$cache2, null, true);
		string name4 = "Achievements";
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomLevelBattleFinishedNetTask.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomLevelBattleFinishedNetTask.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomLevelBattleFinishedNetTask.get_Achievements);
		}
		LuaObject.addMember(l, name4, Lua_BlackJack_ProjectL_UI_HeroPhantomLevelBattleFinishedNetTask.<>f__mg$cache3, null, true);
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomLevelBattleFinishedNetTask.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomLevelBattleFinishedNetTask.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomLevelBattleFinishedNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_HeroPhantomLevelBattleFinishedNetTask.<>f__mg$cache4, typeof(HeroPhantomLevelBattleFinishedNetTask), typeof(UINetTask));
	}

	// Token: 0x04015664 RID: 87652
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04015665 RID: 87653
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04015666 RID: 87654
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04015667 RID: 87655
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04015668 RID: 87656
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;
}
