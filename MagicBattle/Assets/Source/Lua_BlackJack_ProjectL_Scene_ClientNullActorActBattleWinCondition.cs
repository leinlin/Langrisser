using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001329 RID: 4905
[Preserve]
public class Lua_BlackJack_ProjectL_Scene_ClientNullActorActBattleWinCondition : LuaObject
{
	// Token: 0x0601A59A RID: 107930 RVA: 0x007C9C2C File Offset: 0x007C7E2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ClientNullActorActBattleWinCondition o = new ClientNullActorActBattleWinCondition();
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

	// Token: 0x0601A59B RID: 107931 RVA: 0x007C9C74 File Offset: 0x007C7E74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_winConditionInfo(IntPtr l)
	{
		int result;
		try
		{
			ClientNullActorActBattleWinCondition clientNullActorActBattleWinCondition = (ClientNullActorActBattleWinCondition)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientNullActorActBattleWinCondition.m_winConditionInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A59C RID: 107932 RVA: 0x007C9CC8 File Offset: 0x007C7EC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_winConditionInfo(IntPtr l)
	{
		int result;
		try
		{
			ClientNullActorActBattleWinCondition clientNullActorActBattleWinCondition = (ClientNullActorActBattleWinCondition)LuaObject.checkSelf(l);
			ConfigDataBattleWinConditionInfo winConditionInfo;
			LuaObject.checkType<ConfigDataBattleWinConditionInfo>(l, 2, out winConditionInfo);
			clientNullActorActBattleWinCondition.m_winConditionInfo = winConditionInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A59D RID: 107933 RVA: 0x007C9D20 File Offset: 0x007C7F20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_targetPosition(IntPtr l)
	{
		int result;
		try
		{
			ClientNullActorActBattleWinCondition clientNullActorActBattleWinCondition = (ClientNullActorActBattleWinCondition)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientNullActorActBattleWinCondition.m_targetPosition);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A59E RID: 107934 RVA: 0x007C9D78 File Offset: 0x007C7F78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_targetPosition(IntPtr l)
	{
		int result;
		try
		{
			ClientNullActorActBattleWinCondition clientNullActorActBattleWinCondition = (ClientNullActorActBattleWinCondition)LuaObject.checkSelf(l);
			GridPosition targetPosition;
			LuaObject.checkValueType<GridPosition>(l, 2, out targetPosition);
			clientNullActorActBattleWinCondition.m_targetPosition = targetPosition;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A59F RID: 107935 RVA: 0x007C9DD0 File Offset: 0x007C7FD0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Scene.ClientNullActorActBattleWinCondition");
		string name = "m_winConditionInfo";
		if (Lua_BlackJack_ProjectL_Scene_ClientNullActorActBattleWinCondition.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientNullActorActBattleWinCondition.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientNullActorActBattleWinCondition.get_m_winConditionInfo);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Scene_ClientNullActorActBattleWinCondition.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_Scene_ClientNullActorActBattleWinCondition.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientNullActorActBattleWinCondition.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientNullActorActBattleWinCondition.set_m_winConditionInfo);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Scene_ClientNullActorActBattleWinCondition.<>f__mg$cache1, true);
		string name2 = "m_targetPosition";
		if (Lua_BlackJack_ProjectL_Scene_ClientNullActorActBattleWinCondition.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientNullActorActBattleWinCondition.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientNullActorActBattleWinCondition.get_m_targetPosition);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Scene_ClientNullActorActBattleWinCondition.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Scene_ClientNullActorActBattleWinCondition.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientNullActorActBattleWinCondition.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientNullActorActBattleWinCondition.set_m_targetPosition);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Scene_ClientNullActorActBattleWinCondition.<>f__mg$cache3, true);
		if (Lua_BlackJack_ProjectL_Scene_ClientNullActorActBattleWinCondition.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientNullActorActBattleWinCondition.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientNullActorActBattleWinCondition.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Scene_ClientNullActorActBattleWinCondition.<>f__mg$cache4, typeof(ClientNullActorActBattleWinCondition), typeof(ClientActorAct));
	}

	// Token: 0x0401092A RID: 67882
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401092B RID: 67883
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401092C RID: 67884
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0401092D RID: 67885
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0401092E RID: 67886
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;
}
