using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200130F RID: 4879
[Preserve]
public class Lua_BlackJack_ProjectL_Scene_ClientActorActSummon : LuaObject
{
	// Token: 0x0601A295 RID: 107157 RVA: 0x007B1F24 File Offset: 0x007B0124
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActSummon o = new ClientActorActSummon();
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

	// Token: 0x0601A296 RID: 107158 RVA: 0x007B1F6C File Offset: 0x007B016C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillInfo(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActSummon clientActorActSummon = (ClientActorActSummon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientActorActSummon.m_skillInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A297 RID: 107159 RVA: 0x007B1FC0 File Offset: 0x007B01C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillInfo(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActSummon clientActorActSummon = (ClientActorActSummon)LuaObject.checkSelf(l);
			ConfigDataSkillInfo skillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 2, out skillInfo);
			clientActorActSummon.m_skillInfo = skillInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A298 RID: 107160 RVA: 0x007B2018 File Offset: 0x007B0218
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Scene.ClientActorActSummon");
		string name = "m_skillInfo";
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActSummon.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActSummon.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActSummon.get_m_skillInfo);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Scene_ClientActorActSummon.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActSummon.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActSummon.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActSummon.set_m_skillInfo);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Scene_ClientActorActSummon.<>f__mg$cache1, true);
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActSummon.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActSummon.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActSummon.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Scene_ClientActorActSummon.<>f__mg$cache2, typeof(ClientActorActSummon), typeof(ClientActorAct));
	}

	// Token: 0x04010659 RID: 67161
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401065A RID: 67162
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401065B RID: 67163
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;
}
