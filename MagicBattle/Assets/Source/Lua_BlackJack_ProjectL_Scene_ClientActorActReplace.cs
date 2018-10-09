using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Battle;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001307 RID: 4871
[Preserve]
public class Lua_BlackJack_ProjectL_Scene_ClientActorActReplace : LuaObject
{
	// Token: 0x0601A24F RID: 107087 RVA: 0x007B0450 File Offset: 0x007AE650
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActReplace o = new ClientActorActReplace();
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

	// Token: 0x0601A250 RID: 107088 RVA: 0x007B0498 File Offset: 0x007AE698
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_newActor(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActReplace clientActorActReplace = (ClientActorActReplace)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientActorActReplace.m_newActor);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A251 RID: 107089 RVA: 0x007B04EC File Offset: 0x007AE6EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_newActor(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActReplace clientActorActReplace = (ClientActorActReplace)LuaObject.checkSelf(l);
			BattleActor newActor;
			LuaObject.checkType<BattleActor>(l, 2, out newActor);
			clientActorActReplace.m_newActor = newActor;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A252 RID: 107090 RVA: 0x007B0544 File Offset: 0x007AE744
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_fxName(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActReplace clientActorActReplace = (ClientActorActReplace)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientActorActReplace.m_fxName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A253 RID: 107091 RVA: 0x007B0598 File Offset: 0x007AE798
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_fxName(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActReplace clientActorActReplace = (ClientActorActReplace)LuaObject.checkSelf(l);
			string fxName;
			LuaObject.checkType(l, 2, out fxName);
			clientActorActReplace.m_fxName = fxName;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A254 RID: 107092 RVA: 0x007B05F0 File Offset: 0x007AE7F0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Scene.ClientActorActReplace");
		string name = "m_newActor";
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActReplace.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActReplace.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActReplace.get_m_newActor);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Scene_ClientActorActReplace.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActReplace.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActReplace.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActReplace.set_m_newActor);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Scene_ClientActorActReplace.<>f__mg$cache1, true);
		string name2 = "m_fxName";
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActReplace.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActReplace.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActReplace.get_m_fxName);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Scene_ClientActorActReplace.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActReplace.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActReplace.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActReplace.set_m_fxName);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Scene_ClientActorActReplace.<>f__mg$cache3, true);
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActReplace.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActReplace.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActReplace.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Scene_ClientActorActReplace.<>f__mg$cache4, typeof(ClientActorActReplace), typeof(ClientActorAct));
	}

	// Token: 0x04010623 RID: 67107
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04010624 RID: 67108
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04010625 RID: 67109
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04010626 RID: 67110
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04010627 RID: 67111
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;
}
