using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001327 RID: 4903
[Preserve]
public class Lua_BlackJack_ProjectL_Scene_ClientNullActorActBattleDialog : LuaObject
{
	// Token: 0x0601A58E RID: 107918 RVA: 0x007C9810 File Offset: 0x007C7A10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ClientNullActorActBattleDialog o = new ClientNullActorActBattleDialog();
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

	// Token: 0x0601A58F RID: 107919 RVA: 0x007C9858 File Offset: 0x007C7A58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battleDialogInfo(IntPtr l)
	{
		int result;
		try
		{
			ClientNullActorActBattleDialog clientNullActorActBattleDialog = (ClientNullActorActBattleDialog)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientNullActorActBattleDialog.m_battleDialogInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A590 RID: 107920 RVA: 0x007C98AC File Offset: 0x007C7AAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battleDialogInfo(IntPtr l)
	{
		int result;
		try
		{
			ClientNullActorActBattleDialog clientNullActorActBattleDialog = (ClientNullActorActBattleDialog)LuaObject.checkSelf(l);
			ConfigDataBattleDialogInfo battleDialogInfo;
			LuaObject.checkType<ConfigDataBattleDialogInfo>(l, 2, out battleDialogInfo);
			clientNullActorActBattleDialog.m_battleDialogInfo = battleDialogInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A591 RID: 107921 RVA: 0x007C9904 File Offset: 0x007C7B04
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Scene.ClientNullActorActBattleDialog");
		string name = "m_battleDialogInfo";
		if (Lua_BlackJack_ProjectL_Scene_ClientNullActorActBattleDialog.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientNullActorActBattleDialog.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientNullActorActBattleDialog.get_m_battleDialogInfo);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Scene_ClientNullActorActBattleDialog.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_Scene_ClientNullActorActBattleDialog.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientNullActorActBattleDialog.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientNullActorActBattleDialog.set_m_battleDialogInfo);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Scene_ClientNullActorActBattleDialog.<>f__mg$cache1, true);
		if (Lua_BlackJack_ProjectL_Scene_ClientNullActorActBattleDialog.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientNullActorActBattleDialog.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientNullActorActBattleDialog.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Scene_ClientNullActorActBattleDialog.<>f__mg$cache2, typeof(ClientNullActorActBattleDialog), typeof(ClientActorAct));
	}

	// Token: 0x04010922 RID: 67874
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04010923 RID: 67875
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04010924 RID: 67876
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;
}
