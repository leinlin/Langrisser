using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020014BE RID: 5310
[Preserve]
public class Lua_BlackJack_ProjectL_UI_HeroDungeonRewardGainNetTask : LuaObject
{
	// Token: 0x0601F064 RID: 127076 RVA: 0x00A1A600 File Offset: 0x00A18800
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int chapterId;
			LuaObject.checkType(l, 2, out chapterId);
			int index;
			LuaObject.checkType(l, 3, out index);
			HeroDungeonRewardGainNetTask o = new HeroDungeonRewardGainNetTask(chapterId, index);
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

	// Token: 0x0601F065 RID: 127077 RVA: 0x00A1A660 File Offset: 0x00A18860
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Reward(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonRewardGainNetTask heroDungeonRewardGainNetTask = (HeroDungeonRewardGainNetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDungeonRewardGainNetTask.Reward);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F066 RID: 127078 RVA: 0x00A1A6B4 File Offset: 0x00A188B4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.HeroDungeonRewardGainNetTask");
		string name = "Reward";
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonRewardGainNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonRewardGainNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonRewardGainNetTask.get_Reward);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_ProjectL_UI_HeroDungeonRewardGainNetTask.<>f__mg$cache0, null, true);
		if (Lua_BlackJack_ProjectL_UI_HeroDungeonRewardGainNetTask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDungeonRewardGainNetTask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDungeonRewardGainNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_HeroDungeonRewardGainNetTask.<>f__mg$cache1, typeof(HeroDungeonRewardGainNetTask), typeof(UINetTask));
	}

	// Token: 0x040150CA RID: 86218
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040150CB RID: 86219
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;
}
