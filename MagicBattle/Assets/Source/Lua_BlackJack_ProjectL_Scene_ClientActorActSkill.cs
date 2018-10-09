using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001309 RID: 4873
[Preserve]
public class Lua_BlackJack_ProjectL_Scene_ClientActorActSkill : LuaObject
{
	// Token: 0x0601A25B RID: 107099 RVA: 0x007B0868 File Offset: 0x007AEA68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActSkill o = new ClientActorActSkill();
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

	// Token: 0x0601A25C RID: 107100 RVA: 0x007B08B0 File Offset: 0x007AEAB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillInfo(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActSkill clientActorActSkill = (ClientActorActSkill)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientActorActSkill.m_skillInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A25D RID: 107101 RVA: 0x007B0904 File Offset: 0x007AEB04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillInfo(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActSkill clientActorActSkill = (ClientActorActSkill)LuaObject.checkSelf(l);
			ConfigDataSkillInfo skillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 2, out skillInfo);
			clientActorActSkill.m_skillInfo = skillInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A25E RID: 107102 RVA: 0x007B095C File Offset: 0x007AEB5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_targetPosition(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActSkill clientActorActSkill = (ClientActorActSkill)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientActorActSkill.m_targetPosition);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A25F RID: 107103 RVA: 0x007B09B4 File Offset: 0x007AEBB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_targetPosition(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActSkill clientActorActSkill = (ClientActorActSkill)LuaObject.checkSelf(l);
			GridPosition targetPosition;
			LuaObject.checkValueType<GridPosition>(l, 2, out targetPosition);
			clientActorActSkill.m_targetPosition = targetPosition;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A260 RID: 107104 RVA: 0x007B0A0C File Offset: 0x007AEC0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_hits(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActSkill clientActorActSkill = (ClientActorActSkill)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientActorActSkill.m_hits);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A261 RID: 107105 RVA: 0x007B0A60 File Offset: 0x007AEC60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_hits(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActSkill clientActorActSkill = (ClientActorActSkill)LuaObject.checkSelf(l);
			List<ClientActorHitInfo> hits;
			LuaObject.checkType<List<ClientActorHitInfo>>(l, 2, out hits);
			clientActorActSkill.m_hits = hits;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A262 RID: 107106 RVA: 0x007B0AB8 File Offset: 0x007AECB8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Scene.ClientActorActSkill");
		string name = "m_skillInfo";
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActSkill.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActSkill.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActSkill.get_m_skillInfo);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Scene_ClientActorActSkill.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActSkill.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActSkill.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActSkill.set_m_skillInfo);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Scene_ClientActorActSkill.<>f__mg$cache1, true);
		string name2 = "m_targetPosition";
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActSkill.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActSkill.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActSkill.get_m_targetPosition);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Scene_ClientActorActSkill.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActSkill.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActSkill.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActSkill.set_m_targetPosition);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Scene_ClientActorActSkill.<>f__mg$cache3, true);
		string name3 = "m_hits";
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActSkill.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActSkill.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActSkill.get_m_hits);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Scene_ClientActorActSkill.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActSkill.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActSkill.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActSkill.set_m_hits);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Scene_ClientActorActSkill.<>f__mg$cache5, true);
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActSkill.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActSkill.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActSkill.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Scene_ClientActorActSkill.<>f__mg$cache6, typeof(ClientActorActSkill), typeof(ClientActorAct));
	}

	// Token: 0x0401062B RID: 67115
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401062C RID: 67116
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401062D RID: 67117
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0401062E RID: 67118
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0401062F RID: 67119
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04010630 RID: 67120
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04010631 RID: 67121
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;
}
