using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200154F RID: 5455
[Preserve]
public class Lua_BlackJack_ProjectL_UI_RealTimePVPAcquireWinsBonusNetTask : LuaObject
{
	// Token: 0x06020A5A RID: 133722 RVA: 0x00AE9594 File Offset: 0x00AE7794
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int bonusId;
			LuaObject.checkType(l, 2, out bonusId);
			RealTimePVPAcquireWinsBonusNetTask o = new RealTimePVPAcquireWinsBonusNetTask(bonusId);
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

	// Token: 0x06020A5B RID: 133723 RVA: 0x00AE95E8 File Offset: 0x00AE77E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Reward(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPAcquireWinsBonusNetTask realTimePVPAcquireWinsBonusNetTask = (RealTimePVPAcquireWinsBonusNetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, realTimePVPAcquireWinsBonusNetTask.Reward);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020A5C RID: 133724 RVA: 0x00AE963C File Offset: 0x00AE783C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.RealTimePVPAcquireWinsBonusNetTask");
		string name = "Reward";
		if (Lua_BlackJack_ProjectL_UI_RealTimePVPAcquireWinsBonusNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_RealTimePVPAcquireWinsBonusNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RealTimePVPAcquireWinsBonusNetTask.get_Reward);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_ProjectL_UI_RealTimePVPAcquireWinsBonusNetTask.<>f__mg$cache0, null, true);
		if (Lua_BlackJack_ProjectL_UI_RealTimePVPAcquireWinsBonusNetTask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_RealTimePVPAcquireWinsBonusNetTask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RealTimePVPAcquireWinsBonusNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_RealTimePVPAcquireWinsBonusNetTask.<>f__mg$cache1, typeof(RealTimePVPAcquireWinsBonusNetTask), typeof(UINetTask));
	}

	// Token: 0x0401699E RID: 92574
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401699F RID: 92575
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;
}
