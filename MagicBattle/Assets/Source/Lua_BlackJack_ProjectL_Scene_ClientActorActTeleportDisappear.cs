using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001312 RID: 4882
[Preserve]
public class Lua_BlackJack_ProjectL_Scene_ClientActorActTeleportDisappear : LuaObject
{
	// Token: 0x0601A2AA RID: 107178 RVA: 0x007B26BC File Offset: 0x007B08BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActTeleportDisappear o = new ClientActorActTeleportDisappear();
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

	// Token: 0x0601A2AB RID: 107179 RVA: 0x007B2704 File Offset: 0x007B0904
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillInfo(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActTeleportDisappear clientActorActTeleportDisappear = (ClientActorActTeleportDisappear)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientActorActTeleportDisappear.m_skillInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A2AC RID: 107180 RVA: 0x007B2758 File Offset: 0x007B0958
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillInfo(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActTeleportDisappear clientActorActTeleportDisappear = (ClientActorActTeleportDisappear)LuaObject.checkSelf(l);
			ConfigDataSkillInfo skillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 2, out skillInfo);
			clientActorActTeleportDisappear.m_skillInfo = skillInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A2AD RID: 107181 RVA: 0x007B27B0 File Offset: 0x007B09B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_position(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActTeleportDisappear clientActorActTeleportDisappear = (ClientActorActTeleportDisappear)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientActorActTeleportDisappear.m_position);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A2AE RID: 107182 RVA: 0x007B2808 File Offset: 0x007B0A08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_position(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActTeleportDisappear clientActorActTeleportDisappear = (ClientActorActTeleportDisappear)LuaObject.checkSelf(l);
			GridPosition position;
			LuaObject.checkValueType<GridPosition>(l, 2, out position);
			clientActorActTeleportDisappear.m_position = position;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A2AF RID: 107183 RVA: 0x007B2860 File Offset: 0x007B0A60
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Scene.ClientActorActTeleportDisappear");
		string name = "m_skillInfo";
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActTeleportDisappear.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActTeleportDisappear.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActTeleportDisappear.get_m_skillInfo);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Scene_ClientActorActTeleportDisappear.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActTeleportDisappear.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActTeleportDisappear.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActTeleportDisappear.set_m_skillInfo);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Scene_ClientActorActTeleportDisappear.<>f__mg$cache1, true);
		string name2 = "m_position";
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActTeleportDisappear.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActTeleportDisappear.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActTeleportDisappear.get_m_position);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Scene_ClientActorActTeleportDisappear.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActTeleportDisappear.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActTeleportDisappear.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActTeleportDisappear.set_m_position);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Scene_ClientActorActTeleportDisappear.<>f__mg$cache3, true);
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActTeleportDisappear.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActTeleportDisappear.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActTeleportDisappear.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Scene_ClientActorActTeleportDisappear.<>f__mg$cache4, typeof(ClientActorActTeleportDisappear), typeof(ClientActorAct));
	}

	// Token: 0x04010668 RID: 67176
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04010669 RID: 67177
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401066A RID: 67178
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0401066B RID: 67179
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0401066C RID: 67180
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;
}
