using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001553 RID: 5459
[Preserve]
public class Lua_BlackJack_ProjectL_UI_RealTimePVPWaitingForOpponentNetTask : LuaObject
{
	// Token: 0x06020A67 RID: 133735 RVA: 0x00AE98B8 File Offset: 0x00AE7AB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			BattleMode mode;
			LuaObject.checkEnum<BattleMode>(l, 2, out mode);
			RealTimePVPWaitingForOpponentNetTask o = new RealTimePVPWaitingForOpponentNetTask(mode);
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

	// Token: 0x06020A68 RID: 133736 RVA: 0x00AE990C File Offset: 0x00AE7B0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ExpectedWaitingTime(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPWaitingForOpponentNetTask realTimePVPWaitingForOpponentNetTask = (RealTimePVPWaitingForOpponentNetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, realTimePVPWaitingForOpponentNetTask.ExpectedWaitingTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020A69 RID: 133737 RVA: 0x00AE9960 File Offset: 0x00AE7B60
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.RealTimePVPWaitingForOpponentNetTask");
		string name = "ExpectedWaitingTime";
		if (Lua_BlackJack_ProjectL_UI_RealTimePVPWaitingForOpponentNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_RealTimePVPWaitingForOpponentNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RealTimePVPWaitingForOpponentNetTask.get_ExpectedWaitingTime);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_ProjectL_UI_RealTimePVPWaitingForOpponentNetTask.<>f__mg$cache0, null, true);
		if (Lua_BlackJack_ProjectL_UI_RealTimePVPWaitingForOpponentNetTask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_RealTimePVPWaitingForOpponentNetTask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RealTimePVPWaitingForOpponentNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_RealTimePVPWaitingForOpponentNetTask.<>f__mg$cache1, typeof(RealTimePVPWaitingForOpponentNetTask), typeof(UINetTask));
	}

	// Token: 0x040169A3 RID: 92579
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040169A4 RID: 92580
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;
}
