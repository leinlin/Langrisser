using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020013E2 RID: 5090
[Preserve]
public class Lua_BlackJack_ProjectL_UI_CardSelectNetTask : LuaObject
{
	// Token: 0x0601C8DA RID: 116954 RVA: 0x008E0614 File Offset: 0x008DE814
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int cardPoolId;
			LuaObject.checkType(l, 2, out cardPoolId);
			bool isSingleSlect;
			LuaObject.checkType(l, 3, out isSingleSlect);
			bool isUsingTicket;
			LuaObject.checkType(l, 4, out isUsingTicket);
			CardSelectNetTask o = new CardSelectNetTask(cardPoolId, isSingleSlect, isUsingTicket);
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

	// Token: 0x0601C8DB RID: 116955 RVA: 0x008E0684 File Offset: 0x008DE884
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Rewards(IntPtr l)
	{
		int result;
		try
		{
			CardSelectNetTask cardSelectNetTask = (CardSelectNetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cardSelectNetTask.Rewards);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601C8DC RID: 116956 RVA: 0x008E06D8 File Offset: 0x008DE8D8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.CardSelectNetTask");
		string name = "Rewards";
		if (Lua_BlackJack_ProjectL_UI_CardSelectNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_CardSelectNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CardSelectNetTask.get_Rewards);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_ProjectL_UI_CardSelectNetTask.<>f__mg$cache0, null, true);
		if (Lua_BlackJack_ProjectL_UI_CardSelectNetTask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_CardSelectNetTask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CardSelectNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_CardSelectNetTask.<>f__mg$cache1, typeof(CardSelectNetTask), typeof(UINetTask));
	}

	// Token: 0x04012AF8 RID: 76536
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04012AF9 RID: 76537
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;
}
