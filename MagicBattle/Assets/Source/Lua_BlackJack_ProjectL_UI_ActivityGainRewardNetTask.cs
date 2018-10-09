using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001351 RID: 4945
[Preserve]
public class Lua_BlackJack_ProjectL_UI_ActivityGainRewardNetTask : LuaObject
{
	// Token: 0x0601A919 RID: 108825 RVA: 0x007E37DC File Offset: 0x007E19DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ulong activityInstanceID;
			LuaObject.checkType(l, 2, out activityInstanceID);
			int rewardIndex;
			LuaObject.checkType(l, 3, out rewardIndex);
			ActivityGainRewardNetTask o = new ActivityGainRewardNetTask(activityInstanceID, rewardIndex);
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

	// Token: 0x0601A91A RID: 108826 RVA: 0x007E383C File Offset: 0x007E1A3C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.ActivityGainRewardNetTask");
		if (Lua_BlackJack_ProjectL_UI_ActivityGainRewardNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityGainRewardNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityGainRewardNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_ActivityGainRewardNetTask.<>f__mg$cache0, typeof(ActivityGainRewardNetTask), typeof(UINetTask));
	}

	// Token: 0x04010C59 RID: 68697
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
