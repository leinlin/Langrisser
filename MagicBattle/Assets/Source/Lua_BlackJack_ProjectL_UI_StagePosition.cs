using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001585 RID: 5509
[Preserve]
public class Lua_BlackJack_ProjectL_UI_StagePosition : LuaObject
{
	// Token: 0x06021244 RID: 135748 RVA: 0x00B28810 File Offset: 0x00B26A10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			StagePosition o = new StagePosition();
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

	// Token: 0x06021245 RID: 135749 RVA: 0x00B28858 File Offset: 0x00B26A58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Position(IntPtr l)
	{
		int result;
		try
		{
			StagePosition stagePosition = (StagePosition)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, stagePosition.Position);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021246 RID: 135750 RVA: 0x00B288B0 File Offset: 0x00B26AB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Position(IntPtr l)
	{
		int result;
		try
		{
			StagePosition stagePosition = (StagePosition)LuaObject.checkSelf(l);
			GridPosition position;
			LuaObject.checkValueType<GridPosition>(l, 2, out position);
			stagePosition.Position = position;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021247 RID: 135751 RVA: 0x00B28908 File Offset: 0x00B26B08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Direction(IntPtr l)
	{
		int result;
		try
		{
			StagePosition stagePosition = (StagePosition)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, stagePosition.Direction);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021248 RID: 135752 RVA: 0x00B2895C File Offset: 0x00B26B5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Direction(IntPtr l)
	{
		int result;
		try
		{
			StagePosition stagePosition = (StagePosition)LuaObject.checkSelf(l);
			int direction;
			LuaObject.checkType(l, 2, out direction);
			stagePosition.Direction = direction;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021249 RID: 135753 RVA: 0x00B289B4 File Offset: 0x00B26BB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PositionType(IntPtr l)
	{
		int result;
		try
		{
			StagePosition stagePosition = (StagePosition)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)stagePosition.PositionType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602124A RID: 135754 RVA: 0x00B28A08 File Offset: 0x00B26C08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_PositionType(IntPtr l)
	{
		int result;
		try
		{
			StagePosition stagePosition = (StagePosition)LuaObject.checkSelf(l);
			StagePositionType positionType;
			LuaObject.checkEnum<StagePositionType>(l, 2, out positionType);
			stagePosition.PositionType = positionType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602124B RID: 135755 RVA: 0x00B28A60 File Offset: 0x00B26C60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Hero(IntPtr l)
	{
		int result;
		try
		{
			StagePosition stagePosition = (StagePosition)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, stagePosition.Hero);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602124C RID: 135756 RVA: 0x00B28AB4 File Offset: 0x00B26CB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Hero(IntPtr l)
	{
		int result;
		try
		{
			StagePosition stagePosition = (StagePosition)LuaObject.checkSelf(l);
			BattleHero hero;
			LuaObject.checkType<BattleHero>(l, 2, out hero);
			stagePosition.Hero = hero;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602124D RID: 135757 RVA: 0x00B28B0C File Offset: 0x00B26D0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PlayerIndex(IntPtr l)
	{
		int result;
		try
		{
			StagePosition stagePosition = (StagePosition)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, stagePosition.PlayerIndex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602124E RID: 135758 RVA: 0x00B28B60 File Offset: 0x00B26D60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_PlayerIndex(IntPtr l)
	{
		int result;
		try
		{
			StagePosition stagePosition = (StagePosition)LuaObject.checkSelf(l);
			int playerIndex;
			LuaObject.checkType(l, 2, out playerIndex);
			stagePosition.PlayerIndex = playerIndex;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602124F RID: 135759 RVA: 0x00B28BB8 File Offset: 0x00B26DB8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.StagePosition");
		string name = "Position";
		if (Lua_BlackJack_ProjectL_UI_StagePosition.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_StagePosition.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StagePosition.get_Position);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_StagePosition.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_UI_StagePosition.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_StagePosition.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StagePosition.set_Position);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_StagePosition.<>f__mg$cache1, true);
		string name2 = "Direction";
		if (Lua_BlackJack_ProjectL_UI_StagePosition.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_StagePosition.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StagePosition.get_Direction);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_StagePosition.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_UI_StagePosition.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_StagePosition.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StagePosition.set_Direction);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_StagePosition.<>f__mg$cache3, true);
		string name3 = "PositionType";
		if (Lua_BlackJack_ProjectL_UI_StagePosition.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_StagePosition.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StagePosition.get_PositionType);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_StagePosition.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_UI_StagePosition.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_StagePosition.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StagePosition.set_PositionType);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_StagePosition.<>f__mg$cache5, true);
		string name4 = "Hero";
		if (Lua_BlackJack_ProjectL_UI_StagePosition.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_StagePosition.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StagePosition.get_Hero);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_StagePosition.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_UI_StagePosition.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_StagePosition.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StagePosition.set_Hero);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_StagePosition.<>f__mg$cache7, true);
		string name5 = "PlayerIndex";
		if (Lua_BlackJack_ProjectL_UI_StagePosition.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_StagePosition.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StagePosition.get_PlayerIndex);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_StagePosition.<>f__mg$cache8;
		if (Lua_BlackJack_ProjectL_UI_StagePosition.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_StagePosition.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StagePosition.set_PlayerIndex);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_StagePosition.<>f__mg$cache9, true);
		if (Lua_BlackJack_ProjectL_UI_StagePosition.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_StagePosition.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_StagePosition.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_StagePosition.<>f__mg$cacheA, typeof(StagePosition));
	}

	// Token: 0x0401711C RID: 94492
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401711D RID: 94493
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401711E RID: 94494
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0401711F RID: 94495
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04017120 RID: 94496
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04017121 RID: 94497
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04017122 RID: 94498
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04017123 RID: 94499
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04017124 RID: 94500
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04017125 RID: 94501
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04017126 RID: 94502
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;
}
