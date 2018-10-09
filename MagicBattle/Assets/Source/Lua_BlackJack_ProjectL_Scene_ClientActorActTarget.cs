using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001310 RID: 4880
[Preserve]
public class Lua_BlackJack_ProjectL_Scene_ClientActorActTarget : LuaObject
{
	// Token: 0x0601A29A RID: 107162 RVA: 0x007B20B8 File Offset: 0x007B02B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActTarget o = new ClientActorActTarget();
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

	// Token: 0x0601A29B RID: 107163 RVA: 0x007B2100 File Offset: 0x007B0300
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_skillInfo(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActTarget clientActorActTarget = (ClientActorActTarget)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientActorActTarget.m_skillInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A29C RID: 107164 RVA: 0x007B2154 File Offset: 0x007B0354
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillInfo(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActTarget clientActorActTarget = (ClientActorActTarget)LuaObject.checkSelf(l);
			ConfigDataSkillInfo skillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 2, out skillInfo);
			clientActorActTarget.m_skillInfo = skillInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A29D RID: 107165 RVA: 0x007B21AC File Offset: 0x007B03AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_targetPosition(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActTarget clientActorActTarget = (ClientActorActTarget)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientActorActTarget.m_targetPosition);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A29E RID: 107166 RVA: 0x007B2204 File Offset: 0x007B0404
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_targetPosition(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActTarget clientActorActTarget = (ClientActorActTarget)LuaObject.checkSelf(l);
			GridPosition targetPosition;
			LuaObject.checkValueType<GridPosition>(l, 2, out targetPosition);
			clientActorActTarget.m_targetPosition = targetPosition;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A29F RID: 107167 RVA: 0x007B225C File Offset: 0x007B045C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_armyRelationValue(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActTarget clientActorActTarget = (ClientActorActTarget)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientActorActTarget.m_armyRelationValue);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A2A0 RID: 107168 RVA: 0x007B22B0 File Offset: 0x007B04B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_armyRelationValue(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActTarget clientActorActTarget = (ClientActorActTarget)LuaObject.checkSelf(l);
			int armyRelationValue;
			LuaObject.checkType(l, 2, out armyRelationValue);
			clientActorActTarget.m_armyRelationValue = armyRelationValue;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A2A1 RID: 107169 RVA: 0x007B2308 File Offset: 0x007B0508
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Scene.ClientActorActTarget");
		string name = "m_skillInfo";
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActTarget.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActTarget.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActTarget.get_m_skillInfo);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Scene_ClientActorActTarget.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActTarget.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActTarget.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActTarget.set_m_skillInfo);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Scene_ClientActorActTarget.<>f__mg$cache1, true);
		string name2 = "m_targetPosition";
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActTarget.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActTarget.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActTarget.get_m_targetPosition);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Scene_ClientActorActTarget.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActTarget.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActTarget.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActTarget.set_m_targetPosition);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Scene_ClientActorActTarget.<>f__mg$cache3, true);
		string name3 = "m_armyRelationValue";
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActTarget.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActTarget.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActTarget.get_m_armyRelationValue);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Scene_ClientActorActTarget.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActTarget.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActTarget.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActTarget.set_m_armyRelationValue);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Scene_ClientActorActTarget.<>f__mg$cache5, true);
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActTarget.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActTarget.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActTarget.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Scene_ClientActorActTarget.<>f__mg$cache6, typeof(ClientActorActTarget), typeof(ClientActorAct));
	}

	// Token: 0x0401065C RID: 67164
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401065D RID: 67165
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401065E RID: 67166
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0401065F RID: 67167
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04010660 RID: 67168
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04010661 RID: 67169
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04010662 RID: 67170
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;
}
