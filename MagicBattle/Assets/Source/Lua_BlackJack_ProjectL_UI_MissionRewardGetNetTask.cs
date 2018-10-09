using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001510 RID: 5392
[Preserve]
public class Lua_BlackJack_ProjectL_UI_MissionRewardGetNetTask : LuaObject
{
	// Token: 0x0601FF3F RID: 130879 RVA: 0x00A90B28 File Offset: 0x00A8ED28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int id;
			LuaObject.checkType(l, 2, out id);
			MissionRewardGetNetTask o = new MissionRewardGetNetTask(id);
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

	// Token: 0x0601FF40 RID: 130880 RVA: 0x00A90B7C File Offset: 0x00A8ED7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Rewards(IntPtr l)
	{
		int result;
		try
		{
			MissionRewardGetNetTask missionRewardGetNetTask = (MissionRewardGetNetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, missionRewardGetNetTask.Rewards);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF41 RID: 130881 RVA: 0x00A90BD0 File Offset: 0x00A8EDD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Rewards(IntPtr l)
	{
		int result;
		try
		{
			MissionRewardGetNetTask missionRewardGetNetTask = (MissionRewardGetNetTask)LuaObject.checkSelf(l);
			List<Goods> rewards;
			LuaObject.checkType<List<Goods>>(l, 2, out rewards);
			missionRewardGetNetTask.Rewards = rewards;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF42 RID: 130882 RVA: 0x00A90C28 File Offset: 0x00A8EE28
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.MissionRewardGetNetTask");
		string name = "Rewards";
		if (Lua_BlackJack_ProjectL_UI_MissionRewardGetNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionRewardGetNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionRewardGetNetTask.get_Rewards);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_MissionRewardGetNetTask.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_UI_MissionRewardGetNetTask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionRewardGetNetTask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionRewardGetNetTask.set_Rewards);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_MissionRewardGetNetTask.<>f__mg$cache1, true);
		if (Lua_BlackJack_ProjectL_UI_MissionRewardGetNetTask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionRewardGetNetTask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionRewardGetNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_MissionRewardGetNetTask.<>f__mg$cache2, typeof(MissionRewardGetNetTask), typeof(UINetTask));
	}

	// Token: 0x04015F01 RID: 89857
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04015F02 RID: 89858
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04015F03 RID: 89859
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;
}
