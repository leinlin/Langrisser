using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Battle;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200130C RID: 4876
[Preserve]
public class Lua_BlackJack_ProjectL_Scene_ClientActorActStartGuard : LuaObject
{
	// Token: 0x0601A278 RID: 107128 RVA: 0x007B13C4 File Offset: 0x007AF5C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActStartGuard o = new ClientActorActStartGuard();
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

	// Token: 0x0601A279 RID: 107129 RVA: 0x007B140C File Offset: 0x007AF60C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_targetActor(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActStartGuard clientActorActStartGuard = (ClientActorActStartGuard)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientActorActStartGuard.m_targetActor);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A27A RID: 107130 RVA: 0x007B1460 File Offset: 0x007AF660
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_targetActor(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActStartGuard clientActorActStartGuard = (ClientActorActStartGuard)LuaObject.checkSelf(l);
			BattleActor targetActor;
			LuaObject.checkType<BattleActor>(l, 2, out targetActor);
			clientActorActStartGuard.m_targetActor = targetActor;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A27B RID: 107131 RVA: 0x007B14B8 File Offset: 0x007AF6B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_position(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActStartGuard clientActorActStartGuard = (ClientActorActStartGuard)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientActorActStartGuard.m_position);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A27C RID: 107132 RVA: 0x007B1510 File Offset: 0x007AF710
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_position(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActStartGuard clientActorActStartGuard = (ClientActorActStartGuard)LuaObject.checkSelf(l);
			GridPosition position;
			LuaObject.checkValueType<GridPosition>(l, 2, out position);
			clientActorActStartGuard.m_position = position;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A27D RID: 107133 RVA: 0x007B1568 File Offset: 0x007AF768
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_direction(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActStartGuard clientActorActStartGuard = (ClientActorActStartGuard)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientActorActStartGuard.m_direction);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A27E RID: 107134 RVA: 0x007B15BC File Offset: 0x007AF7BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_direction(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActStartGuard clientActorActStartGuard = (ClientActorActStartGuard)LuaObject.checkSelf(l);
			int direction;
			LuaObject.checkType(l, 2, out direction);
			clientActorActStartGuard.m_direction = direction;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A27F RID: 107135 RVA: 0x007B1614 File Offset: 0x007AF814
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Scene.ClientActorActStartGuard");
		string name = "m_targetActor";
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActStartGuard.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActStartGuard.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActStartGuard.get_m_targetActor);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Scene_ClientActorActStartGuard.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActStartGuard.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActStartGuard.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActStartGuard.set_m_targetActor);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Scene_ClientActorActStartGuard.<>f__mg$cache1, true);
		string name2 = "m_position";
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActStartGuard.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActStartGuard.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActStartGuard.get_m_position);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Scene_ClientActorActStartGuard.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActStartGuard.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActStartGuard.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActStartGuard.set_m_position);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Scene_ClientActorActStartGuard.<>f__mg$cache3, true);
		string name3 = "m_direction";
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActStartGuard.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActStartGuard.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActStartGuard.get_m_direction);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Scene_ClientActorActStartGuard.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActStartGuard.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActStartGuard.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActStartGuard.set_m_direction);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Scene_ClientActorActStartGuard.<>f__mg$cache5, true);
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActStartGuard.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActStartGuard.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActStartGuard.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Scene_ClientActorActStartGuard.<>f__mg$cache6, typeof(ClientActorActStartGuard), typeof(ClientActorAct));
	}

	// Token: 0x04010642 RID: 67138
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04010643 RID: 67139
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04010644 RID: 67140
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04010645 RID: 67141
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04010646 RID: 67142
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04010647 RID: 67143
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04010648 RID: 67144
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;
}
