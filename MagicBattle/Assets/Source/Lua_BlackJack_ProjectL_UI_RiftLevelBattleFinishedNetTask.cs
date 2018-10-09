using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Protocol;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001564 RID: 5476
[Preserve]
public class Lua_BlackJack_ProjectL_UI_RiftLevelBattleFinishedNetTask : LuaObject
{
	// Token: 0x06020C79 RID: 134265 RVA: 0x00AFA130 File Offset: 0x00AF8330
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int riftLevelId;
			LuaObject.checkType(l, 2, out riftLevelId);
			ProBattleReport battleReport;
			LuaObject.checkType<ProBattleReport>(l, 3, out battleReport);
			RiftLevelBattleFinishedNetTask o = new RiftLevelBattleFinishedNetTask(riftLevelId, battleReport);
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

	// Token: 0x06020C7A RID: 134266 RVA: 0x00AFA190 File Offset: 0x00AF8390
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Stars(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelBattleFinishedNetTask riftLevelBattleFinishedNetTask = (RiftLevelBattleFinishedNetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftLevelBattleFinishedNetTask.Stars);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C7B RID: 134267 RVA: 0x00AFA1E4 File Offset: 0x00AF83E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_IsFirstWin(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelBattleFinishedNetTask riftLevelBattleFinishedNetTask = (RiftLevelBattleFinishedNetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftLevelBattleFinishedNetTask.IsFirstWin);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C7C RID: 134268 RVA: 0x00AFA238 File Offset: 0x00AF8438
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Reward(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelBattleFinishedNetTask riftLevelBattleFinishedNetTask = (RiftLevelBattleFinishedNetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftLevelBattleFinishedNetTask.Reward);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C7D RID: 134269 RVA: 0x00AFA28C File Offset: 0x00AF848C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Achievements(IntPtr l)
	{
		int result;
		try
		{
			RiftLevelBattleFinishedNetTask riftLevelBattleFinishedNetTask = (RiftLevelBattleFinishedNetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftLevelBattleFinishedNetTask.Achievements);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020C7E RID: 134270 RVA: 0x00AFA2E0 File Offset: 0x00AF84E0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.RiftLevelBattleFinishedNetTask");
		string name = "Stars";
		if (Lua_BlackJack_ProjectL_UI_RiftLevelBattleFinishedNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelBattleFinishedNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelBattleFinishedNetTask.get_Stars);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_ProjectL_UI_RiftLevelBattleFinishedNetTask.<>f__mg$cache0, null, true);
		string name2 = "IsFirstWin";
		if (Lua_BlackJack_ProjectL_UI_RiftLevelBattleFinishedNetTask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelBattleFinishedNetTask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelBattleFinishedNetTask.get_IsFirstWin);
		}
		LuaObject.addMember(l, name2, Lua_BlackJack_ProjectL_UI_RiftLevelBattleFinishedNetTask.<>f__mg$cache1, null, true);
		string name3 = "Reward";
		if (Lua_BlackJack_ProjectL_UI_RiftLevelBattleFinishedNetTask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelBattleFinishedNetTask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelBattleFinishedNetTask.get_Reward);
		}
		LuaObject.addMember(l, name3, Lua_BlackJack_ProjectL_UI_RiftLevelBattleFinishedNetTask.<>f__mg$cache2, null, true);
		string name4 = "Achievements";
		if (Lua_BlackJack_ProjectL_UI_RiftLevelBattleFinishedNetTask.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelBattleFinishedNetTask.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelBattleFinishedNetTask.get_Achievements);
		}
		LuaObject.addMember(l, name4, Lua_BlackJack_ProjectL_UI_RiftLevelBattleFinishedNetTask.<>f__mg$cache3, null, true);
		if (Lua_BlackJack_ProjectL_UI_RiftLevelBattleFinishedNetTask.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_RiftLevelBattleFinishedNetTask.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RiftLevelBattleFinishedNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_RiftLevelBattleFinishedNetTask.<>f__mg$cache4, typeof(RiftLevelBattleFinishedNetTask), typeof(UINetTask));
	}

	// Token: 0x04016B93 RID: 93075
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04016B94 RID: 93076
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04016B95 RID: 93077
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04016B96 RID: 93078
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04016B97 RID: 93079
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;
}
