using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020012FE RID: 4862
[Preserve]
public class Lua_BlackJack_ProjectL_Scene_ClientActorActGainBattleTreasure : LuaObject
{
	// Token: 0x0601A20E RID: 107022 RVA: 0x007AECA8 File Offset: 0x007ACEA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActGainBattleTreasure o = new ClientActorActGainBattleTreasure();
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

	// Token: 0x0601A20F RID: 107023 RVA: 0x007AECF0 File Offset: 0x007ACEF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battleTreasureInfo(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActGainBattleTreasure clientActorActGainBattleTreasure = (ClientActorActGainBattleTreasure)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientActorActGainBattleTreasure.m_battleTreasureInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A210 RID: 107024 RVA: 0x007AED44 File Offset: 0x007ACF44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battleTreasureInfo(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActGainBattleTreasure clientActorActGainBattleTreasure = (ClientActorActGainBattleTreasure)LuaObject.checkSelf(l);
			ConfigDataBattleTreasureInfo battleTreasureInfo;
			LuaObject.checkType<ConfigDataBattleTreasureInfo>(l, 2, out battleTreasureInfo);
			clientActorActGainBattleTreasure.m_battleTreasureInfo = battleTreasureInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A211 RID: 107025 RVA: 0x007AED9C File Offset: 0x007ACF9C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Scene.ClientActorActGainBattleTreasure");
		string name = "m_battleTreasureInfo";
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActGainBattleTreasure.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActGainBattleTreasure.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActGainBattleTreasure.get_m_battleTreasureInfo);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Scene_ClientActorActGainBattleTreasure.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActGainBattleTreasure.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActGainBattleTreasure.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActGainBattleTreasure.set_m_battleTreasureInfo);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Scene_ClientActorActGainBattleTreasure.<>f__mg$cache1, true);
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActGainBattleTreasure.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActGainBattleTreasure.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActGainBattleTreasure.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Scene_ClientActorActGainBattleTreasure.<>f__mg$cache2, typeof(ClientActorActGainBattleTreasure), typeof(ClientActorAct));
	}

	// Token: 0x040105F4 RID: 67060
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040105F5 RID: 67061
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040105F6 RID: 67062
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;
}
