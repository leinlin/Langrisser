using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001540 RID: 5440
[Preserve]
public class Lua_BlackJack_ProjectL_UI_RaffleDrawNetTask : LuaObject
{
	// Token: 0x060207C8 RID: 133064 RVA: 0x00AD4C44 File Offset: 0x00AD2E44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int poolId;
			LuaObject.checkType(l, 2, out poolId);
			RaffleDrawNetTask o = new RaffleDrawNetTask(poolId);
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

	// Token: 0x060207C9 RID: 133065 RVA: 0x00AD4C98 File Offset: 0x00AD2E98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_DrawnGoods(IntPtr l)
	{
		int result;
		try
		{
			RaffleDrawNetTask raffleDrawNetTask = (RaffleDrawNetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raffleDrawNetTask.DrawnGoods);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060207CA RID: 133066 RVA: 0x00AD4CEC File Offset: 0x00AD2EEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_DrawnRaffleId(IntPtr l)
	{
		int result;
		try
		{
			RaffleDrawNetTask raffleDrawNetTask = (RaffleDrawNetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raffleDrawNetTask.DrawnRaffleId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060207CB RID: 133067 RVA: 0x00AD4D40 File Offset: 0x00AD2F40
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.RaffleDrawNetTask");
		string name = "DrawnGoods";
		if (Lua_BlackJack_ProjectL_UI_RaffleDrawNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleDrawNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleDrawNetTask.get_DrawnGoods);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_ProjectL_UI_RaffleDrawNetTask.<>f__mg$cache0, null, true);
		string name2 = "DrawnRaffleId";
		if (Lua_BlackJack_ProjectL_UI_RaffleDrawNetTask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleDrawNetTask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleDrawNetTask.get_DrawnRaffleId);
		}
		LuaObject.addMember(l, name2, Lua_BlackJack_ProjectL_UI_RaffleDrawNetTask.<>f__mg$cache1, null, true);
		if (Lua_BlackJack_ProjectL_UI_RaffleDrawNetTask.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_RaffleDrawNetTask.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RaffleDrawNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_RaffleDrawNetTask.<>f__mg$cache2, typeof(RaffleDrawNetTask), typeof(UINetTask));
	}

	// Token: 0x0401672A RID: 91946
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401672B RID: 91947
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401672C RID: 91948
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;
}
