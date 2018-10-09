using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001311 RID: 4881
[Preserve]
public class Lua_BlackJack_ProjectL_Scene_ClientActorActTeleportAppear : LuaObject
{
	// Token: 0x0601A2A3 RID: 107171 RVA: 0x007B2434 File Offset: 0x007B0634
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActTeleportAppear o = new ClientActorActTeleportAppear();
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

	// Token: 0x0601A2A4 RID: 107172 RVA: 0x007B247C File Offset: 0x007B067C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillInfo(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActTeleportAppear clientActorActTeleportAppear = (ClientActorActTeleportAppear)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientActorActTeleportAppear.m_skillInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A2A5 RID: 107173 RVA: 0x007B24D0 File Offset: 0x007B06D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillInfo(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActTeleportAppear clientActorActTeleportAppear = (ClientActorActTeleportAppear)LuaObject.checkSelf(l);
			ConfigDataSkillInfo skillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 2, out skillInfo);
			clientActorActTeleportAppear.m_skillInfo = skillInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A2A6 RID: 107174 RVA: 0x007B2528 File Offset: 0x007B0728
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_position(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActTeleportAppear clientActorActTeleportAppear = (ClientActorActTeleportAppear)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientActorActTeleportAppear.m_position);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A2A7 RID: 107175 RVA: 0x007B2580 File Offset: 0x007B0780
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_position(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActTeleportAppear clientActorActTeleportAppear = (ClientActorActTeleportAppear)LuaObject.checkSelf(l);
			GridPosition position;
			LuaObject.checkValueType<GridPosition>(l, 2, out position);
			clientActorActTeleportAppear.m_position = position;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A2A8 RID: 107176 RVA: 0x007B25D8 File Offset: 0x007B07D8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Scene.ClientActorActTeleportAppear");
		string name = "m_skillInfo";
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActTeleportAppear.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActTeleportAppear.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActTeleportAppear.get_m_skillInfo);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Scene_ClientActorActTeleportAppear.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActTeleportAppear.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActTeleportAppear.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActTeleportAppear.set_m_skillInfo);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Scene_ClientActorActTeleportAppear.<>f__mg$cache1, true);
		string name2 = "m_position";
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActTeleportAppear.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActTeleportAppear.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActTeleportAppear.get_m_position);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Scene_ClientActorActTeleportAppear.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActTeleportAppear.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActTeleportAppear.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActTeleportAppear.set_m_position);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Scene_ClientActorActTeleportAppear.<>f__mg$cache3, true);
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActTeleportAppear.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActTeleportAppear.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActTeleportAppear.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Scene_ClientActorActTeleportAppear.<>f__mg$cache4, typeof(ClientActorActTeleportAppear), typeof(ClientActorAct));
	}

	// Token: 0x04010663 RID: 67171
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04010664 RID: 67172
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04010665 RID: 67173
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04010666 RID: 67174
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04010667 RID: 67175
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;
}
