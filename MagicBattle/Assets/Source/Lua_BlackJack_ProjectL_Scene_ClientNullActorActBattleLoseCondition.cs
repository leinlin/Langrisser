using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001328 RID: 4904
[Preserve]
public class Lua_BlackJack_ProjectL_Scene_ClientNullActorActBattleLoseCondition : LuaObject
{
	// Token: 0x0601A593 RID: 107923 RVA: 0x007C99A4 File Offset: 0x007C7BA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ClientNullActorActBattleLoseCondition o = new ClientNullActorActBattleLoseCondition();
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

	// Token: 0x0601A594 RID: 107924 RVA: 0x007C99EC File Offset: 0x007C7BEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_loseConditionInfo(IntPtr l)
	{
		int result;
		try
		{
			ClientNullActorActBattleLoseCondition clientNullActorActBattleLoseCondition = (ClientNullActorActBattleLoseCondition)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientNullActorActBattleLoseCondition.m_loseConditionInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A595 RID: 107925 RVA: 0x007C9A40 File Offset: 0x007C7C40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_loseConditionInfo(IntPtr l)
	{
		int result;
		try
		{
			ClientNullActorActBattleLoseCondition clientNullActorActBattleLoseCondition = (ClientNullActorActBattleLoseCondition)LuaObject.checkSelf(l);
			ConfigDataBattleLoseConditionInfo loseConditionInfo;
			LuaObject.checkType<ConfigDataBattleLoseConditionInfo>(l, 2, out loseConditionInfo);
			clientNullActorActBattleLoseCondition.m_loseConditionInfo = loseConditionInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A596 RID: 107926 RVA: 0x007C9A98 File Offset: 0x007C7C98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_targetPosition(IntPtr l)
	{
		int result;
		try
		{
			ClientNullActorActBattleLoseCondition clientNullActorActBattleLoseCondition = (ClientNullActorActBattleLoseCondition)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientNullActorActBattleLoseCondition.m_targetPosition);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A597 RID: 107927 RVA: 0x007C9AF0 File Offset: 0x007C7CF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_targetPosition(IntPtr l)
	{
		int result;
		try
		{
			ClientNullActorActBattleLoseCondition clientNullActorActBattleLoseCondition = (ClientNullActorActBattleLoseCondition)LuaObject.checkSelf(l);
			GridPosition targetPosition;
			LuaObject.checkValueType<GridPosition>(l, 2, out targetPosition);
			clientNullActorActBattleLoseCondition.m_targetPosition = targetPosition;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A598 RID: 107928 RVA: 0x007C9B48 File Offset: 0x007C7D48
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Scene.ClientNullActorActBattleLoseCondition");
		string name = "m_loseConditionInfo";
		if (Lua_BlackJack_ProjectL_Scene_ClientNullActorActBattleLoseCondition.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientNullActorActBattleLoseCondition.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientNullActorActBattleLoseCondition.get_m_loseConditionInfo);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Scene_ClientNullActorActBattleLoseCondition.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_Scene_ClientNullActorActBattleLoseCondition.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientNullActorActBattleLoseCondition.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientNullActorActBattleLoseCondition.set_m_loseConditionInfo);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Scene_ClientNullActorActBattleLoseCondition.<>f__mg$cache1, true);
		string name2 = "m_targetPosition";
		if (Lua_BlackJack_ProjectL_Scene_ClientNullActorActBattleLoseCondition.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientNullActorActBattleLoseCondition.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientNullActorActBattleLoseCondition.get_m_targetPosition);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Scene_ClientNullActorActBattleLoseCondition.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Scene_ClientNullActorActBattleLoseCondition.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientNullActorActBattleLoseCondition.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientNullActorActBattleLoseCondition.set_m_targetPosition);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Scene_ClientNullActorActBattleLoseCondition.<>f__mg$cache3, true);
		if (Lua_BlackJack_ProjectL_Scene_ClientNullActorActBattleLoseCondition.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientNullActorActBattleLoseCondition.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientNullActorActBattleLoseCondition.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Scene_ClientNullActorActBattleLoseCondition.<>f__mg$cache4, typeof(ClientNullActorActBattleLoseCondition), typeof(ClientActorAct));
	}

	// Token: 0x04010925 RID: 67877
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04010926 RID: 67878
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04010927 RID: 67879
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04010928 RID: 67880
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04010929 RID: 67881
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;
}
