using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200153D RID: 5437
[Preserve]
public class Lua_BlackJack_ProjectL_UI_PullOrderRewardNetTask : LuaObject
{
	// Token: 0x0602074F RID: 132943 RVA: 0x00AD0F98 File Offset: 0x00ACF198
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string orderId;
			LuaObject.checkType(l, 2, out orderId);
			PullOrderRewardNetTask o = new PullOrderRewardNetTask(orderId);
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

	// Token: 0x06020750 RID: 132944 RVA: 0x00AD0FEC File Offset: 0x00ACF1EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Reward(IntPtr l)
	{
		int result;
		try
		{
			PullOrderRewardNetTask pullOrderRewardNetTask = (PullOrderRewardNetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, pullOrderRewardNetTask.Reward);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020751 RID: 132945 RVA: 0x00AD1040 File Offset: 0x00ACF240
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Reward(IntPtr l)
	{
		int result;
		try
		{
			PullOrderRewardNetTask pullOrderRewardNetTask = (PullOrderRewardNetTask)LuaObject.checkSelf(l);
			OrderReward reward;
			LuaObject.checkType<OrderReward>(l, 2, out reward);
			pullOrderRewardNetTask.Reward = reward;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020752 RID: 132946 RVA: 0x00AD1098 File Offset: 0x00ACF298
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.PullOrderRewardNetTask");
		string name = "Reward";
		if (Lua_BlackJack_ProjectL_UI_PullOrderRewardNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_PullOrderRewardNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PullOrderRewardNetTask.get_Reward);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_PullOrderRewardNetTask.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_UI_PullOrderRewardNetTask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_PullOrderRewardNetTask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PullOrderRewardNetTask.set_Reward);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_PullOrderRewardNetTask.<>f__mg$cache1, true);
		if (Lua_BlackJack_ProjectL_UI_PullOrderRewardNetTask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_PullOrderRewardNetTask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PullOrderRewardNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_PullOrderRewardNetTask.<>f__mg$cache2, typeof(PullOrderRewardNetTask), typeof(UINetTask));
	}

	// Token: 0x040166B7 RID: 91831
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040166B8 RID: 91832
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040166B9 RID: 91833
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;
}
