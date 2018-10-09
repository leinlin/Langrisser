using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Battle;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200130E RID: 4878
[Preserve]
public class Lua_BlackJack_ProjectL_Scene_ClientActorActStopGuard : LuaObject
{
	// Token: 0x0601A28C RID: 107148 RVA: 0x007B1BA8 File Offset: 0x007AFDA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActStopGuard o = new ClientActorActStopGuard();
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

	// Token: 0x0601A28D RID: 107149 RVA: 0x007B1BF0 File Offset: 0x007AFDF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_targetActor(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActStopGuard clientActorActStopGuard = (ClientActorActStopGuard)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientActorActStopGuard.m_targetActor);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A28E RID: 107150 RVA: 0x007B1C44 File Offset: 0x007AFE44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_targetActor(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActStopGuard clientActorActStopGuard = (ClientActorActStopGuard)LuaObject.checkSelf(l);
			BattleActor targetActor;
			LuaObject.checkType<BattleActor>(l, 2, out targetActor);
			clientActorActStopGuard.m_targetActor = targetActor;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A28F RID: 107151 RVA: 0x007B1C9C File Offset: 0x007AFE9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_position(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActStopGuard clientActorActStopGuard = (ClientActorActStopGuard)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientActorActStopGuard.m_position);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A290 RID: 107152 RVA: 0x007B1CF4 File Offset: 0x007AFEF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_position(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActStopGuard clientActorActStopGuard = (ClientActorActStopGuard)LuaObject.checkSelf(l);
			GridPosition position;
			LuaObject.checkValueType<GridPosition>(l, 2, out position);
			clientActorActStopGuard.m_position = position;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A291 RID: 107153 RVA: 0x007B1D4C File Offset: 0x007AFF4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_direction(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActStopGuard clientActorActStopGuard = (ClientActorActStopGuard)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientActorActStopGuard.m_direction);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A292 RID: 107154 RVA: 0x007B1DA0 File Offset: 0x007AFFA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_direction(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActStopGuard clientActorActStopGuard = (ClientActorActStopGuard)LuaObject.checkSelf(l);
			int direction;
			LuaObject.checkType(l, 2, out direction);
			clientActorActStopGuard.m_direction = direction;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A293 RID: 107155 RVA: 0x007B1DF8 File Offset: 0x007AFFF8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Scene.ClientActorActStopGuard");
		string name = "m_targetActor";
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActStopGuard.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActStopGuard.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActStopGuard.get_m_targetActor);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Scene_ClientActorActStopGuard.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActStopGuard.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActStopGuard.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActStopGuard.set_m_targetActor);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Scene_ClientActorActStopGuard.<>f__mg$cache1, true);
		string name2 = "m_position";
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActStopGuard.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActStopGuard.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActStopGuard.get_m_position);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Scene_ClientActorActStopGuard.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActStopGuard.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActStopGuard.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActStopGuard.set_m_position);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Scene_ClientActorActStopGuard.<>f__mg$cache3, true);
		string name3 = "m_direction";
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActStopGuard.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActStopGuard.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActStopGuard.get_m_direction);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Scene_ClientActorActStopGuard.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActStopGuard.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActStopGuard.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActStopGuard.set_m_direction);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Scene_ClientActorActStopGuard.<>f__mg$cache5, true);
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActStopGuard.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActStopGuard.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActStopGuard.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Scene_ClientActorActStopGuard.<>f__mg$cache6, typeof(ClientActorActStopGuard), typeof(ClientActorAct));
	}

	// Token: 0x04010652 RID: 67154
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04010653 RID: 67155
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04010654 RID: 67156
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04010655 RID: 67157
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04010656 RID: 67158
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04010657 RID: 67159
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04010658 RID: 67160
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;
}
